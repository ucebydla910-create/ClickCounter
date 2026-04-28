using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Form1 : Form
    {
        int ClickCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCounter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            ClickCount++;
            lblCounter.Text = ClickCount.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            lblCounter.Text = "0";
        }
    }
}
