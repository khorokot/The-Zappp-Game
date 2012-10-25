using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZicZacZappp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void howtobt_Click(object sender, EventArgs e)
        {
            var myForm = new Howto();
            myForm.Show();
        }

        private void Onebt_Click(object sender, EventArgs e)
        {
            var myForm = new OnePlayerName();
            myForm.Show();
            this.Hide();
        }

        private void Twobt_Click(object sender, EventArgs e)
        {
            var myForm = new TwoPlayerName();
            myForm.Show();
            this.Hide();
        }

        private void Exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
