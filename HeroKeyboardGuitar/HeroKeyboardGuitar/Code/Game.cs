using HeroKeyboardGuitar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace HeroKeyboardGuitar;

public class Game {
    private Dictionary<GenreType, Bitmap> bgMap;
    public Song CurSong { get; private set; }

    private static Game instance = new();

    private Game() {
        bgMap = new() {
            [GenreType.CLASSICAL] = Resources.classical,
            [GenreType.COUNTRY] = Resources.country,
            [GenreType.METAL] = Resources.metal,
            [GenreType.POP] = Resources.pop,
            [GenreType.RNB] = Resources.rnb,
            [GenreType.ROCK] = Resources.rock,
        };
    }
    public static Game GetInstance() {
        return instance;
    }
    public static Dictionary<int, Action> GetRewardMap() {
        //return instance.CurSong.re
        return null;
    }
    public Bitmap GetBg() {
        return bgMap.GetValueOrDefault(CurSong.Genre, null);
    }
    public static Bitmap GetBg(GenreType genre) {
        return instance.bgMap[genre];
    }
    public static void SetCurSong(Song song) {
        GetInstance().CurSong = song;
    }
    public static void SetCurSong(string songFilePath, GenreType genre) {
        instance.CurSong = new(songFilePath, genre);
    }
}
