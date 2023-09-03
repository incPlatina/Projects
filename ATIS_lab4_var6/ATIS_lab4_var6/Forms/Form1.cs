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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void continueButton1_Click(object sender, EventArgs e)
        {
            //считываем данные с формы
            string post = comboBox1.Text;
            string name = textBox1.Text;
            
            FactoryPerson.listPerson();
            
            //создаем новый объект класса Person
            if (post == "Менеджер")
                FactoryPerson.createPerson(FactoryPerson.IDPerson.Manager_Id, post, name);
            if (post == "Ветеринарный врач")
                FactoryPerson.createPerson(FactoryPerson.IDPerson.Doktor_Id, post, name);
            if (post == "Уборщик")
                FactoryPerson.createPerson(FactoryPerson.IDPerson.Cleaner_Id, post, name);
            if (post == "Работник")
                FactoryPerson.createPerson(FactoryPerson.IDPerson.Worker_Id, post, name);
           
            //запускаем новую форму меню
            Menu m = new Menu();
            //запускаем форму списка животных
            ListForm l = new ListForm();
            
            l.Show();
            this.Hide();
            m.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
