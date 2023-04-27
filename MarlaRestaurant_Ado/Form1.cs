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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MPH81M1;Initial Catalog=Marla_Ado1;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu frm1 = new FormMenu();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRestaurant frm2 = new FormRestaurant();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCalisan frm3 = new FormCalisan();
            frm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMusteriSiparis frm4 = new FormMusteriSiparis();
            frm4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDepoMalzeme frm5 = new FormDepoMalzeme();
            frm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunKategori frm6 = new UrunKategori();
            frm6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAdisyonOdeme frm7 = new FormAdisyonOdeme();
            frm7.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormDetaylar frm8 = new FormDetaylar();
            frm8.ShowDialog();
        }
    }
}
