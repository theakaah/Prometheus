using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prometheus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] machine_6 = new string[] { "PH0001", "PH0008", "3", "4", "5" };
            string[] machine_7 = new string[] { "PHT001", "PHT008", "3", "4", "5" };
            string[] machine_8 = new string[] { "PAS001", "PAS008", "31", "4", "5" };
            //listBox1.Items.AddRange(items1);


            mirror_machine_sel.Items.Clear();
            //mirror_machine_sel.Items.RemoveAt(mirror_machine_sel.SelectedIndex);
            mirror_machine_sel.Items.AddRange(machine_7);


        }

        private void radioButton1_click(object sender, EventArgs e)
        {
            string[] machine_6 = new string[] { "PH0001", "PH0008", "3", "4", "5" };
            mirror_machine_sel.Items.RemoveAt(mirror_machine_sel.SelectedIndex);
            mirror_machine_sel.Items.AddRange(machine_6);



        }
    }
}
