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
    public partial class login : Form
    {
        public static string connectionString = "server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI";
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //打开数据库的连接

                String sql = "select * from users where user_id = @user_id and user_psw = @user_psw ";
                //创建数据库的操作字符串

                SqlCommand cmd = new SqlCommand(sql, conn);
                //对指定的对象，操作字符串内容

                cmd.Parameters.Add(new SqlParameter("@user_id", textBox1.Text));
                //用参数代替占位符，线性更安全
                cmd.Parameters.Add(new SqlParameter("@user_psw", textBox2.Text));

                SqlDataReader reader = cmd.ExecuteReader();//操作

                if (reader.Read())
                {
                    //如果查询到内容，跳转到Information界面，同时关闭当前界面
                    shangping sp = new shangping();
                    sp.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("请输入正确信息！");
                    //textBox1.Text = "";
                    //textBox2.Text = "";
                    main m = new main();
                    m.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
