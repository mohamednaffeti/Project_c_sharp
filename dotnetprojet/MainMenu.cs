using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetprojet
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void myPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Health h1 = new Health();
            //myPanel.Controls.Clear();
            //myPanel.Controls.Add(h1);
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Tasks_Click(object sender, EventArgs e)
        {

            Tasks x = new Tasks();
            x.Show();

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Inscription1 ins = new Inscription1();
            ins.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            statistics s1 = new statistics();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(s1);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
