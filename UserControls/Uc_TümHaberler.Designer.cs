
namespace HaberPortali_H5190062
{
    partial class Uc_TümHaberler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_TümHaberler));
            this.dataGridView_TumHaberler = new System.Windows.Forms.DataGridView();
            this.tblHaberlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbHaberPortaliDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbHaberPortaliDataSet = new HaberPortali_H5190062.DbHaberPortaliDataSet();
            this.pictureBox_HaberResmi = new System.Windows.Forms.PictureBox();
            this.richTextBox_HaberYazisi = new System.Windows.Forms.RichTextBox();
            this.tblHaberlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_HaberlerTableAdapter = new HaberPortali_H5190062.DbHaberPortaliDataSetTableAdapters.tbl_HaberlerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_HaberBaslik = new System.Windows.Forms.TextBox();
            this.txt_HaberAltBaslik = new System.Windows.Forms.TextBox();
            this.txt_HaberYayinTarihi = new System.Windows.Forms.TextBox();
            this.txt_HaberKategorisi = new System.Windows.Forms.TextBox();
            this.txt_HaberTuru = new System.Windows.Forms.TextBox();
            this.txt_HaberYazari = new System.Windows.Forms.TextBox();
            this.fKtblEtkilesimtblHaberlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_YorumTableAdapter = new HaberPortali_H5190062.DbHaberPortaliDataSetTableAdapters.tbl_YorumTableAdapter();
            this.comboBox_HaberKategorisi = new System.Windows.Forms.ComboBox();
            this.comboBox_HaberYazari = new System.Windows.Forms.ComboBox();
            this.comboBox_HaberTuru = new System.Windows.Forms.ComboBox();
            this.dtp_Gun = new System.Windows.Forms.DateTimePicker();
            this.btn_FiltreliAra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.txt_HaberId = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.checkBox_Pasifmi = new System.Windows.Forms.CheckBox();
            this.openFDResim = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_OkunmaSayisi = new System.Windows.Forms.TextBox();
            this.txt_BegeniSayisi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TumHaberler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHaberlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHaberPortaliDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHaberPortaliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HaberResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHaberlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblEtkilesimtblHaberlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_TumHaberler
            // 
            this.dataGridView_TumHaberler.AllowUserToAddRows = false;
            this.dataGridView_TumHaberler.AllowUserToDeleteRows = false;
            this.dataGridView_TumHaberler.BackgroundColor = System.Drawing.Color.Crimson;
            this.dataGridView_TumHaberler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TumHaberler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_TumHaberler.Location = new System.Drawing.Point(0, 368);
            this.dataGridView_TumHaberler.Name = "dataGridView_TumHaberler";
            this.dataGridView_TumHaberler.ReadOnly = true;
            this.dataGridView_TumHaberler.Size = new System.Drawing.Size(772, 194);
            this.dataGridView_TumHaberler.TabIndex = 0;
            this.dataGridView_TumHaberler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TumHaberler_CellClick);
            // 
            // tblHaberlerBindingSource1
            // 
            this.tblHaberlerBindingSource1.DataMember = "tbl_Haberler";
            this.tblHaberlerBindingSource1.DataSource = this.dbHaberPortaliDataSetBindingSource;
            // 
            // dbHaberPortaliDataSetBindingSource
            // 
            this.dbHaberPortaliDataSetBindingSource.DataSource = this.dbHaberPortaliDataSet;
            this.dbHaberPortaliDataSetBindingSource.Position = 0;
            // 
            // dbHaberPortaliDataSet
            // 
            this.dbHaberPortaliDataSet.DataSetName = "DbHaberPortaliDataSet";
            this.dbHaberPortaliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox_HaberResmi
            // 
            this.pictureBox_HaberResmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_HaberResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_HaberResmi.Location = new System.Drawing.Point(370, 13);
            this.pictureBox_HaberResmi.Name = "pictureBox_HaberResmi";
            this.pictureBox_HaberResmi.Size = new System.Drawing.Size(335, 160);
            this.pictureBox_HaberResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_HaberResmi.TabIndex = 1;
            this.pictureBox_HaberResmi.TabStop = false;
            // 
            // richTextBox_HaberYazisi
            // 
            this.richTextBox_HaberYazisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_HaberYazisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_HaberYazisi.Location = new System.Drawing.Point(68, 198);
            this.richTextBox_HaberYazisi.Name = "richTextBox_HaberYazisi";
            this.richTextBox_HaberYazisi.ReadOnly = true;
            this.richTextBox_HaberYazisi.Size = new System.Drawing.Size(637, 106);
            this.richTextBox_HaberYazisi.TabIndex = 22;
            this.richTextBox_HaberYazisi.Text = "";
            // 
            // tblHaberlerBindingSource
            // 
            this.tblHaberlerBindingSource.DataMember = "tbl_Haberler";
            this.tblHaberlerBindingSource.DataSource = this.dbHaberPortaliDataSetBindingSource;
            // 
            // tbl_HaberlerTableAdapter
            // 
            this.tbl_HaberlerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Haber Başlığı";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Haber Alt Başlığı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Haber Yayın Tarihi";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Haber Yazısı";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Haber Kategorisi";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Haber Yazarı";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Haber Türü";
            // 
            // txt_HaberBaslik
            // 
            this.txt_HaberBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HaberBaslik.Location = new System.Drawing.Point(40, 27);
            this.txt_HaberBaslik.Name = "txt_HaberBaslik";
            this.txt_HaberBaslik.ReadOnly = true;
            this.txt_HaberBaslik.Size = new System.Drawing.Size(149, 20);
            this.txt_HaberBaslik.TabIndex = 26;
            // 
            // txt_HaberAltBaslik
            // 
            this.txt_HaberAltBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HaberAltBaslik.Location = new System.Drawing.Point(40, 68);
            this.txt_HaberAltBaslik.Name = "txt_HaberAltBaslik";
            this.txt_HaberAltBaslik.ReadOnly = true;
            this.txt_HaberAltBaslik.Size = new System.Drawing.Size(149, 20);
            this.txt_HaberAltBaslik.TabIndex = 26;
            // 
            // txt_HaberYayinTarihi
            // 
            this.txt_HaberYayinTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HaberYayinTarihi.Location = new System.Drawing.Point(40, 109);
            this.txt_HaberYayinTarihi.Name = "txt_HaberYayinTarihi";
            this.txt_HaberYayinTarihi.ReadOnly = true;
            this.txt_HaberYayinTarihi.Size = new System.Drawing.Size(149, 20);
            this.txt_HaberYayinTarihi.TabIndex = 26;
            // 
            // txt_HaberKategorisi
            // 
            this.txt_HaberKategorisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HaberKategorisi.Location = new System.Drawing.Point(199, 109);
            this.txt_HaberKategorisi.Name = "txt_HaberKategorisi";
            this.txt_HaberKategorisi.ReadOnly = true;
            this.txt_HaberKategorisi.Size = new System.Drawing.Size(149, 20);
            this.txt_HaberKategorisi.TabIndex = 26;
            // 
            // txt_HaberTuru
            // 
            this.txt_HaberTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HaberTuru.Location = new System.Drawing.Point(199, 27);
            this.txt_HaberTuru.Name = "txt_HaberTuru";
            this.txt_HaberTuru.ReadOnly = true;
            this.txt_HaberTuru.Size = new System.Drawing.Size(149, 20);
            this.txt_HaberTuru.TabIndex = 26;
            // 
            // txt_HaberYazari
            // 
            this.txt_HaberYazari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HaberYazari.Location = new System.Drawing.Point(199, 68);
            this.txt_HaberYazari.Name = "txt_HaberYazari";
            this.txt_HaberYazari.ReadOnly = true;
            this.txt_HaberYazari.Size = new System.Drawing.Size(149, 20);
            this.txt_HaberYazari.TabIndex = 26;
            // 
            // fKtblEtkilesimtblHaberlerBindingSource
            // 
            this.fKtblEtkilesimtblHaberlerBindingSource.DataMember = "FK_tbl_Etkilesim_tbl_Haberler";
            this.fKtblEtkilesimtblHaberlerBindingSource.DataSource = this.tblHaberlerBindingSource;
            // 
            // tbl_YorumTableAdapter
            // 
            this.tbl_YorumTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_HaberKategorisi
            // 
            this.comboBox_HaberKategorisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_HaberKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HaberKategorisi.FormattingEnabled = true;
            this.comboBox_HaberKategorisi.Location = new System.Drawing.Point(219, 326);
            this.comboBox_HaberKategorisi.Name = "comboBox_HaberKategorisi";
            this.comboBox_HaberKategorisi.Size = new System.Drawing.Size(121, 21);
            this.comboBox_HaberKategorisi.TabIndex = 27;
            // 
            // comboBox_HaberYazari
            // 
            this.comboBox_HaberYazari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_HaberYazari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HaberYazari.FormattingEnabled = true;
            this.comboBox_HaberYazari.Location = new System.Drawing.Point(68, 326);
            this.comboBox_HaberYazari.Name = "comboBox_HaberYazari";
            this.comboBox_HaberYazari.Size = new System.Drawing.Size(121, 21);
            this.comboBox_HaberYazari.TabIndex = 28;
            // 
            // comboBox_HaberTuru
            // 
            this.comboBox_HaberTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_HaberTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HaberTuru.FormattingEnabled = true;
            this.comboBox_HaberTuru.Location = new System.Drawing.Point(370, 326);
            this.comboBox_HaberTuru.Name = "comboBox_HaberTuru";
            this.comboBox_HaberTuru.Size = new System.Drawing.Size(121, 21);
            this.comboBox_HaberTuru.TabIndex = 27;
            // 
            // dtp_Gun
            // 
            this.dtp_Gun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Gun.Location = new System.Drawing.Point(517, 326);
            this.dtp_Gun.MaxDate = new System.DateTime(9998, 1, 1, 0, 0, 0, 0);
            this.dtp_Gun.Name = "dtp_Gun";
            this.dtp_Gun.Size = new System.Drawing.Size(172, 20);
            this.dtp_Gun.TabIndex = 29;
            this.dtp_Gun.Value = new System.DateTime(2021, 6, 14, 0, 0, 0, 0);
            this.dtp_Gun.ValueChanged += new System.EventHandler(this.dtp_Gun_ValueChanged);
            // 
            // btn_FiltreliAra
            // 
            this.btn_FiltreliAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FiltreliAra.FlatAppearance.BorderSize = 0;
            this.btn_FiltreliAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiltreliAra.Image = ((System.Drawing.Image)(resources.GetObject("btn_FiltreliAra.Image")));
            this.btn_FiltreliAra.Location = new System.Drawing.Point(711, 310);
            this.btn_FiltreliAra.Name = "btn_FiltreliAra";
            this.btn_FiltreliAra.Size = new System.Drawing.Size(50, 50);
            this.btn_FiltreliAra.TabIndex = 31;
            this.btn_FiltreliAra.UseVisualStyleBackColor = true;
            this.btn_FiltreliAra.Click += new System.EventHandler(this.btn_FiltreliAra_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Haber Yazarı";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Haber Kategorisi";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Haber Türü";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(514, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Yayın Tarihi";
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Duzenle.FlatAppearance.BorderSize = 0;
            this.btn_Duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Duzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Duzenle.Image")));
            this.btn_Duzenle.Location = new System.Drawing.Point(711, 254);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(50, 50);
            this.btn_Duzenle.TabIndex = 31;
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Visible = false;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // txt_HaberId
            // 
            this.txt_HaberId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HaberId.Location = new System.Drawing.Point(740, 3);
            this.txt_HaberId.Name = "txt_HaberId";
            this.txt_HaberId.ReadOnly = true;
            this.txt_HaberId.Size = new System.Drawing.Size(29, 20);
            this.txt_HaberId.TabIndex = 26;
            this.txt_HaberId.Visible = false;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.Location = new System.Drawing.Point(711, 198);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(50, 50);
            this.btn_Sil.TabIndex = 31;
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Visible = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // checkBox_Pasifmi
            // 
            this.checkBox_Pasifmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Pasifmi.AutoSize = true;
            this.checkBox_Pasifmi.Location = new System.Drawing.Point(0, 328);
            this.checkBox_Pasifmi.Name = "checkBox_Pasifmi";
            this.checkBox_Pasifmi.Size = new System.Drawing.Size(68, 17);
            this.checkBox_Pasifmi.TabIndex = 36;
            this.checkBox_Pasifmi.Text = "Pasif mi?";
            this.checkBox_Pasifmi.UseVisualStyleBackColor = true;
            // 
            // openFDResim
            // 
            this.openFDResim.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Haberin Okunma Sayısı";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Haberin Beğeni Sayısı";
            // 
            // txt_OkunmaSayisi
            // 
            this.txt_OkunmaSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_OkunmaSayisi.Location = new System.Drawing.Point(40, 153);
            this.txt_OkunmaSayisi.Name = "txt_OkunmaSayisi";
            this.txt_OkunmaSayisi.ReadOnly = true;
            this.txt_OkunmaSayisi.Size = new System.Drawing.Size(149, 20);
            this.txt_OkunmaSayisi.TabIndex = 26;
            // 
            // txt_BegeniSayisi
            // 
            this.txt_BegeniSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BegeniSayisi.Location = new System.Drawing.Point(199, 153);
            this.txt_BegeniSayisi.Name = "txt_BegeniSayisi";
            this.txt_BegeniSayisi.ReadOnly = true;
            this.txt_BegeniSayisi.Size = new System.Drawing.Size(149, 20);
            this.txt_BegeniSayisi.TabIndex = 26;
            // 
            // Uc_TümHaberler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox_Pasifmi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.btn_FiltreliAra);
            this.Controls.Add(this.dtp_Gun);
            this.Controls.Add(this.comboBox_HaberYazari);
            this.Controls.Add(this.comboBox_HaberTuru);
            this.Controls.Add(this.comboBox_HaberKategorisi);
            this.Controls.Add(this.txt_BegeniSayisi);
            this.Controls.Add(this.txt_HaberKategorisi);
            this.Controls.Add(this.txt_OkunmaSayisi);
            this.Controls.Add(this.txt_HaberYayinTarihi);
            this.Controls.Add(this.txt_HaberYazari);
            this.Controls.Add(this.txt_HaberAltBaslik);
            this.Controls.Add(this.txt_HaberTuru);
            this.Controls.Add(this.txt_HaberId);
            this.Controls.Add(this.txt_HaberBaslik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_HaberYazisi);
            this.Controls.Add(this.pictureBox_HaberResmi);
            this.Controls.Add(this.dataGridView_TumHaberler);
            this.Name = "Uc_TümHaberler";
            this.Size = new System.Drawing.Size(772, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TumHaberler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHaberlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHaberPortaliDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHaberPortaliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HaberResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHaberlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblEtkilesimtblHaberlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_TumHaberler;
        private System.Windows.Forms.BindingSource dbHaberPortaliDataSetBindingSource;
        private DbHaberPortaliDataSet dbHaberPortaliDataSet;
        private System.Windows.Forms.PictureBox pictureBox_HaberResmi;
        private System.Windows.Forms.RichTextBox richTextBox_HaberYazisi;
        private System.Windows.Forms.BindingSource tblHaberlerBindingSource;
        private DbHaberPortaliDataSetTableAdapters.tbl_HaberlerTableAdapter tbl_HaberlerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_HaberBaslik;
        private System.Windows.Forms.TextBox txt_HaberAltBaslik;
        private System.Windows.Forms.TextBox txt_HaberYayinTarihi;
        private System.Windows.Forms.TextBox txt_HaberKategorisi;
        private System.Windows.Forms.TextBox txt_HaberTuru;
        private System.Windows.Forms.TextBox txt_HaberYazari;
        private System.Windows.Forms.BindingSource tblHaberlerBindingSource1;
        private System.Windows.Forms.BindingSource fKtblEtkilesimtblHaberlerBindingSource;
        private DbHaberPortaliDataSetTableAdapters.tbl_YorumTableAdapter tbl_YorumTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_HaberKategorisi;
        private System.Windows.Forms.ComboBox comboBox_HaberYazari;
        private System.Windows.Forms.ComboBox comboBox_HaberTuru;
        private System.Windows.Forms.DateTimePicker dtp_Gun;
        private System.Windows.Forms.Button btn_FiltreliAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.TextBox txt_HaberId;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.CheckBox checkBox_Pasifmi;
        private System.Windows.Forms.OpenFileDialog openFDResim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_OkunmaSayisi;
        private System.Windows.Forms.TextBox txt_BegeniSayisi;
    }
}