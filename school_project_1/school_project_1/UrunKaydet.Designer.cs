namespace school_project_1
{
    partial class UrunKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKaydet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tx_urunKodu = new System.Windows.Forms.TextBox();
            this.tx_barkod = new System.Windows.Forms.TextBox();
            this.tx_miktar = new System.Windows.Forms.TextBox();
            this.tx_fiyat = new System.Windows.Forms.TextBox();
            this.cbx_urunTur = new System.Windows.Forms.ComboBox();
            this.cbx_urunSinifi = new System.Windows.Forms.ComboBox();
            this.btn_bilgi = new System.Windows.Forms.Button();
            this.cbx_birim = new System.Windows.Forms.ComboBox();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.cms_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bilgileriYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_urunTurEkle = new System.Windows.Forms.Button();
            this.btn_urunSinifiEkle = new System.Windows.Forms.Button();
            this.btn_birimEkle = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            this.cms_sagtik.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barkod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün Türü:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Birim:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ürün Sınıfı:";
            // 
            // tx_urunKodu
            // 
            this.tx_urunKodu.Location = new System.Drawing.Point(104, 30);
            this.tx_urunKodu.MaxLength = 10;
            this.tx_urunKodu.Name = "tx_urunKodu";
            this.tx_urunKodu.Size = new System.Drawing.Size(100, 20);
            this.tx_urunKodu.TabIndex = 1;
            this.tx_urunKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_urunKodu_KeyPress);
            // 
            // tx_barkod
            // 
            this.tx_barkod.Location = new System.Drawing.Point(104, 62);
            this.tx_barkod.MaxLength = 13;
            this.tx_barkod.Name = "tx_barkod";
            this.tx_barkod.Size = new System.Drawing.Size(100, 20);
            this.tx_barkod.TabIndex = 2;
            this.tx_barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_barkod_KeyPress);
            // 
            // tx_miktar
            // 
            this.tx_miktar.Location = new System.Drawing.Point(104, 97);
            this.tx_miktar.MaxLength = 10;
            this.tx_miktar.Name = "tx_miktar";
            this.tx_miktar.Size = new System.Drawing.Size(100, 20);
            this.tx_miktar.TabIndex = 3;
            this.tx_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_miktar_KeyPress);
            // 
            // tx_fiyat
            // 
            this.tx_fiyat.Location = new System.Drawing.Point(104, 123);
            this.tx_fiyat.MaxLength = 10;
            this.tx_fiyat.Name = "tx_fiyat";
            this.tx_fiyat.Size = new System.Drawing.Size(100, 20);
            this.tx_fiyat.TabIndex = 4;
            this.tx_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_fiyat_KeyPress);
            // 
            // cbx_urunTur
            // 
            this.cbx_urunTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_urunTur.FormattingEnabled = true;
            this.cbx_urunTur.Location = new System.Drawing.Point(586, 45);
            this.cbx_urunTur.Name = "cbx_urunTur";
            this.cbx_urunTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_urunTur.TabIndex = 5;
            // 
            // cbx_urunSinifi
            // 
            this.cbx_urunSinifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_urunSinifi.FormattingEnabled = true;
            this.cbx_urunSinifi.Location = new System.Drawing.Point(586, 75);
            this.cbx_urunSinifi.Name = "cbx_urunSinifi";
            this.cbx_urunSinifi.Size = new System.Drawing.Size(121, 21);
            this.cbx_urunSinifi.TabIndex = 7;
            // 
            // btn_bilgi
            // 
            this.btn_bilgi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bilgi.BackgroundImage")));
            this.btn_bilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_bilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bilgi.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_bilgi.Location = new System.Drawing.Point(210, 97);
            this.btn_bilgi.Name = "btn_bilgi";
            this.btn_bilgi.Size = new System.Drawing.Size(20, 20);
            this.btn_bilgi.TabIndex = 24;
            this.btn_bilgi.UseVisualStyleBackColor = true;
            this.btn_bilgi.Click += new System.EventHandler(this.btn_bilgi_Click);
            // 
            // cbx_birim
            // 
            this.cbx_birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_birim.FormattingEnabled = true;
            this.cbx_birim.Location = new System.Drawing.Point(586, 110);
            this.cbx_birim.Name = "cbx_birim";
            this.cbx_birim.Size = new System.Drawing.Size(121, 21);
            this.cbx_birim.TabIndex = 9;
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.AllowUserToAddRows = false;
            this.dgv_urunler.AllowUserToDeleteRows = false;
            this.dgv_urunler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.ContextMenuStrip = this.cms_sagtik;
            this.dgv_urunler.Location = new System.Drawing.Point(12, 292);
            this.dgv_urunler.MultiSelect = false;
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.ReadOnly = true;
            this.dgv_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_urunler.Size = new System.Drawing.Size(812, 196);
            this.dgv_urunler.TabIndex = 26;
            this.dgv_urunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_urunler_CellDoubleClick);
            // 
            // cms_sagtik
            // 
            this.cms_sagtik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgileriYükleToolStripMenuItem,
            this.seçiliSatırıGüncelleToolStripMenuItem,
            this.seçiliSatırıSilToolStripMenuItem,
            this.formuTemizleToolStripMenuItem});
            this.cms_sagtik.Name = "cms_sagtik";
            this.cms_sagtik.Size = new System.Drawing.Size(218, 92);
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
            // btn_urunTurEkle
            // 
            this.btn_urunTurEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_urunTurEkle.BackgroundImage")));
            this.btn_urunTurEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_urunTurEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urunTurEkle.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_urunTurEkle.Location = new System.Drawing.Point(713, 45);
            this.btn_urunTurEkle.Name = "btn_urunTurEkle";
            this.btn_urunTurEkle.Size = new System.Drawing.Size(20, 20);
            this.btn_urunTurEkle.TabIndex = 6;
            this.btn_urunTurEkle.UseVisualStyleBackColor = true;
            this.btn_urunTurEkle.Click += new System.EventHandler(this.btn_urunTurEkle_Click);
            // 
            // btn_urunSinifiEkle
            // 
            this.btn_urunSinifiEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_urunSinifiEkle.BackgroundImage")));
            this.btn_urunSinifiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_urunSinifiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urunSinifiEkle.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_urunSinifiEkle.Location = new System.Drawing.Point(713, 75);
            this.btn_urunSinifiEkle.Name = "btn_urunSinifiEkle";
            this.btn_urunSinifiEkle.Size = new System.Drawing.Size(20, 20);
            this.btn_urunSinifiEkle.TabIndex = 8;
            this.btn_urunSinifiEkle.UseVisualStyleBackColor = true;
            this.btn_urunSinifiEkle.Click += new System.EventHandler(this.btn_urunSinifiEkle_Click);
            // 
            // btn_birimEkle
            // 
            this.btn_birimEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_birimEkle.BackgroundImage")));
            this.btn_birimEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_birimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_birimEkle.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_birimEkle.Location = new System.Drawing.Point(713, 111);
            this.btn_birimEkle.Name = "btn_birimEkle";
            this.btn_birimEkle.Size = new System.Drawing.Size(20, 20);
            this.btn_birimEkle.TabIndex = 10;
            this.btn_birimEkle.UseVisualStyleBackColor = true;
            this.btn_birimEkle.Click += new System.EventHandler(this.btn_birimEkle_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kapat.Location = new System.Drawing.Point(738, 24);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(86, 55);
            this.btn_kapat.TabIndex = 16;
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
            this.btn_temizle.Location = new System.Drawing.Point(459, 24);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(96, 55);
            this.btn_temizle.TabIndex = 14;
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
            this.btn_sil.Location = new System.Drawing.Point(321, 24);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 55);
            this.btn_sil.TabIndex = 13;
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
            this.btn_guncelle.Location = new System.Drawing.Point(163, 24);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(101, 55);
            this.btn_guncelle.TabIndex = 12;
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
            this.btn_ekle.Location = new System.Drawing.Point(18, 24);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 55);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle\r\n";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tx_miktar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_birimEkle);
            this.groupBox2.Controls.Add(this.tx_urunKodu);
            this.groupBox2.Controls.Add(this.btn_urunSinifiEkle);
            this.groupBox2.Controls.Add(this.tx_barkod);
            this.groupBox2.Controls.Add(this.tx_fiyat);
            this.groupBox2.Controls.Add(this.btn_urunTurEkle);
            this.groupBox2.Controls.Add(this.btn_bilgi);
            this.groupBox2.Controls.Add(this.cbx_birim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbx_urunSinifi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbx_urunTur);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 162);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Kayıt";
            // 
            // btn_yenile
            // 
            this.btn_yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yenile.Image = ((System.Drawing.Image)(resources.GetObject("btn_yenile.Image")));
            this.btn_yenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yenile.Location = new System.Drawing.Point(598, 24);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(89, 55);
            this.btn_yenile.TabIndex = 15;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // UrunKaydet
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(849, 503);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dgv_urunler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrunKaydet";
            this.Text = "Ürün Kaydet";
            this.Load += new System.EventHandler(this.UrunKaydet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            this.cms_sagtik.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tx_urunKodu;
        private System.Windows.Forms.TextBox tx_barkod;
        private System.Windows.Forms.TextBox tx_miktar;
        private System.Windows.Forms.TextBox tx_fiyat;
        private System.Windows.Forms.ComboBox cbx_urunTur;
        private System.Windows.Forms.ComboBox cbx_urunSinifi;
        private System.Windows.Forms.Button btn_bilgi;
        private System.Windows.Forms.ComboBox cbx_birim;
        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Button btn_urunTurEkle;
        private System.Windows.Forms.Button btn_urunSinifiEkle;
        private System.Windows.Forms.Button btn_birimEkle;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.ContextMenuStrip cms_sagtik;
        private System.Windows.Forms.ToolStripMenuItem bilgileriYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuTemizleToolStripMenuItem;
    }
}