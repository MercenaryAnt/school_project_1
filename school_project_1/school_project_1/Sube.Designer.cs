namespace school_project_1
{
    partial class Sube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sube));
            this.tx_telefon = new System.Windows.Forms.TextBox();
            this.tx_adres = new System.Windows.Forms.TextBox();
            this.tx_subeAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_subeler = new System.Windows.Forms.DataGridView();
            this.cms_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bilgileriYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subeler)).BeginInit();
            this.cms_sagtik.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_telefon
            // 
            this.tx_telefon.Location = new System.Drawing.Point(120, 158);
            this.tx_telefon.MaxLength = 11;
            this.tx_telefon.Name = "tx_telefon";
            this.tx_telefon.Size = new System.Drawing.Size(130, 20);
            this.tx_telefon.TabIndex = 3;
            this.tx_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_telefon_KeyPress);
            // 
            // tx_adres
            // 
            this.tx_adres.Location = new System.Drawing.Point(120, 126);
            this.tx_adres.Name = "tx_adres";
            this.tx_adres.Size = new System.Drawing.Size(130, 20);
            this.tx_adres.TabIndex = 2;
            this.tx_adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_adres_KeyPress);
            // 
            // tx_subeAdi
            // 
            this.tx_subeAdi.Location = new System.Drawing.Point(120, 91);
            this.tx_subeAdi.Name = "tx_subeAdi";
            this.tx_subeAdi.Size = new System.Drawing.Size(130, 20);
            this.tx_subeAdi.TabIndex = 1;
            this.tx_subeAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_subeAdi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şube Adı:";
            // 
            // dgv_subeler
            // 
            this.dgv_subeler.AllowUserToAddRows = false;
            this.dgv_subeler.AllowUserToDeleteRows = false;
            this.dgv_subeler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_subeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_subeler.ContextMenuStrip = this.cms_sagtik;
            this.dgv_subeler.Location = new System.Drawing.Point(16, 197);
            this.dgv_subeler.MultiSelect = false;
            this.dgv_subeler.Name = "dgv_subeler";
            this.dgv_subeler.ReadOnly = true;
            this.dgv_subeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_subeler.Size = new System.Drawing.Size(503, 150);
            this.dgv_subeler.TabIndex = 12;
            this.dgv_subeler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_subeler_CellDoubleClick);
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
            // btn_temizle
            // 
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Location = new System.Drawing.Point(322, 12);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(96, 55);
            this.btn_temizle.TabIndex = 7;
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
            this.btn_sil.Location = new System.Drawing.Point(231, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 55);
            this.btn_sil.TabIndex = 6;
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
            this.btn_guncelle.Location = new System.Drawing.Point(114, 12);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(101, 55);
            this.btn_guncelle.TabIndex = 5;
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
            this.btn_ekle.Location = new System.Drawing.Point(16, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(83, 55);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle\r\n";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kapat.Location = new System.Drawing.Point(433, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(86, 55);
            this.btn_kapat.TabIndex = 8;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // Sube
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(538, 364);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dgv_subeler);
            this.Controls.Add(this.tx_telefon);
            this.Controls.Add(this.tx_adres);
            this.Controls.Add(this.tx_subeAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sube";
            this.Text = "Şube Tanımlama";
            this.Load += new System.EventHandler(this.Sube_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subeler)).EndInit();
            this.cms_sagtik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_telefon;
        private System.Windows.Forms.TextBox tx_adres;
        private System.Windows.Forms.TextBox tx_subeAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_subeler;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.ContextMenuStrip cms_sagtik;
        private System.Windows.Forms.ToolStripMenuItem bilgileriYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuTemizleToolStripMenuItem;
    }
}