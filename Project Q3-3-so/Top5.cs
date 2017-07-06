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
    public partial class Top : Form
    {
        string P_Name;
        int P_Time;

        public Top()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Top_Load(object sender, EventArgs e)
        {
            button1.BackgroundImage = System.Drawing.Image.FromFile("Botton.png");
            this.BackgroundImage = System.Drawing.Image.FromFile("TopPlayer.jpg");

            //-------------------FileStream Name File-------------------


            FileStream fs = new FileStream("Name.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            P_Name = sr.ReadLine();
            sr.Close();

            //-------------------BinaryReader Num File--------------------


            BinaryReader OpenFileNum = new BinaryReader(new FileStream("Num.txt", FileMode.Open));
            P_Time = OpenFileNum.ReadInt32();
            OpenFileNum.Close();

            label6.Text = P_Name;
            label7.Text = P_Time.ToString();

        }  
    }
}
