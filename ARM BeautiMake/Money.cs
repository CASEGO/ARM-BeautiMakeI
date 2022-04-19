using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ARM_BeautiMake
{

    public partial class Money : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ARM.mdb";
        private OleDbConnection myConnection;
        public Money()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMoney af = new AddMoney();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Выручка WHERE [Код] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            dataGridView1.DataSource = выручкаBindingSource;
            this.выручкаTableAdapter.Fill(this.aRMDataSet.Выручка);
            textBox1.Clear();
        }

        private void Money_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet.Выручка". При необходимости она может быть перемещена или удалена.
            this.выручкаTableAdapter.Fill(this.aRMDataSet.Выручка);

        }

        private void Money_Activated(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = выручкаBindingSource;
            this.выручкаTableAdapter.Fill(this.aRMDataSet.Выручка);
        }
    }
}
