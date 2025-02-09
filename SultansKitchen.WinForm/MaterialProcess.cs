using SultansKitchen.Core;
using SultansKitchen.Entity;
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
    public partial class MaterialProcess : Form
    {
        public MaterialProcess()
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
            Entity.Material c = new Entity.Material();
            c.Name = txtName.Text;
            new Core.MaterialRepository().Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new MaterialRepository().GetAll().ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                dataGridView1.DataSource = new Core.MaterialRepository().Delete(ID);
            }

            dataGridView1.DataSource = new Core.MaterialRepository().GetAll().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Material Material = new Material();
            Material.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            Material.Name = txtName.Text;
            dataGridView1.DataSource = new MaterialRepository().Update(Material);
            dataGridView1.DataSource = new MaterialRepository().GetAll().ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Getir()
        {
            if (ID > 0)
            {
                Material c = new MaterialRepository().Get(ID);
                txtName.Text = c.Name;
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            Name = (dataGridView1.CurrentRow.Cells["ColumnName"].Value).ToString();
            Getir();

        }

        private void MaterialProcess_Load(object sender, EventArgs e)
        {

        }
    }
}

