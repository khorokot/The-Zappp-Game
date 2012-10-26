using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ZicZacZappp
{
    public partial class Home : Form
    {
        string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString();
        

        public Home()
        {
            InitializeComponent();
        }

        private void howtobt_Click(object sender, EventArgs e)
        {
            var myForm = new Howto();
            myForm.Show();
            this.Hide();
        }

        private void Onebt_Click(object sender, EventArgs e)
        {
            var myForm = new TwoPlayerName();
            myForm.Show(); 
            this.Hide();
        }

        private void Twobt_Click(object sender, EventArgs e)
        {
            var myForm = new PlayerNamemode2();
            myForm.Show();
            this.Hide();
        }

        private void Exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void battle5_Click(object sender, EventArgs e)
        {
            var myForm = new PlayerNamemode3();
            myForm.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\TitleSound.wav");
            player.PlayLooping();
        }
    }
}
