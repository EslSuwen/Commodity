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
    public partial class AddCommodity : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        public AddCommodity()
        {
            InitializeComponent();

        }

        private void AddCommodity_Load(object sender, EventArgs e)
        {
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
            comboBox1.Text = "";
            comboBox2.Text = "" ;
            comboBox1.DataSource = list1;
            comboBox2.DataSource = list2;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            String sql = "insert into commodity(cno,bname,tname,cname,gg,xh,jldw,scj,xsj,cbj,slt,js,kc) values (@cno,@bname,@tname,@cname,@gg,@xh,@jldw,@scj,@xsj,@cbj,@slt,@js,@kc)";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@cno", int.Parse(cno.Text)));
                cmd.Parameters.Add(new SqlParameter("@bname", comboBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@tname", comboBox2.Text));
                cmd.Parameters.Add(new SqlParameter("@cname", cname.Text));
                cmd.Parameters.Add(new SqlParameter("@gg", gg.Text));
                cmd.Parameters.Add(new SqlParameter("@xh", xh.Text));
                cmd.Parameters.Add(new SqlParameter("@jldw", jldw.Text));
                cmd.Parameters.Add(new SqlParameter("@scj", scj.Text));
                cmd.Parameters.Add(new SqlParameter("@xsj", xsj.Text));
                cmd.Parameters.Add(new SqlParameter("@cbj", cbj.Text));
                cmd.Parameters.Add(new SqlParameter("@slt", slt.Text));
                cmd.Parameters.Add(new SqlParameter("@js", js.Text));
                cmd.Parameters.Add(new SqlParameter("@kc", kc.Text));
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
                MessageBox.Show(ex.Message.ToString()+"请检查数据合法性！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
