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
    public partial class CookTypeProcess : Form
    {
        public CookTypeProcess()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        int ID = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                ep.SetError(textBox1, "Boş Geçilemez");
                return;
            }
            Entity.CookType c = new Entity.CookType();
            c.Name = textBox1.Text;
            new Core.CookTypeRepository().Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Core.CookTypeRepository().GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int ID = Convert.ToInt32(drow.Cells[0].Value);
                dataGridView1.DataSource = new Core.CookTypeRepository().Delete(ID);
            }

            dataGridView1.DataSource = new Core.CookTypeRepository().GetAll().ToList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            Getir();

        }
        private void Getir()
        {
            if (ID > 0)
            {
                CookType c = new CookTypeRepository().Get(ID);
                textBox1.Text = c.Name;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CookType CookType = new CookType();
            CookType.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            CookType.Name = textBox1.Text;
            dataGridView1.DataSource = new CookTypeRepository().Update(CookType);
            dataGridView1.DataSource = new CookTypeRepository().GetAll().ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CookTypeProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
