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
    public partial class Inscription2 : Form
    { public string firstname;
        public string lastname;
        public string email;
        public string password;
        

        public Inscription2()
        {
            InitializeComponent();
            
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            Inscription1 p1 = new Inscription1();
            p1.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            User user = new User();
            Person person = new Person();
            user.firstName = firstname;
            user.lastName = lastname;
            user.email = email;
            user.birthday = datebirth.Value;
            if (female.Checked)
                user.genre = 0;
            else user.genre = 1;
            user.address = adresse.Text;
            if (single.Checked)
                user.status = 0;
            else user.status = 1;
            user.nbChildren = int.Parse(nbrchild.Text);
            if (father.Checked)
            {
                user.father = 1;
                
            }
            else user.father = 0;
            if (mother.Checked)
                user.mother = 1;
            else user.mother = 0;
            Inscription1.projectdb.Users.InsertOnSubmit(user);
            Inscription1.projectdb.SubmitChanges();
           



            Children c1 = new Children();
            c1.Show();
            this.Hide();
        }

        private void Inscription2_Load(object sender, EventArgs e)
        {

        }
    }
}
