using SultansKitchen.Core;
using SultansKitchen.Entity;
using SultansKitchen.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace SultansKitchen.WinForm
{
    public partial class CategoryProcess : Form
    {
        public CategoryProcess()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        public int ID = 0;
        public byte[] images;
        int ResimDegisti = 0;

        private void CategoryProcess_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Getir();
        }
        Image ByteToImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resin Seç";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Jpeg Dosyası |*.jpg|Png Dosyası|*.png|Gif Dosyası |*.gif,";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                ResimDegisti = 1;
            }

        }
        byte[] ImageToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtName.Text == "")
            {
                ep.SetError(txtName, "Boş Geçilemez");
                return;
            }
            Category c = new Category();
            c.Name = txtName.Text;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            c.Image = Helper.Tools.ImageToByte(bmp);
            new CategoryRepository().Add(c);
            Clear();

        }
 
        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = new CategoryRepository().GetAll().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            dataGridView1.DataSource = new CategoryRepository().Delete(ID);
            dataGridView1.DataSource = new CategoryRepository().GetAll().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] GuncelResim = images;



            Category Category = new Category();
            Category.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            Category.Name = txtName.Text;

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Category.Image = Helper.Tools.ImageToByte(bmp);

            dataGridView1.DataSource = new CategoryRepository().Update(Category);
            Clear();



            dataGridView1.DataSource = new CategoryRepository().GetAll().ToList();
            ResimDegisti = 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ColumnID"].Value);
            images = (byte[])(dataGridView1.CurrentRow.Cells["ColumnImage"].Value);
            Getir();

        }

        private void Getir()
        {
            if (ID > 0)
            {
                Category c = new CategoryRepository().Get(ID);
                txtName.Text = c.Name;
                images = c.Image;
                pictureBox1.Image = (ByteToImage(c.Image));
            }
        }

        private void Clear()
        {
            txtName.Clear();
            pictureBox1.Image = null;

        }

    }
}
