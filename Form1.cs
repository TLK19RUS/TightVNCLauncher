using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TightVNCLauncher
{
    //tvnviewer -host="192.168.15.1" -password="Yflt;lf0"
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "host";
            listBox1.DataSource = Program.hosts;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.hosts.Add(new THost("inspektore", "inspektore","Yflt;lf0"));
        }
    }
}
