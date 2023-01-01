using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99_OOP_Personel_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> personelList = new List<Personel>();
        int yasYil = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridWiew();
            FillUnvan();
        }

        private void FillUnvan()
        {
            cmbUnvan.DataSource = Enum.GetValues(typeof(Unvan));
        }
        internal enum Unvan
        {
            MolekülerBiyolojiveGenetik,
            YazılımMühendisi,
            Fotoğrafçı,
            BüroPersoneli,
            Operatör,
            SahaMühendisi,
            İnşaatMühendisi,
            EndüstriMühendisi,
        }
        private void FillDataGridWiew()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Personel ID";
            dataGridView1.Columns[1].Name = "Ad";
            dataGridView1.Columns[2].Name = "Soyad";
            dataGridView1.Columns[3].Name = "İşe Giriş Tarihi";
            dataGridView1.Columns[4].Name = "Mail Adresi";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (yasYil >= 18)
            {
                string[] personelBilgileri = new string[]
                {
                txtPersonelId.Text,
                txtAd.Text,
                txtSoyad.Text,
                dtpISeGirisTarihi.Text,
                lblMail.Text
                };

                Personel personel = new Personel(txtPersonelId.Text, txtAd.Text, txtSoyad.Text, dtpDogumTarihi.Value, dtpISeGirisTarihi.Value, txtTelefonNo.Text, lblMail.Text, txtAdres.Text, (Unvan)(cmbUnvan.SelectedIndex));

                dataGridView1.Rows.Add(personelBilgileri);
                personelList.Add(personel);
                FormClear();
            }
            else
            {
                MessageBox.Show("18 yaşından küçük kişilere kayıt yapılamaz.");
            }
        }

        private void FormClear()
        {
            txtPersonelId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            lblMail.Text = "";
            txtAdres.Clear();
            txtTelefonNo.Clear();
            cmbUnvan.SelectedIndex = -1;
            dtpDogumTarihi.Value = DateTime.Now;
            dtpISeGirisTarihi.Value = DateTime.Now;
            FillDataGridWiew();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Silmek için önce bir kayıt seçmelisiniz !!!");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var seciliPersonelIndex = (dataGridView1.DataSource as List<Personel>)[e.RowIndex];

                if (seciliPersonelIndex != null)
                {
                    dataGridView1.DataSource = null;
                    txtAd.Text = seciliPersonelIndex.ToString();
                    txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (Personel personel in personelList)
            {
                if (personel.PersonelId == txtPersonelId.Text)
                {
                    personel.PersonelId = txtPersonelId.Text;
                    personel.Ad = txtAd.Text;
                    personel.Soyad = txtSoyad.Text;
                    personel.DogumTarihi = dtpDogumTarihi.Value;
                    personel.IseGirisTarihi = dtpISeGirisTarihi.Value;
                    personel.TelefonNo = txtTelefonNo.Text;
                    personel.Email = lblMail.Text;
                    personel.Adres = txtAdres.Text;
                    personel.Unvanlar = (Unvan)(cmbUnvan.SelectedIndex);
                }
            }

            dataGridView1.Rows.Clear();
            foreach (Personel personel in personelList)
            {
                dataGridView1.Rows.Add(personel.PersonelId, personel.Ad, personel.Soyad, personel.IseGirisTarihi, personel.Email);
            }
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark;
            DateTime dogumTarihi = dtpDogumTarihi.Value;
            fark = DateTime.Now.Date.Subtract(dogumTarihi);
            int yasGun = Convert.ToInt32(fark.TotalDays);

            yasYil = yasGun / 365;

            lblYas.Text = "Yaş: " + yasYil;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            MailOlustur();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            MailOlustur();
        }

        void MailOlustur()
        {
            lblMail.Text = CleanWriting(txtAd.Text) + "." + CleanWriting(txtSoyad.Text) + "@bilgeadam.com";
        }
        string CleanWriting(string param)
        {
            param = param.Trim()
                .ToLower()
                .Replace('ı', 'i')
                .Replace('ğ', 'g')
                .Replace('ü', 'u')
                .Replace('ş', 's')
                .Replace('ö', 'o')
                .Replace('ç', 'c');
            return param;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
