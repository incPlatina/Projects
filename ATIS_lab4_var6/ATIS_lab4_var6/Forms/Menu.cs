using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIS_lab4_var6
{
    public partial class Menu : System.Windows.Forms.Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FactoryPerson.persons[FactoryPerson.persons.Count() - 1].position == "Менеджер")
            {
                AddBut.Visible = true;
                Removebut.Visible = true;
            }
            if (FactoryPerson.persons[FactoryPerson.persons.Count() - 1].position == "Ветеринарный врач")
            {
                Therapybut.Visible = true;
                conditionBut.Visible = true;
            }
            if (FactoryPerson.persons[FactoryPerson.persons.Count() - 1].position == "Уборщик")
            {
                Cleaningbut.Visible = true;
                desinfectionbut.Visible = true;
                ListAviaryForm list = new ListAviaryForm();
                list.Show();
            }
            if (FactoryPerson.persons[FactoryPerson.persons.Count() - 1].position == "Работник")
            {
                Feedingbut.Visible = true;
                Heatingbut.Visible = true;
                Coolingbut.Visible = true;
                moveBut.Visible = true;
                ListAviaryForm list = new ListAviaryForm();
                list.Show();
            }
            MenuKod.menuKod();
        }
        private void AddBut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(0);
        }

        private void Removebut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(1);
        }
        private void desinfectionbut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(2);
        } 
        
        private void Cleaningbut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(3);
        }

        private void Feedingbut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(4);
        }

        private void Therapybut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(5);
        }
       

        private void Coolingbut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(6);
        }

        private void Heatingbut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(7);
        }

        private void conditionBut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(8);
        }

        private void moveBut_Click(object sender, EventArgs e)
        {
            MenuKod.menuReal(9);
        }
    }
}
