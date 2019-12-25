using System;
using System.Collections;
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
    public partial class AddOrder : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            ArrayList list1 = new ArrayList();
            SqlDataAdapter Da1 = new SqlDataAdapter("select cno from commodity ", conn);
            DataSet Ds1 = new DataSet();
            Da1.Fill(Ds1);
            DataTable dt1 = Ds1.Tables[0];
            foreach (DataRow dr in dt1.Rows)
            {
                list1.Add(dr[0].ToString().Trim());
            }
            cno.Text = "";
            cno.DataSource = list1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "insert into [order](ono,cno,khxm,khsj,khdz,yb,dgsj,dgsl,dj,dgzje) values (@ono,@cno,@khxm,@khsj,@khdz,@yb,@dgsj,@dgsl,@dj,@dgzje)";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ono", int.Parse(ono.Text)));
                cmd.Parameters.Add(new SqlParameter("@cno", int.Parse(cno.Text)));
                cmd.Parameters.Add(new SqlParameter("@khxm", khxm.Text));
                cmd.Parameters.Add(new SqlParameter("@khsj", khsj.Text));
                cmd.Parameters.Add(new SqlParameter("@khdz", khdz.Text));
                cmd.Parameters.Add(new SqlParameter("@yb", yb.Text));
                cmd.Parameters.Add(new SqlParameter("@dgsj", DateTime.Parse(dgsj.Text)));
                cmd.Parameters.Add(new SqlParameter("@dgsl", dgsl.Text));
                cmd.Parameters.Add(new SqlParameter("@dj", dj.Text));
                cmd.Parameters.Add(new SqlParameter("@dgzje", dgzje.Text));
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("信息录入成功");
                    shangping sp = new shangping();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "请检查数据合法性！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
