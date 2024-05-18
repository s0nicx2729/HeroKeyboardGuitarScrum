using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroKeyboardGuitar
{
    public partial class FrmScore : Form
    {
        public FrmScore()
        {
            InitializeComponent();
            TopMost = true;
        }

        /// <summary>
        /// Holds the current score the player has for the currently playing song.
        /// </summary>
        public string ScoreB 
        {
            get 
            {
                return this.scoreVal.Text;
            }
            set 
            {
                this.scoreVal.Text = value;
            }
        }

        /// <summary>
        /// Holds the current streak the player has for the currently playing song.
        /// </summary>
        public string StreakB
        {
            get
            {
                return this.streakVal.Text;
            }
            set
            {
                this.streakVal.Text = value;
            }
        }

        public string MultiplierB
        {
            get
            {
                return this.MultiplierVal.Text;
            }
            set
            {
                this.MultiplierVal.Text = value;
            }
        }
    }
}
