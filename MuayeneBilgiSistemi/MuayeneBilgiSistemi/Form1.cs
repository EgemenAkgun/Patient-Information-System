using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneBilgiSistemi
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Host=172.17.0.1;port=5432;Username=postgres;Password=123;Database=muayenebilgi";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            VerileriYukle();
            
        }
        private void VerileriYukle()
        {
            // PostgreSQL veritabanından hasta verilerini çek ve DataGridView kontrolüne yükle
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string sorgu = "SELECT * FROM HASTA";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewHastalar.DataSource = dataTable;
                }
            }
        }

        private void btnHastKayit_Click(object sender, EventArgs e)
        {
            // Hasta bilgilerini güncellemek için işlem
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string sorgu = "UPDATE HASTA SET adsoyad=@adsoyad, telefon=@telefon, dogum_tarihi=@dogum_tarihi, " +
                               "dogum_yeri=@dogum_yeri, adres=@adres, hastalik=@hastalik, ilac=@ilac WHERE tc=@tc";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, connection))
                {
                    cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyadGuncelle.Text);
                    cmd.Parameters.AddWithValue("@telefon", txtTelefonGuncelle.Text);
                    cmd.Parameters.AddWithValue("@dogum_tarihi", dtpDogumTarihiGuncelle.Value);
                    cmd.Parameters.AddWithValue("@dogum_yeri", txtDogumYeriGuncelle.Text);
                    cmd.Parameters.AddWithValue("@adres", txtAdresGuncelle.Text);
                    cmd.Parameters.AddWithValue("@hastalik", txtHastalikGuncelle.Text);
                    cmd.Parameters.AddWithValue("@ilac", txtIlacGuncelle.Text);
                    cmd.Parameters.AddWithValue("@tc", txtTCGuncelle.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            VerileriYukle(); // Verileri güncelle
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            // Yeni hasta eklemek için işlem
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string sorgu = "INSERT INTO HASTA (adsoyad, tc, telefon, dogum_tarihi, dogum_yeri, adres, hastalik, ilac) " +
                               "VALUES (@adsoyad, @tc, @telefon, @dogum_tarihi, @dogum_yeri, @adres, @hastalik, @ilac)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, connection))
                {
                    cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    cmd.Parameters.AddWithValue("@tc", txtTC.Text);
                    cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@dogum_tarihi", dtpDogumTarihi.Value);
                    cmd.Parameters.AddWithValue("@dogum_yeri", txtDogumYeri.Text);
                    cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                    cmd.Parameters.AddWithValue("@hastalik", txtHastalik.Text);
                    cmd.Parameters.AddWithValue("@ilac", txtIlac.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            VerileriYukle(); // Verileri güncelle
        }

        private void btnHastaSil_Click_1(object sender, EventArgs e)
        {
            // Hasta silmek için işlem
            DialogResult result = MessageBox.Show("Hasta silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sorgu = "DELETE FROM HASTA WHERE tc=@tc";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, connection))
                    {
                        cmd.Parameters.AddWithValue("@tc", txtTCSil.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                VerileriYukle(); // Verileri güncelle
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            // Hasta aramak için işlem
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string sorgu = "SELECT * FROM HASTA WHERE hastalik=@hastalik OR adsoyad=@adsoyad";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sorgu, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@hastalik", txtAraHastalik.Text);
                    adapter.SelectCommand.Parameters.AddWithValue("@adsoyad", txtAraAdSoyad.Text);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewHastalar.DataSource = dataTable;
                }
            }
        }
    }
}

