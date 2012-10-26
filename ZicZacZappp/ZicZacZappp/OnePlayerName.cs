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
    public partial class OnePlayerName : Form
    {
        public OnePlayerName()
        {
            InitializeComponent();
        }

        private void Playbt_Click(object sender, EventArgs e)
        {

            string P1 = oneName.Text;
            int mode1 = 0;
            var battle = new Bettle(P1,P1,mode1);
            battle.ShowDialog();
            //battle.Show();
            
            
                    //oneName.Text = battle.Player1Name;
            
           // myForm.Show();
            this.Hide();
        }

        private void Cancelbt_Click(object sender, EventArgs e)
        {
            var myForm = new Home();
            myForm.Show();
            this.Hide();
        }

    }
}
