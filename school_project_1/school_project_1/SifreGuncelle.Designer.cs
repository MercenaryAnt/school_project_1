namespace school_project_1
{
    partial class SifreGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreGuncelle));
            this.lbl_sifreMesaj = new System.Windows.Forms.Label();
            this.tx_sifretkr = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_sifreKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sifreMesaj
            // 
            this.lbl_sifreMesaj.AutoSize = true;
            this.lbl_sifreMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifreMesaj.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_sifreMesaj.Location = new System.Drawing.Point(85, 68);
            this.lbl_sifreMesaj.Name = "lbl_sifreMesaj";
            this.lbl_sifreMesaj.Size = new System.Drawing.Size(10, 15);
            this.lbl_sifreMesaj.TabIndex = 42;
            this.lbl_sifreMesaj.Text = ".";
            // 
            // tx_sifretkr
            // 
            this.tx_sifretkr.Location = new System.Drawing.Point(114, 38);
            this.tx_sifretkr.Name = "tx_sifretkr";
            this.tx_sifretkr.PasswordChar = '*';
            this.tx_sifretkr.Size = new System.Drawing.Size(100, 20);
            this.tx_sifretkr.TabIndex = 2;
            this.tx_sifretkr.TextChanged += new System.EventHandler(this.tx_sifre_TextChanged);
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(114, 12);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(100, 20);
            this.tx_sifre.TabIndex = 1;
            this.tx_sifre.TextChanged += new System.EventHandler(this.tx_sifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Şifre:";
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_geri.BackgroundImage")));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_geri.Location = new System.Drawing.Point(24, 95);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(40, 40);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_sifreKaydet
            // 
            this.btn_sifreKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sifreKaydet.BackgroundImage")));
            this.btn_sifreKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sifreKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreKaydet.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_sifreKaydet.Location = new System.Drawing.Point(136, 94);
            this.btn_sifreKaydet.Name = "btn_sifreKaydet";
            this.btn_sifreKaydet.Size = new System.Drawing.Size(40, 40);
            this.btn_sifreKaydet.TabIndex = 3;
            this.btn_sifreKaydet.UseVisualStyleBackColor = true;
            this.btn_sifreKaydet.Click += new System.EventHandler(this.btn_sifreKaydet_Click);
            // 
            // SifreGuncelle
            // 
            this.AcceptButton = this.btn_sifreKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btn_geri;
            this.ClientSize = new System.Drawing.Size(228, 157);
            this.Controls.Add(this.btn_sifreKaydet);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lbl_sifreMesaj);
            this.Controls.Add(this.tx_sifretkr);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifreGuncelle";
            this.Text = "Şifre Güncelleme İşlemleri";
            this.Load += new System.EventHandler(this.SifreGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_sifreMesaj;
        private System.Windows.Forms.TextBox tx_sifretkr;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_sifreKaydet;
    }
}