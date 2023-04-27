
namespace MarlaRestaurant_Ado
{
    partial class FormCalisan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtRestaurantId = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalisanUnvan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalisanSoyadi = new System.Windows.Forms.TextBox();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.btnCalisanGetir = new System.Windows.Forms.Button();
            this.dataGridViewCalisan = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalisanDetayID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalisanDetayEkle = new System.Windows.Forms.Button();
            this.btnCalisanDetayGuncelle = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnCalisanDetaySil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.btnCalisanDetay = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisan)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCalisanGetir);
            this.tabPage1.Controls.Add(this.dataGridViewCalisan);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calisan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtRestaurantId);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCalisanUnvan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCalisanSoyadi);
            this.groupBox1.Controls.Add(this.txtCalisanAdi);
            this.groupBox1.Location = new System.Drawing.Point(27, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Çalışan Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Çalışan Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(9, 164);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 28);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(129, 164);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 28);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtRestaurantId
            // 
            this.txtRestaurantId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRestaurantId.Location = new System.Drawing.Point(147, 127);
            this.txtRestaurantId.Name = "txtRestaurantId";
            this.txtRestaurantId.Size = new System.Drawing.Size(132, 21);
            this.txtRestaurantId.TabIndex = 22;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(249, 164);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 28);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unvan";
            // 
            // txtCalisanUnvan
            // 
            this.txtCalisanUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalisanUnvan.Location = new System.Drawing.Point(147, 97);
            this.txtCalisanUnvan.Name = "txtCalisanUnvan";
            this.txtCalisanUnvan.Size = new System.Drawing.Size(132, 21);
            this.txtCalisanUnvan.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "RestaurantId";
            // 
            // txtCalisanSoyadi
            // 
            this.txtCalisanSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalisanSoyadi.Location = new System.Drawing.Point(147, 64);
            this.txtCalisanSoyadi.Name = "txtCalisanSoyadi";
            this.txtCalisanSoyadi.Size = new System.Drawing.Size(132, 21);
            this.txtCalisanSoyadi.TabIndex = 20;
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalisanAdi.Location = new System.Drawing.Point(147, 29);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(132, 21);
            this.txtCalisanAdi.TabIndex = 19;
            // 
            // btnCalisanGetir
            // 
            this.btnCalisanGetir.Location = new System.Drawing.Point(699, 229);
            this.btnCalisanGetir.Name = "btnCalisanGetir";
            this.btnCalisanGetir.Size = new System.Drawing.Size(153, 35);
            this.btnCalisanGetir.TabIndex = 11;
            this.btnCalisanGetir.Text = "Çalışanları Getir";
            this.btnCalisanGetir.UseVisualStyleBackColor = true;
            this.btnCalisanGetir.Click += new System.EventHandler(this.btnCalisanGetir_Click);
            // 
            // dataGridViewCalisan
            // 
            this.dataGridViewCalisan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCalisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalisan.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewCalisan.Name = "dataGridViewCalisan";
            this.dataGridViewCalisan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCalisan.Size = new System.Drawing.Size(854, 184);
            this.dataGridViewCalisan.TabIndex = 10;
            this.dataGridViewCalisan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCalisan_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnCalisanDetay);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CalisanDetay";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCalisanDetayID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCalisanDetayEkle);
            this.groupBox2.Controls.Add(this.btnCalisanDetayGuncelle);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.btnCalisanDetaySil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTelNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTckn);
            this.groupBox2.Controls.Add(this.txtMaas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(8, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 243);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışan Detay Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Calisan Detay ID";
            // 
            // txtCalisanDetayID
            // 
            this.txtCalisanDetayID.Location = new System.Drawing.Point(162, 29);
            this.txtCalisanDetayID.Name = "txtCalisanDetayID";
            this.txtCalisanDetayID.Size = new System.Drawing.Size(158, 21);
            this.txtCalisanDetayID.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "TCKN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Maas";
            // 
            // btnCalisanDetayEkle
            // 
            this.btnCalisanDetayEkle.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanDetayEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanDetayEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDetayEkle.Location = new System.Drawing.Point(20, 196);
            this.btnCalisanDetayEkle.Name = "btnCalisanDetayEkle";
            this.btnCalisanDetayEkle.Size = new System.Drawing.Size(98, 27);
            this.btnCalisanDetayEkle.TabIndex = 12;
            this.btnCalisanDetayEkle.Text = "EKLE";
            this.btnCalisanDetayEkle.UseVisualStyleBackColor = false;
            this.btnCalisanDetayEkle.Click += new System.EventHandler(this.btnCalisanDetayEkle_Click);
            // 
            // btnCalisanDetayGuncelle
            // 
            this.btnCalisanDetayGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanDetayGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanDetayGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDetayGuncelle.Location = new System.Drawing.Point(124, 196);
            this.btnCalisanDetayGuncelle.Name = "btnCalisanDetayGuncelle";
            this.btnCalisanDetayGuncelle.Size = new System.Drawing.Size(98, 27);
            this.btnCalisanDetayGuncelle.TabIndex = 14;
            this.btnCalisanDetayGuncelle.Text = "GÜNCELLE";
            this.btnCalisanDetayGuncelle.UseVisualStyleBackColor = false;
            this.btnCalisanDetayGuncelle.Click += new System.EventHandler(this.btnCalisanDetayGuncelle_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(162, 158);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(158, 21);
            this.txtMail.TabIndex = 22;
            // 
            // btnCalisanDetaySil
            // 
            this.btnCalisanDetaySil.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanDetaySil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanDetaySil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDetaySil.Location = new System.Drawing.Point(228, 196);
            this.btnCalisanDetaySil.Name = "btnCalisanDetaySil";
            this.btnCalisanDetaySil.Size = new System.Drawing.Size(98, 27);
            this.btnCalisanDetaySil.TabIndex = 13;
            this.btnCalisanDetaySil.Text = "SİL";
            this.btnCalisanDetaySil.UseVisualStyleBackColor = false;
            this.btnCalisanDetaySil.Click += new System.EventHandler(this.btnCalisanDetaySil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefon Numarası";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(162, 126);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(158, 21);
            this.txtTelNo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mail";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(162, 95);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(158, 21);
            this.txtTckn.TabIndex = 20;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(162, 60);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(158, 21);
            this.txtMaas.TabIndex = 19;
            // 
            // btnCalisanDetay
            // 
            this.btnCalisanDetay.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDetay.Location = new System.Drawing.Point(709, 204);
            this.btnCalisanDetay.Name = "btnCalisanDetay";
            this.btnCalisanDetay.Size = new System.Drawing.Size(153, 39);
            this.btnCalisanDetay.TabIndex = 13;
            this.btnCalisanDetay.Text = "Çalışan Detay Getir";
            this.btnCalisanDetay.UseVisualStyleBackColor = false;
            this.btnCalisanDetay.Click += new System.EventHandler(this.btnCalisanDetay_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(854, 184);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // FormCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCalisan";
            this.Text = "FormCalisan";
            this.Load += new System.EventHandler(this.FormCalisan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtRestaurantId;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalisanUnvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalisanSoyadi;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.Button btnCalisanGetir;
        private System.Windows.Forms.DataGridView dataGridViewCalisan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalisanDetayID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalisanDetayEkle;
        private System.Windows.Forms.Button btnCalisanDetayGuncelle;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnCalisanDetaySil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button btnCalisanDetay;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}