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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void FormMenu_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select MenuKategoriID,MenuKategoriAdi from MenuKategori", conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            comboBox1.DataSource = dt;

            comboBox1.DisplayMember = "MenuKategoriAdi";
            comboBox1.ValueMember = "MenuKategoriID";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select UrunAdi,UrunAciklamasi,Fiyat from Urun where KategoriID = @menuID ", conn);
            cmd.Parameters.AddWithValue("@menuID", comboBox1.SelectedValue);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView1.DataSource = dt;

        }
    }
}
