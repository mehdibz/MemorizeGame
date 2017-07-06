using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Project_Q3_3_so
{
    public partial class definePlayer : Form
    {
        //Game newMDIChild;
        public definePlayer()
        {
            InitializeComponent();
        }

        private void definePlayer_Load(object sender, EventArgs e)
        {
            btnOk.BackgroundImage = System.Drawing.Image.FromFile("Botton.png");
            this.BackgroundImage = System.Drawing.Image.FromFile("WonBg.jpg");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveName(txtName.Text);
            this.Close();
        }

        public void SaveName(string v)
        {
            FileStream fs = new FileStream("Name.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(v);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
  
    }
}
