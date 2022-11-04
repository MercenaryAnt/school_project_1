using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_project_1
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        public int kullanici_id = 1;

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void AcilacakForm(Form durumKontrol)
        {
            bool durum = false;

            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == durumKontrol.Text)
                {
                    durum = true;
                    eleman.Activate();
                    MessageBox.Show("Pencere Zaten Açık!");
                }
            }
            if (!durum)
            {
                durumKontrol.MdiParent = this;
                durumKontrol.Show();
            }
        }
        
        private void tsbtn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void tsbtn_personel_Click(object sender, EventArgs e)
        {
            Personel pfrm = new Personel();
            AcilacakForm(pfrm);
        }

        private void tsbtn_urun_Click(object sender, EventArgs e)
        {
            UrunKaydet ukfrm = new UrunKaydet();
            AcilacakForm(ukfrm);
        }

        private void tsbtn_satis_Click(object sender, EventArgs e)
        {
            Satis sfrm = new Satis();
            AcilacakForm(sfrm);
        }

        private void tsbtn_kullaniciDuzenle_Click(object sender, EventArgs e)
        {
            KullaniciDuzenle kdfrm = new KullaniciDuzenle();
            AcilacakForm(kdfrm);
        }

        private void tsbtn_musteri_Click(object sender, EventArgs e)
        {
            Musteri mfrm = new Musteri();
            AcilacakForm(mfrm);
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void notifyIconBesya_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();
        }

        private void gosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tsbtn_simgeDurumu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
