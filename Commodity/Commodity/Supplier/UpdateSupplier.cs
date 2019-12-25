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
    public partial class UpdateSupplier : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object name;
        private SqlDataReader reader;

        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s_name = sname.Text.Trim();
            String s_contacts = contacts.Text.Trim();
            String s_phone = phone.Text.Trim();
            String s_synopsis = synopsis.Text.Trim();
            String sql = string.Format("update Supplier set sname='{0}',contacts='{1}',phone='{2}',synopsis='{3}' where sname='{4}'", s_name, s_contacts, s_phone,s_synopsis, name);
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

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            String sql = string.Format("select * from Supplier where sname like'%{0}%'", name);
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                sname.Text = reader.GetString(0);
                contacts.Text = reader.GetString(1);
                phone.Text = reader.GetString(2);
                synopsis.Text = reader.GetString(3);
            }

            reader.Close();
        }
        public UpdateSupplier(object n)
        {
            InitializeComponent();
            name = n;
        }
    }
}
