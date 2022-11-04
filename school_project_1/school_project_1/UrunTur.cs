using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLIslemleri;

namespace school_project_1
{
    public partial class UrunTur : Form
    {
        public UrunTur()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_urunTur.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object kayitSayisi = vt.Insert("insert into tbl_urunTur(urunTur) values('" + tx_urunTur.Text + "')");
            UrunTur_Load(null, null);
            MessageBox.Show("Ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void UrunTur_Load(object sender, EventArgs e)
        {
            dgv_urunTur.DataSource = vt.Select("select urunTur_id,urunTur from tbl_urunTur");
            dgv_urunTur.Columns["urunTur_id"].Visible = false;
        }
        string urunid;
        private void dgv_urunTur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_urunTur.SelectedRows.Count == 0)
                return;
            tx_urunTur.Text = dgv_urunTur.SelectedRows[0].Cells["urunTur"].Value.ToString();

            DataTable urunk = vt.Select("select urunTur_id from tbl_urunTur where urunTur='" +tx_urunTur.Text+ "'");
            urunid = urunk.Rows[0]["urunTur_id"].ToString();
        }
        public void Temizle()
        {
            tx_urunTur.Text = "";

            if (dgv_urunTur.SelectedRows.Count > 0)
                dgv_urunTur.SelectedRows[0].Selected = false;
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_urunTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_urunTur.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSayisi = vt.UpdateDelete(@"update tbl_urunTur set urunTur = '" + tx_urunTur.Text +
                "' where urunTur_id ="
                + dgv_urunTur.SelectedRows[0].Cells["urunTur_id"].Value);
            if (kayitSayisi > 0)
            {
                UrunTur_Load(null, null);
                MessageBox.Show("Bilgiler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
        }
        string urunTurKontrol;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_urunTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_urunTur.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz ÜrünTürüne 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Kayıt silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable kontrol = vt.Select("select COUNT(urun_id) cou from tbl_urun where urunTur_id='" + urunid + "'");
            urunTurKontrol = kontrol.Rows[0]["cou"].ToString();


            if (urunTurKontrol == "0")
            {
                int kayitSayisi = vt.UpdateDelete("delete from tbl_urunTur where urunTur_id=" + dgv_urunTur.SelectedRows[0].Cells["urunTur_id"].Value);
                if (kayitSayisi > 0)
                {
                    UrunTur_Load(null, null);
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu ÜrünTürüne kayıtlı " + urunTurKontrol + " ürün bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
            Temizle();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Sayfayı kapatmak istediğinize emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
                this.Close();
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void tx_urunTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' ' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_urunTur_CellDoubleClick(null, null);
        }
    }
}
