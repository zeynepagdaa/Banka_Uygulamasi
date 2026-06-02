namespace nyp_odev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMusteri = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTicari = new System.Windows.Forms.RadioButton();
            this.rbBireysel = new System.Windows.Forms.RadioButton();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.tabIslemler = new System.Windows.Forms.TabPage();
            this.gbHesapKapama = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbKapatilacakHesap = new System.Windows.Forms.ComboBox();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbHesapKapatMusteri = new System.Windows.Forms.ComboBox();
            this.gbHesapAcma = new System.Windows.Forms.GroupBox();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEkHesap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtHavaleTutar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbHavaleGonderenHesap = new System.Windows.Forms.ComboBox();
            this.cmbHavaleGonderenMusteri = new System.Windows.Forms.ComboBox();
            this.btnHavaleGonder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHavaleAliciHesap = new System.Windows.Forms.ComboBox();
            this.cmbHavaleAliciMusteri = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIslemTutar = new System.Windows.Forms.TextBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIslemHesap = new System.Windows.Forms.ComboBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.cmbIslemMusteri = new System.Windows.Forms.ComboBox();
            this.tabRaporlar = new System.Windows.Forms.TabPage();
            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHesapOzetiGetir = new System.Windows.Forms.Button();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRaporHesap = new System.Windows.Forms.ComboBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cmbRaporMusteri = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBankaToplamGelir = new System.Windows.Forms.Label();
            this.lblBankaToplamPara = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRaporuGetir = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabMusteri.SuspendLayout();
            this.tabIslemler.SuspendLayout();
            this.gbHesapKapama.SuspendLayout();
            this.gbHesapAcma.SuspendLayout();
            this.tabTransfer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabRaporlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMusteri);
            this.tabControl.Controls.Add(this.tabIslemler);
            this.tabControl.Controls.Add(this.tabTransfer);
            this.tabControl.Controls.Add(this.tabRaporlar);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(808, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabMusteri
            // 
            this.tabMusteri.Controls.Add(this.label4);
            this.tabMusteri.Controls.Add(this.rbTicari);
            this.tabMusteri.Controls.Add(this.rbBireysel);
            this.tabMusteri.Controls.Add(this.btnMusteriEkle);
            this.tabMusteri.Controls.Add(this.label2);
            this.tabMusteri.Controls.Add(this.label1);
            this.tabMusteri.Controls.Add(this.txtMusteriSoyad);
            this.tabMusteri.Controls.Add(this.txtMusteriAd);
            this.tabMusteri.Location = new System.Drawing.Point(4, 25);
            this.tabMusteri.Name = "tabMusteri";
            this.tabMusteri.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusteri.Size = new System.Drawing.Size(800, 421);
            this.tabMusteri.TabIndex = 0;
            this.tabMusteri.Text = "Müşteri Bilgileri";
            this.tabMusteri.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(238, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "YENİ MÜŞTERİ KAYDI";
            // 
            // rbTicari
            // 
            this.rbTicari.AutoSize = true;
            this.rbTicari.Location = new System.Drawing.Point(357, 225);
            this.rbTicari.Name = "rbTicari";
            this.rbTicari.Size = new System.Drawing.Size(108, 20);
            this.rbTicari.TabIndex = 14;
            this.rbTicari.TabStop = true;
            this.rbTicari.Text = "Ticari Müşteri";
            this.rbTicari.UseVisualStyleBackColor = true;
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Location = new System.Drawing.Point(216, 225);
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Size = new System.Drawing.Size(123, 20);
            this.rbBireysel.TabIndex = 13;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel Müşteri";
            this.rbBireysel.UseVisualStyleBackColor = true;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(304, 284);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(134, 49);
            this.btnMusteriEkle.TabIndex = 12;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(182, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(209, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(270, 159);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(224, 22);
            this.txtMusteriSoyad.TabIndex = 7;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(270, 102);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(224, 22);
            this.txtMusteriAd.TabIndex = 6;
            // 
            // tabIslemler
            // 
            this.tabIslemler.Controls.Add(this.gbHesapKapama);
            this.tabIslemler.Controls.Add(this.gbHesapAcma);
            this.tabIslemler.Location = new System.Drawing.Point(4, 25);
            this.tabIslemler.Name = "tabIslemler";
            this.tabIslemler.Padding = new System.Windows.Forms.Padding(3);
            this.tabIslemler.Size = new System.Drawing.Size(800, 421);
            this.tabIslemler.TabIndex = 1;
            this.tabIslemler.Text = "Hesap İşlemleri";
            this.tabIslemler.UseVisualStyleBackColor = true;
            // 
            // gbHesapKapama
            // 
            this.gbHesapKapama.Controls.Add(this.label18);
            this.gbHesapKapama.Controls.Add(this.cmbKapatilacakHesap);
            this.gbHesapKapama.Controls.Add(this.btnHesapKapat);
            this.gbHesapKapama.Controls.Add(this.label8);
            this.gbHesapKapama.Controls.Add(this.cmbHesapKapatMusteri);
            this.gbHesapKapama.Location = new System.Drawing.Point(402, 6);
            this.gbHesapKapama.Name = "gbHesapKapama";
            this.gbHesapKapama.Size = new System.Drawing.Size(390, 412);
            this.gbHesapKapama.TabIndex = 1;
            this.gbHesapKapama.TabStop = false;
            this.gbHesapKapama.Text = "Hesap Kapatma";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(50, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 25);
            this.label18.TabIndex = 6;
            this.label18.Text = "Hesap:";
            // 
            // cmbKapatilacakHesap
            // 
            this.cmbKapatilacakHesap.FormattingEnabled = true;
            this.cmbKapatilacakHesap.Location = new System.Drawing.Point(122, 121);
            this.cmbKapatilacakHesap.Name = "cmbKapatilacakHesap";
            this.cmbKapatilacakHesap.Size = new System.Drawing.Size(175, 24);
            this.cmbKapatilacakHesap.TabIndex = 5;
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.Location = new System.Drawing.Point(112, 196);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(146, 55);
            this.btnHesapKapat.TabIndex = 4;
            this.btnHesapKapat.Text = "Hesabı Kapat";
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(41, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Müşteri:";
            // 
            // cmbHesapKapatMusteri
            // 
            this.cmbHesapKapatMusteri.FormattingEnabled = true;
            this.cmbHesapKapatMusteri.Location = new System.Drawing.Point(122, 62);
            this.cmbHesapKapatMusteri.Name = "cmbHesapKapatMusteri";
            this.cmbHesapKapatMusteri.Size = new System.Drawing.Size(175, 24);
            this.cmbHesapKapatMusteri.TabIndex = 2;
            this.cmbHesapKapatMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbHesapKapatMusteri_SelectedIndexChanged);
            // 
            // gbHesapAcma
            // 
            this.gbHesapAcma.Controls.Add(this.btnHesapAc);
            this.gbHesapAcma.Controls.Add(this.label7);
            this.gbHesapAcma.Controls.Add(this.txtEkHesap);
            this.gbHesapAcma.Controls.Add(this.label5);
            this.gbHesapAcma.Controls.Add(this.cmbMusteriler);
            this.gbHesapAcma.Location = new System.Drawing.Point(8, 6);
            this.gbHesapAcma.Name = "gbHesapAcma";
            this.gbHesapAcma.Size = new System.Drawing.Size(388, 412);
            this.gbHesapAcma.TabIndex = 0;
            this.gbHesapAcma.TabStop = false;
            this.gbHesapAcma.Text = "Hesap Açma";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Location = new System.Drawing.Point(148, 196);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(146, 55);
            this.btnHesapAc.TabIndex = 6;
            this.btnHesapAc.Text = "Ek Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hesap Limiti:";
            // 
            // txtEkHesap
            // 
            this.txtEkHesap.Location = new System.Drawing.Point(148, 125);
            this.txtEkHesap.Name = "txtEkHesap";
            this.txtEkHesap.Size = new System.Drawing.Size(175, 22);
            this.txtEkHesap.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müşteri:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(148, 65);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(175, 24);
            this.cmbMusteriler.TabIndex = 0;
            this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabTransfer
            // 
            this.tabTransfer.Controls.Add(this.groupBox2);
            this.tabTransfer.Controls.Add(this.groupBox1);
            this.tabTransfer.Location = new System.Drawing.Point(4, 25);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransfer.Size = new System.Drawing.Size(800, 421);
            this.tabTransfer.TabIndex = 2;
            this.tabTransfer.Text = "Para Transfer";
            this.tabTransfer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtHavaleTutar);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cmbHavaleGonderenHesap);
            this.groupBox2.Controls.Add(this.cmbHavaleGonderenMusteri);
            this.groupBox2.Controls.Add(this.btnHavaleGonder);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbHavaleAliciHesap);
            this.groupBox2.Controls.Add(this.cmbHavaleAliciMusteri);
            this.groupBox2.Location = new System.Drawing.Point(386, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Başka Hesaba Havale";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(121, 266);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 25);
            this.label21.TabIndex = 13;
            this.label21.Text = "Tutar:";
            // 
            // txtHavaleTutar
            // 
            this.txtHavaleTutar.Location = new System.Drawing.Point(195, 266);
            this.txtHavaleTutar.Name = "txtHavaleTutar";
            this.txtHavaleTutar.Size = new System.Drawing.Size(207, 22);
            this.txtHavaleTutar.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(29, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 25);
            this.label19.TabIndex = 12;
            this.label19.Text = "Gönderen Hesap:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(19, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(158, 25);
            this.label20.TabIndex = 11;
            this.label20.Text = "Gönderen Müşteri:";
            // 
            // cmbHavaleGonderenHesap
            // 
            this.cmbHavaleGonderenHesap.FormattingEnabled = true;
            this.cmbHavaleGonderenHesap.Location = new System.Drawing.Point(195, 95);
            this.cmbHavaleGonderenHesap.Name = "cmbHavaleGonderenHesap";
            this.cmbHavaleGonderenHesap.Size = new System.Drawing.Size(207, 24);
            this.cmbHavaleGonderenHesap.TabIndex = 10;
            // 
            // cmbHavaleGonderenMusteri
            // 
            this.cmbHavaleGonderenMusteri.FormattingEnabled = true;
            this.cmbHavaleGonderenMusteri.Location = new System.Drawing.Point(195, 41);
            this.cmbHavaleGonderenMusteri.Name = "cmbHavaleGonderenMusteri";
            this.cmbHavaleGonderenMusteri.Size = new System.Drawing.Size(207, 24);
            this.cmbHavaleGonderenMusteri.TabIndex = 9;
            this.cmbHavaleGonderenMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbHavaleGonderenMusteri_SelectedIndexChanged);
            // 
            // btnHavaleGonder
            // 
            this.btnHavaleGonder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavaleGonder.Location = new System.Drawing.Point(147, 340);
            this.btnHavaleGonder.Name = "btnHavaleGonder";
            this.btnHavaleGonder.Size = new System.Drawing.Size(111, 49);
            this.btnHavaleGonder.TabIndex = 8;
            this.btnHavaleGonder.Text = "GÖNDER";
            this.btnHavaleGonder.UseVisualStyleBackColor = true;
            this.btnHavaleGonder.Click += new System.EventHandler(this.btnHavaleGonder_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(75, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Alıcı Hesap:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(65, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Alıcı Müşteri:";
            // 
            // cmbHavaleAliciHesap
            // 
            this.cmbHavaleAliciHesap.FormattingEnabled = true;
            this.cmbHavaleAliciHesap.Location = new System.Drawing.Point(195, 209);
            this.cmbHavaleAliciHesap.Name = "cmbHavaleAliciHesap";
            this.cmbHavaleAliciHesap.Size = new System.Drawing.Size(207, 24);
            this.cmbHavaleAliciHesap.TabIndex = 4;
            // 
            // cmbHavaleAliciMusteri
            // 
            this.cmbHavaleAliciMusteri.FormattingEnabled = true;
            this.cmbHavaleAliciMusteri.Location = new System.Drawing.Point(195, 151);
            this.cmbHavaleAliciMusteri.Name = "cmbHavaleAliciMusteri";
            this.cmbHavaleAliciMusteri.Size = new System.Drawing.Size(207, 24);
            this.cmbHavaleAliciMusteri.TabIndex = 3;
            this.cmbHavaleAliciMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbHavaleAliciMusteri_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIslemTutar);
            this.groupBox1.Controls.Add(this.btnParaYatir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbIslemHesap);
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Controls.Add(this.cmbIslemMusteri);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Çek/Yatır";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(27, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tutar:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hesap:";
            // 
            // txtIslemTutar
            // 
            this.txtIslemTutar.Location = new System.Drawing.Point(102, 123);
            this.txtIslemTutar.Name = "txtIslemTutar";
            this.txtIslemTutar.Size = new System.Drawing.Size(214, 22);
            this.txtIslemTutar.TabIndex = 6;
            this.txtIslemTutar.TextChanged += new System.EventHandler(this.txtIslemTutar_TextChanged);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.Location = new System.Drawing.Point(196, 214);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(111, 49);
            this.btnParaYatir.TabIndex = 7;
            this.btnParaYatir.Text = "YATIR";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri:";
            // 
            // cmbIslemHesap
            // 
            this.cmbIslemHesap.FormattingEnabled = true;
            this.cmbIslemHesap.Location = new System.Drawing.Point(102, 78);
            this.cmbIslemHesap.Name = "cmbIslemHesap";
            this.cmbIslemHesap.Size = new System.Drawing.Size(214, 24);
            this.cmbIslemHesap.TabIndex = 3;
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(59, 214);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(111, 49);
            this.btnParaCek.TabIndex = 6;
            this.btnParaCek.Text = "ÇEK";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // cmbIslemMusteri
            // 
            this.cmbIslemMusteri.FormattingEnabled = true;
            this.cmbIslemMusteri.Location = new System.Drawing.Point(102, 34);
            this.cmbIslemMusteri.Name = "cmbIslemMusteri";
            this.cmbIslemMusteri.Size = new System.Drawing.Size(214, 24);
            this.cmbIslemMusteri.TabIndex = 2;
            this.cmbIslemMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbIslemMusteri_SelectedIndexChanged);
            // 
            // tabRaporlar
            // 
            this.tabRaporlar.Controls.Add(this.dgvRaporlar);
            this.tabRaporlar.Controls.Add(this.groupBox4);
            this.tabRaporlar.Controls.Add(this.groupBox3);
            this.tabRaporlar.Location = new System.Drawing.Point(4, 25);
            this.tabRaporlar.Name = "tabRaporlar";
            this.tabRaporlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRaporlar.Size = new System.Drawing.Size(800, 421);
            this.tabRaporlar.TabIndex = 3;
            this.tabRaporlar.Text = "Raporlar";
            this.tabRaporlar.UseVisualStyleBackColor = true;
            // 
            // dgvRaporlar
            // 
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporlar.Location = new System.Drawing.Point(8, 261);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.RowHeadersWidth = 51;
            this.dgvRaporlar.RowTemplate.Height = 24;
            this.dgvRaporlar.Size = new System.Drawing.Size(789, 154);
            this.dgvRaporlar.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHesapOzetiGetir);
            this.groupBox4.Controls.Add(this.dtpBitis);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cmbRaporHesap);
            this.groupBox4.Controls.Add(this.dtpBaslangic);
            this.groupBox4.Controls.Add(this.cmbRaporMusteri);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 254);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hesap Özeti";
            // 
            // btnHesapOzetiGetir
            // 
            this.btnHesapOzetiGetir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapOzetiGetir.Location = new System.Drawing.Point(148, 185);
            this.btnHesapOzetiGetir.Name = "btnHesapOzetiGetir";
            this.btnHesapOzetiGetir.Size = new System.Drawing.Size(152, 53);
            this.btnHesapOzetiGetir.TabIndex = 8;
            this.btnHesapOzetiGetir.Text = "Özeti Getir";
            this.btnHesapOzetiGetir.UseVisualStyleBackColor = true;
            this.btnHesapOzetiGetir.Click += new System.EventHandler(this.btnHesapOzetiGetir_Click);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(306, 140);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(69, 22);
            this.dtpBitis.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(221, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Bitiş Tarihi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Başlangıç Tarihi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(76, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Hesap:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(67, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Müşteri:";
            // 
            // cmbRaporHesap
            // 
            this.cmbRaporHesap.FormattingEnabled = true;
            this.cmbRaporHesap.Location = new System.Drawing.Point(148, 84);
            this.cmbRaporHesap.Name = "cmbRaporHesap";
            this.cmbRaporHesap.Size = new System.Drawing.Size(217, 24);
            this.cmbRaporHesap.TabIndex = 2;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(136, 140);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(69, 22);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // cmbRaporMusteri
            // 
            this.cmbRaporMusteri.FormattingEnabled = true;
            this.cmbRaporMusteri.Location = new System.Drawing.Point(148, 24);
            this.cmbRaporMusteri.Name = "cmbRaporMusteri";
            this.cmbRaporMusteri.Size = new System.Drawing.Size(217, 24);
            this.cmbRaporMusteri.TabIndex = 0;
            this.cmbRaporMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbRaporMusteri_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBankaToplamGelir);
            this.groupBox3.Controls.Add(this.lblBankaToplamPara);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnRaporuGetir);
            this.groupBox3.Location = new System.Drawing.Point(414, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 252);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Banka Genel Durumu";
            // 
            // lblBankaToplamGelir
            // 
            this.lblBankaToplamGelir.AutoSize = true;
            this.lblBankaToplamGelir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankaToplamGelir.Location = new System.Drawing.Point(139, 107);
            this.lblBankaToplamGelir.Name = "lblBankaToplamGelir";
            this.lblBankaToplamGelir.Size = new System.Drawing.Size(24, 25);
            this.lblBankaToplamGelir.TabIndex = 6;
            this.lblBankaToplamGelir.Text = "...";
            // 
            // lblBankaToplamPara
            // 
            this.lblBankaToplamPara.AutoSize = true;
            this.lblBankaToplamPara.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankaToplamPara.Location = new System.Drawing.Point(137, 34);
            this.lblBankaToplamPara.Name = "lblBankaToplamPara";
            this.lblBankaToplamPara.Size = new System.Drawing.Size(24, 25);
            this.lblBankaToplamPara.TabIndex = 5;
            this.lblBankaToplamPara.Text = "...";
            this.lblBankaToplamPara.Click += new System.EventHandler(this.lblBankaToplamPara_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(17, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "Toplam Gelir:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(17, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Toplam Para:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // btnRaporuGetir
            // 
            this.btnRaporuGetir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporuGetir.Location = new System.Drawing.Point(104, 174);
            this.btnRaporuGetir.Name = "btnRaporuGetir";
            this.btnRaporuGetir.Size = new System.Drawing.Size(152, 53);
            this.btnRaporuGetir.TabIndex = 0;
            this.btnRaporuGetir.Text = "Raporu Getir";
            this.btnRaporuGetir.UseVisualStyleBackColor = true;
            this.btnRaporuGetir.Click += new System.EventHandler(this.btnRaporuGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMusteri.ResumeLayout(false);
            this.tabMusteri.PerformLayout();
            this.tabIslemler.ResumeLayout(false);
            this.gbHesapKapama.ResumeLayout(false);
            this.gbHesapKapama.PerformLayout();
            this.gbHesapAcma.ResumeLayout(false);
            this.gbHesapAcma.PerformLayout();
            this.tabTransfer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabRaporlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMusteri;
        private System.Windows.Forms.TabPage tabIslemler;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.TabPage tabRaporlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.RadioButton rbTicari;
        private System.Windows.Forms.RadioButton rbBireysel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbHesapKapama;
        private System.Windows.Forms.GroupBox gbHesapAcma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEkHesap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbHesapKapatMusteri;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIslemHesap;
        private System.Windows.Forms.ComboBox cmbIslemMusteri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIslemTutar;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.ComboBox cmbHavaleAliciHesap;
        private System.Windows.Forms.ComboBox cmbHavaleAliciMusteri;
        private System.Windows.Forms.Button btnHavaleGonder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRaporuGetir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbRaporHesap;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.ComboBox cmbRaporMusteri;
        private System.Windows.Forms.Button btnHesapOzetiGetir;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvRaporlar;
        private System.Windows.Forms.Label lblBankaToplamGelir;
        private System.Windows.Forms.Label lblBankaToplamPara;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbKapatilacakHesap;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbHavaleGonderenHesap;
        private System.Windows.Forms.ComboBox cmbHavaleGonderenMusteri;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtHavaleTutar;
    }
}

