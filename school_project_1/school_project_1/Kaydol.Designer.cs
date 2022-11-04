namespace school_project_1
{
    partial class Kaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            this.lbl_sifreMesaj = new System.Windows.Forms.Label();
            this.tx_eposta = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.tx_sifretkr = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.tt_kaydol = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_sifreMesaj
            // 
            this.lbl_sifreMesaj.AutoSize = true;
            this.lbl_sifreMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifreMesaj.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_sifreMesaj.Location = new System.Drawing.Point(66, 112);
            this.lbl_sifreMesaj.Name = "lbl_sifreMesaj";
            this.lbl_sifreMesaj.Size = new System.Drawing.Size(11, 16);
            this.lbl_sifreMesaj.TabIndex = 41;
            this.lbl_sifreMesaj.Text = ".";
            // 
            // tx_eposta
            // 
            this.tx_eposta.Location = new System.Drawing.Point(116, 197);
            this.tx_eposta.Name = "tx_eposta";
            this.tx_eposta.Size = new System.Drawing.Size(138, 20);
            this.tx_eposta.TabIndex = 6;
            this.tt_kaydol.SetToolTip(this.tx_eposta, "E-posta giriniz.");
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(116, 170);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(138, 20);
            this.tx_soyad.TabIndex = 5;
            this.tt_kaydol.SetToolTip(this.tx_soyad, "Soyadı en az 2 karakter olarak girniz.");
            this.tx_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_soyad_KeyPress);
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(116, 144);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(138, 20);
            this.tx_ad.TabIndex = 4;
            this.tt_kaydol.SetToolTip(this.tx_ad, "Ad uzunluğu 2 karakter olmalıdır.");
            this.tx_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ad_KeyPress);
            // 
            // tx_sifretkr
            // 
            this.tx_sifretkr.Location = new System.Drawing.Point(116, 78);
            this.tx_sifretkr.Name = "tx_sifretkr";
            this.tx_sifretkr.PasswordChar = '*';
            this.tx_sifretkr.Size = new System.Drawing.Size(138, 20);
            this.tx_sifretkr.TabIndex = 3;
            this.tt_kaydol.SetToolTip(this.tx_sifretkr, "Şifreyi tekrar giriniz.");
            this.tx_sifretkr.TextChanged += new System.EventHandler(this.tx_sifre_TextChanged);
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(116, 52);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(138, 20);
            this.tx_sifre.TabIndex = 2;
            this.tt_kaydol.SetToolTip(this.tx_sifre, "Şifre giriniz.");
            this.tx_sifre.TextChanged += new System.EventHandler(this.tx_sifre_TextChanged);
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.Location = new System.Drawing.Point(116, 21);
            this.tx_tcNo.MaxLength = 11;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(138, 20);
            this.tx_tcNo.TabIndex = 1;
            this.tt_kaydol.SetToolTip(this.tx_tcNo, "TC kimlik numarası 11 karakter uzuluğunda olmalı ve sadece rakamlardan oluşmalıdı" +
        "r.");
            this.tx_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_tcNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(52, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "E-posta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "TC Kimlik No:";
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydol.BackgroundImage")));
            this.btn_kaydol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydol.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_kaydol.Location = new System.Drawing.Point(175, 245);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(61, 49);
            this.btn_kaydol.TabIndex = 7;
            this.btn_kaydol.UseVisualStyleBackColor = true;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_geri.BackgroundImage")));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_geri.Location = new System.Drawing.Point(32, 245);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(61, 49);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Kaydol
            // 
            this.AcceptButton = this.btn_kaydol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(266, 313);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lbl_sifreMesaj);
            this.Controls.Add(this.tx_eposta);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.tx_sifretkr);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_tcNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kaydol";
            this.Text = "Kaydol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kaydol_FormClosing);
            this.Load += new System.EventHandler(this.Kaydol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sifreMesaj;
        private System.Windows.Forms.TextBox tx_eposta;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.TextBox tx_sifretkr;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.ToolTip tt_kaydol;
        public System.Windows.Forms.TextBox tx_sifre;
    }
}