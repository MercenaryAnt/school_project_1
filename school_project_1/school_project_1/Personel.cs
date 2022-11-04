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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        private void btn_subeEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sube sfrm = new Sube();
            sfrm.Show();
        }

        private void btn_gorevEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gorev gfrm = new Gorev();
            gfrm.Show();
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
        public void PersonelDoldur()
        {
            dgv_personel.DataSource =
                vt.Select(@"select p.personel_id,p.ad AS 'Adı',p.soyad AS 'Soyadı',p.tcNo AS 'TC Kimlik No',p.telefon AS 'Telefon',p.adres AS 'Adres',p.eposta AS 'E-mail',g.gorev_id,g.gorev AS 'Görevi',s.sube_id,s.subeAdi AS 'Şube Adı'
                            from tbl_personel p 
                            join tbl_gorev g on p.gorev_id=g.gorev_id
                            join tbl_sube s on p.sube_id=s.sube_id");

            dgv_personel.Columns["personel_id"].Visible = false;
            dgv_personel.Columns["gorev_id"].Visible = false;
            dgv_personel.Columns["sube_id"].Visible = false;

        }
            
        private void Personel_Load(object sender, EventArgs e)
        {
            PersonelDoldur();
            cbx_sube.DisplayMember = "subeAdi";
            cbx_sube.ValueMember = "sube_id";
            cbx_sube.DataSource = vt.Select("select sube_id, subeAdi from tbl_sube");

            cbx_gorev.DisplayMember = "gorev";
            cbx_gorev.ValueMember = "gorev_id";
            cbx_gorev.DataSource = vt.Select("select gorev_id, gorev from tbl_gorev");

        }
    
        public void Temizle()
        {
            tx_ad.Text = "";
            tx_soyad.Text = "";
            tx_tcNo.Text = "";
            tx_telefon.Text = "";
            tx_adres.Text = "";
            tx_email.Text = "";
            cbx_gorev.SelectedIndex = -1;
            cbx_sube.SelectedIndex = -1;

            if (dgv_personel.SelectedRows.Count > 0)
                dgv_personel.SelectedRows[0].Selected = false;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (tx_soyad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 karakter olmalıdır.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_tcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakter olmalıdır.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılmamalıdır.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_email.Text == "")
            {
                MessageBox.Show("E-mail boş bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_sube.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen çalıştığı şubeyi seçiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (cbx_gorev.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen görevini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_personel.Rows)
            {
                if (item.Cells[4].Value.ToString() == tx_telefon.Text)
                {
                    MessageBox.Show("Bu telefon numarasına ait personel daha önce eklenmiş.Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[3].Value.ToString() == tx_tcNo.Text)
                {
                    MessageBox.Show("Bu TC kimlik numarasına ait personel daha önce eklenmiş. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[6].Value.ToString() == tx_email.Text)
                {
                    MessageBox.Show("Bu e-mail adresi başka bir personele ait. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            object kayitSayisi = vt.Insert(@"insert into tbl_personel(ad,soyad,tcNo,telefon,adres,eposta,gorev_id,sube_id)
                values('"+tx_ad.Text+"','"+tx_soyad.Text+"','"+tx_tcNo.Text+"','"+tx_telefon.Text+"','"+tx_adres.Text+"','"+tx_email.Text+"',"+cbx_gorev.SelectedValue+","+cbx_sube.SelectedValue+")");

            PersonelDoldur();
            MessageBox.Show("Personel, başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();

        }
      
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (tx_ad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_soyad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_tcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_email.Text == "")
            {
                MessageBox.Show("E-mail boş bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_sube.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen çalıştığı şubeyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_gorev.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen görevini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_personel.Rows)
            {
                if (item.Cells[4].Value.ToString() == tx_telefon.Text)
                {
                    MessageBox.Show("Bu telefon numarasına ait personel daha önce eklenmiş.Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[3].Value.ToString() == tx_tcNo.Text)
                {
                    MessageBox.Show("Bu TC kimlik numarasına ait personel daha önce eklenmiş. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[6].Value.ToString() == tx_email.Text)
                {
                    MessageBox.Show("Bu e-mail adresi başka bir personele ait. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int kayitSayisi = vt.UpdateDelete(@"update tbl_personel
                                                set ad='"+tx_ad.Text+
                                                "',soyad='"+tx_soyad.Text+
                                                "',tcNo='"+tx_tcNo.Text+
                                                "', telefon='"+tx_telefon.Text+
                                                "', adres='"+tx_adres.Text+
                                                "',eposta='"+tx_email.Text+
                                                "',gorev_id="+cbx_gorev.SelectedValue+
                                                ",sube_id="+cbx_sube.SelectedValue+
                                                "where personel_id="+dgv_personel.SelectedRows[0].Cells["personel_id"].Value);
                                               
            if (kayitSayisi > 0)
            {
                PersonelDoldur();
                MessageBox.Show("Kayıt güncelleme işlemi başarılı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        string telefon, tcNo, email;
        private void dgv_personel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
                return;
            tx_ad.Text = dgv_personel.SelectedRows[0].Cells[1].Value.ToString();
            tx_soyad.Text = dgv_personel.SelectedRows[0].Cells[2].Value.ToString();
            tx_tcNo.Text = dgv_personel.SelectedRows[0].Cells[3].Value.ToString();
            tx_telefon.Text = dgv_personel.SelectedRows[0].Cells[4].Value.ToString();
            tx_adres.Text = dgv_personel.SelectedRows[0].Cells[5].Value.ToString();
            tx_email.Text = dgv_personel.SelectedRows[0].Cells[6].Value.ToString();
            cbx_gorev.SelectedValue = dgv_personel.SelectedRows[0].Cells["gorev_id"].Value;
            cbx_sube.SelectedValue = dgv_personel.SelectedRows[0].Cells["sube_id"].Value;



            telefon = tx_telefon.Text;
            tcNo = tx_tcNo.Text;
            email = tx_email.Text;

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DialogResult cevap = MessageBox.Show("Personel kaydı silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_personel where personel_id=" + dgv_personel.SelectedRows[0].Cells["personel_id"].Value);
            if (kayitSay > 0)
            {
                PersonelDoldur();
                MessageBox.Show("Kayıt başarıyla silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Temizle();
        }

        private void tx_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_personel_CellDoubleClick(null, null);
        }

        private void tx_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Personel_Load(null, null);
        }
    }
}
