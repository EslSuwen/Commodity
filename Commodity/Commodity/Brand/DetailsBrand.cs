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
    public partial class DetailsBrand : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object name;
        private SqlDataReader reader;
        public DetailsBrand()
        {
            InitializeComponent();
        }

        private void DetailsBrand_Load(object sender, EventArgs e)
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
        public DetailsBrand(object n)
        {
            InitializeComponent();
            name = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
