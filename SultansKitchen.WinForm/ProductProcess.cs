using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SultansKitchen.WinForm
{
    public partial class ProductProcess : Form
    {
        public ProductProcess()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        int ID = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                ep.SetError(txtName, "Boş Geçilemez");
                return;
            }
            Entity.Product h = new Entity.Product();
            h.Name = txtName.Text;
            h.Price =Convert.ToDecimal(txtPrice.Text);
            new Core.ProductRepository().Add(h);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Core.ProductRepository().GetAll();

        }
    }
}
