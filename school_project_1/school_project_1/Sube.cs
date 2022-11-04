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
    public partial class Sube : Form
    {
        public Sube()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void Sube_Load(object sender, EventArgs e)
        {
            dgv_subeler.DataSource = vt.Select("select sube_id,subeAdi AS 'Şube Adı',adres AS 'Adres',telefon AS 'Telefon' from tbl_sube");
            dgv_subeler.Columns["sube_id"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_subeAdi.Text == "")
            {
                MessageBox.Show("Şube adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_adres.Text == " ")
            {
                MessageBox.Show("Adres boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_subeler.Rows)
            {
                if (item.Cells[3].Value.ToString() == tx_telefon.Text)
                {
                    MessageBox.Show("Bu telefon numarasına ait şube daha önce eklenmiş.Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            object kayit = vt.Insert(@"insert into tbl_sube(subeAdi,adres,telefon)
                                values('" + tx_subeAdi.Text + "','" + tx_adres.Text + "','" + tx_telefon.Text + "')");

            Sube_Load(null, null);
            MessageBox.Show("Şube kaydı eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_subeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_subeAdi.Text == "")
            {
                MessageBox.Show("Şube adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_subeler.Rows)
            {
                if (item.Cells[3].Value.ToString() == tx_telefon.Text && item.Selected == false)
                {
                    MessageBox.Show("Bu telefon numarası başka bir şubeye ait. Güncelleme işlemi iptal edildi.!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_sube
                                             set subeAdi='" + tx_subeAdi.Text +
                                         "',adres='" + tx_adres.Text +
                                         "',telefon='" + tx_telefon.Text +
                                         "'where sube_id=" +
        dgv_subeler.SelectedRows[0].Cells["sube_id"].Value);
            if (kayitSay > 0)
            {
                Sube_Load(null, null);
                MessageBox.Show("Şube bilgileri güncellendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Temizle();

        }
        public void Temizle()
        {
            tx_subeAdi.Text = "";
            tx_telefon.Text = "";
            tx_adres.Text = "";

            if (dgv_subeler.SelectedRows.Count > 0)
                dgv_subeler.SelectedRows[0].Selected = false;
        }
        string subeKontrol, subeSatisKontrol;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_subeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_subeAdi.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz şubeye 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Şube kaydı silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable kontrol = vt.Select("select COUNT(personel_id) cou from tbl_personel where sube_id='" + subeid + "'");
            subeKontrol = kontrol.Rows[0]["cou"].ToString();

            DataTable kontrol2 = vt.Select("select COUNT(satis_id) cou from tbl_satis where sube_id='" + subeid + "'");
            subeSatisKontrol = kontrol2.Rows[0]["cou"].ToString();

            if (subeKontrol == "0")
            {
                if (subeSatisKontrol == "0")
                {
                    int kayitSay = vt.UpdateDelete("delete from tbl_sube where sube_id=" + dgv_subeler.SelectedRows[0].Cells["sube_id"].Value);
                    if (kayitSay > 0)
                    {
                        Sube_Load(null, null);
                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Şube kayıtlı " + subeSatisKontrol + " satiş'ta bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu Şube kayıtlı " + subeKontrol + " personel'de bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Temizle();
        }


        private void btn_temizle_Click(object sender, EventArgs e)
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
        string subeid;
        private void dgv_subeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_subeler.SelectedRows.Count == 0)
                return;
            tx_subeAdi.Text = dgv_subeler.SelectedRows[0].Cells[1].Value.ToString();
            tx_adres.Text = dgv_subeler.SelectedRows[0].Cells[2].Value.ToString();
            tx_telefon.Text = dgv_subeler.SelectedRows[0].Cells[3].Value.ToString();

            DataTable subek = vt.Select("select sube_id from tbl_sube where subeAdi='" + tx_subeAdi.Text + "'");
            subeid = subek.Rows[0]["sube_id"].ToString();
        }

        private void tx_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_subeAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' ' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false  && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_subeler_CellDoubleClick(null, null);
        }
    }
}
