using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControlTask
{
    public partial class main : Form
    {
        private SqlConnection NorthwindConnection;
        private SqlDataAdapter SqlDataAdapter1;
        private DataSet NorthwindDataSet;
        private string activeTable;
        DataTable table;

        public main()
        {
            InitializeComponent();
            closing.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void connecting_Click(object sender, EventArgs e)
        {
            connect Connection = new connect();
            if (Connection.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string con = $"Server=(local)\\sqlexpress;Initial Catalog=Northwind;Integrated Security=False;Password={Connection.userPassword};" +
                    $"User Id={Connection.userName}";
                NorthwindConnection = new SqlConnection(con);
                NorthwindConnection.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Подключение к БД выполнено успешно!");
                ToolStripMenuItem tables = new ToolStripMenuItem("Таблицы");
                SqlCommand smd = new SqlCommand("SELECT TABLE_NAME FROM Northwind.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", NorthwindConnection);
                SqlDataReader sdr = smd.ExecuteReader();
                while (sdr.Read())
                {
                    tables.DropDownItems.Add(sdr["TABLE_NAME"].ToString());
                    tables.DropDownItems[tables.DropDownItems.Count-1].Click += new System.EventHandler(clickOnTable);
                }          

                menuStrip1.Items.Add(tables);
                NorthwindConnection.Close();
                NorthwindDataSet = new DataSet("Northwind");

                connecting.Enabled = false;
                closing.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void closing_Click(object sender, EventArgs e)
        {
            SqlDataAdapter1 = null;
            NorthwindDataSet = null;
            NorthwindConnection = new SqlConnection();
            dataGridView1.Columns.Clear();
            menuStrip1.Items.RemoveAt(1);

            connecting.Enabled = true;
            closing.Enabled = false;

        }
        private void clickOnTable(object sender,System.EventArgs e) 
        {
            
            SqlDataAdapter1 = new SqlDataAdapter($"SELECT * FROM [{sender.ToString()}]", NorthwindConnection);

            table = new DataTable(sender.ToString());
            NorthwindDataSet = new DataSet();
            NorthwindDataSet.Tables.Add(table);

            SqlDataAdapter1.Fill(NorthwindDataSet.Tables[sender.ToString()]);
            dataGridView1.DataSource = NorthwindDataSet.Tables[$"{sender.ToString()}"];
            activeTable = sender.ToString();
            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                NorthwindDataSet.EndInit();
                SqlDataAdapter1.Update(NorthwindDataSet.Tables[activeTable]);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        private void addRow_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();
            table.Rows.Add(row);
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }catch(Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
