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
        public static float speed = .7f;
        private FrmMain frmMain;

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

                // Construct the expected image file path for the song title image
                string imageFilePath = Path.Combine(IMAGES_ROOT_PATH, song + ".png");

                // Construct the expected image file path for the song background
                string imageFilePath2 = Path.Combine(IMAGES_ROOT_PATH, song + "2.png");

                // Load the Title if it exists, otherwise use the genre-based image
                Image TitleImage;
                Image BackgroundImage;
                if (File.Exists(imageFilePath) )
                {
                    TitleImage = Image.FromFile(imageFilePath);
                }
                else
                {
                    TitleImage = Game.GetBg(genre);
                }

                // Load the background if it exists, otherwise use the genre-based image
                if (File.Exists(imageFilePath2))
                {
                    BackgroundImage = Image.FromFile(imageFilePath2);

                }
                else
                {
                    BackgroundImage = Game.GetBg(genre);
                }

                Button btnSong = new()
                {
                    BackgroundImage = TitleImage,
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
                btnSong.Click += (e, sender) =>
                {
                    Game.SetCurSong(filePath, genre);
                    FrmMain frmMain = new();
                    frmMain.Show();
                    frmMain.BackgroundImage = BackgroundImage;
                };

                Controls.Add(btnSong);
            }
        }

        private void btn_ConfirmSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                speed = float.Parse(speedBox.Text);
            } catch (FormatException)
            {
                lbl_speedCheck.Visible = true;
            }
        }
    }
}
