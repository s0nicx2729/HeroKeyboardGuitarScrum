using NAudio.Wave;

namespace AudioAnalyzing;

public class Audio {
    private double[] samples;
    private WaveOutEvent outputDevice;
    private int sampleRate;
    private string filePath;
    private AudioFileReader fileReader;
    private List<double> clusters;

    public List<double> ActionTimes { get; private set; }
    public double AudioLengthInMs { get; private set; }
    public long StreamLengthInBytes { get; private set; }

    public Audio(string filePath) {
        this.filePath = filePath;
        fileReader = new AudioFileReader(filePath);
        int sampleRate = fileReader.WaveFormat.SampleRate;
        int sampleCount = (int)(fileReader.Length / fileReader.WaveFormat.BitsPerSample / 8);
        int channelCount = fileReader.WaveFormat.Channels;
        var samplesList = new List<double>(sampleCount);
        var buffer = new float[sampleRate * channelCount];
        int samplesRead = 0;
        while ((samplesRead = fileReader.Read(buffer, 0, buffer.Length)) > 0) {
            samplesList.AddRange(buffer.Take(samplesRead).Select(x => (double)x));
        }
        samples = samplesList.ToArray();
        AudioLengthInMs = fileReader.TotalTime.TotalMilliseconds;
        StreamLengthInBytes = fileReader.Length;
        outputDevice = new();

        ActionTimes = new();
        clusters = new();
        List<double> curCluster = new();
        double THRES = 0.4;
        bool inCluster = false;
        const int MAX_TOLERANCE = 500;
        int curTolerance = 0;
        int clusterStart = -1;
        for (int i = 0; i < samples.Length; i++) {
            var sample = Math.Abs(samples[i]);
            if (!inCluster) {
                if (Math.Abs(sample) > THRES) { // start
                    inCluster = true;
                    curTolerance = 0;
                    curCluster = new();
                    clusterStart = i;
                    clusters.Add(THRES);
                    curCluster.Add(sample);
                }
                else {
                    clusters.Add(0.0);
                }
            }
            else {
                if (Math.Abs(sample) < THRES / 1.5) {
                    curTolerance++;
                    if (curTolerance >= MAX_TOLERANCE) {
                        inCluster = false;
                        int actionIndex = clusterStart + curCluster.IndexOf(curCluster.Max());
                        double actionTime = (actionIndex / (double)samples.Length) * AudioLengthInMs;
                        ActionTimes.Add(actionTime);
                        clusters.Add(0.0);
                        curCluster.Add(0.0);
                    }
                    else {
                        clusters.Add(THRES);
                        curCluster.Add(sample);
                    }
                }
                else {
                    curTolerance = 0;
                    clusters.Add(THRES);
                    curCluster.Add(sample);
                }
            }
        }
    }
    public void DebugFileWrite() {
        File.WriteAllText("samples.txt", string.Join(',', samples.Select(x => Math.Abs(x))));
        File.WriteAllText("clusters.txt", string.Join(',', clusters));
        File.WriteAllText("actiontimes.txt", string.Join(',', ActionTimes));
    }
    public void WriteSamplesToFile(string filePath) {
        File.WriteAllText(filePath, string.Join(',', samples));
    }
    public int GetPosition() {
        double perComplete = outputDevice.GetPosition() / (double)StreamLengthInBytes;
        return (int)Math.Clamp(perComplete * samples.Length, 0, samples.Length - 1);
    }
    public double GetSample(int index) {
        return samples[index];
    }
    public double GetCluster(int index) {
        return clusters[index];
    }
    public int GetNumberOfSamples() {
        return samples.Length;
    }
    public void Play() {
        fileReader = new AudioFileReader(filePath);
        outputDevice.Init(fileReader);
        outputDevice.Play();
    }
    public void Stop() {
        outputDevice.Stop();
    }
}
