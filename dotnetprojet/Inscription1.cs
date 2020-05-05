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
    public partial class Inscription1 : Form
    {
        internal static DBDataContext projectdb = new DBDataContext();
        Inscription2 ins2;
        public Inscription1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            PremierPage p1 = new PremierPage();
            p1.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
           /* ins2 = new Inscription2();
            ins2.lastname = firstname.Text;
            ins2.lastname = lastname.Text;
            ins2.email = email.Text;
            ins2.password = password.Text;
            ins2.ShowDialog(); */
            Inscription2 p2 = new Inscription2(firstname.Text, lastname.Text,password.Text, email.Text);
            /*p2.firstname = firstname.Text;
            p2.lastname = lastname.Text;
            p2.email = email.Text;
            p2.password = password.Text;*/

            p2.Show();
            this.Hide();
        }

        private void bunifuTextbox3_Click(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void Inscription1_Load(object sender, EventArgs e)
        {

        }
    }
}
