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

namespace Commodity.Brand
{
    
    public partial class UpdateBrand : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object name;
        private SqlDataReader reader;
        public UpdateBrand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String b_name = bname.Text.Trim();
            String b_website = bwebsite.Text.Trim();
            String b_picture = bpicture.Text.Trim();
            String sql = string.Format("update brand set bname='{0}',bwebsite='{1}',bpicture='{2}' where bname='{3}'", b_name, b_website,b_picture,name);
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
        public UpdateBrand(object n)
        {
            InitializeComponent();
            name = n;
        }

        private void UpdateBrand_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            String sql = string.Format("select * from brand where bname like'%{0}%'", name);
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                bname.Text = reader.GetString(0);
                bwebsite.Text = reader.GetString(1);
                bpicture.Text = reader.GetString(2);
            }

            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
