namespace school_project_1
{
    partial class Gorev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorev));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_gorev = new System.Windows.Forms.TextBox();
            this.dgv_gorev = new System.Windows.Forms.DataGridView();
            this.cms_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bilgileriYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliSatırıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gorev)).BeginInit();
            this.cms_sagtik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Görev:";
            // 
            // tx_gorev
            // 
            this.tx_gorev.Location = new System.Drawing.Point(100, 86);
            this.tx_gorev.Name = "tx_gorev";
            this.tx_gorev.Size = new System.Drawing.Size(145, 20);
            this.tx_gorev.TabIndex = 1;
            this.tx_gorev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_gorev_KeyPress);
            // 
            // dgv_gorev
            // 
            this.dgv_gorev.AllowUserToAddRows = false;
            this.dgv_gorev.AllowUserToDeleteRows = false;
            this.dgv_gorev.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_gorev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gorev.ContextMenuStrip = this.cms_sagtik;
            this.dgv_gorev.Location = new System.Drawing.Point(12, 126);
            this.dgv_gorev.MultiSelect = false;
            this.dgv_gorev.Name = "dgv_gorev";
            this.dgv_gorev.ReadOnly = true;
            this.dgv_gorev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gorev.Size = new System.Drawing.Size(465, 150);
            this.dgv_gorev.TabIndex = 53;
            this.dgv_gorev.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gorev_CellDoubleClick);
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
            // btn_kapat
            // 
            this.btn_kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kapat.Location = new System.Drawing.Point(391, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(86, 55);
            this.btn_kapat.TabIndex = 6;
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
            this.btn_temizle.Location = new System.Drawing.Point(289, 12);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(96, 55);
            this.btn_temizle.TabIndex = 5;
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
            this.btn_sil.Location = new System.Drawing.Point(208, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 55);
            this.btn_sil.TabIndex = 4;
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
            this.btn_guncelle.Location = new System.Drawing.Point(101, 12);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(101, 55);
            this.btn_guncelle.TabIndex = 3;
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
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle\r\n";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // Gorev
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(497, 295);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_gorev);
            this.Controls.Add(this.dgv_gorev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gorev";
            this.Text = "Görev Tanımlama";
            this.Load += new System.EventHandler(this.Gorev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gorev)).EndInit();
            this.cms_sagtik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_gorev;
        private System.Windows.Forms.DataGridView dgv_gorev;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ContextMenuStrip cms_sagtik;
        private System.Windows.Forms.ToolStripMenuItem bilgileriYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliSatırıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuTemizleToolStripMenuItem;
    }
}