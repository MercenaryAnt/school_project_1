namespace school_project_1
{
    partial class Musteri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_adres = new System.Windows.Forms.TextBox();
            this.tx_telefon = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dgv_musteriler = new System.Windows.Forms.DataGridView();
            this.cms_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bilgileriYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriler)).BeginInit();
            this.cms_sagtik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TC Kimlik No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_adres);
            this.groupBox1.Controls.Add(this.tx_telefon);
            this.groupBox1.Controls.Add(this.tx_email);
            this.groupBox1.Controls.Add(this.tx_tcNo);
            this.groupBox1.Controls.Add(this.tx_soyad);
            this.groupBox1.Controls.Add(this.tx_ad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Tanımlama";
            // 
            // tx_adres
            // 
            this.tx_adres.Location = new System.Drawing.Point(465, 96);
            this.tx_adres.Name = "tx_adres";
            this.tx_adres.Size = new System.Drawing.Size(100, 20);
            this.tx_adres.TabIndex = 6;
            // 
            // tx_telefon
            // 
            this.tx_telefon.Location = new System.Drawing.Point(465, 64);
            this.tx_telefon.MaxLength = 11;
            this.tx_telefon.Name = "tx_telefon";
            this.tx_telefon.Size = new System.Drawing.Size(100, 20);
            this.tx_telefon.TabIndex = 5;
            this.tx_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_telefon_KeyPress);
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(465, 35);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(100, 20);
            this.tx_email.TabIndex = 4;
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.Location = new System.Drawing.Point(117, 97);
            this.tx_tcNo.MaxLength = 11;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(100, 20);
            this.tx_tcNo.TabIndex = 3;
            this.tx_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_tcNo_KeyPress);
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(117, 65);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(100, 20);
            this.tx_soyad.TabIndex = 2;
            this.tx_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyad_KeyPress);
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(117, 36);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(100, 20);
            this.tx_ad.TabIndex = 1;
            this.tx_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ad_KeyPress);
            // 
            // btn_kapat
            // 
            this.btn_kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kapat.Location = new System.Drawing.Point(555, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(86, 55);
            this.btn_kapat.TabIndex = 11;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Location = new System.Drawing.Point(423, 12);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(96, 55);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(310, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 55);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(150, 12);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(101, 55);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 55);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Ekle\r\n";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dgv_musteriler
            // 
            this.dgv_musteriler.AllowUserToAddRows = false;
            this.dgv_musteriler.AllowUserToDeleteRows = false;
            this.dgv_musteriler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musteriler.ContextMenuStrip = this.cms_sagtik;
            this.dgv_musteriler.Location = new System.Drawing.Point(12, 260);
            this.dgv_musteriler.MultiSelect = false;
            this.dgv_musteriler.Name = "dgv_musteriler";
            this.dgv_musteriler.ReadOnly = true;
            this.dgv_musteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_musteriler.Size = new System.Drawing.Size(629, 150);
            this.dgv_musteriler.TabIndex = 65;
            this.dgv_musteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_musteriler_CellDoubleClick);
            // 
            // cms_sagtik
            // 
            this.cms_sagtik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgileriYükleToolStripMenuItem,
            this.seçiliSatırıGüncelleToolStripMenuItem,
            this.seçiliSatırıSilToolStripMenuItem,
            this.formuTemizleToolStripMenuItem});
            this.cms_sagtik.Name = "cms_sagtik";
            this.cms_sagtik.Size = new System.Drawing.Size(218, 114);
            // 
            // bilgileriYükleToolStripMenuItem
            // 
            this.bilgileriYükleToolStripMenuItem.Name = "bilgileriYükleToolStripMenuItem";
            this.bilgileriYükleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.bilgileriYükleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.bilgileriYükleToolStripMenuItem.Text = "Bilgileri Yükle";
            this.bilgileriYükleToolStripMenuItem.Click += new System.EventHandler(this.bilgileriYükleToolStripMenuItem_Click);
            // 
            // seçiliSatırıGüncelleToolStripMenuItem
            // 
            this.seçiliSatırıGüncelleToolStripMenuItem.Name = "seçiliSatırıGüncelleToolStripMenuItem";
            this.seçiliSatırıGüncelleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.seçiliSatırıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.seçiliSatırıGüncelleToolStripMenuItem.Text = "Seçili Satırı Güncelle";
            this.seçiliSatırıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // seçiliSatırıSilToolStripMenuItem
            // 
            this.seçiliSatırıSilToolStripMenuItem.Name = "seçiliSatırıSilToolStripMenuItem";
            this.seçiliSatırıSilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.seçiliSatırıSilToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.seçiliSatırıSilToolStripMenuItem.Text = "Seçili Satırı Sil";
            this.seçiliSatırıSilToolStripMenuItem.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // formuTemizleToolStripMenuItem
            // 
            this.formuTemizleToolStripMenuItem.Name = "formuTemizleToolStripMenuItem";
            this.formuTemizleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.formuTemizleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.formuTemizleToolStripMenuItem.Text = "Formu Temizle";
            this.formuTemizleToolStripMenuItem.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Musteri
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(668, 438);
            this.Controls.Add(this.dgv_musteriler);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri";
            this.Text = "Müşteri Tanımlama";
            this.Load += new System.EventHandler(this.Musteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriler)).EndInit();
            this.cms_sagtik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_adres;
        private System.Windows.Forms.TextBox tx_telefon;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dgv_musteriler;
        private System.Windows.Forms.ContextMenuStrip cms_sagtik;
        private System.Windows.Forms.ToolStripMenuItem bilgileriYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuTemizleToolStripMenuItem;
    }
}