using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LisansProgrami
{
    public partial class Lisanslama : Form
    {
        public Lisanslama()
        {
            InitializeComponent();
        }

        private void btn_lisansKoduUret_Click(object sender, EventArgs e)
        {
            string yazilimKodu = tx_yazilimKodu.Text.Remove(4, 1).Remove(8, 1).Remove(12,1);
            yazilimKodu = yazilimKodu + "BeyazEsya31";

            yazilimKodu = MD5Sifrele(yazilimKodu).ToUpper();

            string lisansKodu = yazilimKodu.Substring(1, 3) + yazilimKodu.Substring(8, 6) + yazilimKodu.Substring(20, 3) + yazilimKodu.Substring(28, 3) + yazilimKodu.Substring(16, 1);

            lisansKodu = lisansKodu.Insert(12, "-");
            lisansKodu = lisansKodu.Insert(8, "-");
            lisansKodu = lisansKodu.Insert(4, "-");

            tx_lisansKodu.Text = lisansKodu;
        }


        public string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
    }
}
