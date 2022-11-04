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
    public partial class SatisDurumu : Form
    {
        public SatisDurumu()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_satisDurum.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object kayitSay = vt.Insert("insert into tbl_satisDurumu(satisDurumu) values('"+tx_satisDurum.Text+"')");
            SatisDurumu_Load(null, null);
            MessageBox.Show("Ekleme başarılı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void SatisDurumu_Load(object sender, EventArgs e)
        {
            dgv_satisDurum.DataSource = vt.Select("select satisDurum_id,satisDurumu AS 'Satış Durumu' from tbl_satisDurumu");
            dgv_satisDurum.Columns["satisDurum_id"].Visible = false;
            Temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_satisDurum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_satisDurum.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_satisDurumu set satisDurumu = '" + tx_satisDurum.Text +
                "' where satisDurum_id ="
                + dgv_satisDurum.SelectedRows[0].Cells["satisDurum_id"].Value);
            if (kayitSay > 0)
            {
                SatisDurumu_Load(null, null);
                MessageBox.Show("Bilgiler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
        }
        string satisDurumKontrol;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_satisDurum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_satisDurum.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz satışdurumuna 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Kayıt silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable kontrol = vt.Select("select COUNT(satis_id) cou from tbl_satis where satisDurum_id='" + satisDurumuid + "'");
            satisDurumKontrol = kontrol.Rows[0]["cou"].ToString();

            if (satisDurumKontrol == "0")
            {
                int kayitSay = vt.UpdateDelete("delete from tbl_satisDurumu where satisDurum_id=" + dgv_satisDurum.SelectedRows[0].Cells["satisDurum_id"].Value);
                if (kayitSay > 0)
                {
                    SatisDurumu_Load(null, null);
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu SatışDurumuna kayıtlı " + satisDurumKontrol + " satış bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Temizle();
        }
        public void Temizle()
        {
            tx_satisDurum.Text = "";

            if (dgv_satisDurum.SelectedRows.Count > 0)
                dgv_satisDurum.SelectedRows[0].Selected = false;
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        string satisDurumuid;
        private void dgv_satisDurum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_satisDurum.SelectedRows.Count == 0)
                return;
            tx_satisDurum.Text = dgv_satisDurum.SelectedRows[0].Cells[1].Value.ToString();

            DataTable satisDurumuk = vt.Select("select satisDurum_id from tbl_satisDurumu where satisDurumu='" + tx_satisDurum.Text + "'");
            satisDurumuid = satisDurumuk.Rows[0]["satisDurum_id"].ToString();
        }

        private void tx_satisDurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' ' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_satisDurum_CellDoubleClick(null, null);
        }
    }
}
