
namespace dershane_öğrenci_başarı_takip_programı_v1._0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgöğrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnögrenciekle = new System.Windows.Forms.Button();
            this.txtdogumtarihi = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtdogumyeri = new System.Windows.Forms.TextBox();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdogumtarihiG = new System.Windows.Forms.TextBox();
            this.txttelG = new System.Windows.Forms.TextBox();
            this.txttxtdogumyeriG = new System.Windows.Forms.TextBox();
            this.txtsoyadiG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtadiG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdogumtarihiS = new System.Windows.Forms.TextBox();
            this.txtTelS = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtsoyadiS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtadiS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgöğrenciler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgöğrenciler
            // 
            this.dgöğrenciler.AllowUserToAddRows = false;
            this.dgöğrenciler.AllowUserToDeleteRows = false;
            this.dgöğrenciler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgöğrenciler.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgöğrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgöğrenciler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgöğrenciler.GridColor = System.Drawing.Color.White;
            this.dgöğrenciler.Location = new System.Drawing.Point(24, 249);
            this.dgöğrenciler.MultiSelect = false;
            this.dgöğrenciler.Name = "dgöğrenciler";
            this.dgöğrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgöğrenciler.Size = new System.Drawing.Size(569, 279);
            this.dgöğrenciler.TabIndex = 4;
            this.dgöğrenciler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgöğrenciler_CellContentClick);
            this.dgöğrenciler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnögrenciekle);
            this.groupBox1.Controls.Add(this.txtdogumtarihi);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtdogumyeri);
            this.groupBox1.Controls.Add(this.txtsoyadi);
            this.groupBox1.Controls.Add(this.txtadi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btnögrenciekle
            // 
            this.btnögrenciekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnögrenciekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnögrenciekle.Image = global::dershane_öğrenci_başarı_takip_programı_v1._0.Properties.Resources.Tick_Mark_icon_icons_com_69146__2_;
            this.btnögrenciekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnögrenciekle.Location = new System.Drawing.Point(254, 145);
            this.btnögrenciekle.Name = "btnögrenciekle";
            this.btnögrenciekle.Size = new System.Drawing.Size(114, 54);
            this.btnögrenciekle.TabIndex = 24;
            this.btnögrenciekle.Text = "Ekle";
            this.btnögrenciekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnögrenciekle.UseVisualStyleBackColor = true;
            this.btnögrenciekle.Click += new System.EventHandler(this.btnögrenciekle_Click);
            // 
            // txtdogumtarihi
            // 
            this.txtdogumtarihi.Location = new System.Drawing.Point(419, 35);
            this.txtdogumtarihi.Name = "txtdogumtarihi";
            this.txtdogumtarihi.Size = new System.Drawing.Size(125, 22);
            this.txtdogumtarihi.TabIndex = 23;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(73, 118);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(125, 22);
            this.txttel.TabIndex = 14;
            // 
            // txtdogumyeri
            // 
            this.txtdogumyeri.Location = new System.Drawing.Point(419, 73);
            this.txtdogumyeri.Name = "txtdogumyeri";
            this.txtdogumyeri.Size = new System.Drawing.Size(125, 22);
            this.txtdogumyeri.TabIndex = 13;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Location = new System.Drawing.Point(73, 76);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(125, 22);
            this.txtsoyadi.TabIndex = 12;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(73, 35);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(125, 22);
            this.txtadi.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(36, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(315, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(327, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Yeri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::dershane_öğrenci_başarı_takip_programı_v1._0.Properties.Resources.sign_error_icon_34362__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(239, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 54);
            this.button2.TabIndex = 21;
            this.button2.Text = "Sil";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::dershane_öğrenci_başarı_takip_programı_v1._0.Properties.Resources.back_arrow_14429__2_;
            this.pictureBox1.Location = new System.Drawing.Point(914, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtdogumtarihiG);
            this.groupBox2.Controls.Add(this.txttelG);
            this.groupBox2.Controls.Add(this.txttxtdogumyeriG);
            this.groupBox2.Controls.Add(this.txtsoyadiG);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtadiG);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(599, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 231);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Güncelle";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::dershane_öğrenci_başarı_takip_programı_v1._0.Properties.Resources.system_software_update_22485__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(239, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Güncelle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdogumtarihiG
            // 
            this.txtdogumtarihiG.Location = new System.Drawing.Point(105, 128);
            this.txtdogumtarihiG.Name = "txtdogumtarihiG";
            this.txtdogumtarihiG.Size = new System.Drawing.Size(125, 22);
            this.txtdogumtarihiG.TabIndex = 29;
            // 
            // txttelG
            // 
            this.txttelG.Location = new System.Drawing.Point(105, 91);
            this.txttelG.Name = "txttelG";
            this.txttelG.Size = new System.Drawing.Size(125, 22);
            this.txttelG.TabIndex = 20;
            // 
            // txttxtdogumyeriG
            // 
            this.txttxtdogumyeriG.Location = new System.Drawing.Point(105, 162);
            this.txttxtdogumyeriG.Name = "txttxtdogumyeriG";
            this.txttxtdogumyeriG.Size = new System.Drawing.Size(125, 22);
            this.txttxtdogumyeriG.TabIndex = 28;
            // 
            // txtsoyadiG
            // 
            this.txtsoyadiG.Location = new System.Drawing.Point(105, 56);
            this.txtsoyadiG.Name = "txtsoyadiG";
            this.txtsoyadiG.Size = new System.Drawing.Size(125, 22);
            this.txtsoyadiG.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Doğum Yeri:";
            // 
            // txtadiG
            // 
            this.txtadiG.Location = new System.Drawing.Point(105, 15);
            this.txtadiG.Name = "txtadiG";
            this.txtadiG.Size = new System.Drawing.Size(125, 22);
            this.txtadiG.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(70, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtdogumtarihiS);
            this.groupBox3.Controls.Add(this.txtTelS);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtsoyadiS);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtadiS);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(599, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 231);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Sil";
            // 
            // txtdogumtarihiS
            // 
            this.txtdogumtarihiS.Location = new System.Drawing.Point(105, 128);
            this.txtdogumtarihiS.Name = "txtdogumtarihiS";
            this.txtdogumtarihiS.Size = new System.Drawing.Size(125, 22);
            this.txtdogumtarihiS.TabIndex = 29;
            // 
            // txtTelS
            // 
            this.txtTelS.Location = new System.Drawing.Point(105, 91);
            this.txtTelS.Name = "txtTelS";
            this.txtTelS.Size = new System.Drawing.Size(125, 22);
            this.txtTelS.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 22);
            this.textBox3.TabIndex = 28;
            // 
            // txtsoyadiS
            // 
            this.txtsoyadiS.Location = new System.Drawing.Point(105, 56);
            this.txtsoyadiS.Name = "txtsoyadiS";
            this.txtsoyadiS.Size = new System.Drawing.Size(125, 22);
            this.txtsoyadiS.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Doğum Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Doğum Yeri:";
            // 
            // txtadiS
            // 
            this.txtadiS.Location = new System.Drawing.Point(105, 15);
            this.txtadiS.Name = "txtadiS";
            this.txtadiS.Size = new System.Drawing.Size(125, 22);
            this.txtadiS.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(70, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tel:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(47, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Soyadı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(70, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dershane_öğrenci_başarı_takip_programı_v1._0.Properties.Resources.stock_photo_abstract_multicolored_background_poly_pattern;
            this.ClientSize = new System.Drawing.Size(985, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgöğrenciler);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dershane Öğrenci Başarı Takip Programı/Öğrenci Ekleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgöğrenciler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgöğrenciler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnögrenciekle;
        private System.Windows.Forms.TextBox txtdogumtarihi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtdogumyeri;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdogumtarihiG;
        private System.Windows.Forms.TextBox txttelG;
        private System.Windows.Forms.TextBox txttxtdogumyeriG;
        private System.Windows.Forms.TextBox txtsoyadiG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtadiG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdogumtarihiS;
        private System.Windows.Forms.TextBox txtTelS;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtsoyadiS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtadiS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

