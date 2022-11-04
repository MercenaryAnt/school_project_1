namespace school_project_1
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.notifyIconBesya = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtn_personel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_musteri = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_urun = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_satis = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_kullaniciDuzenle = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_simgeDurumu = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_kapat = new System.Windows.Forms.ToolStripButton();
            this.cms_sagtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeDurumunaKüçültToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.contextMenuNotify.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.cms_sagtik.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconBesya
            // 
            this.notifyIconBesya.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIconBesya.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconBesya.Icon")));
            this.notifyIconBesya.Text = "Beyaz Eşya ";
            this.notifyIconBesya.Visible = true;
            this.notifyIconBesya.DoubleClick += new System.EventHandler(this.notifyIconBesya_DoubleClick);
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gosterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(109, 70);
            // 
            // gosterToolStripMenuItem
            // 
            this.gosterToolStripMenuItem.Name = "gosterToolStripMenuItem";
            this.gosterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gosterToolStripMenuItem.Text = "Göster";
            this.gosterToolStripMenuItem.Click += new System.EventHandler(this.gosterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.tsbtn_kapat_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_personel,
            this.tsbtn_musteri,
            this.tsbtn_urun,
            this.tsbtn_satis,
            this.tsbtn_kullaniciDuzenle,
            this.tsbtn_simgeDurumu,
            this.tsbtn_kapat});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(692, 38);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbtn_personel
            // 
            this.tsbtn_personel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_personel.Image")));
            this.tsbtn_personel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_personel.Name = "tsbtn_personel";
            this.tsbtn_personel.Size = new System.Drawing.Size(103, 35);
            this.tsbtn_personel.Text = "Personel İşlemleri";
            this.tsbtn_personel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_personel.Click += new System.EventHandler(this.tsbtn_personel_Click);
            // 
            // tsbtn_musteri
            // 
            this.tsbtn_musteri.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_musteri.Image")));
            this.tsbtn_musteri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_musteri.Name = "tsbtn_musteri";
            this.tsbtn_musteri.Size = new System.Drawing.Size(98, 35);
            this.tsbtn_musteri.Text = "Müşteri İşlemleri";
            this.tsbtn_musteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_musteri.Click += new System.EventHandler(this.tsbtn_musteri_Click);
            // 
            // tsbtn_urun
            // 
            this.tsbtn_urun.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_urun.Image")));
            this.tsbtn_urun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_urun.Name = "tsbtn_urun";
            this.tsbtn_urun.Size = new System.Drawing.Size(84, 35);
            this.tsbtn_urun.Text = "Ürün İşlemleri";
            this.tsbtn_urun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_urun.Click += new System.EventHandler(this.tsbtn_urun_Click);
            // 
            // tsbtn_satis
            // 
            this.tsbtn_satis.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_satis.Image")));
            this.tsbtn_satis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_satis.Name = "tsbtn_satis";
            this.tsbtn_satis.Size = new System.Drawing.Size(82, 35);
            this.tsbtn_satis.Text = "Satış İşlemleri";
            this.tsbtn_satis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_satis.Click += new System.EventHandler(this.tsbtn_satis_Click);
            // 
            // tsbtn_kullaniciDuzenle
            // 
            this.tsbtn_kullaniciDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_kullaniciDuzenle.Image")));
            this.tsbtn_kullaniciDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_kullaniciDuzenle.Name = "tsbtn_kullaniciDuzenle";
            this.tsbtn_kullaniciDuzenle.Size = new System.Drawing.Size(101, 35);
            this.tsbtn_kullaniciDuzenle.Text = "Kullanıcı Düzenle";
            this.tsbtn_kullaniciDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_kullaniciDuzenle.Click += new System.EventHandler(this.tsbtn_kullaniciDuzenle_Click);
            // 
            // tsbtn_simgeDurumu
            // 
            this.tsbtn_simgeDurumu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_simgeDurumu.Image")));
            this.tsbtn_simgeDurumu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_simgeDurumu.Name = "tsbtn_simgeDurumu";
            this.tsbtn_simgeDurumu.Size = new System.Drawing.Size(141, 35);
            this.tsbtn_simgeDurumu.Text = "Simge Durumuna Küçült";
            this.tsbtn_simgeDurumu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_simgeDurumu.Click += new System.EventHandler(this.tsbtn_simgeDurumu_Click);
            // 
            // tsbtn_kapat
            // 
            this.tsbtn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_kapat.Image")));
            this.tsbtn_kapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_kapat.Name = "tsbtn_kapat";
            this.tsbtn_kapat.Size = new System.Drawing.Size(41, 35);
            this.tsbtn_kapat.Text = "Kapat";
            this.tsbtn_kapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_kapat.Click += new System.EventHandler(this.tsbtn_kapat_Click);
            // 
            // cms_sagtik
            // 
            this.cms_sagtik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemleriToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.kullanıcıDüzenleToolStripMenuItem,
            this.simgeDurumunaKüçültToolStripMenuItem,
            this.kapatToolStripMenuItem1});
            this.cms_sagtik.Name = "cms_sagtik";
            this.cms_sagtik.Size = new System.Drawing.Size(242, 158);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.tsbtn_personel_Click);
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.tsbtn_musteri_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            this.ürünİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.tsbtn_urun_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            this.satışİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.tsbtn_satis_Click);
            // 
            // kullanıcıDüzenleToolStripMenuItem
            // 
            this.kullanıcıDüzenleToolStripMenuItem.Name = "kullanıcıDüzenleToolStripMenuItem";
            this.kullanıcıDüzenleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.kullanıcıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.kullanıcıDüzenleToolStripMenuItem.Text = "Kullanıcı Düzenle";
            this.kullanıcıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.tsbtn_kullaniciDuzenle_Click);
            // 
            // simgeDurumunaKüçültToolStripMenuItem
            // 
            this.simgeDurumunaKüçültToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("simgeDurumunaKüçültToolStripMenuItem.Image")));
            this.simgeDurumunaKüçültToolStripMenuItem.Name = "simgeDurumunaKüçültToolStripMenuItem";
            this.simgeDurumunaKüçültToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.simgeDurumunaKüçültToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.simgeDurumunaKüçültToolStripMenuItem.Text = "Simge Durumuna Küçült";
            this.simgeDurumunaKüçültToolStripMenuItem.Click += new System.EventHandler(this.tsbtn_simgeDurumu_Click);
            // 
            // kapatToolStripMenuItem1
            // 
            this.kapatToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem1.Image")));
            this.kapatToolStripMenuItem1.Name = "kapatToolStripMenuItem1";
            this.kapatToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.kapatToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
            this.kapatToolStripMenuItem1.Text = "Kapat";
            this.kapatToolStripMenuItem1.Click += new System.EventHandler(this.tsbtn_kapat_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(523, 122);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat.TabIndex = 3;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Visible = false;
            this.btn_kapat.Click += new System.EventHandler(this.tsbtn_kapat_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(692, 406);
            this.ContextMenuStrip = this.cms_sagtik;
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.btn_kapat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "AnaForm";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.contextMenuNotify.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.cms_sagtik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconBesya;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbtn_personel;
        private System.Windows.Forms.ToolStripButton tsbtn_musteri;
        private System.Windows.Forms.ToolStripButton tsbtn_urun;
        private System.Windows.Forms.ToolStripButton tsbtn_satis;
        private System.Windows.Forms.ToolStripButton tsbtn_kullaniciDuzenle;
        private System.Windows.Forms.ToolStripButton tsbtn_kapat;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem gosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtn_simgeDurumu;
        private System.Windows.Forms.ContextMenuStrip cms_sagtik;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeDurumunaKüçültToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem1;
        private System.Windows.Forms.Button btn_kapat;
    }
}