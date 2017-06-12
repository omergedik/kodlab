namespace Company
{
    partial class yeniÇalışan
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
            this.isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.eposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doğumtarihi = new System.Windows.Forms.MaskedTextBox();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.telno = new System.Windows.Forms.MaskedTextBox();
            this.hesapno = new System.Windows.Forms.MaskedTextBox();
            this.pozisyonCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(17, 152);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(140, 29);
            this.isim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "İsim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mail Adresi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password :";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(17, 33);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(140, 29);
            this.username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username :";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(17, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(140, 29);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(17, 213);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(140, 29);
            this.eposta.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hesap No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Telefon No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "TC Kimlik :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Doğum Tarihi :";
            // 
            // doğumtarihi
            // 
            this.doğumtarihi.Location = new System.Drawing.Point(202, 213);
            this.doğumtarihi.Mask = "00/00/0000";
            this.doğumtarihi.Name = "doğumtarihi";
            this.doğumtarihi.Size = new System.Drawing.Size(140, 29);
            this.doğumtarihi.TabIndex = 8;
            this.doğumtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(202, 152);
            this.tc.Mask = "000000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(140, 29);
            this.tc.TabIndex = 7;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(202, 93);
            this.telno.Mask = "(999) 000-0000";
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(140, 29);
            this.telno.TabIndex = 6;
            // 
            // hesapno
            // 
            this.hesapno.Location = new System.Drawing.Point(202, 33);
            this.hesapno.Mask = "00000000";
            this.hesapno.Name = "hesapno";
            this.hesapno.Size = new System.Drawing.Size(140, 29);
            this.hesapno.TabIndex = 5;
            // 
            // pozisyonCombo
            // 
            this.pozisyonCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pozisyonCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pozisyonCombo.FormattingEnabled = true;
            this.pozisyonCombo.Items.AddRange(new object[] {
            "Müdür",
            "Programcı",
            "Pazarlamacı",
            "Sekreter"});
            this.pozisyonCombo.Location = new System.Drawing.Point(17, 275);
            this.pozisyonCombo.Name = "pozisyonCombo";
            this.pozisyonCombo.Size = new System.Drawing.Size(140, 29);
            this.pozisyonCombo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Pozisyon :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yeniÇalışan
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(354, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pozisyonCombo);
            this.Controls.Add(this.hesapno);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.doğumtarihi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.password);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "yeniÇalışan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Çalışan Ekle";
            this.Load += new System.EventHandler(this.yeniÇalışan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox doğumtarihi;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.MaskedTextBox telno;
        private System.Windows.Forms.MaskedTextBox hesapno;
        private System.Windows.Forms.ComboBox pozisyonCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}