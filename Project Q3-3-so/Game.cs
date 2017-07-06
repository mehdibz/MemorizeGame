using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Q3_3_so
{
    public partial class Game : Form
    {
        int[] arrCell = new int[16];
        int[] arrRNum = new int[16];
        int[] arrNumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 };
        int y,n,r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16;
        int t = 0, cell1, cell2,counter;
        //string Win_Time;
        static FileStream FWstream;
        //static FileStream FRstream;
        public StreamWriter W;
        public StreamReader R;
        //MessageBoxIcon ic;

        public Game()
        {
            InitializeComponent();
            //MessageBoxIcon ic = new MessageBoxIcon();
            counter = 101;
            PictureBox[] p = new PictureBox[10];
        }

        
        public void timer1_Tick(object sender, System.EventArgs e)   
        {
            
            if (counter <= 0) 
            {
               timer1.Enabled = false;
               counter = 101;
               MessageBox.Show(" Your time is finished...");
            }
            else
            {
           counter = counter - 1;
           label1.Text = "Time Remaining :";
           label2.Text = counter.ToString();
           label4.Text = "Time Elapsed :";
           label3.Text = (100 - counter).ToString();
           Int32 Read_Num = (100 - counter);
            if(n==16)
            {
                timer1.Enabled = false;
                BinaryReader OpenObj = new BinaryReader(new FileStream("Num.txt", FileMode.Open));
                int i = OpenObj.ReadInt32();
                OpenObj.Close();
                if (Read_Num < i)
                {
                    BinaryWriter CreateObj = new BinaryWriter(new FileStream("Num.txt", FileMode.Create));
                    CreateObj.Write(Read_Num);
                    CreateObj.Close();
                    definePlayer dfnPlayer = new definePlayer();
                    dfnPlayer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You finished the game but you did not won the game...", "Finished successfully", MessageBoxButtons.OK);
                    
                }
                //Top win = new Top();
                //FileLink(name+score,score);
                n=0;
            }
           }
        }
        

        private void Game_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Back.bmp");
            counter = 101;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.WindowState = FormWindowState.Maximized;
            process();
        
        }
        private void process()
        {
           

            Random rndNumber = new Random();
            //----------------------R1

            r1 = rndNumber.Next(0, arrNumber.Length);
            arrCell[0] = arrNumber[r1];
            arrRNum[0] = r1;
            Array.Clear(arrNumber, r1, 1);

            //----------------------R2

            r2 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r2] == 0)
            {
                r2 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[1] = arrNumber[r2];
            arrRNum[1] = r2;
            Array.Clear(arrNumber, r2, 1);

            //---------------------R3

            r3 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r3] == 0)
            {
                r3 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[2] = arrNumber[r3];
            arrRNum[2] = r3;
            Array.Clear(arrNumber, r3, 1);

            //----------------------R4

            r4 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r4] == 0)
            {
                r4 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[3] = arrNumber[r4];
            arrRNum[3] = r4;
            Array.Clear(arrNumber, r4, 1);

            //----------------------R5

            r5 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r5] == 0)
            {
                r5 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[4] = arrNumber[r5];
            arrRNum[4] = r5;
            Array.Clear(arrNumber, r5, 1);

            //---------------------R6

            r6 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r6] == 0)
            {
                r6 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[5] = arrNumber[r6];
            arrRNum[5] = r6;
            Array.Clear(arrNumber, r6, 1);

            //----------------------R7

            r7 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r7] == 0)
            {
                r7 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[6] = arrNumber[r7];
            arrRNum[6] = r7;
            Array.Clear(arrNumber, r7, 1);

            //----------------------R8

            r8 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r8] == 0)
            {
                r8 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[7] = arrNumber[r8];
            arrRNum[7] = r8;
            Array.Clear(arrNumber, r8, 1);

            //-----------------------R9

            r9 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r9] == 0)
            {
                r9 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[8] = arrNumber[r9];
            arrRNum[8] = r9;
            Array.Clear(arrNumber, r9, 1);

            //-----------------------R10

            r10 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r10] == 0)
            {
                r10 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[9] = arrNumber[r10];
            arrRNum[9] = r10;
            Array.Clear(arrNumber, r10, 1);

            //---------------------R11

            r11 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r11] == 0)
            {
                r11 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[10] = arrNumber[r11];
            arrRNum[10] = r11;
            Array.Clear(arrNumber, r11, 1);

            //---------------------R12

            r12 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r12] == 0)
            {
                r12 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[11] = arrNumber[r12];
            arrRNum[11] = r12;
            Array.Clear(arrNumber, r12, 1);

            //----------------------R13

            r13 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r13] == 0)
            {
                r13 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[12] = arrNumber[r13];
            arrRNum[12] = r13;
            Array.Clear(arrNumber, r13, 1);

            //------------------------R14

            r14 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r14] == 0)
            {
                r14 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[13] = arrNumber[r14];
            arrRNum[13] = r14;
            Array.Clear(arrNumber, r14, 1);

            //-----------------------R15

            r15 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r15] == 0)
            {
                r15 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[14] = arrNumber[r15];
            arrRNum[14] = r15;
            Array.Clear(arrNumber, r15, 1);

            //-----------------------R16

            r16 = rndNumber.Next(0, arrNumber.Length);
            while (arrNumber[r16] == 0)
            {
                r16 = rndNumber.Next(0, arrNumber.Length);
            }

            arrCell[15] = arrNumber[r16];
            arrRNum[15] = r16;
            Array.Clear(arrNumber, r16, 1);

            CallReset();
        }
        private void CallReset()
        {
            int m;
            pictureBox1.Load("20.jpg");
            pictureBox2.Load("20.jpg");
            pictureBox3.Load("20.jpg");
            pictureBox4.Load("20.jpg");
            pictureBox5.Load("20.jpg");
            pictureBox6.Load("20.jpg");
            pictureBox7.Load("20.jpg");
            pictureBox8.Load("20.jpg");
            pictureBox9.Load("20.jpg");
            pictureBox10.Load("20.jpg");
            pictureBox11.Load("20.jpg");
            pictureBox12.Load("20.jpg");
            pictureBox13.Load("20.jpg");
            pictureBox14.Load("20.jpg");
            pictureBox15.Load("20.jpg");
            pictureBox16.Load("20.jpg");
            for (m = 0; m < 8; m++)
              arrNumber[m] = m+1;
            for (m = 0; m < 8; m++)
              arrNumber[m + 8] = m+1;
        }
        private void CallResetVisible()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
        }
        private void Case(int var)
        {
            switch(var)
            {
                case 0:
                    pictureBox1.Visible = false;
                    ++n;
                    break;
                case 1:
                    pictureBox2.Visible = false;
                    ++n;
                    break;
                case 2:
                    pictureBox3.Visible = false;
                    ++n;
                    break;
                case 3:
                    pictureBox4.Visible = false;
                    ++n;
                    break;
                case 4:
                    pictureBox5.Visible = false;
                    ++n;
                    break;
                case 5:
                    pictureBox6.Visible = false;
                    ++n;
                    break;
                case 6:
                    pictureBox7.Visible = false;
                    ++n;
                    break;
                case 7:
                    pictureBox8.Visible = false;
                    ++n;
                    break;
                case 8:
                    pictureBox9.Visible = false;
                    ++n;
                    break;
                case 9:
                    pictureBox10.Visible = false;
                    ++n;
                    break;
                case 10:
                    pictureBox11.Visible = false;
                    ++n;
                    break;
                case 11:
                    pictureBox12.Visible = false;
                    ++n;
                    break;
                case 12:
                    pictureBox13.Visible = false;
                    ++n;
                    break;
                case 13:
                    pictureBox14.Visible = false;
                    ++n;
                    break;
                case 14:
                    pictureBox15.Visible = false;
                    ++n;
                    break;
                case 15:
                    pictureBox16.Visible = false;
                    ++n;
                    break;
            }
        }
        public void FileLink(string v, string filemode)
        {
            switch (filemode)
            {
                case "Append":
                    FWstream = new FileStream("TopScore.txt", FileMode.Append, FileAccess.Write);
                    break;

                case "Truncate":
                    FWstream = new FileStream("TopScore.txt", FileMode.Truncate, FileAccess.Write);
                    break;

                case "Open":
                    FWstream = new FileStream("TopScore.txt", FileMode.Open, FileAccess.Write);
                    break;
            }
            W = new StreamWriter(FWstream);
            W.Write(v);
            W.Flush();
            W.Close();
            FWstream.Close();
        }
        private void roll(int x)
        {
            Random rndRNum = new Random();
            if (t < 2)
            {

                if (t == 0)
                {
                    cell1 = arrCell[x];
                    y = x;
                    t++;
                }
                else
                {
                    ++t;
                    cell2 = arrCell[x];
                    if ((y != x)&&(cell1 == cell2))
                    {
                        Case(y);
                        Case(x);
                        t = 0;
                    }
                }
            }
            else
            {
                CallReset();
                t = 0;
                cell1 = 0;
                cell2 = 0;
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(arrCell[0].ToString()+".jpg");
            roll(0);
                       
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Load(arrCell[1].ToString() + ".jpg");
            roll(1);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Load(arrCell[2].ToString() + ".jpg");
            roll(2);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Load(arrCell[3].ToString() + ".jpg");
            roll(3);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Load(arrCell[4].ToString() + ".jpg");
            roll(4);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Load(arrCell[5].ToString() + ".jpg");
            roll(5);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Load(arrCell[6].ToString() + ".jpg");
            roll(6);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Load(arrCell[7].ToString() + ".jpg");
            roll(7);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Load(arrCell[8].ToString() + ".jpg");
            roll(8);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Load(arrCell[9].ToString() + ".jpg");
            roll(9);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Load(arrCell[10].ToString() + ".jpg");
            roll(10);
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Load(arrCell[11].ToString() + ".jpg");
            roll(11);
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Load(arrCell[12].ToString() + ".jpg");
            roll(12);
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Load(arrCell[13].ToString() + ".jpg");
            roll(13);
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Load(arrCell[14].ToString() + ".jpg");
            roll(14);
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Load(arrCell[15].ToString() + ".jpg");
            roll(15);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CallResetVisible();
            timer1.Enabled = true;
            counter = 101;
            process();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            int i = 50;
            BinaryWriter CreateObj = new BinaryWriter(new FileStream("Num.txt", FileMode.Create));
            CreateObj.Write(i);
            CreateObj.Close();
        }

        
        

        
    }
}
