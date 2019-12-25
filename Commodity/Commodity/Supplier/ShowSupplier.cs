using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commodity.Supplier
{
    public partial class ShowSupplier : Form
    {
        public static string connectionString = "server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI";
        public ShowSupplier()
        {
            InitializeComponent();
        }

        private void ShowSupplier_Load(object sender, EventArgs e)
        {
            DataGridViewDataLoad();
        }
        public void DataGridViewDataLoad()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter s = new SqlDataAdapter("select * from  Supplier", conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            dataGridView1.DataSource = d.Tables["t"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除该品牌信息？", "删除", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                object name;
                int a = dataGridView1.CurrentRow.Index;
                name = dataGridView1.Rows[a].Cells[0].Value;
                Console.WriteLine(name);
                string sql2 = string.Format("delete from Supplier where sname='{0}'", name);
                cmd = new SqlCommand(sql2, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
            }
            DataGridViewDataLoad();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewDataLoad();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String type = comboBox1.Text.Trim();
            if (type == "按供货商名名查询")
            {
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from Supplier where sname like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
            else if (type == "按联系人查询")
            {
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from Supplier where contacts like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSupplier a = new AddSupplier();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object name;
            int a = dataGridView1.CurrentRow.Index;
            name = dataGridView1.Rows[a].Cells[0].Value;
            UpdateSupplier U = new UpdateSupplier(name);
            U.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object name;
            int a = dataGridView1.CurrentRow.Index;
            name = dataGridView1.Rows[a].Cells[0].Value;
            DetailsSupplier U = new DetailsSupplier(name);
            U.Show();
        }
    }
}
