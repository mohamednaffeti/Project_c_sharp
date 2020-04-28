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
    public partial class SpouseName : Form
    {
        public SpouseName()
        {
            InitializeComponent();
        }

        private void NivEtude_OnTextChange(object sender, EventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            Parent p = new Parent();
            p.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            MainMenu m= new MainMenu();
            m.Show();
            this.Hide();
        }
    }
}
