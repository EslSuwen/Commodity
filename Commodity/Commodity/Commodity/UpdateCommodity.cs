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
namespace Commodity
{
    public partial class UpdateCommodity : Form
    {
        SqlConnection conn=new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object cid;
        private SqlDataReader reader;


        private void UpdateCommodity_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            string sql1 = "select * from commodity where cno=" + cid;
            ArrayList list1 = new ArrayList();
            ArrayList list2 = new ArrayList();
            SqlDataAdapter Da1 = new SqlDataAdapter("select bname from brand ", conn);
            DataSet Ds1 = new DataSet();
            DataSet Ds2 = new DataSet();
            SqlDataAdapter Da2 = new SqlDataAdapter("select tname from type ", conn);
            Da1.Fill(Ds1);
            Da2.Fill(Ds2);
            DataTable dt1 = Ds1.Tables[0];
            DataTable dt2 = Ds2.Tables[0];
            foreach (DataRow dr in dt1.Rows)
            {
                list1.Add(dr[0].ToString().Trim());
            }
            foreach (DataRow dr in dt2.Rows)
            {
                list2.Add(dr[0].ToString().Trim());
            }
            bname.DataSource = list1;
            tname.DataSource = list2;
            cmd.CommandText = sql1;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                cno.Text = cid.ToString();
                bname.Text = reader.GetString(1);
                tname.Text = reader.GetString(2);
                cname.Text = reader.GetString(3);
                gg.Text = reader.GetString(4);
                xh.Text = reader.GetString(5);
                jldw.Text = reader.GetString(6);
                scj.Text = reader.GetValue(7).ToString();
                xsj.Text = reader.GetValue(8).ToString();
                cbj.Text = reader.GetValue(9).ToString();
                slt.Text = reader.GetString(10);
                js.Text = reader.GetString(11);
                kc.Text = reader.GetInt32(12).ToString();
            }

            reader.Close();
        }
        public UpdateCommodity(object id)
        {
            InitializeComponent();
            cid= id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String c_no = cno.Text.Trim();
            String b_name = bname.Text.Trim();
            String t_name = tname.Text.Trim();
            String c_name = cname.Text.Trim();
            String c_js = js.Text.Trim();
            String c_slt = slt.Text.Trim();
            String c_gg = gg.Text.Trim();
            String c_xh = xh.Text.Trim();
            String c_jldw = jldw.Text.Trim();
            String c_scj = scj.Text.Trim();
            String c_xsj = xsj.Text.Trim();
            String c_cbj = cbj.Text.Trim();
            String c_kc = kc.Text.Trim();
            String sql = string.Format("update commodity set bname='{0}',tname='{1}',cname='{2}',gg='{3}',xh='{4}',jldw='{5}',scj='{6}',xsj='{7}',cbj='{8}',slt='{9}',js='{10}',kc='{11}' where cno='{12}'", b_name, t_name, c_name, c_gg, c_xh, c_jldw, c_scj, c_xsj, c_cbj, c_slt, c_js, c_kc, c_no);
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
