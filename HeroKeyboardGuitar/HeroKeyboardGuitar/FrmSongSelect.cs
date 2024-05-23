using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;


namespace HeroKeyboardGuitar
{
    internal partial class FrmSongSelect : Form
    {
        private readonly string SONGS_ROOT_PATH = Path.Combine(Application.StartupPath, "../../../Songs/");
        private readonly string IMAGES_ROOT_PATH = Path.Combine(Application.StartupPath, "../../../Images/");

        public FrmSongSelect()
        {
            InitializeComponent();
        }

        private void FrmSongSelect_Load(object sender, EventArgs e)
        {
            int top = 50;
            int left = 20;
            const int size = 250;
            const int spacing = 50;

            foreach (var songFilePath in Directory.GetFiles(SONGS_ROOT_PATH))
            {
                var song = Path.GetFileNameWithoutExtension(songFilePath);
                var songName = song.Split('_')[0];
                GenreType genre;
                if (!Enum.TryParse(song.Split('_')[1], true, out genre))
                {
                    genre = GenreType.COUNTRY;
                }

                // Construct the expected image file path
                string imageFilePath = Path.Combine(IMAGES_ROOT_PATH, song + ".png");

                // Load the image if it exists, otherwise use the genre-based image
                Image backgroundImage;
                if (File.Exists(imageFilePath))
                {
                    backgroundImage = Image.FromFile(imageFilePath);
                }
                else
                {
                    backgroundImage = Game.GetBg(genre);
                }

                Button btnSong = new()
                {
                    BackgroundImage = backgroundImage,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Width = size,
                    Height = size,
                    Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(songName.ToLower()),
                    TextAlign = ContentAlignment.BottomCenter,
                    Font = new Font("Arial", 30),
                    ForeColor = Color.Cyan,
                    Top = top,
                    Left = left,
                };

                left += size + spacing;
                var filePath = songFilePath;
                btnSong.Click += (e, sender) => {
                    Game.SetCurSong(filePath, genre);
                    FrmMain frmMain = new();
                    frmMain.Show();
                };

                Controls.Add(btnSong);
            }
        }
    }
}
