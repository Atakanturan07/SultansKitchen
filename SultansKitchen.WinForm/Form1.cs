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
using System.IO;


namespace SultansKitchen.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = new CategoryRepository().GetAll().ToList();
            cbCategory.ValueMember = "ID";
            cbCategory.DisplayMember = "Name";
            cbCookType.DataSource = new CookTypeRepository().GetAll().ToList();
            cbCookType.ValueMember = "ID";
            cbCookType.DisplayMember = "Name";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        byte[] ImageToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Food food = new Food();

            food.Name = txtName.Text;
            food.CategoryID = cbCategory.SelectedIndex;
            food.Image = ImageToByte(pictureBox1.Image);
            food.Level = cbLevel.SelectedIndex;
            food.Calory = Convert.ToDecimal(txtCalory.Text);
            food.Capacity = cbCapacity.SelectedIndex;
            food.Description = txtDescription.Text;
            food.CookTime = cbCookTime.SelectedIndex;
            food.CookTypeID = cbCookType.SelectedIndex;

            new FoodRepository().Add(food);
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new FoodRepository().GetAll().ToList();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyası |*.jpg|Png Dosyası |*.png|Gif Dosyası |*.gif";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void malzemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialProcess Material = new MaterialProcess();
            Material.ShowDialog();
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryProcess Category = new CategoryProcess();
            Category.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pişirmeŞekliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CookTypeProcess CookType = new CookTypeProcess();
            CookType.ShowDialog();
        }

        private void birimlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitProcess Unit = new UnitProcess();
                Unit.ShowDialog();
        }

        private void birleştiriciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JunctionProcess Junction = new JunctionProcess();
            Junction.ShowDialog();
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductProcess product = new ProductProcess();
            product.ShowDialog();
        }
    }
}
