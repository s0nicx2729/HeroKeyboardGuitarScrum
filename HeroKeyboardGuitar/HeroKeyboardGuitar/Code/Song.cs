using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HeroKeyboardGuitar;

public class Audio {
    private double[] samples;
    private double audioLen;
    private WaveOutEvent outputDevice;
    private long streamLength;
    private int sampleRate;
    private string filePath;
    private AudioFileReader fileReader;

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
        audioLen = fileReader.TotalTime.TotalMilliseconds;
        streamLength = fileReader.Length;
        outputDevice = new();
    }
    public void WriteSamplesToFile(string filePath) {
        File.WriteAllText(filePath, string.Join(',', samples));
    }
    public int GetPosition() {
        double perComplete = outputDevice.GetPosition() / (double)streamLength;
        return (int)Math.Clamp(perComplete * samples.Length, 0, samples.Length - 1);
    }
    public double GetSample(int index) {
        return samples[index];
    }
    public int GetNumberOfSamples() {
        return samples.Length;
    }
    public void Play() {
        fileReader = new AudioFileReader(filePath);
        outputDevice.Init(fileReader);
        outputDevice.Play();
    }
    public double TotalSongTimeInMs() {
        return audioLen;
    }

    public void Foo(int number) {
        throw new System.NotImplementedException();
    }
}

public class Song {
    private string title;
    public GenreType Genre { get; private set; }
    private Dictionary<int, Action> rewardMap;
    private string audioFile;
    private List<Note> notes;
    public Audio Audio { get; private set; }

    public Song(string fileName, GenreType genre) {
        this.audioFile = fileName;
        Audio = new(fileName);
        Genre = genre;
    }

    public void Play() {
        Audio.Play();
    }

    public void Restart() {
    }
}
