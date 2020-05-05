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
    public partial class ChildrenForm : Form
    {
        int nbChildrenSubmited=0;
        public ChildrenForm()
        {

            InitializeComponent();
        }

        private void ChildrenForm_Load(object sender, EventArgs e)
        {
           
        }
        private void ChildrenForm_Shown(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pred_Click(object sender, EventArgs e)
        {
            Inscription2 ins2 = new Inscription2();
            ins2.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
          
           
                Children children = new Children();
            
            //children.IdChildren = nbChildrenSubmited ;
                children.childrenName = childrenNameTxt.Text;
                children.studyLevel = degreeTxt.Text;
                children.schoolDistance = int.Parse(schoolDistanceTxt.Text);
                //lezem nzid job/etudiant fi children w baed nzid f person.
                 
                Inscription1.projectdb.Children.InsertOnSubmit(children);
                Inscription1.projectdb.SubmitChanges();
                 this.nbChildrenSubmited++;
            Person person = new Person();
            person.personName= childrenNameTxt.Text;
            person.jobstudylevel= degreeTxt.Text;
            person.schedule = childrenschedule.Text;
            person.type = "children";
            Inscription1.projectdb.Person.InsertOnSubmit(person);
            Inscription1.projectdb.SubmitChanges();

            if (Inscription2.user.nbChildren == this.nbChildrenSubmited)
            {
               
                if ((Inscription2.user.father == 1) || (Inscription2.user.mother == 1))
                {
                    Parent parent = new Parent();
                    parent.Show();
                    this.Hide();
                }
                else if (Inscription2.user.status == 1)
                {
                    SpouseName spouse = new SpouseName();
                    spouse.Show();
                    this.Hide();
                }

            }
            else
            {
                childrenNameTxt.Text = "";
                schoolDistanceTxt.Text = "";
                degreeTxt.Text = "";
            }


        }
    }
}
