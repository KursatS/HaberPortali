
namespace HaberPortali_H5190062
{
    partial class Uc_Yorum
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
            this.richTextBox_Yorum = new System.Windows.Forms.RichTextBox();
            this.label_YorumSahibi = new System.Windows.Forms.Label();
            this.label_YorumSahibiSoyad = new System.Windows.Forms.Label();
            this.label_YorumTarihi = new System.Windows.Forms.Label();
            this.label_YorumSahibiYetki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_Yorum
            // 
            this.richTextBox_Yorum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_Yorum.Location = new System.Drawing.Point(43, 35);
            this.richTextBox_Yorum.Name = "richTextBox_Yorum";
            this.richTextBox_Yorum.Size = new System.Drawing.Size(676, 56);
            this.richTextBox_Yorum.TabIndex = 0;
            this.richTextBox_Yorum.Text = "";
            // 
            // label_YorumSahibi
            // 
            this.label_YorumSahibi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_YorumSahibi.AutoSize = true;
            this.label_YorumSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_YorumSahibi.Location = new System.Drawing.Point(47, 16);
            this.label_YorumSahibi.Name = "label_YorumSahibi";
            this.label_YorumSahibi.Size = new System.Drawing.Size(22, 13);
            this.label_YorumSahibi.TabIndex = 1;
            this.label_YorumSahibi.Text = "Ad";
            // 
            // label_YorumSahibiSoyad
            // 
            this.label_YorumSahibiSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_YorumSahibiSoyad.AutoSize = true;
            this.label_YorumSahibiSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_YorumSahibiSoyad.Location = new System.Drawing.Point(88, 16);
            this.label_YorumSahibiSoyad.Name = "label_YorumSahibiSoyad";
            this.label_YorumSahibiSoyad.Size = new System.Drawing.Size(42, 13);
            this.label_YorumSahibiSoyad.TabIndex = 1;
            this.label_YorumSahibiSoyad.Text = "Soyad";
            // 
            // label_YorumTarihi
            // 
            this.label_YorumTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_YorumTarihi.AutoSize = true;
            this.label_YorumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_YorumTarihi.Location = new System.Drawing.Point(590, 16);
            this.label_YorumTarihi.Name = "label_YorumTarihi";
            this.label_YorumTarihi.Size = new System.Drawing.Size(108, 13);
            this.label_YorumTarihi.TabIndex = 1;
            this.label_YorumTarihi.Text = "label_YorumTarihi";
            // 
            // label_YorumSahibiYetki
            // 
            this.label_YorumSahibiYetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_YorumSahibiYetki.AutoSize = true;
            this.label_YorumSahibiYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_YorumSahibiYetki.Location = new System.Drawing.Point(152, 16);
            this.label_YorumSahibiYetki.Name = "label_YorumSahibiYetki";
            this.label_YorumSahibiYetki.Size = new System.Drawing.Size(36, 13);
            this.label_YorumSahibiYetki.TabIndex = 1;
            this.label_YorumSahibiYetki.Text = "Yetki";
            // 
            // Uc_Yorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_YorumTarihi);
            this.Controls.Add(this.label_YorumSahibiYetki);
            this.Controls.Add(this.label_YorumSahibiSoyad);
            this.Controls.Add(this.label_YorumSahibi);
            this.Controls.Add(this.richTextBox_Yorum);
            this.Name = "Uc_Yorum";
            this.Size = new System.Drawing.Size(772, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Yorum;
        private System.Windows.Forms.Label label_YorumSahibi;
        private System.Windows.Forms.Label label_YorumSahibiSoyad;
        private System.Windows.Forms.Label label_YorumTarihi;
        private System.Windows.Forms.Label label_YorumSahibiYetki;
    }
}