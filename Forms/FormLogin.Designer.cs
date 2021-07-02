
namespace HaberPortali_H5190062
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txt_Kadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_ZiyaretciGiris = new System.Windows.Forms.Button();
            this.btn_KayıtOl = new System.Windows.Forms.Button();
            this.panel_Giris = new System.Windows.Forms.Panel();
            this.btn_SimgeDurumu = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Giris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Kadi
            // 
            this.txt_Kadi.Location = new System.Drawing.Point(359, 232);
            this.txt_Kadi.Name = "txt_Kadi";
            this.txt_Kadi.Size = new System.Drawing.Size(195, 20);
            this.txt_Kadi.TabIndex = 6;
            this.txt_Kadi.Text = "kursatsinan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(356, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kullanıcı Adı / Eposta";
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(359, 282);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(195, 20);
            this.txt_Parola.TabIndex = 6;
            this.txt_Parola.Text = "123456";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(356, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parola";
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Crimson;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.Color.White;
            this.btn_Giris.Location = new System.Drawing.Point(359, 317);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(195, 56);
            this.btn_Giris.TabIndex = 8;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_ZiyaretciGiris
            // 
            this.btn_ZiyaretciGiris.BackColor = System.Drawing.Color.Crimson;
            this.btn_ZiyaretciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZiyaretciGiris.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ZiyaretciGiris.ForeColor = System.Drawing.Color.White;
            this.btn_ZiyaretciGiris.Location = new System.Drawing.Point(359, 379);
            this.btn_ZiyaretciGiris.Name = "btn_ZiyaretciGiris";
            this.btn_ZiyaretciGiris.Size = new System.Drawing.Size(93, 56);
            this.btn_ZiyaretciGiris.TabIndex = 8;
            this.btn_ZiyaretciGiris.Text = "Ziyaretçi Girişi";
            this.btn_ZiyaretciGiris.UseVisualStyleBackColor = false;
            this.btn_ZiyaretciGiris.Click += new System.EventHandler(this.btn_ZiyaretciGiris_Click);
            // 
            // btn_KayıtOl
            // 
            this.btn_KayıtOl.BackColor = System.Drawing.Color.Crimson;
            this.btn_KayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KayıtOl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayıtOl.ForeColor = System.Drawing.Color.White;
            this.btn_KayıtOl.Location = new System.Drawing.Point(461, 379);
            this.btn_KayıtOl.Name = "btn_KayıtOl";
            this.btn_KayıtOl.Size = new System.Drawing.Size(93, 56);
            this.btn_KayıtOl.TabIndex = 8;
            this.btn_KayıtOl.Text = "Kayıt Ol";
            this.btn_KayıtOl.UseVisualStyleBackColor = false;
            this.btn_KayıtOl.Click += new System.EventHandler(this.btn_KayıtOl_Click);
            // 
            // panel_Giris
            // 
            this.panel_Giris.Controls.Add(this.btn_SimgeDurumu);
            this.panel_Giris.Controls.Add(this.btn_Cikis);
            this.panel_Giris.Controls.Add(this.pictureBox1);
            this.panel_Giris.Controls.Add(this.label3);
            this.panel_Giris.Controls.Add(this.panel4);
            this.panel_Giris.Controls.Add(this.panel3);
            this.panel_Giris.Controls.Add(this.panel2);
            this.panel_Giris.Controls.Add(this.panel1);
            this.panel_Giris.Controls.Add(this.btn_KayıtOl);
            this.panel_Giris.Controls.Add(this.txt_Kadi);
            this.panel_Giris.Controls.Add(this.btn_ZiyaretciGiris);
            this.panel_Giris.Controls.Add(this.label4);
            this.panel_Giris.Controls.Add(this.txt_Parola);
            this.panel_Giris.Controls.Add(this.btn_Giris);
            this.panel_Giris.Controls.Add(this.label5);
            this.panel_Giris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Giris.Location = new System.Drawing.Point(0, 0);
            this.panel_Giris.Name = "panel_Giris";
            this.panel_Giris.Size = new System.Drawing.Size(900, 550);
            this.panel_Giris.TabIndex = 9;
            // 
            // btn_SimgeDurumu
            // 
            this.btn_SimgeDurumu.BackColor = System.Drawing.Color.White;
            this.btn_SimgeDurumu.FlatAppearance.BorderSize = 0;
            this.btn_SimgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SimgeDurumu.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SimgeDurumu.ForeColor = System.Drawing.Color.White;
            this.btn_SimgeDurumu.Image = ((System.Drawing.Image)(resources.GetObject("btn_SimgeDurumu.Image")));
            this.btn_SimgeDurumu.Location = new System.Drawing.Point(812, 8);
            this.btn_SimgeDurumu.Name = "btn_SimgeDurumu";
            this.btn_SimgeDurumu.Size = new System.Drawing.Size(42, 38);
            this.btn_SimgeDurumu.TabIndex = 15;
            this.btn_SimgeDurumu.UseVisualStyleBackColor = false;
            this.btn_SimgeDurumu.Click += new System.EventHandler(this.btn_SimgeDurumu_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.White;
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.ForeColor = System.Drawing.Color.White;
            this.btn_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cikis.Image")));
            this.btn_Cikis.Location = new System.Drawing.Point(850, 8);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(42, 38);
            this.btn_Cikis.TabIndex = 15;
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(299, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 61);
            this.label3.TabIndex = 13;
            this.label3.Text = "Haber Portalı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(892, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 462);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label_Message);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(8, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 80);
            this.panel3.TabIndex = 11;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.BackColor = System.Drawing.Color.Crimson;
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(6, 11);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 13);
            this.label_Message.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medipol Üniversitesi Bilgisayar Programcılığı Bölümü C# Uygulamaları Dersi Final " +
    "Projesi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 542);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 8);
            this.panel1.TabIndex = 9;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel_Giris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Giris.ResumeLayout(false);
            this.panel_Giris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Kadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_ZiyaretciGiris;
        private System.Windows.Forms.Button btn_KayıtOl;
        private System.Windows.Forms.Panel panel_Giris;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SimgeDurumu;
    }
}

