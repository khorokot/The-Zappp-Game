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
    public partial class Bettle : Form
    {
        //public string Player1Name
        //{
        //    get { return label2.Text; }
        //}
        string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString();
        public Bettle(string P1,string P2,int mode)
        {
            if (mode == 0)
            {
                InitializeComponent();
                initialStatus();

                msgStatus.Text = "แกะดำ เป็นฝ่ายเริ่มก่อนจร้าาาาา";
                PlayerOsc.Text = scrO.ToString();
                PlayerXsc.Text = scrX.ToString();
                label2.Text = P1;
                label3.Text = "computer";
            }
            else if (mode == 1)
            {
                InitializeComponent();
                initialStatus();

                msgStatus.Text = "แกะดำ เป็นฝ่ายเริ่มก่อนจร้าาาาา";
                PlayerOsc.Text = scrO.ToString();
                PlayerXsc.Text = scrX.ToString();
                label2.Text = P1;
                label3.Text = P2;
            }
        }

        public void initialStatus()
        {
            for (int i = 0; i < 9; i++)
            {
                isClicked[i] = false;
            }
        }

        int scrX = 0;
        int scrO = 0;

        bool X = true;
        bool O = false;

        bool signal = false;
        bool[] isClicked = new bool[9];

        int counter = 0;
        string[] array = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };

        public int scoreAdd(int score)
        {
            score++;
            return score;
        }

        private void winnerX()
        {
            MessageBox.Show("Winner is Blacksheep ... Restart game!");
            msgStatus.Text = "Winner is Blacksheep. Restart game !";
            scrX = scoreAdd(scrX);
            PlayerXsc.Text = scrX.ToString();
        }

        private void winnerO()
        {
            MessageBox.Show("Winner is Whitesheep ... Restart game!");
            msgStatus.Text = "Winner is Whitesheep. Restart game !";
            scrO = scoreAdd(scrO);
            PlayerOsc.Text = scrO.ToString();
        }

        private void isDrawBattle()
        {
            if ((counter == 9) && !(CheckForWin(array)))
            {
                MessageBox.Show("Draw battle ... Restart game!");
                msgStatus.Text = "Draw battle";
            }

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 0;

            if (signal) {
                return;
            }

            if (isClicked[0])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt1.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt1.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else return;
            counter++;

            isClicked[0] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 1;

            if (isClicked[1])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt2.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt2.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else return;
            counter++;

            isClicked[1] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 2;

            if (isClicked[2])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt3.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt3.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else return;
            counter++;

            isClicked[2] = true;

            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 3;

            if (isClicked[3])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt4.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt4.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else return;
            counter++;

            isClicked[3] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 4;

            if (isClicked[4])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt5.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt5.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else return;
            counter++;

            isClicked[4] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 5;

            if (isClicked[5])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt6.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt6.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else return;
            counter++;

            isClicked[5] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 6;

            if (signal)
            {
                return;
            }

            if (isClicked[6])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt7.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt7.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }

            else return;
            counter++;

            isClicked[6] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 7;

            if (signal)
            {
                return;
            }

            if (isClicked[7])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt8.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt8.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }

            else return;
            counter++;

            isClicked[7] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 8;

            if (signal)
            {
                return;
            }

            if (isClicked[8])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt9.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำเล่นจร้า";
                bt9.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }

            else return;
            counter++;

            isClicked[8] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            bt1.Image = bt2.Image = bt3.Image = bt4.Image = bt5.Image = bt6.Image = bt7.Image = bt8.Image = bt9.Image = null;
            msgStatus.Text = "";
            counter = 0;
            signal = false;

            X = true;
            O = false;

            for (int i = 0; i < 9; i++)
            {
                array[i] = "0";
            }
            initialStatus();
        }

        private void ResetSC_Click(object sender, EventArgs e)
        {
            scrX = scrO = 0;
            PlayerXsc.Text = scrX.ToString();
            PlayerOsc.Text = scrO.ToString();
            msgStatus.Text = "reset score";
        }

        public bool CheckForWin(String[] array)
        {
            bool flag = false;

            if ((array[0] == array[1]) && (array[0] == array[2]) && (array[1] == array[2]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[1]) && (array[0] == array[2]) && (array[1] == array[2]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[3] == array[4]) && (array[3] == array[5]) && (array[4] == array[5]) && (array[3] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[3] == array[4]) && (array[3] == array[5]) && (array[4] == array[5]) && (array[3] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[7] == array[8]) && (array[6] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[7] == array[8]) && (array[6] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[0] == array[3]) && (array[0] == array[6]) && (array[3] == array[6]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[3]) && (array[0] == array[6]) && (array[3] == array[6]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[1] == array[4]) && (array[1] == array[7]) && (array[4] == array[7]) && (array[1] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[1] == array[4]) && (array[1] == array[7]) && (array[4] == array[7]) && (array[1] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[2] == array[5]) && (array[2] == array[8]) && (array[5] == array[8]) && (array[2] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[2] == array[5]) && (array[2] == array[8]) && (array[5] == array[8]) && (array[2] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[0] == array[4]) && (array[0] == array[8]) && (array[4] == array[8]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[4]) && (array[0] == array[8]) && (array[4] == array[8]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[2] == array[4]) && (array[2] == array[6]) && (array[4] == array[6]) && (array[2] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[2] == array[4]) && (array[2] == array[6]) && (array[4] == array[6]) && (array[2] == "o"))
            {
                winnerO();
                flag = true;
            }

            signal = flag;
            return flag;
        }

        private void Bettle_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Environment.Exit(0);
        }

    }
}
