using AudioAnalyzing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HeroKeyboardGuitar;
/// <summary>
/// Contains the song's title, genre, file path, and audio.
/// </summary>
public class Song {
    private readonly string title;

    /// <summary>
    /// Contains the song's genre.
    /// </summary>
    public GenreType Genre { get; private set; }
    private readonly string filePath;

    /// <summary>
    /// Contains the song's audio.
    /// </summary>
    public Audio Audio { get; private set; }

    public Song(string filePath, GenreType genre) {
        this.filePath = filePath;
        title = Path.GetFileNameWithoutExtension(filePath);
        Audio = new(filePath);
        Genre = genre;
    }
    /// <summary>
    /// Plays the song.
    /// </summary>
    public void Play() {
        Audio.Play();
    }
    /// <summary>
    /// Restarts the song.
    /// </summary>
    public static void Restart() {
    }
    /// <summary>
    /// Stops the song.
    /// </summary>
    public void Stop() {
        Audio.Stop();
    }
}
