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
    public partial class Bettle5 : Form
    {
        string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString();
        //public string Player1Name
        //{
        //    get { return label2.Text; }
        //}

        public Bettle5(string P1, string P2, int mode)
        {
            if (mode == 2)
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
            for (int i = 0; i < 25 ; i++)
            {
                isClicked[i] = false;
            }
        }

        int scrX = 0;
        int scrO = 0;

        bool X = true;
        bool O = false;

        bool signal = false;
        bool[] isClicked = new bool[25];

        int counter = 0;
        string[] array = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" , "0", "0", "0", "0", "0", "0", "0", "0", "0" };

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
            if ((counter == 25) && !(CheckForWin(array)))
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

            if (signal)
            {
                return;
            }

            if (isClicked[0])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt1.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                //if (!signal)
                //{
                //    msgStatus.Text = "!!!!";
                //}

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt1.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                //if (!signal)
                //{
                //    msgStatus.Text = "!!!!";
                //}

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

            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 1;

            if (signal)
            {
                return;
            }

            if (isClicked[1])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt2.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                //if (!signal)
                //{
                //    msgStatus.Text = "!!!!";
                //}

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt2.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                //if (!signal)
                //{
                //    msgStatus.Text = "!!!!";
                //}

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
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 2;

            if (signal)
            {
                return;
            }

            if (isClicked[2])
            {
                return;
            }

            if (O && (counter < 25))
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
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
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
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 3;

            if (signal)
            {
                return;
            }

            if (isClicked[3])
            {
                return;
            }

            if (O && (counter < 25))
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
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
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
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 4;

            if (signal)
            {
                return;
            }

            if (isClicked[4])
            {
                return;
            }

            if (O && (counter < 25))
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
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
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
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 5;

            if (signal)
            {
                return;
            }

            if (isClicked[5])
            {
                return;
            }

            if (O && (counter < 25))
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
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
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
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 6;

            if (signal)
            {
                return;
            }

            if (isClicked[6])
            {
                return;
            }

            if (O && (counter < 25))
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
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
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
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 7;

            if (signal)
            {
                return;
            }

            if (isClicked[7])
            {
                return;
            }

            if (O && (counter < 25))
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
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
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
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 8;

            if (signal)
            {
                return;
            }

            if (isClicked[8])
            {
                return;
            }

            if (O && (counter < 25))
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
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
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

        private void bt10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 9;

            if (signal)
            {
                return;
            }

            if (isClicked[9])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt10.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt10.Image = Image.FromFile("X.jpg");
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

            isClicked[9] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 10;

            if (signal)
            {
                return;
            }

            if (isClicked[10])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt11.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt11.Image = Image.FromFile("X.jpg");
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

            isClicked[10] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 11;

            if (signal)
            {
                return;
            }

            if (isClicked[11])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt12.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt12.Image = Image.FromFile("X.jpg");
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

            isClicked[11] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 12;

            if (signal)
            {
                return;
            }

            if (isClicked[12])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt13.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt13.Image = Image.FromFile("X.jpg");
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

            isClicked[12] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt14_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 13;

            if (signal)
            {
                return;
            }

            if (isClicked[13])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt14.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt14.Image = Image.FromFile("X.jpg");
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

            isClicked[13] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt15_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();
            int botton = 14;

            if (signal)
            {
                return;
            }

            if (isClicked[14])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt15.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt15.Image = Image.FromFile("X.jpg");
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

            isClicked[14] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            bt1.Image = bt2.Image = bt3.Image = bt4.Image = bt5.Image = bt6.Image = bt7.Image = bt8.Image = bt9.Image = bt10.Image = bt11.Image = bt12.Image = bt13.Image = bt14.Image = bt15.Image = bt16.Image = bt17.Image = bt18.Image = bt19.Image = bt20.Image = bt21.Image = bt22.Image = bt23.Image = bt24.Image = bt25.Image = null;
            msgStatus.Text = "";
            counter = 0;
            signal = false;

            X = true;
            O = false;

            for (int i = 0; i < 25; i++)
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

        private void bt16_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 15;

            if (signal)
            {
                return;
            }

            if (isClicked[15])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt16.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt16.Image = Image.FromFile("X.jpg");
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

            isClicked[15] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void Bettle4_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Environment.Exit(0);
        }

        private void bt17_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 16;

            if (signal)
            {
                return;
            }

            if (isClicked[16])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt17.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt17.Image = Image.FromFile("X.jpg");
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

            isClicked[16] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt18_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 17;

            if (signal)
            {
                return;
            }

            if (isClicked[17])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt18.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt18.Image = Image.FromFile("X.jpg");
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

            isClicked[17] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt19_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 18;

            if (signal)
            {
                return;
            }

            if (isClicked[18])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt19.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt19.Image = Image.FromFile("X.jpg");
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

            isClicked[18] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt20_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 19;

            if (signal)
            {
                return;
            }

            if (isClicked[19])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt20.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt20.Image = Image.FromFile("X.jpg");
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

            isClicked[19] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt21_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 20;

            if (signal)
            {
                return;
            }

            if (isClicked[20])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt21.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt21.Image = Image.FromFile("X.jpg");
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

            isClicked[20] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt22_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 21;

            if (signal)
            {
                return;
            }

            if (isClicked[21])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt22.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt22.Image = Image.FromFile("X.jpg");
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

            isClicked[21] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt23_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 22;

            if (signal)
            {
                return;
            }

            if (isClicked[22])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt23.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt23.Image = Image.FromFile("X.jpg");
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

            isClicked[22] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt24_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 23;

            if (signal)
            {
                return;
            }

            if (isClicked[23])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt24.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt24.Image = Image.FromFile("X.jpg");
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

            isClicked[23] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        private void bt25_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path + @"\Sound\k2.wav");
            player.Play();

            int botton = 24;

            if (signal)
            {
                return;
            }

            if (isClicked[24])
            {
                return;
            }

            if (O && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะขาวเล่นจร้า";
                bt25.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "!!!!";
                }

            }
            else if (X && (counter < 25))
            {
                msgStatus.Text = "ต่อไปเป็นฝ่าย แกะดำล่นจร้า";
                bt25.Image = Image.FromFile("X.jpg");
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

            isClicked[24] = true;
            if (CheckForWin(array))
            {
                return;
            }

            isDrawBattle();
        }

        public bool CheckForWin(String[] array)
        {
            bool flag = false;

            if ((array[0] == array[1]) && (array[0] == array[2]) && (array[0] == array[3]) && (array[0] == array[4]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[1]) && (array[0] == array[2]) && (array[0] == array[3]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[0] == array[6]) && (array[0] == array[12]) && (array[0] == array[18]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[6]) && (array[0] == array[12]) && (array[0] == array[18]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[0] == array[5]) && (array[0] == array[10]) && (array[0] == array[15]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[5]) && (array[0] == array[10]) && (array[0] == array[15]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[1] == array[6]) && (array[1] == array[11]) && (array[1] == array[16]) && (array[1] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[1] == array[6]) && (array[1] == array[11]) && (array[1] == array[16]) && (array[1] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[1] == array[7]) && (array[1] == array[13]) && (array[1] == array[19]) && (array[1] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[1] == array[7]) && (array[1] == array[13]) && (array[1] == array[19]) && (array[1] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[1] == array[2]) && (array[1] == array[3]) && (array[1] == array[4]) && (array[1] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[1] == array[2]) && (array[1] == array[3]) && (array[1] == array[4]) && (array[1] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[2] == array[7]) && (array[2] == array[12]) && (array[2] == array[17]) && (array[2] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[2] == array[7]) && (array[2] == array[12]) && (array[2] == array[17]) && (array[2] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[3] == array[7]) && (array[3] == array[11]) && (array[3] == array[15]) && (array[3] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[3] == array[7]) && (array[3] == array[11]) && (array[3] == array[15]) && (array[3] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[3] == array[8]) && (array[3] == array[13]) && (array[3] == array[18]) && (array[3] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[3] == array[7]) && (array[3] == array[13]) && (array[3] == array[18]) && (array[3] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[4] == array[9]) && (array[4] == array[14]) && (array[4] == array[19]) && (array[4] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[4] == array[9]) && (array[4] == array[14]) && (array[4] == array[19]) && (array[4] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[4] == array[8]) && (array[4] == array[12]) && (array[4] == array[16]) && (array[4] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[4] == array[8]) && (array[4] == array[12]) && (array[4] == array[16]) && (array[4] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[5] == array[10]) && (array[5] == array[15]) && (array[5] == array[20]) && (array[5] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[5] == array[10]) && (array[5] == array[15]) && (array[5] == array[20]) && (array[5] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[5] == array[11]) && (array[5] == array[17]) && (array[5] == array[23]) && (array[5] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[5] == array[11]) && (array[5] == array[17]) && (array[5] == array[23]) && (array[5] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[5] == array[6]) && (array[5] == array[7]) && (array[5] == array[8]) && (array[5] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[5] == array[6]) && (array[5] == array[7]) && (array[5] == array[8]) && (array[5] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[6] == array[11]) && (array[6] == array[16]) && (array[6] == array[21]) && (array[6] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[6] == array[11]) && (array[6] == array[16]) && (array[6] == array[21]) && (array[6] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[6] == array[12]) && (array[6] == array[18]) && (array[6] == array[24]) && (array[6] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[6] == array[12]) && (array[6] == array[18]) && (array[6] == array[24]) && (array[6] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[6] == array[9]) && (array[6] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[6] == array[9]) && (array[6] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[7] == array[12]) && (array[7] == array[17]) && (array[7] == array[22]) && (array[7] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[7] == array[12]) && (array[7] == array[17]) && (array[7] == array[22]) && (array[7] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[8] == array[12]) && (array[8] == array[16]) && (array[8] == array[20]) && (array[8] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[8] == array[12]) && (array[8] == array[16]) && (array[8] == array[20]) && (array[8] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[8] == array[13]) && (array[8] == array[18]) && (array[8] == array[23]) && (array[8] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[8] == array[13]) && (array[8] == array[18]) && (array[8] == array[23]) && (array[8] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[9] == array[13]) && (array[9] == array[17]) && (array[9] == array[21]) && (array[9] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[9] == array[13]) && (array[9] == array[17]) && (array[9] == array[21]) && (array[9] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[9] == array[14]) && (array[9] == array[19]) && (array[9] == array[24]) && (array[9] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[9] == array[14]) && (array[9] == array[19]) && (array[9] == array[24]) && (array[9] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[10] == array[11]) && (array[10] == array[12]) && (array[10] == array[13]) && (array[10] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[10] == array[11]) && (array[10] == array[12]) && (array[10] == array[13]) && (array[10] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[11] == array[12]) && (array[11] == array[13]) && (array[11] == array[14]) && (array[11] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[11] == array[12]) && (array[11] == array[13]) && (array[11] == array[14]) && (array[11] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[15] == array[16]) && (array[15] == array[17]) && (array[15] == array[18]) && (array[15] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[15] == array[16]) && (array[15] == array[17]) && (array[15] == array[18]) && (array[15] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[16] == array[17]) && (array[16] == array[18]) && (array[16] == array[19]) && (array[16] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[16] == array[17]) && (array[16] == array[18]) && (array[16] == array[19]) && (array[16] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[20] == array[21]) && (array[20] == array[22]) && (array[20] == array[23]) && (array[20] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[20] == array[21]) && (array[20] == array[22]) && (array[20] == array[23]) && (array[20] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[21] == array[22]) && (array[21] == array[23]) && (array[21] == array[24]) && (array[21] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[21] == array[22]) && (array[21] == array[23]) && (array[21] == array[24]) && (array[21] == "o"))
            {
                winnerO();
                flag = true;
            }



            signal = flag;
            return flag;

        }
    }
}
