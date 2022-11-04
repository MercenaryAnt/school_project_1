namespace school_project_1
{
    partial class KullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_tcNo = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.cbx_sifreGoster = new System.Windows.Forms.CheckBox();
            this.cbx_hatirla = new System.Windows.Forms.CheckBox();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.tt_giris = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(65, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // tx_tcNo
            // 
            this.tx_tcNo.Location = new System.Drawing.Point(111, 28);
            this.tx_tcNo.MaxLength = 11;
            this.tx_tcNo.Name = "tx_tcNo";
            this.tx_tcNo.Size = new System.Drawing.Size(100, 20);
            this.tx_tcNo.TabIndex = 1;
            this.tt_giris.SetToolTip(this.tx_tcNo, "TC kimlik numaranızı giriniz.");
            this.tx_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_tcNo_KeyPress);
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(111, 55);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(100, 20);
            this.tx_sifre.TabIndex = 2;
            this.tt_giris.SetToolTip(this.tx_sifre, "Şifrenizi giriniz.");
            // 
            // cbx_sifreGoster
            // 
            this.cbx_sifreGoster.AutoSize = true;
            this.cbx_sifreGoster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_sifreGoster.Location = new System.Drawing.Point(217, 57);
            this.cbx_sifreGoster.Name = "cbx_sifreGoster";
            this.cbx_sifreGoster.Size = new System.Drawing.Size(88, 17);
            this.cbx_sifreGoster.TabIndex = 3;
            this.cbx_sifreGoster.Text = "Şifreyi Göster";
            this.cbx_sifreGoster.UseVisualStyleBackColor = true;
            this.cbx_sifreGoster.CheckedChanged += new System.EventHandler(this.cbx_sifreGoster_CheckedChanged);
            // 
            // cbx_hatirla
            // 
            this.cbx_hatirla.AutoSize = true;
            this.cbx_hatirla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_hatirla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_hatirla.Location = new System.Drawing.Point(12, 93);
            this.cbx_hatirla.Name = "cbx_hatirla";
            this.cbx_hatirla.Size = new System.Drawing.Size(80, 17);
            this.cbx_hatirla.TabIndex = 4;
            this.cbx_hatirla.Text = "Beni Hatırla";
            this.cbx_hatirla.UseVisualStyleBackColor = true;
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydol.BackgroundImage")));
            this.btn_kaydol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydol.Location = new System.Drawing.Point(176, 143);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(61, 41);
            this.btn_kaydol.TabIndex = 6;
            this.btn_kaydol.UseVisualStyleBackColor = true;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Location = new System.Drawing.Point(68, 143);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(61, 41);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // KullaniciGirisi
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(313, 210);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.cbx_hatirla);
            this.Controls.Add(this.cbx_sifreGoster);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_tcNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGirisi";
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciGirisi_FormClosing);
            this.Load += new System.EventHandler(this.KullaniciGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_tcNo;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.CheckBox cbx_sifreGoster;
        private System.Windows.Forms.CheckBox cbx_hatirla;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.ToolTip tt_giris;
    }
}

