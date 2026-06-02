using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using nyp_odev2;

namespace nyp_odev2
{
    public partial class Form1: Form
    {

        BankaYonetim banka = new BankaYonetim();
        public Form1()
        {
            InitializeComponent();
            txtMusteriAd.MaxLength = 50;
            txtMusteriSoyad.MaxLength = 50;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Örnek olarak eklenen müşteri ve hesaplar
            int no1 = banka.YeniMusteriNoUret();
            MusteriBilgileri musteri1 = new BireyselMusteri("Defne", "Yılmaz", no1);
            banka.MusteriEkle(musteri1);

            
            int hesapNo1 = banka.YeniHesapNoUret();
            banka.HesapAc(musteri1, hesapNo1, 2000m); 
            banka.ParaYatir(musteri1.Hesaplar[0], 1500m); 

            
            int no2 = banka.YeniMusteriNoUret();
            MusteriBilgileri musteri2 = new TicariMusteri("Özgün", "Havacılık", no2);
            banka.MusteriEkle(musteri2);

            
            int hesapNo2 = banka.YeniHesapNoUret();
            banka.HesapAc(musteri2, hesapNo2, 15000m);
            banka.ParaYatir(musteri2.Hesaplar[0], 45000m);

            int hesapNo3 = banka.YeniHesapNoUret();
            banka.HesapAc(musteri2, hesapNo3, 5000m);
            banka.ParaYatir(musteri2.Hesaplar[1], 250m);

           
            MusteriListesiniGuncelle();
        }

       

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) || string.IsNullOrWhiteSpace(txtMusteriSoyad.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                string ad = txtMusteriAd.Text;
                string soyad = txtMusteriSoyad.Text;

                int musteriNo = banka.YeniMusteriNoUret();

                MusteriBilgileri yeniMusteri;
                if (rbBireysel.Checked)
                {
                    yeniMusteri = new BireyselMusteri(ad, soyad, musteriNo);
                }
                else if (rbTicari.Checked)
                {
                    yeniMusteri = new TicariMusteri(ad, soyad, musteriNo);
                }
                else
                {
                    MessageBox.Show("Lütfen müşteri tipini seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                banka.MusteriEkle(yeniMusteri);

                MessageBox.Show("Müşteri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtMusteriAd.Clear();
                txtMusteriSoyad.Clear();

                MusteriListesiniGuncelle();
            }

            catch (FormatException)
            {
                MessageBox.Show("Müşteri Numarası sadece sayılardan oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                private void MusteriListesiniGuncelle()
                {
                    cmbMusteriler.DataSource = null; 
                    cmbMusteriler.DataSource = banka.Musteriler; 
                    cmbMusteriler.DisplayMember = "TamAdGosterim";

                    cmbHesapKapatMusteri.DataSource = null;
                    cmbHesapKapatMusteri.DataSource = banka.Musteriler;
                    cmbHesapKapatMusteri.DisplayMember = "TamAdGosterim";

                    cmbIslemMusteri.DataSource = null;
                    cmbIslemMusteri.DataSource = banka.Musteriler;
                    cmbIslemMusteri.DisplayMember = "TamAdGosterim";

                    cmbHavaleGonderenMusteri.DataSource = null;
                    cmbHavaleGonderenMusteri.DataSource = banka.Musteriler.ToList();
                    cmbHavaleGonderenMusteri.DisplayMember = "TamAdGosterim";

                    cmbHavaleAliciMusteri.DataSource = null;
                    cmbHavaleAliciMusteri.DataSource = banka.Musteriler.ToList();
                    cmbHavaleAliciMusteri.DisplayMember = "TamAdGosterim";

                    cmbRaporMusteri.DataSource = null;
                    cmbRaporMusteri.DataSource = banka.Musteriler.ToList();
                    cmbRaporMusteri.DisplayMember = "TamAdGosterim";
                }
        

        

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbMusteriler.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

 
                if (string.IsNullOrWhiteSpace(txtEkHesap.Text))
                {
                    MessageBox.Show("Lütfen ek hesap limitini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                MusteriBilgileri secilenMusteri = (MusteriBilgileri)cmbMusteriler.SelectedItem;

               
                decimal ekHesap = Convert.ToDecimal(txtEkHesap.Text);

               
                int yeniHesapNo = banka.YeniHesapNoUret();

                
                banka.HesapAc(secilenMusteri, yeniHesapNo, ekHesap);

                MessageBox.Show($"{secilenMusteri.Ad} {secilenMusteri.Soyad} adına {yeniHesapNo} numaralı hesap başarıyla açıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEkHesap.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ek hesap limiti sadece rakamlardan oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnRaporuGetir_Click(object sender, EventArgs e)
        {
            decimal toplamMusteriParasi = 0;

            
            var bankadakiTumHesaplar = new List<dynamic>();

            
            foreach (var musteri in banka.Musteriler)
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    toplamMusteriParasi += hesap.Bakiye;

                    
                    bankadakiTumHesaplar.Add(new
                    {
                        MusteriAd = musteri.TamAdGosterim,
                        HesapNumarasi = hesap.HesapNo,
                        GuncelBakiye = hesap.Bakiye,
                        KalanEkHesap = hesap.EkHesap
                    });
                }
            }


         
            lblBankaToplamPara.Text = $"{toplamMusteriParasi} TL";
            lblBankaToplamGelir.Text = $"{banka.BankaToplamGeliri} TL";


            dgvRaporlar.Columns.Clear();

            dgvRaporlar.DataSource = null;
            dgvRaporlar.DataSource = bankadakiTumHesaplar;

            if (dgvRaporlar.Columns.Count > 0)
            {
                dgvRaporlar.Columns["MusteriAd"].HeaderText = "Müşteri Bilgisi";
                dgvRaporlar.Columns["MusteriAd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRaporlar.Columns["GuncelBakiye"].DefaultCellStyle.Format = "C2";
                dgvRaporlar.Columns["KalanEkHesap"].DefaultCellStyle.Format = "C2";
            }
        }




        private void cmbHesapKapatMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHesapKapatMusteri.SelectedItem != null)
            {
                MusteriBilgileri secilenMusteri = (MusteriBilgileri)cmbHesapKapatMusteri.SelectedItem;

                cmbKapatilacakHesap.DataSource = null; 
                cmbKapatilacakHesap.DataSource = secilenMusteri.Hesaplar; 
                cmbKapatilacakHesap.DisplayMember = "HesapNo"; 
            }
        }

        private void cmbIslemMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIslemMusteri.SelectedItem != null)
            {
                MusteriBilgileri secilenMusteri = (MusteriBilgileri)cmbIslemMusteri.SelectedItem;

                cmbIslemHesap.DataSource = null;
                cmbIslemHesap.DataSource = secilenMusteri.Hesaplar;
                cmbIslemHesap.DisplayMember = "HesapNo";
            }
        }


        

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbIslemMusteri.SelectedItem == null || cmbIslemHesap.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen işlem yapılacak müşteri ve hesabı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIslemTutar.Text))
                {
                    MessageBox.Show("Lütfen çekilecek tutarı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                HesapBilgileri secilenHesap = (HesapBilgileri)cmbIslemHesap.SelectedItem;
                decimal tutar = Convert.ToDecimal(txtIslemTutar.Text);

                
                banka.ParaCek(secilenHesap, tutar);

                MessageBox.Show($"{tutar} TL başarıyla çekildi.\nGüncel Bakiye: {secilenHesap.Bakiye} TL\nKalan Ek Hesap: {secilenHesap.EkHesap} TL", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIslemTutar.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tutarı sadece rakam kullanarak giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbIslemMusteri.SelectedItem == null || cmbIslemHesap.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen işlem yapılacak müşteri ve hesabı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIslemTutar.Text))
                {
                    MessageBox.Show("Lütfen yatırılacak tutarı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HesapBilgileri secilenHesap = (HesapBilgileri)cmbIslemHesap.SelectedItem;
                decimal tutar = Convert.ToDecimal(txtIslemTutar.Text);

                
                banka.ParaYatir(secilenHesap, tutar);

                MessageBox.Show($"{tutar} TL başarıyla yatırıldı.\nGüncel Bakiye: {secilenHesap.Bakiye} TL", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIslemTutar.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tutarı sadece rakam kullanarak giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbHavaleGonderenMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHavaleGonderenMusteri.SelectedItem != null)
            {
                MusteriBilgileri secilenMusteri = (MusteriBilgileri)cmbHavaleGonderenMusteri.SelectedItem;
                cmbHavaleGonderenHesap.DataSource = null;
                cmbHavaleGonderenHesap.DataSource = secilenMusteri.Hesaplar;
                cmbHavaleGonderenHesap.DisplayMember = "HesapNo";
            }
        }

        private void cmbHavaleAliciMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHavaleAliciMusteri.SelectedItem != null)
            {
                MusteriBilgileri secilenMusteri = (MusteriBilgileri)cmbHavaleAliciMusteri.SelectedItem;
                cmbHavaleAliciHesap.DataSource = null;
                cmbHavaleAliciHesap.DataSource = secilenMusteri.Hesaplar;
                cmbHavaleAliciHesap.DisplayMember = "HesapNo";
            }
        }

        private void btnHavaleGonder_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbHavaleGonderenMusteri.SelectedItem == null || cmbHavaleGonderenHesap.SelectedItem == null ||
                    cmbHavaleAliciMusteri.SelectedItem == null || cmbHavaleAliciHesap.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen gönderen ve alıcı bilgilerini eksiksiz seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtHavaleTutar.Text))
                {
                    MessageBox.Show("Lütfen havale tutarını giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                MusteriBilgileri gonderenMusteri = (MusteriBilgileri)cmbHavaleGonderenMusteri.SelectedItem;
                HesapBilgileri gonderenHesap = (HesapBilgileri)cmbHavaleGonderenHesap.SelectedItem;

                MusteriBilgileri aliciMusteri = (MusteriBilgileri)cmbHavaleAliciMusteri.SelectedItem;
                HesapBilgileri aliciHesap = (HesapBilgileri)cmbHavaleAliciHesap.SelectedItem;

                decimal tutar = Convert.ToDecimal(txtHavaleTutar.Text);

                
                if (gonderenHesap.HesapNo == aliciHesap.HesapNo)
                {
                    MessageBox.Show("Aynı hesaba havale yapamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                banka.HavaleYap(gonderenMusteri, gonderenHesap, aliciHesap, tutar);

                MessageBox.Show("Havale işlemi başarıyla gerçekleşti!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHavaleTutar.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen tutarı sadece rakam kullanarak giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void cmbRaporMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRaporMusteri.SelectedItem != null)
            {
                MusteriBilgileri secilenMusteri = (MusteriBilgileri)cmbRaporMusteri.SelectedItem;
                cmbRaporHesap.DataSource = null;
                cmbRaporHesap.DataSource = secilenMusteri.Hesaplar;
                cmbRaporHesap.DisplayMember = "HesapNo";
            }
        }

        private void btnHesapOzetiGetir_Click(object sender, EventArgs e)
        {
            if (cmbRaporMusteri.SelectedItem == null || cmbRaporHesap.SelectedItem == null)
            {
                MessageBox.Show("Lütfen müşteri ve hesap seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HesapBilgileri secilenHesap = (HesapBilgileri)cmbRaporHesap.SelectedItem;

            
            DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddTicks(-1); 

            
            var filtrelenmisIslemler = secilenHesap.HesapOzeti
                .Where(islem => islem.Tarih >= baslangicTarihi && islem.Tarih <= bitisTarihi)
                .ToList();

            if (filtrelenmisIslemler.Count == 0)
            {
                MessageBox.Show("Seçilen tarih aralığında hiçbir işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            dgvRaporlar.Columns.Clear();

            dgvRaporlar.DataSource = null;
            dgvRaporlar.DataSource = filtrelenmisIslemler;



            if (dgvRaporlar.Columns.Count > 0)
            {
                dgvRaporlar.Columns["Tarih"].Width = 120;
                dgvRaporlar.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvRaporlar.Columns["IslemTipi"].HeaderText = "İşlem Tipi";
                dgvRaporlar.Columns["Miktar"].DefaultCellStyle.Format = "C2"; 
                dgvRaporlar.Columns["Aciklama"].HeaderText = "Açıklama / Detay";
                dgvRaporlar.Columns["Aciklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

       

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbHesapKapatMusteri.SelectedItem == null || cmbKapatilacakHesap.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen önce müşteri ve kapatılacak hesabı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                MusteriBilgileri secilenMusteri = (MusteriBilgileri)cmbHesapKapatMusteri.SelectedItem;
                HesapBilgileri secilenHesap = (HesapBilgileri)cmbKapatilacakHesap.SelectedItem;

                
                banka.HesapKapat(secilenMusteri, secilenHesap);

                MessageBox.Show($"{secilenHesap.HesapNo} numaralı hesap başarıyla kapatıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                cmbHesapKapatMusteri_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Yanlışlıkla tıkladığım boş metotları silemediğim için burada topladım.
        private void label16_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtIslemTutar_TextChanged(object sender, EventArgs e) { }

        private void label11_Click(object sender, EventArgs e) { }

        private void lblBankaToplamPara_Click(object sender, EventArgs e)
        {

        }
    }
}
    

