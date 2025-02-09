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
    public partial class UnitProcess : Form
    {
        public UnitProcess()
        {
            InitializeComponent();
        }
        int ID = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Unit unit = new Unit();
            unit.Name = txtName.Text;
            new UnitRepository().Add(unit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Core.UnitRepository().GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                dataGridView1.DataSource = new Core.UnitRepository().Delete(ID);
            }

            dataGridView1.DataSource = new Core.UnitRepository().GetAll().ToList();

        }

        private void Getir()
        {
            Unit u = new UnitRepository().Get(ID);
            txtName.Text = u.Name;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            Name = Convert.ToString(dataGridView1.CurrentRow.Cells["ColumnName"]);
            Getir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Unit Unit = new Unit();
            Unit.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            Unit.Name = txtName.Text;
            dataGridView1.DataSource = new UnitRepository().Update(Unit);
            dataGridView1.DataSource = new UnitRepository().GetAll().ToList();
        }
    }
}
