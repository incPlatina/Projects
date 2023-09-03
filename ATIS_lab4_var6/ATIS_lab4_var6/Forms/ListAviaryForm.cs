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
    public partial class ListAviaryForm : Form
    {
        public ListAviaryForm()
        {
            InitializeComponent();
            for (int i = 0; i < Enclosure.enclosures.Count(); i++)
            {
                string[] aviarySroke = { listAviary.Items.Count.ToString(), Enclosure.enclosures[i].Type.ToString(), Enclosure.enclosures[i].StatusClean.ToString(), Enclosure.enclosures[i].StatusDes.ToString(), "15", Enclosure.enclosures[i].Temperature.ToString(), Enclosure.enclosures[i]._StatusTemperature.ToString() };
                var list = new ListViewItem(aviarySroke);
                listAviary.Items.Add(list);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAviary.Items.Clear();
            for (int i = 0; i < Enclosure.enclosures.Count(); i++)
            {
                string[] aviarySroke = { listAviary.Items.Count.ToString(), Enclosure.enclosures[i].Type.ToString(), Enclosure.enclosures[i].StatusClean.ToString(), Enclosure.enclosures[i].StatusDes.ToString(), "15", Enclosure.enclosures[i].Temperature.ToString(), Enclosure.enclosures[i]._StatusTemperature.ToString() };
                var list = new ListViewItem(aviarySroke);
                listAviary.Items.Add(list);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listAviary.Items.Clear();
            for (int i = 0; i < Enclosure.enclosures.Count(); i++)
            {
                string[] aviarySroke = { listAviary.Items.Count.ToString(), Enclosure.enclosures[i].Type.ToString(), "нет", "нет", "15", Enclosure.enclosures[i].Temperature.ToString(), Enclosure.enclosures[i]._StatusTemperature.ToString() };
                var list = new ListViewItem(aviarySroke);
                listAviary.Items.Add(list);
            }
        }
    }
}
