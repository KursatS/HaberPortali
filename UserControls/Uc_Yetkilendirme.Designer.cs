
namespace HaberPortali_H5190062
{
    partial class Uc_Yetkilendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Yetkilendirme));
            this.txt_AraEposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Cinsiyet = new System.Windows.Forms.TextBox();
            this.txt_Kad = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.comboBox_Yetki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_AraEposta
            // 
            this.txt_AraEposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AraEposta.Location = new System.Drawing.Point(296, 88);
            this.txt_AraEposta.Name = "txt_AraEposta";
            this.txt_AraEposta.Size = new System.Drawing.Size(175, 20);
            this.txt_AraEposta.TabIndex = 0;
            this.txt_AraEposta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcının Eposta Adresi";
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Id.Location = new System.Drawing.Point(213, 175);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(121, 20);
            this.txt_Id.TabIndex = 2;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Ad.Location = new System.Drawing.Point(213, 254);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(121, 20);
            this.txt_Ad.TabIndex = 3;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Soyad.Location = new System.Drawing.Point(213, 333);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(121, 20);
            this.txt_Soyad.TabIndex = 4;
            // 
            // txt_Cinsiyet
            // 
            this.txt_Cinsiyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cinsiyet.Location = new System.Drawing.Point(430, 333);
            this.txt_Cinsiyet.Name = "txt_Cinsiyet";
            this.txt_Cinsiyet.ReadOnly = true;
            this.txt_Cinsiyet.Size = new System.Drawing.Size(121, 20);
            this.txt_Cinsiyet.TabIndex = 5;
            // 
            // txt_Kad
            // 
            this.txt_Kad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Kad.Location = new System.Drawing.Point(430, 175);
            this.txt_Kad.Name = "txt_Kad";
            this.txt_Kad.ReadOnly = true;
            this.txt_Kad.Size = new System.Drawing.Size(121, 20);
            this.txt_Kad.TabIndex = 6;
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Eposta.Location = new System.Drawing.Point(430, 254);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.ReadOnly = true;
            this.txt_Eposta.Size = new System.Drawing.Size(121, 20);
            this.txt_Eposta.TabIndex = 7;
            // 
            // comboBox_Yetki
            // 
            this.comboBox_Yetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Yetki.FormattingEnabled = true;
            this.comboBox_Yetki.Location = new System.Drawing.Point(321, 409);
            this.comboBox_Yetki.Name = "comboBox_Yetki";
            this.comboBox_Yetki.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Yetki.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adı";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyadı";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Eposta";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Yetki";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label_Message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 40);
            this.panel1.TabIndex = 16;
            // 
            // label_Message
            // 
            this.label_Message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(20, 13);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 13);
            this.label_Message.TabIndex = 0;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Kaydet.FlatAppearance.BorderSize = 0;
            this.btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.Image")));
            this.btn_Kaydet.Location = new System.Drawing.Point(571, 437);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(45, 45);
            this.btn_Kaydet.TabIndex = 17;
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // Uc_Yetkilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Yetki);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.txt_Kad);
            this.Controls.Add(this.txt_Cinsiyet);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AraEposta);
            this.Name = "Uc_Yetkilendirme";
            this.Size = new System.Drawing.Size(772, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AraEposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Cinsiyet;
        private System.Windows.Forms.TextBox txt_Kad;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.ComboBox comboBox_Yetki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button btn_Kaydet;
    }
}