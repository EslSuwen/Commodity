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
    public partial class DetailsType : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object name;
        private SqlDataReader reader;
        public DetailsType()
        {
            InitializeComponent();
        }

        private void DetailsType_Load(object sender, EventArgs e)
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

        public DetailsType(object n)
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
