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
    public partial class FormDepoMalzeme : Form
    {
        public FormDepoMalzeme()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void FormDepoMalzeme_Load(object sender, EventArgs e)
        {

        }

        private void btnDepoGetir_Click(object sender, EventArgs e)
        {
            DepoGetir();
        }

        private void DepoGetir()
        {
            SqlCommand cmd = new SqlCommand("select DepoID,DepoAdi,Adres from Depo", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewDepo.DataSource = dt;
        }
        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Depo(DepoAdi,Adres) values (@depoAdi,@adres)", conn);
            cmd.Parameters.AddWithValue("@depoAdi", txtDepoAdi.Text);
            cmd.Parameters.AddWithValue("@adres", txtDepoAdres.Text);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewDepo.DataSource = dt;
            DepoGetir();
            TemizleDepo();
        }

        private void dataGridViewDepo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDepo.SelectedRows.Count > 0)
            {
                txtDepoAdi.Text = dataGridViewDepo.CurrentRow.Cells[1].Value.ToString();
                txtDepoAdres.Text = dataGridViewDepo.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void btnDepoGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Depo Set DepoAdi=@depoAdi,Adres=@adres where DepoID=@depoID", conn);
            int id = Convert.ToInt32(dataGridViewDepo.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@depoID", id);
            cmd.Parameters.AddWithValue("@depoAdi", txtDepoAdi.Text);
            cmd.Parameters.AddWithValue("@adres", txtDepoAdres.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DepoGetir();
            TemizleDepo();
        }

        private void TemizleDepo()
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

        private void btnDepoSil_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Delete from  Depo where DepoID=@depoID", conn);
            int id = Convert.ToInt32(dataGridViewDepo.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@depoID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DepoGetir();
            TemizleDepo();
        }


        //MALZEME KATEGORI
        private void btnMalKategoriGetir_Click(object sender, EventArgs e)
        {
            MalzemeKategoriGetir();
        }

        private void MalzemeKategoriGetir()
        {
            SqlCommand cmd = new SqlCommand("select MalzemeKategoriID,MalzemeKategoriAdi from MalzemeKategori", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewMalzemeKategori.DataSource = dt;
        }

        private void btnMalKategoriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert MalzemeKategori(MalzemeKategoriAdi) values (@malzemeKategoriAdi)", conn);
            cmd.Parameters.AddWithValue("@malzemeKategoriAdi", txtMalKatAdi.Text);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewMalzemeKategori.DataSource = dt;
            MalzemeKategoriGetir();
            TemizleMalzemeKategori();
        }

        private void TemizleMalzemeKategori()
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

        private void dataGridViewMalzemeKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMalzemeKategori.SelectedRows.Count > 0)
            {
                txtMalKatAdi.Text = dataGridViewMalzemeKategori.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btnMalKategoriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update MalzemeKategori Set MalzemeKategoriAdi=@malzemeKategoriAdi where MalzemeKategoriID=@malzemeKategoriID", conn);
            int id = Convert.ToInt32(dataGridViewMalzemeKategori.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@malzemeKategoriID", id);
            cmd.Parameters.AddWithValue("@malzemeKategoriAdi", txtMalKatAdi.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MalzemeKategoriGetir();
            TemizleMalzemeKategori();
        }

        private void btnMalKategoriSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from MalzemeKategori where MalzemeKategoriID=@malzemeKategoriID", conn);
            int id = Convert.ToInt32(dataGridViewMalzemeKategori.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@malzemeKategoriID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MalzemeKategoriGetir();
            TemizleMalzemeKategori();
        }

        //Tedarikci
        private void btnTedarikciGetir_Click(object sender, EventArgs e)
        {
            TedarikciGetir();
        }

        private void TedarikciGetir()
        {
            SqlCommand cmd = new SqlCommand("select TedarikciID,TedarikciAdi from Tedarikci", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewTedarikci.DataSource = dt;
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Tedarikci(TedarikciAdi) values (@tedarikciAdi)", conn);
            cmd.Parameters.AddWithValue("@tedarikciAdi", txtTedarikciAdi.Text);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewTedarikci.DataSource = dt;
            TedarikciGetir();
            TemizleTedarikci();
        }

        private void TemizleTedarikci()
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

        private void dataGridViewTedarikci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTedarikci.SelectedRows.Count > 0)
            {
                txtTedarikciAdi.Text = dataGridViewTedarikci.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnTedarikciGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tedarikci Set TedarikciAdi=@tedarikciAdi where TedarikciID=@tedarikciID", conn);
            int id = Convert.ToInt32(dataGridViewTedarikci.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@tedarikciID", id);
            cmd.Parameters.AddWithValue("@tedarikciAdi", txtTedarikciAdi.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            TedarikciGetir();
            TemizleTedarikci();
        }

        private void btnTedarikciSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tedarikci where TedarikciID=@tedarikciID", conn);
            int id = Convert.ToInt32(dataGridViewTedarikci.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@tedarikciID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            TedarikciGetir();
            TemizleTedarikci();
        }


        //MALZEME
        private void btnMalzemeGetir_Click(object sender, EventArgs e)
        {
            MalzemeGetir();
        }

        private void MalzemeGetir()
        {
            SqlCommand cmd = new SqlCommand("select MalzemeID, MalzemeAdi, Durum, MalzemeKategoriID, TedarikciID from Malzeme", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridViewMalzeme.DataSource = dt;
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("insert Malzeme(MalzemeAdi, Durum, MalzemeKategoriID, TedarikciID) values (@malzemeAdi, @durum, @malzemeKategoriID, @tedarikciID)", conn);
            cmd.Parameters.AddWithValue("@malzemeAdi", txtMalzemeAdi.Text);
            cmd.Parameters.AddWithValue("@durum", checkboxMalDurum.Checked);
            cmd.Parameters.AddWithValue("@malzemeKategoriID", txtMalKatId.Text);
            cmd.Parameters.AddWithValue("@tedarikciID", txtMalTedId.Text);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridViewMalzeme.DataSource = dt;
            MalzemeGetir();
            TemizleMalzeme();
        }

        private void TemizleMalzeme()
        {
            foreach (var item in groupBox2.Controls)
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

        private void dataGridViewMalzeme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMalzeme.SelectedRows.Count > 0)
            {
                txtMalzemeAdi.Text = dataGridViewMalzeme.Rows[e.RowIndex].Cells[1].Value.ToString();
                checkboxMalDurum.Checked = Convert.ToBoolean(dataGridViewMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtMalKatId.Text = dataGridViewMalzeme.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMalTedId.Text = dataGridViewMalzeme.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnMalzemeGuncelle_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("update Malzeme Set MalzemeAdi=@malzemeAdi,Durum=@durum,MalzemeKategoriID=@malzemeKategoriID,TedarikciID=@tedarikciID where MalzemeID=@malzemeID", conn);
            int id = Convert.ToInt32(dataGridViewMalzeme.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@malzemeID", id);
            cmd.Parameters.AddWithValue("@malzemeAdi", txtMalzemeAdi.Text);
            cmd.Parameters.AddWithValue("@durum", checkboxMalDurum.Checked);
            cmd.Parameters.AddWithValue("@malzemeKategoriID", txtMalKatId.Text);
            cmd.Parameters.AddWithValue("@tedarikciID", txtMalTedId.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MalzemeGetir();
            TemizleMalzeme();
        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Malzeme where  MalzemeID=@malzemeID", conn);
            int id = Convert.ToInt32(dataGridViewMalzeme.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@malzemeID", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MalzemeGetir();
            TemizleMalzeme();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

      
    }
}
