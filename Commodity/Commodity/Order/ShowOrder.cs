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

namespace Commodity.Order
{
    public partial class ShowOrder : Form
    {
        public static string connectionString = "server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI";
        public ShowOrder()
        {
            InitializeComponent();
        }

        private void ShowOrder_Load(object sender, EventArgs e)
        {
            DataGridViewDataLoad();
        }
        public void DataGridViewDataLoad()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter s = new SqlDataAdapter("select * from [order]", conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            dataGridView1.DataSource = d.Tables["t"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewDataLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除该订单信息？", "删除", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                object id;
                int a = dataGridView1.CurrentRow.Index;
                id = dataGridView1.Rows[a].Cells[0].Value;
                Console.WriteLine(id);
                string sql2 = "delete from [order] where ono=" + id;
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

        private void button5_Click(object sender, EventArgs e)
        {
            String type = comboBox1.Text.Trim();
            if (type == "按订单号查询")
            { 
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from [order] where ono like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"]; 
            }
            else if (type == "按商品编号查询")
            {
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from [order] where cno like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
            else if (type == "按客户姓名查询")
            {
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from [order] where khxm like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
            else if (type == "按时间查询")
            {
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from [order] where dgsj like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
            else
                DataGridViewDataLoad();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrder a = new AddOrder();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object id;
            int a = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[a].Cells[0].Value;
            UpdateOrder U = new UpdateOrder(id);
            U.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object id;
            int a = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[a].Cells[0].Value;
            DerailsOrder U = new DerailsOrder(id);
            U.Show();
        }
    }
}
