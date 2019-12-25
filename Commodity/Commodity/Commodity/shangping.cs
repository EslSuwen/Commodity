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

namespace Commodity
{
    public partial class shangping : Form
    {

        public static string connectionString = "server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI";
        public shangping()
        {
            InitializeComponent();
        }

        private void shangping_Load(object sender, EventArgs e)
        {

            DataGridViewDataLoad();
        }
        public void DataGridViewDataLoad()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter s = new SqlDataAdapter("select * from commodity", conn);
            DataSet d = new DataSet();
            s.Fill(d, "t");
            dataGridView1.DataSource = d.Tables["t"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCommodity a = new AddCommodity();
            a.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object id;
            int a = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[a].Cells[0].Value;
            Commodity.DetailsCommodity d = new Commodity.DetailsCommodity(id);
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除该商品信息？", "删除", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                object id;
                int a = dataGridView1.CurrentRow.Index;
                id=dataGridView1.Rows[a].Cells[0].Value;
                Console.WriteLine(id);
                string sql2 = "delete from commodity where cno=" + id;
                cmd = new SqlCommand(sql2, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
            }
            DataGridViewDataLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewDataLoad();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object id;
            int a = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[a].Cells[0].Value;
            UpdateCommodity U = new UpdateCommodity(id);
            U.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String type = comboBox1.Text.Trim();
            if (type == "按商品名查询")
            { 
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from commodity where cname like'%{0}%'", text);
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
                String sql = string.Format("select * from commodity where cno like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
            else if (type == "按类型查询")
            {
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from commodity where tname like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
            else if (type == "按品牌查询")
            {
                String text = textBox1.Text.Trim();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sql = string.Format("select * from commodity where bname like'%{0}%'", text);
                SqlDataAdapter s = new SqlDataAdapter(sql, conn);
                DataSet d = new DataSet();
                s.Fill(d, "t");
                dataGridView1.DataSource = d.Tables["t"];
            }
            else
                DataGridViewDataLoad();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }
    }
}
