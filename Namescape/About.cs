using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Namescape
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void avangsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://avangs.info/");
        }

        private void ilwarLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ilwar.com/it/");
        }
    }
}
