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
    public partial class ZooInitialization : Form
    {
        public ZooInitialization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //инициализируем стартовые значеения людей, животных, вольеров
            FactoryAnimals.SetAnimals();
            Enclosure.SetEnclosures();
            //запускаем новую форму меню
            Form1 m = new Form1();
           
           
            this.Hide();
            m.Show();
        }

        private void ZooInitialization_Load(object sender, EventArgs e)
        {

        }
    }
}
