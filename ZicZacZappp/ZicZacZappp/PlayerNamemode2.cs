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
    public partial class PlayerNamemode2 : Form
    {

        public PlayerNamemode2()
        {
            InitializeComponent();
        }

        private void Playbt_Click(object sender, EventArgs e)
        {
            string P1 = nameX.Text;
            string P2 = nameO.Text;
            int mode2 = 2;
            this.Hide();
            var myForm = new Bettle4(P1,P2,mode2);
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
