using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_votingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addUeserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser myform = new addUser();
            myform.Show();
        }

        private void votingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voting v = new Voting();
            v.Show();
        }
    }
}
