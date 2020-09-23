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
            public static string[] machine_6 = new string[] { "PH0001", "PH0008", "3", "4", "5" };
            public static string[] machine_7 = new string[] { "PHT001", "PHT008", "3", "4", "5" };
            public static string[] machine_8 = new string[] { "PAS001", "PAS008", "31", "4", "5" };



        }

    private void mirror_machine_sel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mirror_machine_sel.Items.RemoveAt(mirror_machine_sel.SelectedIndex);
            mirror_machine_sel.Items.AddRange(machine_6);



        }
}
}
