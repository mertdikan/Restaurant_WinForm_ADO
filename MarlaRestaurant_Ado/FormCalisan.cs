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
    public partial class FormCalisan : Form
    {
        public FormCalisan()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void FormCalisan_Load(object sender, EventArgs e)
        {

        }


        private void btnCalisanGetir_Click(object sender, EventArgs e)
        {
            CalisanGetir();
        }

        private void CalisanGetir()
        {
            SqlCommand cmd = new SqlCommand("select CalisanID,CalisanAdi,CalisanSoyadi,Unvan,RestaurantID from Calisan", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewCalisan.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Calisan(CalisanAdi,CalisanSoyadi,Unvan,RestaurantID) values (@calAdi,@calSoyadi,@unvan,@resId)", conn);
            cmd.Parameters.AddWithValue("@calAdi", txtCalisanAdi.Text);
            cmd.Parameters.AddWithValue("@calSoyadi", txtCalisanSoyadi.Text);
            cmd.Parameters.AddWithValue("@unvan", txtCalisanUnvan.Text);
            cmd.Parameters.AddWithValue("@resId", txtRestaurantId.Text);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewCalisan.DataSource = dt;
            CalisanGetir();
            TemizleCalisan();
        }

        private void TemizleCalisan()
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

        private void dataGridViewCalisan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewCalisan.SelectedRows.Count > 0)
            {
                txtCalisanAdi.Text = dataGridViewCalisan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCalisanSoyadi.Text = dataGridViewCalisan.CurrentRow.Cells[2].Value.ToString();
                txtCalisanUnvan.Text = dataGridViewCalisan.CurrentRow.Cells[3].Value.ToString();
                txtRestaurantId.Text = dataGridViewCalisan.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Calisan Set CalisanAdi=@calAdi,CalisanSoyadi=@calSoyadi,Unvan=@unvan,RestaurantID=@resId where CalisanID=@calId", conn);


            int id = Convert.ToInt32(dataGridViewCalisan.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@calId", id);
            cmd.Parameters.AddWithValue("@calAdi", txtCalisanAdi.Text);
            cmd.Parameters.AddWithValue("@calSoyadi", txtCalisanSoyadi.Text);
            cmd.Parameters.AddWithValue("@unvan", txtCalisanUnvan.Text);
            cmd.Parameters.AddWithValue("@resId", txtRestaurantId.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            TemizleCalisan();
            CalisanGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  Calisan where CalisanID=@calId", conn);
           
            int id = Convert.ToInt32(dataGridViewCalisan.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@calId", id);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            CalisanGetir();
            TemizleCalisan();
        }


        //CALISAN DETAY
        private void btnCalisanDetay_Click(object sender, EventArgs e)
        {
            CalisanDetayGetir();
        }

        private void CalisanDetayGetir()
        {
            SqlCommand cmd = new SqlCommand("select CalisanDetayID,Maas,Tckn,TelNo,Mail from CalisanDetay", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnCalisanDetayEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert CalisanDetay(CalisanDetayID,Maas,Tckn,TelNo,Mail) values (@calDetayId,@maas,@tckn,@telNo,@mail)", conn);
            cmd.Parameters.AddWithValue("@calDetayId", txtCalisanDetayID.Text);
            cmd.Parameters.AddWithValue("@maas", txtMaas.Text);
            cmd.Parameters.AddWithValue("@tckn", txtTckn.Text);
            cmd.Parameters.AddWithValue("@telNo", txtTelNo.Text);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView2.DataSource = dt;
            CalisanDetayGetir();
            TemizleCalisanDetay();
        }

        private void TemizleCalisanDetay()
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

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                txtCalisanDetayID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaas.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTckn.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtTelNo.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtMail.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btnCalisanDetayGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update CalisanDetay Set Maas=@maas,Tckn=@tckn,TelNo=@telNo,Mail=@mail where CalisanDetayID=@calDetayId", conn);

            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@calDetayId", id);
            cmd.Parameters.AddWithValue("@maas",Convert.ToDecimal(txtMaas.Text));
            cmd.Parameters.AddWithValue("@tckn", txtTckn.Text);
            cmd.Parameters.AddWithValue("@telNo", txtTelNo.Text);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            CalisanDetayGetir();
        }

        private void btnCalisanDetaySil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  Calisan where CalisanDetayID=@calDetayId", conn);

            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@calDetayId", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            CalisanDetayGetir();
            TemizleCalisanDetay();
        }
    }
}
