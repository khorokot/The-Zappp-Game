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
    public partial class TwoPlayerName : Form
    {
        
        public TwoPlayerName()
        {
            InitializeComponent();
        }

        private void Playbt_Click(object sender, EventArgs e)
        {
            string P1 = nameX.Text;
            string P2 = nameO.Text;
            int mode2 = 1;
            this.Hide();
            var myForm = new Bettle(P1,P2,mode2);
            myForm.ShowDialog();
           // myForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var myForm = new Home();
            myForm.Show();
            this.Hide();
        }
    }
}
