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
    public partial class UpdateOrder : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object oid;
        private SqlDataReader reader;
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            string sql1 = "select * from [order] where ono=" + oid;
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
            cmd.CommandText = sql1;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ono.Text = oid.ToString();
                cno.Text = reader.GetInt32(1).ToString();
                khxm.Text = reader.GetString(2);
                khsj.Text = reader.GetString(3);
                khdz.Text = reader.GetString(4);
                yb.Text = reader.GetString(5);
                dgsj.Text = reader.GetDateTime(6).ToString();
                dgsl.Text = reader.GetInt32(7).ToString();
                dj.Text = reader.GetValue(8).ToString();
                dgzje.Text = reader.GetValue(9).ToString();
            }

            reader.Close();
        }
        public UpdateOrder(object id)
        {
            InitializeComponent();
            oid = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String c_no = cno.Text.Trim();
            String o_ono = ono.Text.Trim();
            String o_khxm = khxm.Text.Trim();
            String o_khsj = khsj.Text.Trim();
            String o_khdz = khdz.Text.Trim();
            String o_yb = yb.Text.Trim();
            String o_dgsj = dgsj.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String o_dgsl = dgsl.Text.Trim();
            String o_dj = dj.Text.Trim();
            String o_dgzje = dgzje.Text.Trim();
           
            String sql = string.Format("update [order] set ono='{0}',cno='{1}',khxm='{2}',khsj='{3}',khdz='{4}',yb='{5}',dgsj='{6}',dgsl='{7}',dj='{8}',dgzje='{9}' where ono='{10}'", o_ono , c_no, o_khxm, o_khsj,o_khdz, o_yb, o_dgsj, o_dgsl, o_dj, o_dgzje,oid);
            try
            {
                cmd = new SqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("信息修改成功");
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
