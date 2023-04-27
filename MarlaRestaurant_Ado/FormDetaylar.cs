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
    public partial class FormDetaylar : Form
    {
        public FormDetaylar()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void btnUMGetir_Click(object sender, EventArgs e)
        {
            UrunMalzemeDetayGetir();
        }

        private void UrunMalzemeDetayGetir()
        {
            SqlCommand cmd = new SqlCommand("select UrunMalzemeID,UrunID,MalzemeID,MalzemeStok from UrunMalzemeDetay", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewUrunMalzemeDetay.DataSource = dt;
        }



        private void TemizleUrunMalzemeDetay()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }
            }
        }

        private void btnUMEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert UrunMalzemeDetay(UrunID,MalzemeID,MalzemeStok) values (@urunId,@malzemeID,@malzemeStok)", conn);
            cmd.Parameters.AddWithValue("@urunId", Convert.ToInt32(txtUMUrunIdDetay.Text));
            cmd.Parameters.AddWithValue("@malzemeID", Convert.ToInt32(txtUMMalzemeIdDetay.Text));
            cmd.Parameters.AddWithValue("@malzemeStok", Convert.ToInt32(txttxtUMMalzemeStokDetay.Text));

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewUrunMalzemeDetay.DataSource = dt;
            UrunMalzemeDetayGetir();
            TemizleUrunMalzemeDetay();
        }

        private void dataGridViewUrunMalzemeDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrunMalzemeDetay.SelectedRows.Count > 0)
            {
                txtUMUrunIdDetay.Text = dataGridViewUrunMalzemeDetay.CurrentRow.Cells[1].Value.ToString();
                txtUMMalzemeIdDetay.Text = dataGridViewUrunMalzemeDetay.CurrentRow.Cells[2].Value.ToString();
                txttxtUMMalzemeStokDetay.Text = dataGridViewUrunMalzemeDetay.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btnUMGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update UrunMalzemeDetay Set UrunID=@urunId,MalzemeID=@malzemeID,MalzemeStok=@malzemeStok where UrunMalzemeID=@urunMalzemeId", conn);
            int id = Convert.ToInt32(dataGridViewUrunMalzemeDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@urunMalzemeId", id);
            cmd.Parameters.AddWithValue("@urunId", txtUMUrunIdDetay.Text);
            cmd.Parameters.AddWithValue("@malzemeID", txtUMMalzemeIdDetay.Text);
            cmd.Parameters.AddWithValue("@malzemeStok", txttxtUMMalzemeStokDetay.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            UrunMalzemeDetayGetir();
            TemizleUrunMalzemeDetay();
        }

        private void btnUMSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  UrunMalzemeDetay where UrunMalzemeID=@urunMalzemeId", conn);
            int id = Convert.ToInt32(dataGridViewUrunMalzemeDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@urunMalzemeId", id);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            UrunMalzemeDetayGetir();
            TemizleUrunMalzemeDetay();
        }


        //DEPO MALZEME DETAY
        private void button1_Click(object sender, EventArgs e)
        {
            DepoMalzemeDetayGetir();
        }

        private void DepoMalzemeDetayGetir()
        {
            SqlCommand cmd = new SqlCommand("select DepoMalzemeID,DepoID,MalzemeID,DepoStok from DepoMalzemeDetay", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewDepoMalzemeDetay.DataSource = dt;
        }

        private void btnDMEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert DepoMalzemeDetay(DepoID,MalzemeID,DepoStok) values (@depoId,@dmalzemeID,@depoStok)", conn);
            cmd.Parameters.AddWithValue("@depoId", Convert.ToInt32(txtDMDepoId.Text));
            cmd.Parameters.AddWithValue("@dmalzemeID", Convert.ToInt32(txtDMMalzemeId.Text));
            cmd.Parameters.AddWithValue("@depoStok", Convert.ToInt32(txtDMDepoStok.Text));

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewDepoMalzemeDetay.DataSource = dt;
            DepoMalzemeDetayGetir();
            TemizleDepoMalzemeDetay();
        }

        private void TemizleDepoMalzemeDetay()
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

        private void dataGridViewDepoMalzemeDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDepoMalzemeDetay.SelectedRows.Count > 0)
            {
                txtDMDepoId.Text = dataGridViewDepoMalzemeDetay.CurrentRow.Cells[1].Value.ToString();
                txtDMMalzemeId.Text = dataGridViewDepoMalzemeDetay.CurrentRow.Cells[2].Value.ToString();
                txtDMDepoStok.Text = dataGridViewDepoMalzemeDetay.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btnDMGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update DepoMalzemeDetay Set DepoID=@depoId,MalzemeID=@dmalzemeID,DepoStok=@depoStok where DepoMalzemeID=@depoMalId", conn);
            int id = Convert.ToInt32(dataGridViewDepoMalzemeDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@depoMalId", id);
            cmd.Parameters.AddWithValue("@depoId", txtDMDepoId.Text);
            cmd.Parameters.AddWithValue("@dmalzemeID", txtDMMalzemeId.Text);
            cmd.Parameters.AddWithValue("@depoStok", txtDMDepoStok.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DepoMalzemeDetayGetir();
            TemizleDepoMalzemeDetay();
        }

        private void btnDMSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  DepoMalzemeDetay where DepoMalzemeID=@depoMalId", conn);
            int id = Convert.ToInt32(dataGridViewDepoMalzemeDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@depoMalId", id);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DepoMalzemeDetayGetir();
            TemizleDepoMalzemeDetay();
        }
        // RESTAURANT MALZEME DETAY
        private void btnRestaurantDetayGetir_Click(object sender, EventArgs e)
        {
            RestaurantMalzemeDetay();
        }

        private void RestaurantMalzemeDetay()
        {
            SqlCommand cmd = new SqlCommand("select RestaurantMalzemeDetay,MalzemeID,RestaurantId,RestaurantStok from RestaurantMalzemeDetay", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnResMalDetayEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert RestaurantMalzemeDetay(MalzemeID,RestaurantId,RestaurantStok) values (@malzemeID,@restaurantId,@restaurantStok)", conn);
            cmd.Parameters.AddWithValue("@malzemeID", Convert.ToInt32(txtResMalDetayMalzemeId.Text));
            cmd.Parameters.AddWithValue("@restaurantId", Convert.ToInt32(txtResMalDetayRestaurantId.Text));
            cmd.Parameters.AddWithValue("@restaurantStok", Convert.ToInt32(txtResMalDetayRestaurantStok.Text));

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView1.DataSource = dt;
            RestaurantMalzemeDetay();
            TemizleRestaurantMalzemeDetay();
        }

        private void TemizleRestaurantMalzemeDetay()
        {

            foreach (var item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtResMalDetayMalzemeId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtResMalDetayRestaurantId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtResMalDetayRestaurantStok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btnResMalDetayGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update RestaurantMalzemeDetay Set MalzemeID=@malzemeID,RestaurantId=@restaurantId,RestaurantStok=@restaurantStok where RestaurantMalzemeDetay=@resMalId", conn);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@resMalId", id);
            cmd.Parameters.AddWithValue("@malzemeID", txtResMalDetayMalzemeId.Text);
            cmd.Parameters.AddWithValue("@restaurantId", txtResMalDetayRestaurantId.Text);
            cmd.Parameters.AddWithValue("@restaurantStok", txtResMalDetayRestaurantStok.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            RestaurantMalzemeDetay();
            TemizleDepoMalzemeDetay();
        }

        private void btnResMalDetaySil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  RestaurantMalzemeDetay where RestaurantMalzemeDetay=@resMalId", conn);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@resMalId", id);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            RestaurantMalzemeDetay();
            TemizleRestaurantMalzemeDetay();
        }


        //Urun SİPARİŞ DETAY
        private void button3_Click(object sender, EventArgs e)
        {
            UrunSiparisDetay();
        }

        private void UrunSiparisDetay()
        {
            SqlCommand cmd = new SqlCommand("select UrunSiparisDetayID,UrunID,SiparisID,SiparisMiktari,Fiyat from UrunSiparisDetay", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewUrunSiparisDetay.DataSource = dt;
        }

        private void btnUrunSiparisEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert UrunSiparisDetay(UrunID,SiparisID,SiparisMiktari,Fiyat) values (@urunID,@siparisID,@siparisMiktari,@fiyat)", conn);
            cmd.Parameters.AddWithValue("@urunID", txtUrunSiparisUrunID.Text);
            cmd.Parameters.AddWithValue("@siparisID", txtUrunSiparisSiparisId.Text);
            cmd.Parameters.AddWithValue("@siparisMiktari", txtUrunSiparisStokMiktari.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtUrunSiparisFiyat.Text);


            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewUrunSiparisDetay.DataSource = dt;
            UrunSiparisDetay();
            TemizleUrunSiparisDetay();
        }

        private void TemizleUrunSiparisDetay()
        {
            foreach (var item in groupBox4.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void dataGridViewUrunSiparisDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrunSiparisDetay.SelectedRows.Count > 0)
            {
                txtUrunSiparisUrunID.Text = dataGridViewUrunSiparisDetay.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUrunSiparisSiparisId.Text = dataGridViewUrunSiparisDetay.CurrentRow.Cells[2].Value.ToString();
                txtUrunSiparisStokMiktari.Text = dataGridViewUrunSiparisDetay.CurrentRow.Cells[3].Value.ToString();
                txtUrunSiparisFiyat.Text = dataGridViewUrunSiparisDetay.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btnUrunSiparisGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update UrunSiparisDetay Set UrunID=@urunID,SiparisID=@siparisID,SiparisMiktari=@siparisMiktari,Fiyat=@fiyat where UrunSiparisDetayID=@urunSiparisDetayID", conn);

            int id = Convert.ToInt32(dataGridViewUrunSiparisDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@urunSiparisDetayID", id);
            cmd.Parameters.AddWithValue("@urunID", txtUrunSiparisUrunID.Text);
            cmd.Parameters.AddWithValue("@siparisID", txtUrunSiparisUrunID.Text);
            cmd.Parameters.AddWithValue("@siparisMiktari", txtUrunSiparisStokMiktari.Text);
            cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtUrunSiparisFiyat.Text));


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            UrunSiparisDetay();
            TemizleUrunSiparisDetay();
        }

        private void btnUrunSiparisSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  UrunSiparisDetay where UrunSiparisDetayID=@urunSiparisDetayID", conn);
            int id = Convert.ToInt32(dataGridViewUrunSiparisDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@urunSiparisDetayID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            UrunSiparisDetay();
            TemizleUrunSiparisDetay();
        }

        //Adisyon Siparis Detay
        private void btnASDGetir_Click(object sender, EventArgs e)
        {
            AdisyonSiparisDetayGetir();
        }

        private void AdisyonSiparisDetayGetir()
        {
            SqlCommand cmd = new SqlCommand("select AdisyonSiparisDetayID,SiparisID,AdisyonID from AdisyonSiparisDetay", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewAdisyonSiparisDetay.DataSource = dt;
        }

        private void btnAdisyonSiparisDetayEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert AdisyonSiparisDetay(SiparisID,AdisyonID) values (@siparisID,@adisyonID)", conn);
            cmd.Parameters.AddWithValue("@siparisID", txtAdisyonSiparisDetaySiparisId.Text);
            cmd.Parameters.AddWithValue("@adisyonID", txtAdisyonSiparisDetayAdisyonID.Text);


            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewAdisyonSiparisDetay.DataSource = dt;
            AdisyonSiparisDetayGetir();
            TemizleAdisyonSiparisDetay();
        }

        private void TemizleAdisyonSiparisDetay()
        {
            foreach (var item in groupBox5.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();

                }
            }
        }

        private void dataGridViewAdisyonSiparisDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdisyonSiparisDetay.SelectedRows.Count > 0)
            {
                txtAdisyonSiparisDetaySiparisId.Text = dataGridViewAdisyonSiparisDetay.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAdisyonSiparisDetayAdisyonID.Text = dataGridViewAdisyonSiparisDetay.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnAdisyonSiparisDetayGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update AdisyonSiparisDetay Set SiparisID=@siparisID,AdisyonID=@adisyonID where AdisyonSiparisDetay=@adisyonSiparisDetayID", conn);
            int id = Convert.ToInt32(dataGridViewAdisyonSiparisDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@adisyonSiparisDetayID", id);
            cmd.Parameters.AddWithValue("@siparisID", txtAdisyonSiparisDetaySiparisId.Text);
            cmd.Parameters.AddWithValue("@adisyonID", txtAdisyonSiparisDetayAdisyonID.Text);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            AdisyonSiparisDetayGetir();
            TemizleAdisyonSiparisDetay();
        }

        private void btnAdisyonSiparisDetaySil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from AdisyonSiparisDetay where AdisyonSiparisDetay=@adisyonSiparisDetayID", conn);
            int id = Convert.ToInt32(dataGridViewAdisyonSiparisDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@adisyonSiparisDetayID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            AdisyonSiparisDetayGetir();
            TemizleAdisyonSiparisDetay();
        }

        private void btnAdsyonGetir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select AdisyonID,Tarih from Adisyon", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewAdisyonSiparisDetay.DataSource = dt;
        }

        //ADISYON ODEME DETAY
        private void btnAdisyonOdemeDetayGetir_Click(object sender, EventArgs e)
        {
            AdisyonOdemeDetayGetir();
        }

        private void AdisyonOdemeDetayGetir()
        {
            SqlCommand cmd = new SqlCommand("select AdisyonOdemeDetayID,AdisyonID,OdemeYontemiID,OdemeYontemiAdi from AdisyonOdemeDetay", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewAdisyonOdemeDetay.DataSource = dt;
        }

        private void btnAdisyonOdemeDetayEKLE_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert AdisyonOdemeDetay(AdisyonID,OdemeYontemiID,OdemeYontemiAdi) values (@adisyonID,@odemeYontemiID,@odemeYontemiAdi)", conn);
            cmd.Parameters.AddWithValue("@adisyonID", txtAdisyonOdemeDetayAdisyonId.Text);
            cmd.Parameters.AddWithValue("@odemeYontemiID", txtAdisyonOdemeDetayOdemeYontemiId.Text);
            cmd.Parameters.AddWithValue("@odemeYontemiAdi", txtAdisyonOdemeDetayOdemeYontemiAdi.Text);


            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewAdisyonOdemeDetay.DataSource = dt;
            AdisyonOdemeDetayGetir();
            TemizleAdisyonOdemeDetay();
        }

        private void TemizleAdisyonOdemeDetay()
        {
            foreach (var item in groupBox6.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void dataGridViewAdisyonOdemeDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdisyonOdemeDetay.SelectedRows.Count > 0)
            {
                txtAdisyonOdemeDetayAdisyonId.Text = dataGridViewAdisyonOdemeDetay.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAdisyonOdemeDetayOdemeYontemiId.Text = dataGridViewAdisyonOdemeDetay.CurrentRow.Cells[2].Value.ToString();
                txtAdisyonOdemeDetayOdemeYontemiAdi.Text = dataGridViewAdisyonOdemeDetay.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnAdisyonOdemeDetayGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update AdisyonOdemeDetay Set AdisyonID=@adisyonID,OdemeYontemiID=@odemeYontemiID,OdemeYontemiAdi=@odemeYontemiAdi where AdisyonOdemeDetayID=@adisyonOdemeDetayID", conn);
            int id = Convert.ToInt32(dataGridViewAdisyonOdemeDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@adisyonOdemeDetayID", id);
            cmd.Parameters.AddWithValue("@adisyonID", txtAdisyonOdemeDetayAdisyonId.Text);
            cmd.Parameters.AddWithValue("@odemeYontemiID", txtAdisyonOdemeDetayOdemeYontemiId.Text);
            cmd.Parameters.AddWithValue("@odemeYontemiAdi", txtAdisyonOdemeDetayOdemeYontemiAdi.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            AdisyonOdemeDetayGetir();
            TemizleAdisyonOdemeDetay();
        }

        private void btnAdisyonOdemeDetaySil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from AdisyonOdemeDetay where AdisyonOdemeDetayID=@adisyonOdemeDetayID", conn);
            int id = Convert.ToInt32(dataGridViewAdisyonOdemeDetay.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@adisyonOdemeDetayID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            AdisyonOdemeDetayGetir();
            TemizleAdisyonOdemeDetay();
        }
    }
}

