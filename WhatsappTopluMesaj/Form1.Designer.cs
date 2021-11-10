
namespace WhatsappTopluMesaj
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
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtNumaraGirdisi = new System.Windows.Forms.TextBox();
            this.lblKayitliKisiSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtMesaj
            // 
            this.txtMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(66)))));
            this.txtMesaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMesaj.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMesaj.Location = new System.Drawing.Point(208, 553);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMesaj.Size = new System.Drawing.Size(530, 85);
            this.txtMesaj.TabIndex = 1;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGonder.FlatAppearance.BorderSize = 0;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGonder.Location = new System.Drawing.Point(744, 553);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(94, 85);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtNumaraGirdisi
            // 
            this.txtNumaraGirdisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(66)))));
            this.txtNumaraGirdisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumaraGirdisi.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumaraGirdisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumaraGirdisi.Location = new System.Drawing.Point(12, 81);
            this.txtNumaraGirdisi.Multiline = true;
            this.txtNumaraGirdisi.Name = "txtNumaraGirdisi";
            this.txtNumaraGirdisi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumaraGirdisi.Size = new System.Drawing.Size(190, 557);
            this.txtNumaraGirdisi.TabIndex = 9;
            // 
            // lblKayitliKisiSayisi
            // 
            this.lblKayitliKisiSayisi.AutoSize = true;
            this.lblKayitliKisiSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblKayitliKisiSayisi.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitliKisiSayisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKayitliKisiSayisi.Location = new System.Drawing.Point(231, 20);
            this.lblKayitliKisiSayisi.Name = "lblKayitliKisiSayisi";
            this.lblKayitliKisiSayisi.Size = new System.Drawing.Size(167, 26);
            this.lblKayitliKisiSayisi.TabIndex = 11;
            this.lblKayitliKisiSayisi.Text = "Kayıtlı Kişi Sayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(232, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 126);
            this.label1.TabIndex = 12;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(232, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 105);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(232, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://tr.rakko.tools/tools/22/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKayitliKisiSayisi);
            this.Controls.Add(this.txtNumaraGirdisi);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMesaj);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whatsapp Toplu Mesaj Gönderme Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtNumaraGirdisi;
        private System.Windows.Forms.Label lblKayitliKisiSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

