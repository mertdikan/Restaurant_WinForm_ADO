using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarlaRestaurant_Ado
{
    public partial class FormMusteriSiparis : Form
    {
        public FormMusteriSiparis()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void FormMusteriSiparis_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        private void MusterileriGetir()
        {
            SqlCommand cmd = new SqlCommand("select MusteriID,Adi,Soyadi,Adres,Telefon from Musteri", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewMusteri.DataSource = dt;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Musteri(Adi,Soyadi,Adres,Telefon) values (@ad,@soyad,@adres,@tel)", conn);
            cmd.Parameters.AddWithValue("@ad", txtMusteriAdi.Text);
            cmd.Parameters.AddWithValue("@soyad", txtMusteriSoyadi.Text);
            cmd.Parameters.AddWithValue("@adres", txtMusteriAdres.Text);
            cmd.Parameters.AddWithValue("@tel", txtMusteriTel.Text);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewMusteri.DataSource = dt;
            MusterileriGetir();
            TemizleMusteri();
        }

        private void TemizleMusteri()
        {
            foreach (var item in groupbox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }
            }
        }

        private void dataGridViewMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMusteri.SelectedRows.Count > 0)
            {
                txtMusteriAdi.Text = dataGridViewMusteri.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMusteriSoyadi.Text = dataGridViewMusteri.CurrentRow.Cells[2].Value.ToString();
                txtMusteriAdres.Text = dataGridViewMusteri.CurrentRow.Cells[3].Value.ToString();
                txtMusteriTel.Text = dataGridViewMusteri.CurrentRow.Cells[4].Value.ToString();

            }

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Musteri Set Adi=@ad,Soyadi=@soyad,Adres=@adres,Telefon=@tel where MusteriID=@musId", conn);
            int id = Convert.ToInt32(dataGridViewMusteri.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@musId", id);
            cmd.Parameters.AddWithValue("@ad", txtMusteriAdi.Text);
            cmd.Parameters.AddWithValue("@soyad", txtMusteriSoyadi.Text);
            cmd.Parameters.AddWithValue("@adres", txtMusteriAdres.Text);
            cmd.Parameters.AddWithValue("@tel", txtMusteriTel.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MusterileriGetir();
            TemizleMusteri();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  Musteri where MusteriID=@musId", conn);
            int id = Convert.ToInt32(dataGridViewMusteri.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@musId", id);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MusterileriGetir();
            TemizleMusteri();
        }


        //SİPARİS

        private void btnSiparisGetir_Click(object sender, EventArgs e)
        {
            SiparisGetir();
        }

        private void SiparisGetir()
        {
            SqlCommand cmd = new SqlCommand("select SiparisID,SiparisTarihi,TeslimTarihi,SiparisTuru,MasaNumarası,MusteriID,CalisanId from Siparis", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewSiparis.DataSource = dt;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Siparis(SiparisTarihi,TeslimTarihi,SiparisTuru,MasaNumarası,MusteriID,CalisanId) values (@sipTarihi,@tesTarihi,@sipTuru,@masaNo,@musId,@calId)", conn);
            cmd.Parameters.AddWithValue("@sipTarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@tesTarihi", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@sipTuru", checkBoxSipTuru.Checked);
            cmd.Parameters.AddWithValue("@masaNo", txtSiparisMasaNo.Text);
            cmd.Parameters.AddWithValue("@musId", txtSiparisMusteriId.Text);
            cmd.Parameters.AddWithValue("@calId", txtSiparisCalisanId.Text);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewSiparis.DataSource = dt;
            SiparisGetir();
            TemizleSiparis();
        }

        private void dataGridViewSiparis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSiparis.SelectedRows.Count > 0)
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewSiparis.CurrentRow.Cells[1].Value);
                dateTimePicker2.Value = Convert.ToDateTime(dataGridViewSiparis.CurrentRow.Cells[2].Value);
                checkBoxSipTuru.Checked =Convert.ToBoolean(dataGridViewSiparis.CurrentRow.Cells[3].Value);
                txtSiparisMasaNo.Text = dataGridViewSiparis.CurrentRow.Cells[4].Value.ToString();
                txtSiparisMusteriId.Text = dataGridViewSiparis.CurrentRow.Cells[5].Value.ToString();
                txtSiparisCalisanId.Text = dataGridViewSiparis.CurrentRow.Cells[6].Value.ToString();

            }
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Siparis Set SiparisTarihi=@sipTarihi,TeslimTarihi=@tesTarihi,SiparisTuru=@sipTuru,MasaNumarası=@masaNo,MusteriID=@musId,CalisanId=@calId  where SiparisID=@sipId", conn);

            int id = Convert.ToInt32(dataGridViewSiparis.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@sipId", id);
            cmd.Parameters.AddWithValue("@sipTarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@tesTarihi", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@sipTuru", checkBoxSipTuru.Checked);
            cmd.Parameters.AddWithValue("@masaNo", Convert.ToInt32(txtSiparisMasaNo.Text));
            cmd.Parameters.AddWithValue("@musId", Convert.ToInt32(txtSiparisMusteriId.Text));
            cmd.Parameters.AddWithValue("@calId", Convert.ToInt32(txtSiparisCalisanId.Text));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SiparisGetir();
            TemizleSiparis();
        }

        private void TemizleSiparis()
        {
            foreach (var item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }
            }
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  Siparis where SiparisID=@sipId", conn);
            int id = Convert.ToInt32(dataGridViewSiparis.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@sipId", id);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SiparisGetir();
            TemizleSiparis();

        }
    }
}
