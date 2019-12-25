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

namespace Commodity.Order
{
    public partial class DerailsOrder : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object oid;
        private SqlDataReader reader;
        public DerailsOrder()
        {
            InitializeComponent();
        }

        private void DerailsOrder_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            string sql1 = "select * from [order] where ono=" + oid;
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
        public DerailsOrder(object id)
        {
            InitializeComponent();
            oid = id;
        }
    }
}
