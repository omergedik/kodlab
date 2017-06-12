namespace Company
{
    partial class yeniFirma
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eposta = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.telno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mail Adresi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefon No :";
            // 
            // adı
            // 
            this.adı.Location = new System.Drawing.Point(118, 9);
            this.adı.Name = "adı";
            this.adı.Size = new System.Drawing.Size(140, 29);
            this.adı.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firma Adı :";
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(118, 79);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(140, 29);
            this.eposta.TabIndex = 2;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(118, 114);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(140, 29);
            this.adres.TabIndex = 3;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(118, 44);
            this.telno.Mask = "(999) 000-0000";
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(140, 29);
            this.telno.TabIndex = 1;
            // 
            // yeniFirma
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(274, 185);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.eposta);
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
            this.Name = "yeniFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Firma Ekle";
            this.Load += new System.EventHandler(this.yeniFirma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.MaskedTextBox telno;
    }
}