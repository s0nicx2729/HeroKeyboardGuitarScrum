using ScottPlot.Plottables;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

public partial class FrmMain : Form {
    private DataLogger dataLogger;
    private float sampleFreqThreshold = 0.2f;
    private string file;
    private readonly string SONGS_ROOT_PATH = $"{Application.StartupPath}../../../Data/";

    public FrmMain() {
        InitializeComponent();
    }

    public void FrmMain_Load(object sender, EventArgs e) {
        plot.Plot.Title("WAV File Data");
        plot.Plot.XLabel("Time (ms)");
        plot.Plot.YLabel("Audio Value");
        plot.Plot.Axes.SetLimitsY(-1, +1);
        dataLogger = plot.Plot.Add.DataLogger();
        cmbSongChoice.Items.Clear();
        foreach (var file in Directory.GetFiles(SONGS_ROOT_PATH)) {
            cmbSongChoice.Items.Add(Path.GetFileName(file));
        }
        cmbSongChoice.SelectedIndex = 0;
    }

    private void tmrPlay_Tick(object sender, EventArgs e) {
        Song song = Game.GetInstance().CurSong;
        int index = song.Audio.GetPosition();
        label1.Text = index.ToString();
        double audioVal = song.Audio.GetSample(index);
        if (Math.Abs(audioVal) > sampleFreqThreshold) {
            btnBeatPress.BackColor = Color.LightGreen;
        }
        else {
            btnBeatPress.BackColor = Color.DarkGoldenrod;
        }
        double[] plotData = Enumerable.Repeat(0.0, song.Audio.GetNumberOfSamples()).ToArray();
        for (int i = 0; i < index; i++) {
            plotData[i] = song.Audio.GetSample(i);
        }
        dataLogger.Data.Clear();
        dataLogger.Add(plotData);
        plot.Refresh();
        if (index >= song.Audio.GetNumberOfSamples() - 1) {
            tmrPlay.Enabled = false;
        }
    }

    private void btnPlay_Click(object sender, EventArgs e) {
        if (!tmrPlay.Enabled) {
            sampleFreqThreshold = (float)nudThreshold.Value;
            file = $"{SONGS_ROOT_PATH}{cmbSongChoice.Text}";
            Song song = new(file, (GenreType)typeof(GenreType).GetEnumValues().GetValue(new Random().Next(0,6)));
            Game.SetCurSong(song);
            BackgroundImage = Game.GetInstance().GetBg();

            plot.Plot.Title("WAV File Data");
            plot.Plot.XLabel("Time (ms)");
            plot.Plot.YLabel("Audio Value");
            plot.Plot.Axes.SetLimitsY(-1, +1);
            plot.Plot.Axes.SetLimitsX(0, song.Audio.TotalSongTimeInMs());

            Game.GetInstance().CurSong.Play();
            tmrPlay.Enabled = true;
        }
    }

    private void nudThreshold_ValueChanged(object sender, EventArgs e) {
        sampleFreqThreshold = (float)nudThreshold.Value;
    }
}
