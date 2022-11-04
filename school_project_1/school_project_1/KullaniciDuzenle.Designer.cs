namespace school_project_1
{
    partial class KullaniciDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciDuzenle));
            this.tx_eposta = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sifreGuncelle = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_eposta
            // 
            this.tx_eposta.Location = new System.Drawing.Point(166, 159);
            this.tx_eposta.Name = "tx_eposta";
            this.tx_eposta.Size = new System.Drawing.Size(100, 20);
            this.tx_eposta.TabIndex = 4;
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(166, 133);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(100, 20);
            this.tx_soyad.TabIndex = 3;
            this.tx_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyad_KeyPress);
            // 
            // tx_ad
            // 
            this.tx_ad.BackColor = System.Drawing.SystemColors.Window;
            this.tx_ad.Location = new System.Drawing.Point(166, 106);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(100, 20);
            this.tx_ad.TabIndex = 2;
            this.tx_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(72, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "E-posta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(81, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(104, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ad:";
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.BackColor = System.Drawing.SystemColors.Window;
            this.tx_tcNo.Location = new System.Drawing.Point(166, 80);
            this.tx_tcNo.MaxLength = 11;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(100, 20);
            this.tx_tcNo.TabIndex = 1;
            this.tx_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_tcNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "TC Kimlik No:";
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_geri.BackgroundImage")));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_geri.Location = new System.Drawing.Point(26, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(50, 50);
            this.btn_geri.TabIndex = 7;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.BackgroundImage")));
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_kaydet.Location = new System.Drawing.Point(126, 12);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(50, 50);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sifreGuncelle
            // 
            this.btn_sifreGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sifreGuncelle.BackgroundImage")));
            this.btn_sifreGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sifreGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreGuncelle.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_sifreGuncelle.Location = new System.Drawing.Point(229, 12);
            this.btn_sifreGuncelle.Name = "btn_sifreGuncelle";
            this.btn_sifreGuncelle.Size = new System.Drawing.Size(107, 50);
            this.btn_sifreGuncelle.TabIndex = 6;
            this.btn_sifreGuncelle.UseVisualStyleBackColor = true;
            this.btn_sifreGuncelle.Click += new System.EventHandler(this.btn_sifreGuncelle_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_admin.BackgroundImage")));
            this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_admin.Location = new System.Drawing.Point(286, 139);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(50, 50);
            this.btn_admin.TabIndex = 8;
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // KullaniciDuzenle
            // 
            this.AcceptButton = this.btn_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btn_geri;
            this.ClientSize = new System.Drawing.Size(357, 201);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_sifreGuncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.tx_eposta);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_tcNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciDuzenle";
            this.Text = "Kullanıcı Düzenleme İşlemleri";
            this.Load += new System.EventHandler(this.KullaniciDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_eposta;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sifreGuncelle;
        private System.Windows.Forms.Button btn_admin;
    }
}