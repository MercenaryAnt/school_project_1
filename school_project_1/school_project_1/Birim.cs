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
    public partial class Birim : Form
    {
        public Birim()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void Birim_Load(object sender, EventArgs e)
        {
            dgv_birim.DataSource = vt.Select("select birim_id, birim AS 'Stok Birimi' from tbl_birim");
            dgv_birim.Columns["birim_id"].Visible = false;
        }
        string birimid;
        private void dgv_birim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_birim.SelectedRows.Count == 0)
                return;
            tx_birim.Text = dgv_birim.SelectedRows[0].Cells[1].Value.ToString();

            DataTable birimk = vt.Select("select birim_id from tbl_birim where birim='" + tx_birim.Text + "'");
            birimid = birimk.Rows[0]["birim_id"].ToString();
        }

        private void tx_birim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' ' && e.KeyChar != '\b' )
                e.Handled = true;
        }

        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
            if (tx_birim.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object kayitSay = vt.Insert("insert into tbl_birim(birim) values('" + tx_birim.Text + "')");
            Birim_Load(null, null);
            MessageBox.Show("Stok birimi eklemesi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            if (dgv_birim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_birim.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_birim set birim = '" + tx_birim.Text +
                "' where birim_id ="
                + dgv_birim.SelectedRows[0].Cells["birim_id"].Value);
            if (kayitSay > 0)
            {
                Birim_Load(null, null);
                MessageBox.Show("Bilgiler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
        }
        string birimKontrol;
        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            if (dgv_birim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_birim.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz birime 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Kayıt silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable kontrol = vt.Select("select COUNT(urun_id) cou from tbl_urun where birim_id='" + birimid + "'");
            birimKontrol = kontrol.Rows[0]["cou"].ToString();

            if (birimKontrol == "0")
            {
                int kayitSay = vt.UpdateDelete("delete from tbl_birim where birim_id=" + dgv_birim.SelectedRows[0].Cells["birim_id"].Value);
                if (kayitSay > 0)
                {
                    Birim_Load(null, null);
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu Birime kayıtlı " + birimKontrol + " ürün bulunmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            Temizle();

        }
        public void Temizle()
        {
            tx_birim.Text = "";

            if (dgv_birim.SelectedRows.Count > 0)
                dgv_birim.SelectedRows[0].Selected = false;
        }

        private void btn_temizle_Click_1(object sender, EventArgs e)
        {
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

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_birim_CellDoubleClick(null, null);
        }
    }
}
