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

    public partial class Clients : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ARM.mdb";
        private OleDbConnection myConnection;

        public Clients()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "SELECT [Код клиента], [Номер заказа], [ФИО], [Телефон] FROM Клиенты WHERE  [Код клиента] LIKE '%" + kod + "%' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
            textBox1.Clear();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.aRMDataSet.Клиенты);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = клиентыBindingSource;
            this.клиентыTableAdapter.Fill(this.aRMDataSet.Клиенты);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "DELETE FROM Клиенты WHERE [Код клиента] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            dataGridView1.DataSource = клиентыBindingSource;
            this.клиентыTableAdapter.Fill(this.aRMDataSet.Клиенты);
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
