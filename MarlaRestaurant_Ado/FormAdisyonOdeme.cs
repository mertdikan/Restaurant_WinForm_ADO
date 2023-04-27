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
    public partial class FormAdisyonOdeme : Form
    {
        public FormAdisyonOdeme()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void FormAdisyonOdeme_Load(object sender, EventArgs e)
        {

        }

        private void btnAdisyonGetir_Click(object sender, EventArgs e)
        {
            AdisyonGetir();
        }

        private void AdisyonGetir()
        {
            SqlCommand cmd = new SqlCommand("select AdisyonID,Tarih from Adisyon", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewAdisyon.DataSource = dt;
        }

        private void btnAdisyonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Adisyon(Tarih) values (@tarih)", conn);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);


            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewAdisyon.DataSource = dt;
            AdisyonGetir();
           
        }

       
        private void dataGridViewAdisyon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdisyon.SelectedRows.Count > 0)
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewAdisyon.Rows[e.RowIndex].Cells[1].Value.ToString());

            }
        }

        private void btnAdisyonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Adisyon Set Tarih=@tarih where AdisyonID=@adisyonId", conn);
            int id = Convert.ToInt32(dataGridViewAdisyon.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@adisyonId", id);
            cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dateTimePicker1.Value));


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            AdisyonGetir();
        }

        private void btnAdisyonSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Adisyon Set Tarih=@tarih where AdisyonID=@adisyonId", conn);
            int id = Convert.ToInt32(dataGridViewAdisyon.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@adisyonId", id);
            cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dateTimePicker1.Value));


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            AdisyonGetir();
        }

        //Odeme YONTEMI

        private void btnOdemeYontGetir_Click(object sender, EventArgs e)
        {
            OdemeYontemiGetir();
        }

        private void OdemeYontemiGetir()
        {
            SqlCommand cmd = new SqlCommand("select OdemeYontemiID,OdemeYontemiAdi from OdemeYontemi", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewOdeme.DataSource = dt;
        }

        private void btnOdemeYontEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert OdemeYontemi(OdemeYontemiAdi) values (@odemeYontemi)", conn);
            cmd.Parameters.AddWithValue("@odemeYontemi", txtOdemeYontemiAdi.Text);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewOdeme.DataSource = dt;
            OdemeYontemiGetir();
            Temizle();
        }

        private void dataGridViewOdeme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOdeme.SelectedRows.Count > 0)
            {
                txtOdemeYontemiAdi.Text = dataGridViewOdeme.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btnOdemeYontGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update OdemeYontemi Set OdemeYontemiAdi=@odemeYontemi where OdemeYontemiID=@odemeYontemiID", conn);
            int id = Convert.ToInt32(dataGridViewOdeme.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@odemeYontemiID", id);
            cmd.Parameters.AddWithValue("@odemeYontemi", txtOdemeYontemiAdi.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            OdemeYontemiGetir();
            Temizle();
        }

        private void Temizle()
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

        private void btnOdemeYontSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from OdemeYontemi where OdemeYontemiID=@odemeYontemiID", conn);
            int id = Convert.ToInt32(dataGridViewOdeme.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@odemeYontemiID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            OdemeYontemiGetir();
            Temizle();
        }

     
    }
}
