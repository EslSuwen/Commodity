
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commodity
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shangping s = new shangping();
            s.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Brand.brandshow b = new Brand.brandshow();
            b.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type.ShowType s = new type.ShowType();
            s.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Supplier.ShowSupplier s = new Supplier.ShowSupplier();
            s.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order.ShowOrder s = new Order.ShowOrder();
            s.Show();
            this.Close();
        }
    }
}
