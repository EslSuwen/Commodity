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

namespace Commodity.type
{
    public partial class AddType : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        public AddType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "insert into type(tname,tpicture) values (@tname,@tpicture)";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@tname", tname.Text));
                cmd.Parameters.Add(new SqlParameter("@tpicture", tpicture.Text));
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
