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
    public partial class DetailsSupplier : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-D8HOK3N;database=spgl;integrated security = SSPI");
        SqlCommand cmd;
        private object name;
        private SqlDataReader reader;
        public DetailsSupplier()
        {
            InitializeComponent();
        }

        private void DetailsSupplier_Load(object sender, EventArgs e)
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
        public DetailsSupplier(object n)
        {
            InitializeComponent();
            name = n;
        }
    }
}
