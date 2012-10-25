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

        public Bettle(string P1,string P2,int mode)
        {
            if (mode == 0)
            {
                InitializeComponent();
                initialStatus();

                msgStatus.Text = "xxxxx";
                PlayerOsc.Text = scrO.ToString();
                PlayerXsc.Text = scrX.ToString();
                //label2.Text = P1;
            }
            else if (mode == 1)
            {
                InitializeComponent();
                initialStatus();

                msgStatus.Text = "xxxxx";
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


        private void winnerX()
        {
            //MessageBox.Show("Winner is X", "Winner", MessageBoxButton.OK, MessageBoxImage.Information);
            msgStatus.Text = "Winner is X. Restart game !";
            scrX++;
            PlayerXsc.Text = scrX.ToString();
        }

        private void winnerO()
        {
            //MessageBox.Show("Winner is O", "Winner", MessageBoxButton.OK, MessageBoxImage.Information);
            msgStatus.Text = "Winner is O. Restart game !";
            scrO++;
            PlayerOsc.Text = scrO.ToString();
        }

        private void isDrawBattle()
        {
            if ((counter == 9) && !(CheckForWin()))
            {
                //MessageBox.Show("Draw battle", "Winner", MessageBoxButton.OK, MessageBoxImage.Information);
                msgStatus.Text = "Draw battle";
            }

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            int botton = 0;

            if (signal) {
                return;
            }

            if (isClicked[0])
            {
                return;
            }
           
            if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt1.Image = Image.FromFile("X.jpg");
                array[botton] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }
               
            }
            else if (O && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt1.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[0] = true;
            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            int botton = 1;

            if (signal)
            {
                return;
            }

            if (isClicked[1])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt2.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt2.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[1] = true;
            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            int botton = 2;

            if (signal)
            {
                return;
            }

            if (isClicked[2])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt3.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt3.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[2] = true;

            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            int botton = 3;

            if (signal)
            {
                return;
            }

            if (isClicked[3])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt4.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt4.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[3] = true;
            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            int botton = 4;

            if (signal)
            {
                return;
            }

            if (isClicked[4])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt5.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt5.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[4] = true;
            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            int botton = 5;

            if (signal)
            {
                return;
            }

            if (isClicked[5])
            {
                return;
            }

            if (O && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt6.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt6.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[5] = true;
            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
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
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt7.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt7.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[6] = true;
            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
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
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt8.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt8.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[7] = true;
            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
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
                msgStatus.Text = "ตอนนี้เป็นฝ่าย O เล่นน๊าาาา";
                bt9.Image = Image.FromFile("O.jpg");
                array[botton] = "o";
                O = false;
                X = true;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ X ย๊ะหล่อน";
                }

            }
            else if (X && (counter < 9))
            {
                msgStatus.Text = "ตอนนี้เป็นฝ่าย X เล่นน๊าาาา";
                bt9.Image = Image.FromFile("X.jpg");
                array[botton] = "x";

                O = true;
                X = false;

                if (!signal)
                {
                    msgStatus.Text = "ว๊ายยยยย เป็นตาของ O ย๊ะหล่อน";
                }

            }

            else return;
            counter++;

            isClicked[8] = true;
            if (CheckForWin())
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

        private bool CheckForWin()
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


    }
}
