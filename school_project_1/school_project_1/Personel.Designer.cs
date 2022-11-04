namespace school_project_1
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_gorevEkle = new System.Windows.Forms.Button();
            this.btn_subeEkle = new System.Windows.Forms.Button();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.cbx_gorev = new System.Windows.Forms.ComboBox();
            this.cbx_sube = new System.Windows.Forms.ComboBox();
            this.tx_adres = new System.Windows.Forms.TextBox();
            this.tx_telefon = new System.Windows.Forms.TextBox();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.dgv_personel = new System.Windows.Forms.DataGridView();
            this.cms_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bilgileriYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).BeginInit();
            this.cms_sagtik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Çalıştığı Şube:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Görev:";
            // 
            // btn_kapat
            // 
            this.btn_kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kapat.Location = new System.Drawing.Point(792, 21);
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
            this.btn_temizle.Location = new System.Drawing.Point(463, 21);
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
            this.btn_sil.Location = new System.Drawing.Point(329, 21);
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
            this.btn_guncelle.Location = new System.Drawing.Point(168, 21);
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
            this.btn_ekle.Location = new System.Drawing.Point(12, 21);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 55);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle\r\n";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_gorevEkle);
            this.groupBox1.Controls.Add(this.btn_subeEkle);
            this.groupBox1.Controls.Add(this.tx_email);
            this.groupBox1.Controls.Add(this.cbx_gorev);
            this.groupBox1.Controls.Add(this.cbx_sube);
            this.groupBox1.Controls.Add(this.tx_adres);
            this.groupBox1.Controls.Add(this.tx_telefon);
            this.groupBox1.Controls.Add(this.tx_tcNo);
            this.groupBox1.Controls.Add(this.tx_soyad);
            this.groupBox1.Controls.Add(this.tx_ad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 158);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Tanımla";
            // 
            // btn_gorevEkle
            // 
            this.btn_gorevEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gorevEkle.BackgroundImage")));
            this.btn_gorevEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gorevEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gorevEkle.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_gorevEkle.Location = new System.Drawing.Point(721, 121);
            this.btn_gorevEkle.Name = "btn_gorevEkle";
            this.btn_gorevEkle.Size = new System.Drawing.Size(20, 20);
            this.btn_gorevEkle.TabIndex = 10;
            this.btn_gorevEkle.UseVisualStyleBackColor = true;
            this.btn_gorevEkle.Click += new System.EventHandler(this.btn_gorevEkle_Click);
            // 
            // btn_subeEkle
            // 
            this.btn_subeEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_subeEkle.BackgroundImage")));
            this.btn_subeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_subeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subeEkle.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_subeEkle.Location = new System.Drawing.Point(721, 92);
            this.btn_subeEkle.Name = "btn_subeEkle";
            this.btn_subeEkle.Size = new System.Drawing.Size(20, 20);
            this.btn_subeEkle.TabIndex = 8;
            this.btn_subeEkle.UseVisualStyleBackColor = true;
            this.btn_subeEkle.Click += new System.EventHandler(this.btn_subeEkle_Click);
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(615, 60);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(100, 20);
            this.tx_email.TabIndex = 6;
            // 
            // cbx_gorev
            // 
            this.cbx_gorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_gorev.FormattingEnabled = true;
            this.cbx_gorev.Location = new System.Drawing.Point(615, 121);
            this.cbx_gorev.Name = "cbx_gorev";
            this.cbx_gorev.Size = new System.Drawing.Size(100, 21);
            this.cbx_gorev.TabIndex = 9;
            // 
            // cbx_sube
            // 
            this.cbx_sube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sube.FormattingEnabled = true;
            this.cbx_sube.Location = new System.Drawing.Point(614, 92);
            this.cbx_sube.Name = "cbx_sube";
            this.cbx_sube.Size = new System.Drawing.Size(101, 21);
            this.cbx_sube.TabIndex = 7;
            // 
            // tx_adres
            // 
            this.tx_adres.Location = new System.Drawing.Point(614, 31);
            this.tx_adres.Name = "tx_adres";
            this.tx_adres.Size = new System.Drawing.Size(100, 20);
            this.tx_adres.TabIndex = 5;
            // 
            // tx_telefon
            // 
            this.tx_telefon.Location = new System.Drawing.Point(133, 118);
            this.tx_telefon.MaxLength = 11;
            this.tx_telefon.Name = "tx_telefon";
            this.tx_telefon.Size = new System.Drawing.Size(100, 20);
            this.tx_telefon.TabIndex = 4;
            this.tx_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_telefon_KeyPress);
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.Location = new System.Drawing.Point(133, 89);
            this.tx_tcNo.MaxLength = 11;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(100, 20);
            this.tx_tcNo.TabIndex = 3;
            this.tx_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_tcNo_KeyPress);
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(133, 60);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(100, 20);
            this.tx_soyad.TabIndex = 2;
            this.tx_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyad_KeyPress);
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(133, 31);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(100, 20);
            this.tx_ad.TabIndex = 1;
            this.tx_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ad_KeyPress);
            // 
            // dgv_personel
            // 
            this.dgv_personel.AllowUserToAddRows = false;
            this.dgv_personel.AllowUserToDeleteRows = false;
            this.dgv_personel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personel.ContextMenuStrip = this.cms_sagtik;
            this.dgv_personel.Location = new System.Drawing.Point(12, 278);
            this.dgv_personel.MultiSelect = false;
            this.dgv_personel.Name = "dgv_personel";
            this.dgv_personel.ReadOnly = true;
            this.dgv_personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personel.Size = new System.Drawing.Size(866, 196);
            this.dgv_personel.TabIndex = 57;
            this.dgv_personel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personel_CellDoubleClick);
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
            // btn_yenile
            // 
            this.btn_yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yenile.Image = ((System.Drawing.Image)(resources.GetObject("btn_yenile.Image")));
            this.btn_yenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yenile.Location = new System.Drawing.Point(626, 21);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(89, 55);
            this.btn_yenile.TabIndex = 15;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // Personel
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(890, 492);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.dgv_personel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personel";
            this.Text = "Personel Tanımlama";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.ComboBox cbx_gorev;
        private System.Windows.Forms.ComboBox cbx_sube;
        private System.Windows.Forms.TextBox tx_adres;
        private System.Windows.Forms.TextBox tx_telefon;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.Button btn_gorevEkle;
        private System.Windows.Forms.Button btn_subeEkle;
        private System.Windows.Forms.DataGridView dgv_personel;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.ContextMenuStrip cms_sagtik;
        private System.Windows.Forms.ToolStripMenuItem bilgileriYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuTemizleToolStripMenuItem;
    }
}