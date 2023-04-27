
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
    public partial class FormRestaurant : Form
    {
        public FormRestaurant()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");



        private void FormRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void btnRestaurantGetir_Click(object sender, EventArgs e)
        {
            RestaurantGetir();
        }

        private void RestaurantGetir()
        {
            SqlCommand cmd = new SqlCommand("Select RestaurantID,RestaurantAdi,Sehir,Adres,Tel from Restaurant", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("insert Restaurant(RestaurantAdi,Sehir,Adres,Tel) values (@resAdi,@Sehir,@adress,@tel)", conn);
            cmd.Parameters.AddWithValue("@resAdi", txtRestaurantAdi.Text);
            cmd.Parameters.AddWithValue("@Sehir", txtSehir.Text);
            cmd.Parameters.AddWithValue("@adress", txtAdres.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView1.DataSource = dt;
            RestaurantGetir();
            TemizleRestaurant();

        }

        private void TemizleRestaurant()
        {
            foreach (var item in groupBoxRestaurant.Controls)
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
                txtRestaurantAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSehir.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Restaurant Set RestaurantAdi=@resAdi,Sehir=@Sehir,Adres=@adress,Tel=@tel where RestaurantID=@ResId", conn);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@ResId", id);
            cmd.Parameters.AddWithValue("@resAdi", txtRestaurantAdi.Text);
            cmd.Parameters.AddWithValue("@Sehir", txtSehir.Text);
            cmd.Parameters.AddWithValue("@adress", txtAdres.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            RestaurantGetir();
            TemizleRestaurant();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from  Restaurant where RestaurantID=@ResId", conn);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@ResId", id);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            RestaurantGetir();
            TemizleRestaurant();
        }

        private void groupBoxRestaurant_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
