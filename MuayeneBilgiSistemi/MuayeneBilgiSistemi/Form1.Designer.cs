
namespace MuayeneBilgiSistemi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtHastalik = new System.Windows.Forms.TextBox();
            this.txtIlac = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnHastKayit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.dtpDogumTarihiGuncelle = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonGuncelle = new System.Windows.Forms.TextBox();
            this.txtAdSoyadGuncelle = new System.Windows.Forms.TextBox();
            this.txtDogumYeriGuncelle = new System.Windows.Forms.TextBox();
            this.txtAdresGuncelle = new System.Windows.Forms.TextBox();
            this.txtHastalikGuncelle = new System.Windows.Forms.TextBox();
            this.txtIlacGuncelle = new System.Windows.Forms.TextBox();
            this.txtTCGuncelle = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.txtTCSil = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHastalar = new System.Windows.Forms.DataGridView();
            this.txtAraHastalik = new System.Windows.Forms.TextBox();
            this.txtAraAdSoyad = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpage1
            // 
            this.tabpage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabpage1.Controls.Add(this.label11);
            this.tabpage1.Controls.Add(this.label10);
            this.tabpage1.Controls.Add(this.label9);
            this.tabpage1.Controls.Add(this.label8);
            this.tabpage1.Controls.Add(this.label7);
            this.tabpage1.Controls.Add(this.label6);
            this.tabpage1.Controls.Add(this.label5);
            this.tabpage1.Controls.Add(this.label4);
            this.tabpage1.Controls.Add(this.txtAdSoyad);
            this.tabpage1.Controls.Add(this.txtTC);
            this.tabpage1.Controls.Add(this.txtTelefon);
            this.tabpage1.Controls.Add(this.txtDogumYeri);
            this.tabpage1.Controls.Add(this.txtAdres);
            this.tabpage1.Controls.Add(this.txtHastalik);
            this.tabpage1.Controls.Add(this.txtIlac);
            this.tabpage1.Controls.Add(this.dtpDogumTarihi);
            this.tabpage1.Controls.Add(this.btnHastKayit);
            this.tabpage1.Location = new System.Drawing.Point(4, 25);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(796, 415);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Hasta Kayıt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Doğum Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ad Soyad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "İlaç :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hastalık :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doğum Yeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(318, 49);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 8;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(318, 77);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(318, 133);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(318, 173);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(100, 22);
            this.txtDogumYeri.TabIndex = 5;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(318, 201);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 4;
            // 
            // txtHastalik
            // 
            this.txtHastalik.Location = new System.Drawing.Point(318, 229);
            this.txtHastalik.Name = "txtHastalik";
            this.txtHastalik.Size = new System.Drawing.Size(100, 22);
            this.txtHastalik.TabIndex = 3;
            // 
            // txtIlac
            // 
            this.txtIlac.Location = new System.Drawing.Point(318, 257);
            this.txtIlac.Name = "txtIlac";
            this.txtIlac.Size = new System.Drawing.Size(100, 22);
            this.txtIlac.TabIndex = 2;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(318, 105);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpDogumTarihi.TabIndex = 1;
            // 
            // btnHastKayit
            // 
            this.btnHastKayit.Location = new System.Drawing.Point(318, 285);
            this.btnHastKayit.Name = "btnHastKayit";
            this.btnHastKayit.Size = new System.Drawing.Size(156, 48);
            this.btnHastKayit.TabIndex = 0;
            this.btnHastKayit.Text = "Kaydet";
            this.btnHastKayit.UseVisualStyleBackColor = true;
            this.btnHastKayit.Click += new System.EventHandler(this.btnHastKayit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnHastaGuncelle);
            this.tabPage2.Controls.Add(this.dtpDogumTarihiGuncelle);
            this.tabPage2.Controls.Add(this.txtTelefonGuncelle);
            this.tabPage2.Controls.Add(this.txtAdSoyadGuncelle);
            this.tabPage2.Controls.Add(this.txtDogumYeriGuncelle);
            this.tabPage2.Controls.Add(this.txtAdresGuncelle);
            this.tabPage2.Controls.Add(this.txtHastalikGuncelle);
            this.tabPage2.Controls.Add(this.txtIlacGuncelle);
            this.tabPage2.Controls.Add(this.txtTCGuncelle);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hasta Güncelle";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(246, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 17);
            this.label19.TabIndex = 23;
            this.label19.Text = "TC:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(232, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "İlaç :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(219, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "Hastalık :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(232, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Adres :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(203, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Doğum Yeri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Doğum Tarihi :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Telefon Numarası:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ad Soyad:";
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.Location = new System.Drawing.Point(291, 310);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(132, 37);
            this.btnHastaGuncelle.TabIndex = 8;
            this.btnHastaGuncelle.Text = "Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = true;
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // dtpDogumTarihiGuncelle
            // 
            this.dtpDogumTarihiGuncelle.Location = new System.Drawing.Point(291, 170);
            this.dtpDogumTarihiGuncelle.Name = "dtpDogumTarihiGuncelle";
            this.dtpDogumTarihiGuncelle.Size = new System.Drawing.Size(200, 22);
            this.dtpDogumTarihiGuncelle.TabIndex = 7;
            // 
            // txtTelefonGuncelle
            // 
            this.txtTelefonGuncelle.Location = new System.Drawing.Point(291, 130);
            this.txtTelefonGuncelle.Name = "txtTelefonGuncelle";
            this.txtTelefonGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtTelefonGuncelle.TabIndex = 6;
            // 
            // txtAdSoyadGuncelle
            // 
            this.txtAdSoyadGuncelle.Location = new System.Drawing.Point(291, 102);
            this.txtAdSoyadGuncelle.Name = "txtAdSoyadGuncelle";
            this.txtAdSoyadGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyadGuncelle.TabIndex = 5;
            // 
            // txtDogumYeriGuncelle
            // 
            this.txtDogumYeriGuncelle.Location = new System.Drawing.Point(291, 198);
            this.txtDogumYeriGuncelle.Name = "txtDogumYeriGuncelle";
            this.txtDogumYeriGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtDogumYeriGuncelle.TabIndex = 4;
            // 
            // txtAdresGuncelle
            // 
            this.txtAdresGuncelle.Location = new System.Drawing.Point(291, 226);
            this.txtAdresGuncelle.Name = "txtAdresGuncelle";
            this.txtAdresGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtAdresGuncelle.TabIndex = 3;
            // 
            // txtHastalikGuncelle
            // 
            this.txtHastalikGuncelle.Location = new System.Drawing.Point(291, 254);
            this.txtHastalikGuncelle.Name = "txtHastalikGuncelle";
            this.txtHastalikGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtHastalikGuncelle.TabIndex = 2;
            // 
            // txtIlacGuncelle
            // 
            this.txtIlacGuncelle.Location = new System.Drawing.Point(291, 282);
            this.txtIlacGuncelle.Name = "txtIlacGuncelle";
            this.txtIlacGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtIlacGuncelle.TabIndex = 1;
            // 
            // txtTCGuncelle
            // 
            this.txtTCGuncelle.Location = new System.Drawing.Point(291, 16);
            this.txtTCGuncelle.Name = "txtTCGuncelle";
            this.txtTCGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtTCGuncelle.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnHastaSil);
            this.tabPage3.Controls.Add(this.txtTCSil);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hasta Sil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "tc no:";
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.Location = new System.Drawing.Point(284, 189);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(109, 39);
            this.btnHastaSil.TabIndex = 1;
            this.btnHastaSil.Text = "Sil";
            this.btnHastaSil.UseVisualStyleBackColor = true;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click_1);
            // 
            // txtTCSil
            // 
            this.txtTCSil.Location = new System.Drawing.Point(284, 151);
            this.txtTCSil.Name = "txtTCSil";
            this.txtTCSil.Size = new System.Drawing.Size(227, 22);
            this.txtTCSil.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.btnAra);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.dataGridViewHastalar);
            this.tabPage4.Controls.Add(this.txtAraHastalik);
            this.tabPage4.Controls.Add(this.txtAraAdSoyad);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(796, 415);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hasta Görüntüle";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(315, 125);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(129, 49);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Görüntüle";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hastalık Adı:";
            // 
            // dataGridViewHastalar
            // 
            this.dataGridViewHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastalar.Location = new System.Drawing.Point(28, 191);
            this.dataGridViewHastalar.Name = "dataGridViewHastalar";
            this.dataGridViewHastalar.RowHeadersWidth = 51;
            this.dataGridViewHastalar.RowTemplate.Height = 24;
            this.dataGridViewHastalar.Size = new System.Drawing.Size(718, 218);
            this.dataGridViewHastalar.TabIndex = 2;
            // 
            // txtAraHastalik
            // 
            this.txtAraHastalik.Location = new System.Drawing.Point(344, 55);
            this.txtAraHastalik.Name = "txtAraHastalik";
            this.txtAraHastalik.Size = new System.Drawing.Size(100, 22);
            this.txtAraHastalik.TabIndex = 1;
            // 
            // txtAraAdSoyad
            // 
            this.txtAraAdSoyad.Location = new System.Drawing.Point(344, 83);
            this.txtAraAdSoyad.Name = "txtAraAdSoyad";
            this.txtAraAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAraAdSoyad.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtHastalik;
        private System.Windows.Forms.TextBox txtIlac;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnHastKayit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihiGuncelle;
        private System.Windows.Forms.TextBox txtTelefonGuncelle;
        private System.Windows.Forms.TextBox txtAdSoyadGuncelle;
        private System.Windows.Forms.TextBox txtDogumYeriGuncelle;
        private System.Windows.Forms.TextBox txtAdresGuncelle;
        private System.Windows.Forms.TextBox txtHastalikGuncelle;
        private System.Windows.Forms.TextBox txtIlacGuncelle;
        private System.Windows.Forms.TextBox txtTCGuncelle;
        private System.Windows.Forms.TextBox txtTCSil;
        private System.Windows.Forms.DataGridView dataGridViewHastalar;
        private System.Windows.Forms.TextBox txtAraHastalik;
        private System.Windows.Forms.TextBox txtAraAdSoyad;
        private System.Windows.Forms.Button btnHastaGuncelle;
        private System.Windows.Forms.Button btnHastaSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAra;
    }
}

