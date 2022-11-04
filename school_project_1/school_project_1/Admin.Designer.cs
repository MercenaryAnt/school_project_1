namespace school_project_1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tx_eposta = new System.Windows.Forms.TextBox();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.cbx_yetki = new System.Windows.Forms.ComboBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_eposta
            // 
            this.tx_eposta.Location = new System.Drawing.Point(108, 127);
            this.tx_eposta.Name = "tx_eposta";
            this.tx_eposta.Size = new System.Drawing.Size(130, 20);
            this.tx_eposta.TabIndex = 5;
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Location = new System.Drawing.Point(46, 130);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(46, 13);
            this.lbl_eposta.TabIndex = 22;
            this.lbl_eposta.Text = "E-posta:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(52, 51);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(40, 13);
            this.lbl_soyad.TabIndex = 20;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(21, 77);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(71, 13);
            this.lbl_tc.TabIndex = 19;
            this.lbl_tc.Text = "TC Kimlik No:";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(69, 25);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(23, 13);
            this.lbl_ad.TabIndex = 18;
            this.lbl_ad.Text = "Ad:";
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.Location = new System.Drawing.Point(108, 74);
            this.tx_tcNo.MaxLength = 11;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(130, 20);
            this.tx_tcNo.TabIndex = 3;
            this.tx_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_tcNo_KeyPress);
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(108, 22);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(130, 20);
            this.tx_ad.TabIndex = 1;
            this.tx_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ad_KeyPress);
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(108, 48);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(130, 20);
            this.tx_soyad.TabIndex = 2;
            this.tx_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyad_KeyPress);
            // 
            // dgv_admin
            // 
            this.dgv_admin.AllowUserToAddRows = false;
            this.dgv_admin.AllowUserToDeleteRows = false;
            this.dgv_admin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(8, 210);
            this.dgv_admin.MultiSelect = false;
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.ReadOnly = true;
            this.dgv_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_admin.Size = new System.Drawing.Size(548, 166);
            this.dgv_admin.TabIndex = 12;
            this.dgv_admin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admin_CellDoubleClick);
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_geri.BackgroundImage")));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_geri.Location = new System.Drawing.Point(12, 382);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(50, 50);
            this.btn_geri.TabIndex = 10;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(58, 156);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(34, 13);
            this.lbl_yetki.TabIndex = 47;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // cbx_yetki
            // 
            this.cbx_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_yetki.FormattingEnabled = true;
            this.cbx_yetki.Location = new System.Drawing.Point(108, 153);
            this.cbx_yetki.Name = "cbx_yetki";
            this.cbx_yetki.Size = new System.Drawing.Size(130, 21);
            this.cbx_yetki.TabIndex = 6;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(375, 156);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(99, 51);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(480, 156);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(76, 51);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Location = new System.Drawing.Point(272, 156);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(97, 51);
            this.btn_temizle.TabIndex = 7;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(108, 100);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(130, 20);
            this.tx_sifre.TabIndex = 4;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(61, 103);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(31, 13);
            this.lbl_sifre.TabIndex = 51;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Boş bırakılabilir";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(573, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cbx_yetki);
            this.Controls.Add(this.lbl_yetki);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.tx_eposta);
            this.Controls.Add(this.lbl_eposta);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_tcNo);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.dgv_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_eposta;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.ComboBox cbx_yetki;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label label1;
    }
}