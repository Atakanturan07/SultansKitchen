namespace SultansKitchen.WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pişirmeŞekliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birleştiriciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbCookType = new System.Windows.Forms.ComboBox();
            this.cbCookTime = new System.Windows.Forms.ComboBox();
            this.cbCapacity = new System.Windows.Forms.ComboBox();
            this.txtCalory = new System.Windows.Forms.TextBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünİşlemleriToolStripMenuItem,
            this.malzemeİşlemleriToolStripMenuItem,
            this.kategoriİşlemleriToolStripMenuItem,
            this.pişirmeŞekliToolStripMenuItem,
            this.birimlerToolStripMenuItem,
            this.birleştiriciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            this.ürünİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ürünİşlemleriToolStripMenuItem_Click);
            // 
            // malzemeİşlemleriToolStripMenuItem
            // 
            this.malzemeİşlemleriToolStripMenuItem.Name = "malzemeİşlemleriToolStripMenuItem";
            this.malzemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.malzemeİşlemleriToolStripMenuItem.Text = "Malzeme İşlemleri";
            this.malzemeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.malzemeİşlemleriToolStripMenuItem_Click);
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            this.kategoriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kategoriİşlemleriToolStripMenuItem_Click);
            // 
            // pişirmeŞekliToolStripMenuItem
            // 
            this.pişirmeŞekliToolStripMenuItem.Name = "pişirmeŞekliToolStripMenuItem";
            this.pişirmeŞekliToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.pişirmeŞekliToolStripMenuItem.Text = "Pişirme Şekli";
            this.pişirmeŞekliToolStripMenuItem.Click += new System.EventHandler(this.pişirmeŞekliToolStripMenuItem_Click);
            // 
            // birimlerToolStripMenuItem
            // 
            this.birimlerToolStripMenuItem.Name = "birimlerToolStripMenuItem";
            this.birimlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.birimlerToolStripMenuItem.Text = "Birimler";
            this.birimlerToolStripMenuItem.Click += new System.EventHandler(this.birimlerToolStripMenuItem_Click);
            // 
            // birleştiriciToolStripMenuItem
            // 
            this.birleştiriciToolStripMenuItem.Name = "birleştiriciToolStripMenuItem";
            this.birleştiriciToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.birleştiriciToolStripMenuItem.Text = "Birleştirici";
            this.birleştiriciToolStripMenuItem.Click += new System.EventHandler(this.birleştiriciToolStripMenuItem_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 22);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(108, 83);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(171, 24);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resim:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(108, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 125);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Pişirme Şekli";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Pişirme Süresi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tanım";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kapasite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kalori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Level";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(480, 146);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(195, 22);
            this.txtDescription.TabIndex = 28;
            // 
            // cbCookType
            // 
            this.cbCookType.FormattingEnabled = true;
            this.cbCookType.Location = new System.Drawing.Point(480, 210);
            this.cbCookType.Margin = new System.Windows.Forms.Padding(4);
            this.cbCookType.Name = "cbCookType";
            this.cbCookType.Size = new System.Drawing.Size(195, 24);
            this.cbCookType.TabIndex = 27;
            // 
            // cbCookTime
            // 
            this.cbCookTime.FormattingEnabled = true;
            this.cbCookTime.Location = new System.Drawing.Point(480, 177);
            this.cbCookTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbCookTime.Name = "cbCookTime";
            this.cbCookTime.Size = new System.Drawing.Size(195, 24);
            this.cbCookTime.TabIndex = 26;
            // 
            // cbCapacity
            // 
            this.cbCapacity.FormattingEnabled = true;
            this.cbCapacity.Location = new System.Drawing.Point(480, 113);
            this.cbCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.cbCapacity.Name = "cbCapacity";
            this.cbCapacity.Size = new System.Drawing.Size(195, 24);
            this.cbCapacity.TabIndex = 25;
            // 
            // txtCalory
            // 
            this.txtCalory.Location = new System.Drawing.Point(480, 81);
            this.txtCalory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalory.Name = "txtCalory";
            this.txtCalory.Size = new System.Drawing.Size(195, 22);
            this.txtCalory.TabIndex = 24;
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cbLevel.Location = new System.Drawing.Point(480, 48);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(195, 24);
            this.cbLevel.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 257);
            this.dataGridView1.TabIndex = 35;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(270, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 54);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(418, 259);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(94, 54);
            this.btnlist.TabIndex = 37;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 597);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbCookType);
            this.Controls.Add(this.cbCookTime);
            this.Controls.Add(this.cbCapacity);
            this.Controls.Add(this.txtCalory);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pişirmeŞekliToolStripMenuItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbCookType;
        private System.Windows.Forms.ComboBox cbCookTime;
        private System.Windows.Forms.ComboBox cbCapacity;
        private System.Windows.Forms.TextBox txtCalory;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem birimlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birleştiriciToolStripMenuItem;
    }
}

