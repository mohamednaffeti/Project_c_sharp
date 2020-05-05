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
    public partial class Parent : Form
    {
        public Parent()
        {
          
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextbox4_OnTextChange(object sender, EventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            ChildrenForm ins2 = new ChildrenForm();
            ins2.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (Inscription2.user.mother == 1)
            {
                Person mother = new Person();
                mother.personName = motherNameTxt.Text;
                mother.jobstudylevel= motherJobTxt.Text;
                mother.schedule = motherScheduleTxt.Text;
                mother.type = "mother";

                // to do
                // add type col to database 
                // mother.type = "mother"


                Inscription1.projectdb.Person.InsertOnSubmit(mother);
                Inscription1.projectdb.SubmitChanges();
               
            }

            if (Inscription2.user.father == 1)
            {
                
                Person father = new Person();
                father.personName = fatherNameTxt.Text;
                father.jobstudylevel = fatherJobTxt.Text;
                father.schedule = fatherScheduleTxt.Text;
                father.type = "father";
                // to do
                // add type col to database 
                // father.type = "father"



                Inscription1.projectdb.Person.InsertOnSubmit(father);
                Inscription1.projectdb.SubmitChanges();
            }



            if (Inscription2.user.status == 1)
            {
                SpouseName s = new SpouseName();
                s.Show();
                this.Hide();
            }else
            {
                MainMenu main = new MainMenu();
                main.Show();
                this.Hide();
            }
        }
    }
}
