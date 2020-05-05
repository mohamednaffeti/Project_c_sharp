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
            if (Inscription2.user.status==0)
            {
                this.Hide();
                MainMenu m = new MainMenu();
                m.Show();


            }
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
            Person spouse = new Person();
            spouse.personName = spouseNametxt.Text;
            spouse.jobstudylevel = spouseJobTxt.Text;
            spouse.schedule = spouseschedule.Text;
            // to do
            // add type col to database 
            spouse.type = "partner";

            Inscription1.projectdb.Person.InsertOnSubmit(spouse);
            Inscription1.projectdb.SubmitChanges();

            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }
    }
}
