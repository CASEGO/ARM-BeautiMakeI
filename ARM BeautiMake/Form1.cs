using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_BeautiMake
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients frm = new Clients();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff frm = new Staff();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Money frm = new Money();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FeedBacks frm = new FeedBacks();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
