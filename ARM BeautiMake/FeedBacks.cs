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
    public partial class FeedBacks : Form
    {
        public FeedBacks()
        {
            InitializeComponent();
        }

        private void FeedBacks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet.Отзывы". При необходимости она может быть перемещена или удалена.
            this.отзывыTableAdapter.Fill(this.aRMDataSet.Отзывы);

        }
    }
}
