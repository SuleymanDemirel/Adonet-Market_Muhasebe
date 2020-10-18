namespace Muhasebe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblÜrün = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.tbxÜrün = new System.Windows.Forms.TextBox();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.tbxAdetUpdate = new System.Windows.Forms.TextBox();
            this.tbxFiyatUpdate = new System.Windows.Forms.TextBox();
            this.tbxÜrünUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdbSigara = new System.Windows.Forms.RadioButton();
            this.rdbGıda = new System.Windows.Forms.RadioButton();
            this.rdbÇerez = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgwCerezs = new System.Windows.Forms.DataGridView();
            this.btnCerezSil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxÜrünCerezUpdate = new System.Windows.Forms.TextBox();
            this.tbxAdetCerezUpdate = new System.Windows.Forms.TextBox();
            this.btnCerezGüncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFiyatCerezUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGıdaSil = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbxÜrünGıdaUpdate = new System.Windows.Forms.TextBox();
            this.tbxAdetGıdaUpdate = new System.Windows.Forms.TextBox();
            this.btnGıdaGüncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxFiyatGıdaUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgwGıdas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCerezs)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGıdas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(7, 6);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(519, 158);
            this.dgwProducts.TabIndex = 5;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblÜrün
            // 
            this.lblÜrün.AutoSize = true;
            this.lblÜrün.Location = new System.Drawing.Point(8, 25);
            this.lblÜrün.Name = "lblÜrün";
            this.lblÜrün.Size = new System.Drawing.Size(53, 17);
            this.lblÜrün.TabIndex = 6;
            this.lblÜrün.Text = "Ürün : ";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(10, 55);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(50, 17);
            this.lblAdet.TabIndex = 7;
            this.lblAdet.Text = "Adet : ";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(8, 80);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(52, 17);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat : ";
            // 
            // tbxÜrün
            // 
            this.tbxÜrün.Location = new System.Drawing.Point(68, 25);
            this.tbxÜrün.Name = "tbxÜrün";
            this.tbxÜrün.Size = new System.Drawing.Size(114, 22);
            this.tbxÜrün.TabIndex = 9;
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(68, 81);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(114, 22);
            this.tbxFiyat.TabIndex = 10;
            // 
            // tbxAdet
            // 
            this.tbxAdet.Location = new System.Drawing.Point(68, 53);
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(114, 22);
            this.tbxAdet.TabIndex = 11;
            // 
            // tbxAdetUpdate
            // 
            this.tbxAdetUpdate.Location = new System.Drawing.Point(86, 55);
            this.tbxAdetUpdate.Name = "tbxAdetUpdate";
            this.tbxAdetUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxAdetUpdate.TabIndex = 18;
            // 
            // tbxFiyatUpdate
            // 
            this.tbxFiyatUpdate.Location = new System.Drawing.Point(86, 83);
            this.tbxFiyatUpdate.Name = "tbxFiyatUpdate";
            this.tbxFiyatUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxFiyatUpdate.TabIndex = 17;
            // 
            // tbxÜrünUpdate
            // 
            this.tbxÜrünUpdate.Location = new System.Drawing.Point(86, 27);
            this.tbxÜrünUpdate.Name = "tbxÜrünUpdate";
            this.tbxÜrünUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxÜrünUpdate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fiyat : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ürün : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(31, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 33);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.tbxÜrün);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblÜrün);
            this.groupBox1.Controls.Add(this.lblAdet);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.tbxFiyat);
            this.groupBox1.Controls.Add(this.tbxAdet);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 152);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdbSigara);
            this.groupBox6.Controls.Add(this.rdbGıda);
            this.groupBox6.Controls.Add(this.rdbÇerez);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(188, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(78, 121);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kategori";
            // 
            // rdbSigara
            // 
            this.rdbSigara.AutoSize = true;
            this.rdbSigara.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.rdbSigara.Location = new System.Drawing.Point(6, 26);
            this.rdbSigara.Name = "rdbSigara";
            this.rdbSigara.Size = new System.Drawing.Size(68, 21);
            this.rdbSigara.TabIndex = 30;
            this.rdbSigara.TabStop = true;
            this.rdbSigara.Text = "Sigara";
            this.rdbSigara.UseVisualStyleBackColor = true;
            // 
            // rdbGıda
            // 
            this.rdbGıda.AutoSize = true;
            this.rdbGıda.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.rdbGıda.Location = new System.Drawing.Point(6, 87);
            this.rdbGıda.Name = "rdbGıda";
            this.rdbGıda.Size = new System.Drawing.Size(57, 21);
            this.rdbGıda.TabIndex = 32;
            this.rdbGıda.TabStop = true;
            this.rdbGıda.Text = "Gıda";
            this.rdbGıda.UseVisualStyleBackColor = true;
            // 
            // rdbÇerez
            // 
            this.rdbÇerez.AutoSize = true;
            this.rdbÇerez.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.rdbÇerez.Location = new System.Drawing.Point(6, 57);
            this.rdbÇerez.Name = "rdbÇerez";
            this.rdbÇerez.Size = new System.Drawing.Size(65, 21);
            this.rdbÇerez.TabIndex = 31;
            this.rdbÇerez.TabStop = true;
            this.rdbÇerez.Text = "Çerez";
            this.rdbÇerez.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxÜrünUpdate);
            this.groupBox2.Controls.Add(this.tbxAdetUpdate);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxFiyatUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(6, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 152);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(44, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 35);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgwCerezs
            // 
            this.dgwCerezs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCerezs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCerezs.Location = new System.Drawing.Point(6, 6);
            this.dgwCerezs.Name = "dgwCerezs";
            this.dgwCerezs.RowTemplate.Height = 24;
            this.dgwCerezs.Size = new System.Drawing.Size(520, 158);
            this.dgwCerezs.TabIndex = 22;
            this.dgwCerezs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCerez_CellClick);
            // 
            // btnCerezSil
            // 
            this.btnCerezSil.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCerezSil.Location = new System.Drawing.Point(45, 57);
            this.btnCerezSil.Name = "btnCerezSil";
            this.btnCerezSil.Size = new System.Drawing.Size(191, 35);
            this.btnCerezSil.TabIndex = 25;
            this.btnCerezSil.Text = "Sil";
            this.btnCerezSil.UseVisualStyleBackColor = true;
            this.btnCerezSil.Click += new System.EventHandler(this.btnGıdaSil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxÜrünCerezUpdate);
            this.groupBox3.Controls.Add(this.tbxAdetCerezUpdate);
            this.groupBox3.Controls.Add(this.btnCerezGüncelle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbxFiyatCerezUpdate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(6, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 152);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Güncelle";
            // 
            // tbxÜrünCerezUpdate
            // 
            this.tbxÜrünCerezUpdate.Location = new System.Drawing.Point(92, 28);
            this.tbxÜrünCerezUpdate.Name = "tbxÜrünCerezUpdate";
            this.tbxÜrünCerezUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxÜrünCerezUpdate.TabIndex = 16;
            // 
            // tbxAdetCerezUpdate
            // 
            this.tbxAdetCerezUpdate.Location = new System.Drawing.Point(92, 56);
            this.tbxAdetCerezUpdate.Name = "tbxAdetCerezUpdate";
            this.tbxAdetCerezUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxAdetCerezUpdate.TabIndex = 18;
            // 
            // btnCerezGüncelle
            // 
            this.btnCerezGüncelle.Location = new System.Drawing.Point(37, 112);
            this.btnCerezGüncelle.Name = "btnCerezGüncelle";
            this.btnCerezGüncelle.Size = new System.Drawing.Size(178, 33);
            this.btnCerezGüncelle.TabIndex = 12;
            this.btnCerezGüncelle.Text = "Güncelle";
            this.btnCerezGüncelle.UseVisualStyleBackColor = true;
            this.btnCerezGüncelle.Click += new System.EventHandler(this.btnGıdaGüncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ürün : ";
            // 
            // tbxFiyatCerezUpdate
            // 
            this.tbxFiyatCerezUpdate.Location = new System.Drawing.Point(92, 84);
            this.tbxFiyatCerezUpdate.Name = "tbxFiyatCerezUpdate";
            this.tbxFiyatCerezUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxFiyatCerezUpdate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adet : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fiyat : ";
            // 
            // btnGıdaSil
            // 
            this.btnGıdaSil.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnGıdaSil.Location = new System.Drawing.Point(37, 61);
            this.btnGıdaSil.Name = "btnGıdaSil";
            this.btnGıdaSil.Size = new System.Drawing.Size(191, 35);
            this.btnGıdaSil.TabIndex = 29;
            this.btnGıdaSil.Text = "Sil";
            this.btnGıdaSil.UseVisualStyleBackColor = true;
            this.btnGıdaSil.Click += new System.EventHandler(this.btnGıdaSil_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbxÜrünGıdaUpdate);
            this.groupBox5.Controls.Add(this.tbxAdetGıdaUpdate);
            this.groupBox5.Controls.Add(this.btnGıdaGüncelle);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbxFiyatGıdaUpdate);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(3, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 152);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürün Güncelle";
            // 
            // tbxÜrünGıdaUpdate
            // 
            this.tbxÜrünGıdaUpdate.Location = new System.Drawing.Point(101, 27);
            this.tbxÜrünGıdaUpdate.Name = "tbxÜrünGıdaUpdate";
            this.tbxÜrünGıdaUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxÜrünGıdaUpdate.TabIndex = 16;
            // 
            // tbxAdetGıdaUpdate
            // 
            this.tbxAdetGıdaUpdate.Location = new System.Drawing.Point(101, 55);
            this.tbxAdetGıdaUpdate.Name = "tbxAdetGıdaUpdate";
            this.tbxAdetGıdaUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxAdetGıdaUpdate.TabIndex = 18;
            // 
            // btnGıdaGüncelle
            // 
            this.btnGıdaGüncelle.Location = new System.Drawing.Point(46, 111);
            this.btnGıdaGüncelle.Name = "btnGıdaGüncelle";
            this.btnGıdaGüncelle.Size = new System.Drawing.Size(169, 33);
            this.btnGıdaGüncelle.TabIndex = 12;
            this.btnGıdaGüncelle.Text = "Güncelle";
            this.btnGıdaGüncelle.UseVisualStyleBackColor = true;
            this.btnGıdaGüncelle.Click += new System.EventHandler(this.btnGıdaGüncelle_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ürün : ";
            // 
            // tbxFiyatGıdaUpdate
            // 
            this.tbxFiyatGıdaUpdate.Location = new System.Drawing.Point(101, 83);
            this.tbxFiyatGıdaUpdate.Name = "tbxFiyatGıdaUpdate";
            this.tbxFiyatGıdaUpdate.Size = new System.Drawing.Size(114, 22);
            this.tbxFiyatGıdaUpdate.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Adet : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Fiyat : ";
            // 
            // dgwGıdas
            // 
            this.dgwGıdas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGıdas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGıdas.Location = new System.Drawing.Point(3, 3);
            this.dgwGıdas.Name = "dgwGıdas";
            this.dgwGıdas.RowTemplate.Height = 24;
            this.dgwGıdas.Size = new System.Drawing.Size(523, 164);
            this.dgwGıdas.TabIndex = 26;
            this.dgwGıdas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGıdas_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 357);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgwProducts);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sigara";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(257, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 152);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seçili Ürünü Sil";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.dgwCerezs);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çerez";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnCerezSil);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(261, 173);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(265, 149);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Seçili Ürünü Sil";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.dgwGıdas);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(540, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gıda";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnGıdaSil);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox9.Location = new System.Drawing.Point(268, 176);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(258, 149);
            this.groupBox9.TabIndex = 36;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Seçili Ürünü Sil";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 27);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(155, 121);
            this.button1.TabIndex = 34;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.Navy;
            this.groupBox7.Location = new System.Drawing.Point(333, 376);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(167, 155);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hesaplama Aracı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 535);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Veri Tabanı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCerezs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGıdas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblÜrün;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox tbxÜrün;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.TextBox tbxAdetUpdate;
        private System.Windows.Forms.TextBox tbxFiyatUpdate;
        private System.Windows.Forms.TextBox tbxÜrünUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgwCerezs;
        private System.Windows.Forms.Button btnCerezSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxÜrünCerezUpdate;
        private System.Windows.Forms.TextBox tbxAdetCerezUpdate;
        private System.Windows.Forms.Button btnCerezGüncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFiyatCerezUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGıdaSil;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbxÜrünGıdaUpdate;
        private System.Windows.Forms.TextBox tbxAdetGıdaUpdate;
        private System.Windows.Forms.Button btnGıdaGüncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxFiyatGıdaUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgwGıdas;
        private System.Windows.Forms.RadioButton rdbSigara;
        private System.Windows.Forms.RadioButton rdbÇerez;
        private System.Windows.Forms.RadioButton rdbGıda;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

