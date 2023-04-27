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
    public partial class UrunKategori : Form
    {
        public UrunKategori()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void UrunKategori_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void UrunGetir()
        {
            SqlCommand cmd = new SqlCommand("select UrunID,KategoriID,UrunAdi,UrunAciklamasi,Fiyat,Durum from Urun", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewUrun.DataSource = dt;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Urun(KategoriID,UrunAdi,UrunAciklamasi,Fiyat,Durum) values (@katID,@urunAdi,@urunAciklama,@fiyat,@durum)", conn);
            cmd.Parameters.AddWithValue("@katID", txtKategoriId.Text);
            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@urunAciklama", txtUrunAciklamasi.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            cmd.Parameters.AddWithValue("@durum", checkBox1.Checked);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewUrun.DataSource = dt;
            UrunGetir();
            TemizleUrun();
        }

        private void TemizleUrun()
        {
            foreach (var item in groupBoxUrun.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }
                else if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
            }
        }

        private void dataGridViewUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrun.SelectedRows.Count > 0)
            {
                txtKategoriId.Text = dataGridViewUrun.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUrunAdi.Text = dataGridViewUrun.CurrentRow.Cells[2].Value.ToString();
                txtUrunAciklamasi.Text = dataGridViewUrun.CurrentRow.Cells[3].Value.ToString();
                txtFiyat.Text = dataGridViewUrun.CurrentRow.Cells[4].Value.ToString();
                checkBox1.Checked = Convert.ToBoolean(dataGridViewUrun.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Urun Set KategoriID=@katID,UrunAdi=@urunAdi,UrunAciklamasi=@urunAciklama,Fiyat=@fiyat,Durum=@durum where UrunID=@urunId", conn);
            int id = Convert.ToInt32(dataGridViewUrun.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@urunId", id);
            cmd.Parameters.AddWithValue("@katID", txtKategoriId.Text);
            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@urunAciklama", txtUrunAciklamasi.Text);
            cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));
            cmd.Parameters.AddWithValue("@durum", checkBox1.Checked);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            UrunGetir();
            TemizleUrun();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  Urun where UrunID=@urunId", conn);
            int id = Convert.ToInt32(dataGridViewUrun.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@urunId", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            UrunGetir();
            TemizleUrun();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            SqlCommand cmd = new SqlCommand("select MenuKategoriID,MenuKategoriAdi,MenuID from MenuKategori", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewKategori.DataSource = dt;
        }

        private void btnEkleKat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert MenuKategori(MenuKategoriAdi,MenuID) values (@menuKategoriAdi,@menuID)", conn);
            cmd.Parameters.AddWithValue("@menuKategoriAdi", txtKagetoriAdi.Text);
            cmd.Parameters.AddWithValue("@menuID", txtMenuId.Text);


            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewKategori.DataSource = dt;
            KategoriGetir();
            TemizleKategori();
        }

        private void TemizleKategori()
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

        private void dataGridViewKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKategori.SelectedRows.Count > 0)
            {
                txtKagetoriAdi.Text = dataGridViewKategori.CurrentRow.Cells[1].Value.ToString();
                txtMenuId.Text = dataGridViewKategori.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void btnGuncelleKat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update MenuKategori Set MenuKategoriAdi=@menuKategoriAdi,MenuID=@menuID where MenuKategoriID=@menuKategoriID", conn);
            int id = Convert.ToInt32(dataGridViewKategori.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@menuKategoriID", id);
            cmd.Parameters.AddWithValue("@menuKategoriAdi", txtKagetoriAdi.Text);
            cmd.Parameters.AddWithValue("@menuID", txtMenuId.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            KategoriGetir();
            TemizleKategori();
        }

        private void btnSilKat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  MenuKategori where MenuKategoriID=@menuKategoriID", conn);
            int id = Convert.ToInt32(dataGridViewKategori.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@menuKategoriID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            KategoriGetir();
            TemizleKategori();
        }

       
    }
}
