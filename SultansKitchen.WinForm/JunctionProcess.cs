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
    public partial class JunctionProcess : Form
    {
        public JunctionProcess()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Entity.FoodMaterialJunction food = new Entity.FoodMaterialJunction();
            new Core.FoodMaterialjunctionRepository().Add(food);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Core.FoodMaterialjunctionRepository().GetAll().ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                dataGridView1.DataSource = new Core.FoodMaterialjunctionRepository().Delete(ID);
            }

            dataGridView1.DataSource = new Core.FoodMaterialjunctionRepository().GetAll().ToList();
        }
    }
}
