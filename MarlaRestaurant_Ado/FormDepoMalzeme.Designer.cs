
namespace MarlaRestaurant_Ado
{
    partial class FormDepoMalzeme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDepoGetir = new System.Windows.Forms.Button();
            this.dataGridViewDepo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepoAdres = new System.Windows.Forms.TextBox();
            this.txtDepoAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepoSil = new System.Windows.Forms.Button();
            this.btnDepoGuncelle = new System.Windows.Forms.Button();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMalzemeGetir = new System.Windows.Forms.Button();
            this.dataGridViewMalzeme = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMalTedId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkboxMalDurum = new System.Windows.Forms.CheckBox();
            this.txtMalKatId = new System.Windows.Forms.TextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnMalzemeGuncelle = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMalKategoriGetir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMalKategoriSil = new System.Windows.Forms.Button();
            this.btnMalKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnMalKategoriEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMalKatAdi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewMalzemeKategori = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTedarikciGetir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTedarikciSil = new System.Windows.Forms.Button();
            this.btnTedarikciGuncelle = new System.Windows.Forms.Button();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewTedarikci = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzeme)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeKategori)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.Controls.Add(this.btnDepoGetir);
            this.tabPage1.Controls.Add(this.dataGridViewDepo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Depo";
            // 
            // btnDepoGetir
            // 
            this.btnDepoGetir.BackColor = System.Drawing.Color.Silver;
            this.btnDepoGetir.Location = new System.Drawing.Point(635, 213);
            this.btnDepoGetir.Name = "btnDepoGetir";
            this.btnDepoGetir.Size = new System.Drawing.Size(171, 36);
            this.btnDepoGetir.TabIndex = 16;
            this.btnDepoGetir.Text = "Depoları Getir";
            this.btnDepoGetir.UseVisualStyleBackColor = false;
            this.btnDepoGetir.Click += new System.EventHandler(this.btnDepoGetir_Click);
            // 
            // dataGridViewDepo
            // 
            this.dataGridViewDepo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepo.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewDepo.Name = "dataGridViewDepo";
            this.dataGridViewDepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepo.Size = new System.Drawing.Size(795, 167);
            this.dataGridViewDepo.TabIndex = 15;
            this.dataGridViewDepo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepo_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepoAdres);
            this.groupBox1.Controls.Add(this.txtDepoAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDepoSil);
            this.groupBox1.Controls.Add(this.btnDepoGuncelle);
            this.groupBox1.Controls.Add(this.btnDepoEkle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 180);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Bilgileri";
            // 
            // txtDepoAdres
            // 
            this.txtDepoAdres.Location = new System.Drawing.Point(110, 64);
            this.txtDepoAdres.Name = "txtDepoAdres";
            this.txtDepoAdres.Size = new System.Drawing.Size(142, 21);
            this.txtDepoAdres.TabIndex = 9;
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Location = new System.Drawing.Point(110, 33);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Size = new System.Drawing.Size(142, 21);
            this.txtDepoAdi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Depo Adı";
            // 
            // btnDepoSil
            // 
            this.btnDepoSil.BackColor = System.Drawing.Color.Silver;
            this.btnDepoSil.Location = new System.Drawing.Point(227, 115);
            this.btnDepoSil.Name = "btnDepoSil";
            this.btnDepoSil.Size = new System.Drawing.Size(95, 32);
            this.btnDepoSil.TabIndex = 5;
            this.btnDepoSil.Text = "SİL";
            this.btnDepoSil.UseVisualStyleBackColor = false;
            this.btnDepoSil.Click += new System.EventHandler(this.btnDepoSil_Click);
            // 
            // btnDepoGuncelle
            // 
            this.btnDepoGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnDepoGuncelle.Location = new System.Drawing.Point(121, 115);
            this.btnDepoGuncelle.Name = "btnDepoGuncelle";
            this.btnDepoGuncelle.Size = new System.Drawing.Size(100, 32);
            this.btnDepoGuncelle.TabIndex = 4;
            this.btnDepoGuncelle.Text = "GÜNCELLE";
            this.btnDepoGuncelle.UseVisualStyleBackColor = false;
            this.btnDepoGuncelle.Click += new System.EventHandler(this.btnDepoGuncelle_Click);
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.BackColor = System.Drawing.Color.Silver;
            this.btnDepoEkle.Location = new System.Drawing.Point(6, 115);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(92, 32);
            this.btnDepoEkle.TabIndex = 3;
            this.btnDepoEkle.Text = "EKLE";
            this.btnDepoEkle.UseVisualStyleBackColor = false;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage2.Controls.Add(this.btnMalzemeGetir);
            this.tabPage2.Controls.Add(this.dataGridViewMalzeme);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Malzeme";
            // 
            // btnMalzemeGetir
            // 
            this.btnMalzemeGetir.BackColor = System.Drawing.Color.Silver;
            this.btnMalzemeGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalzemeGetir.Location = new System.Drawing.Point(642, 223);
            this.btnMalzemeGetir.Name = "btnMalzemeGetir";
            this.btnMalzemeGetir.Size = new System.Drawing.Size(171, 37);
            this.btnMalzemeGetir.TabIndex = 18;
            this.btnMalzemeGetir.Text = "Malzeme Getir";
            this.btnMalzemeGetir.UseVisualStyleBackColor = false;
            this.btnMalzemeGetir.Click += new System.EventHandler(this.btnMalzemeGetir_Click);
            // 
            // dataGridViewMalzeme
            // 
            this.dataGridViewMalzeme.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalzeme.Location = new System.Drawing.Point(14, 22);
            this.dataGridViewMalzeme.Name = "dataGridViewMalzeme";
            this.dataGridViewMalzeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMalzeme.Size = new System.Drawing.Size(799, 167);
            this.dataGridViewMalzeme.TabIndex = 17;
            this.dataGridViewMalzeme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalzeme_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMalTedId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkboxMalDurum);
            this.groupBox2.Controls.Add(this.txtMalKatId);
            this.groupBox2.Controls.Add(this.txtMalzemeAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnMalzemeSil);
            this.groupBox2.Controls.Add(this.btnMalzemeGuncelle);
            this.groupBox2.Controls.Add(this.btnMalzemeEkle);
            this.groupBox2.Location = new System.Drawing.Point(14, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 193);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "TedarikciId";
            // 
            // txtMalTedId
            // 
            this.txtMalTedId.Location = new System.Drawing.Point(171, 111);
            this.txtMalTedId.Name = "txtMalTedId";
            this.txtMalTedId.Size = new System.Drawing.Size(128, 21);
            this.txtMalTedId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "MalzemeKategoriId";
            // 
            // checkboxMalDurum
            // 
            this.checkboxMalDurum.AutoSize = true;
            this.checkboxMalDurum.Location = new System.Drawing.Point(171, 65);
            this.checkboxMalDurum.Name = "checkboxMalDurum";
            this.checkboxMalDurum.Size = new System.Drawing.Size(15, 14);
            this.checkboxMalDurum.TabIndex = 10;
            this.checkboxMalDurum.UseVisualStyleBackColor = true;
            // 
            // txtMalKatId
            // 
            this.txtMalKatId.Location = new System.Drawing.Point(171, 84);
            this.txtMalKatId.Name = "txtMalKatId";
            this.txtMalKatId.Size = new System.Drawing.Size(128, 21);
            this.txtMalKatId.TabIndex = 9;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(171, 36);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(128, 21);
            this.txtMalzemeAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Malzeme Adı";
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.BackColor = System.Drawing.Color.Silver;
            this.btnMalzemeSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalzemeSil.Location = new System.Drawing.Point(237, 152);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(91, 33);
            this.btnMalzemeSil.TabIndex = 5;
            this.btnMalzemeSil.Text = "SİL";
            this.btnMalzemeSil.UseVisualStyleBackColor = false;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnMalzemeGuncelle
            // 
            this.btnMalzemeGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnMalzemeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalzemeGuncelle.Location = new System.Drawing.Point(131, 152);
            this.btnMalzemeGuncelle.Name = "btnMalzemeGuncelle";
            this.btnMalzemeGuncelle.Size = new System.Drawing.Size(100, 33);
            this.btnMalzemeGuncelle.TabIndex = 4;
            this.btnMalzemeGuncelle.Text = "GÜNCELLE";
            this.btnMalzemeGuncelle.UseVisualStyleBackColor = false;
            this.btnMalzemeGuncelle.Click += new System.EventHandler(this.btnMalzemeGuncelle_Click);
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.BackColor = System.Drawing.Color.Silver;
            this.btnMalzemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalzemeEkle.Location = new System.Drawing.Point(28, 152);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(97, 33);
            this.btnMalzemeEkle.TabIndex = 3;
            this.btnMalzemeEkle.Text = "EKLE";
            this.btnMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnMalKategoriGetir);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.dataGridViewMalzemeKategori);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(826, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MazemeKategori";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Malzeme Ara";
            // 
            // btnMalKategoriGetir
            // 
            this.btnMalKategoriGetir.BackColor = System.Drawing.Color.Silver;
            this.btnMalKategoriGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalKategoriGetir.Location = new System.Drawing.Point(609, 315);
            this.btnMalKategoriGetir.Name = "btnMalKategoriGetir";
            this.btnMalKategoriGetir.Size = new System.Drawing.Size(179, 40);
            this.btnMalKategoriGetir.TabIndex = 9;
            this.btnMalKategoriGetir.Text = "Malzeme Kategori Getir";
            this.btnMalKategoriGetir.UseVisualStyleBackColor = false;
            this.btnMalKategoriGetir.Click += new System.EventHandler(this.btnMalKategoriGetir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMalKategoriSil);
            this.groupBox3.Controls.Add(this.btnMalKategoriGuncelle);
            this.groupBox3.Controls.Add(this.btnMalKategoriEkle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMalKatAdi);
            this.groupBox3.Location = new System.Drawing.Point(14, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 163);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Malzeme Kategori Bilgileri";
            // 
            // btnMalKategoriSil
            // 
            this.btnMalKategoriSil.BackColor = System.Drawing.Color.Silver;
            this.btnMalKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalKategoriSil.Location = new System.Drawing.Point(212, 98);
            this.btnMalKategoriSil.Name = "btnMalKategoriSil";
            this.btnMalKategoriSil.Size = new System.Drawing.Size(91, 31);
            this.btnMalKategoriSil.TabIndex = 4;
            this.btnMalKategoriSil.Text = "SİL";
            this.btnMalKategoriSil.UseVisualStyleBackColor = false;
            this.btnMalKategoriSil.Click += new System.EventHandler(this.btnMalKategoriSil_Click);
            // 
            // btnMalKategoriGuncelle
            // 
            this.btnMalKategoriGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnMalKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalKategoriGuncelle.Location = new System.Drawing.Point(103, 98);
            this.btnMalKategoriGuncelle.Name = "btnMalKategoriGuncelle";
            this.btnMalKategoriGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnMalKategoriGuncelle.TabIndex = 3;
            this.btnMalKategoriGuncelle.Text = "GÜNCELLE";
            this.btnMalKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnMalKategoriGuncelle.Click += new System.EventHandler(this.btnMalKategoriGuncelle_Click);
            // 
            // btnMalKategoriEkle
            // 
            this.btnMalKategoriEkle.BackColor = System.Drawing.Color.Silver;
            this.btnMalKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalKategoriEkle.Location = new System.Drawing.Point(9, 98);
            this.btnMalKategoriEkle.Name = "btnMalKategoriEkle";
            this.btnMalKategoriEkle.Size = new System.Drawing.Size(75, 31);
            this.btnMalKategoriEkle.TabIndex = 2;
            this.btnMalKategoriEkle.Text = "EKLE";
            this.btnMalKategoriEkle.UseVisualStyleBackColor = false;
            this.btnMalKategoriEkle.Click += new System.EventHandler(this.btnMalKategoriEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Malzeme Kategori Adı";
            // 
            // txtMalKatAdi
            // 
            this.txtMalKatAdi.Location = new System.Drawing.Point(171, 56);
            this.txtMalKatAdi.Name = "txtMalKatAdi";
            this.txtMalKatAdi.Size = new System.Drawing.Size(132, 21);
            this.txtMalKatAdi.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(649, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // dataGridViewMalzemeKategori
            // 
            this.dataGridViewMalzemeKategori.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMalzemeKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalzemeKategori.Location = new System.Drawing.Point(5, 3);
            this.dataGridViewMalzemeKategori.Name = "dataGridViewMalzemeKategori";
            this.dataGridViewMalzemeKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMalzemeKategori.Size = new System.Drawing.Size(818, 196);
            this.dataGridViewMalzemeKategori.TabIndex = 6;
            this.dataGridViewMalzemeKategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalzemeKategori_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage4.Controls.Add(this.btnTedarikciGetir);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.dataGridViewTedarikci);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(826, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tedarikçi";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnTedarikciGetir
            // 
            this.btnTedarikciGetir.BackColor = System.Drawing.Color.Silver;
            this.btnTedarikciGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciGetir.Location = new System.Drawing.Point(659, 239);
            this.btnTedarikciGetir.Name = "btnTedarikciGetir";
            this.btnTedarikciGetir.Size = new System.Drawing.Size(146, 34);
            this.btnTedarikciGetir.TabIndex = 12;
            this.btnTedarikciGetir.Text = "Tedarikçileri Getir";
            this.btnTedarikciGetir.UseVisualStyleBackColor = false;
            this.btnTedarikciGetir.Click += new System.EventHandler(this.btnTedarikciGetir_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox4.Controls.Add(this.btnTedarikciSil);
            this.groupBox4.Controls.Add(this.btnTedarikciGuncelle);
            this.groupBox4.Controls.Add(this.btnTedarikciEkle);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtTedarikciAdi);
            this.groupBox4.Location = new System.Drawing.Point(21, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 148);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tedarikçi Bilgileri";
            // 
            // btnTedarikciSil
            // 
            this.btnTedarikciSil.BackColor = System.Drawing.Color.Silver;
            this.btnTedarikciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciSil.Location = new System.Drawing.Point(206, 90);
            this.btnTedarikciSil.Name = "btnTedarikciSil";
            this.btnTedarikciSil.Size = new System.Drawing.Size(88, 29);
            this.btnTedarikciSil.TabIndex = 4;
            this.btnTedarikciSil.Text = "SİL";
            this.btnTedarikciSil.UseVisualStyleBackColor = false;
            this.btnTedarikciSil.Click += new System.EventHandler(this.btnTedarikciSil_Click);
            // 
            // btnTedarikciGuncelle
            // 
            this.btnTedarikciGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnTedarikciGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciGuncelle.Location = new System.Drawing.Point(108, 90);
            this.btnTedarikciGuncelle.Name = "btnTedarikciGuncelle";
            this.btnTedarikciGuncelle.Size = new System.Drawing.Size(92, 29);
            this.btnTedarikciGuncelle.TabIndex = 3;
            this.btnTedarikciGuncelle.Text = "GUNCELLE";
            this.btnTedarikciGuncelle.UseVisualStyleBackColor = false;
            this.btnTedarikciGuncelle.Click += new System.EventHandler(this.btnTedarikciGuncelle_Click);
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.BackColor = System.Drawing.Color.Silver;
            this.btnTedarikciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciEkle.Location = new System.Drawing.Point(18, 90);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(84, 29);
            this.btnTedarikciEkle.TabIndex = 2;
            this.btnTedarikciEkle.Text = "EKLE";
            this.btnTedarikciEkle.UseVisualStyleBackColor = false;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tedarikçi Adı";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(139, 40);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(155, 21);
            this.txtTedarikciAdi.TabIndex = 0;
            // 
            // dataGridViewTedarikci
            // 
            this.dataGridViewTedarikci.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTedarikci.Location = new System.Drawing.Point(5, 16);
            this.dataGridViewTedarikci.Name = "dataGridViewTedarikci";
            this.dataGridViewTedarikci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTedarikci.Size = new System.Drawing.Size(818, 196);
            this.dataGridViewTedarikci.TabIndex = 10;
            this.dataGridViewTedarikci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTedarikci_CellDoubleClick);
            // 
            // FormDepoMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDepoMalzeme";
            this.Text = "FormDepoMalzeme";
            this.Load += new System.EventHandler(this.FormDepoMalzeme_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzeme)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalzemeKategori)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTedarikci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDepoGetir;
        private System.Windows.Forms.DataGridView dataGridViewDepo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDepoAdres;
        private System.Windows.Forms.TextBox txtDepoAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepoSil;
        private System.Windows.Forms.Button btnDepoGuncelle;
        private System.Windows.Forms.Button btnDepoEkle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnMalKategoriGetir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMalKategoriSil;
        private System.Windows.Forms.Button btnMalKategoriGuncelle;
        private System.Windows.Forms.Button btnMalKategoriEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMalKatAdi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewMalzemeKategori;
        private System.Windows.Forms.Button btnTedarikciGetir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTedarikciSil;
        private System.Windows.Forms.Button btnTedarikciGuncelle;
        private System.Windows.Forms.Button btnTedarikciEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.DataGridView dataGridViewTedarikci;
        private System.Windows.Forms.Button btnMalzemeGetir;
        private System.Windows.Forms.DataGridView dataGridViewMalzeme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMalTedId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkboxMalDurum;
        private System.Windows.Forms.TextBox txtMalKatId;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnMalzemeGuncelle;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Label label10;
    }
}