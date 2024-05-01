using AudioAnalyzing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HeroKeyboardGuitar;

public class Song {
    private string title;
    public GenreType Genre { get; private set; }
    private Dictionary<int, Action> rewardMap;
    private string filePath;
    private List<Note> notes;
    public Audio Audio { get; private set; }

    public Song(string filePath, GenreType genre) {
        this.filePath = filePath;
        title = Path.GetFileNameWithoutExtension(filePath);
        Audio = new(filePath);
        Genre = genre;
    }

    public void Play() {
        Audio.Play();
    }

    public void Restart() {
    }

    public void Stop() {
        Audio.Stop();
    }
}
