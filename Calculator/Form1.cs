using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            radDegree.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculatorInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This calculator is property of \n Tran Le Anh Minh \n To Quoc Bao", "About calculator");
        }
    }
}
