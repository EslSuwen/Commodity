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

namespace Commodity.Type
{

    public partial class UpdateType : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object name;
        private SqlDataReader reader;
        public UpdateType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String t_name = tname.Text.Trim();
            String t_picture = tpicture.Text.Trim();
            String sql = string.Format("update type set tname='{0}',tpicture='{1}' where tname='{2}'", t_name, t_picture, name);
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

        private void UpdateType_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            String sql = string.Format("select * from type where tname like'%{0}%'", name);
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tname.Text = reader.GetString(0);
                tpicture.Text = reader.GetString(1);
            }

            reader.Close();
        }
        public UpdateType(object n)
        {
            InitializeComponent();
            name = n;
        }
    }
}
