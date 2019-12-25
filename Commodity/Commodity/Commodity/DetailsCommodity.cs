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

namespace Commodity.Commodity
{
    public partial class DetailsCommodity : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object cid;
        private SqlDataReader reader;
        public DetailsCommodity()
        {
            InitializeComponent();
        }

        private void DetailsCommodity_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            string sql1 = "select * from commodity where cno=" + cid;
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
        public DetailsCommodity(object id)
        {
            InitializeComponent();
            cid = id;
        }
    }
}
