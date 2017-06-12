namespace Company
{
    partial class yeniKitap
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
            this.fiyatı = new System.Windows.Forms.MaskedTextBox();
            this.yayıntarihi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yazarı = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fiyatı
            // 
            this.fiyatı.Location = new System.Drawing.Point(123, 117);
            this.fiyatı.Mask = "000";
            this.fiyatı.Name = "fiyatı";
            this.fiyatı.Size = new System.Drawing.Size(40, 29);
            this.fiyatı.TabIndex = 3;
            this.fiyatı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yayıntarihi
            // 
            this.yayıntarihi.Location = new System.Drawing.Point(123, 82);
            this.yayıntarihi.Mask = "00/00/0000";
            this.yayıntarihi.Name = "yayıntarihi";
            this.yayıntarihi.Size = new System.Drawing.Size(140, 29);
            this.yayıntarihi.TabIndex = 2;
            this.yayıntarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "TL";
            // 
            // yazarı
            // 
            this.yazarı.Location = new System.Drawing.Point(123, 47);
            this.yazarı.Name = "yazarı";
            this.yazarı.Size = new System.Drawing.Size(140, 29);
            this.yazarı.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Yayın Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kitap Yazarı :";
            // 
            // adı
            // 
            this.adı.Location = new System.Drawing.Point(123, 12);
            this.adı.Name = "adı";
            this.adı.Size = new System.Drawing.Size(140, 29);
            this.adı.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kitap Adı :";
            // 
            // yeniKitap
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(283, 163);
            this.Controls.Add(this.fiyatı);
            this.Controls.Add(this.yayıntarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yazarı);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adı);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "yeniKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kitap Ekle";
            this.Load += new System.EventHandler(this.yeniKitap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox fiyatı;
        private System.Windows.Forms.MaskedTextBox yayıntarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yazarı;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adı;
        private System.Windows.Forms.Label label1;

    }
}