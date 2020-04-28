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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            PremierPage p1 = new PremierPage();
            p1.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            MainMenu p1 = new MainMenu();
            p1.Show();
            this.Hide();
        }
    }
}
