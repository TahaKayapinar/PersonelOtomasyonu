using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _99_OOP_Personel_Otomasyonu.Form1;

namespace _99_OOP_Personel_Otomasyonu
{
    internal class Personel
    {
        public Personel(string personelID, string ad, string soyad, DateTime dogumTarihi, DateTime iseGirisTarihi, string telefonNo, string email, string adres, Unvan unvanlar)
        {
            PersonelId = personelID;
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
            IseGirisTarihi = iseGirisTarihi;
            TelefonNo = telefonNo;
            Email = email;
            Adres = adres;
            Unvanlar = unvanlar;
        }

        public string PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public Unvan Unvanlar { get; set; }
    }
}
