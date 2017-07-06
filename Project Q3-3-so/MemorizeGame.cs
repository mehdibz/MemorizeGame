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
    public partial class MemorizeGame : Form
    {
        Game newMDIChild;
        AboutUs about;
        Top top5;
        public MemorizeGame()
        {
            InitializeComponent();
            about = new AboutUs();
            newMDIChild = new Game();
            top5 = new Top();
            panel1.Location = new Point(1700, 90);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMemorizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
            about.Activate();
        }

        

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
                newMDIChild.MdiParent = this;
               if (newMDIChild.Visible == false)
                {
                    newMDIChild.Show();
                    newMDIChild.Activate();
                }
                else
                {
                    newMDIChild.Activate();
                }
               newMDIChild.WindowState = FormWindowState.Maximized;

        }
        private void timer2_Tick(object sender, System.EventArgs e)
        {
            if (panel1.Left <= 100)
            {
                timer2.Enabled = false;
            }
            else
            {
                panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
            }
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (panel1.Location.X >= 1700)
            {
                timer1.Enabled = false;
            }
            else
            {
                panel1.Location = new Point(panel1.Location.X + 60, panel1.Location.Y);
            }
        }
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Interval = 5;
            timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            
        }

        private void MemorizeGame_Load(object sender, EventArgs e)
        {
            if (panel1.Location.X <= 920)
            {
                panel1.Location = new Point(1700, 90);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void topScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.Orange;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = System.Drawing.Color.Orange;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = System.Drawing.Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
         
            newMDIChild.MdiParent = this;
            if (newMDIChild.Visible == false)
            {
                newMDIChild.Show();
                newMDIChild.Activate();
            }
            else
            {
                newMDIChild.Activate();
            }
            newMDIChild.WindowState = FormWindowState.Maximized;
        }

        

        

       

        

        

        

        
    }
}
