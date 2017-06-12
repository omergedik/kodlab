using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Company
{
    public partial class Anasayfa : Form
    {
        public Login _login;
        public string dosya = Application.StartupPath + @"..\..\..\Dosya";

        bool userSet = false;
        Kullanıcı _girisYapan;
        public Kullanıcı girisYapan { get { return _girisYapan; } set { if (!userSet) { _girisYapan = value; userSet = true; } } }   
        
        public Anasayfa()
        {
            InitializeComponent();
        }

        PictureBox kullaniciResim,kitapResim;
        public Button kullaniciGor, kitapGör,FirmaGör;
        Button kullaniciSil, kitapSil,FirmaSil,DuyuruSil;
        Label kullaniciIsmi,  kitapIsmi,FirmaIsmi;
        LinkLabel duyuruBas;
        public TableLayoutPanel tableFirmalar, tableDuyuru, tableKitaplar, tableKullanıcı;

        public void duyuruGetir() 
        {
            tableDuyuru = new TableLayoutPanel();
            tableDuyuru.BackColor = System.Drawing.Color.LightSlateGray;
            tableDuyuru.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableDuyuru.ColumnCount = 2;
            tableDuyuru.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3935F));
            tableDuyuru.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableDuyuru.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tableDuyuru.ForeColor = System.Drawing.Color.Cornsilk;
            tableDuyuru.Location = new System.Drawing.Point(0, 0);
            tableDuyuru.Name = "tableDuyuru";
            tableDuyuru.RowCount = _login.duyurular.Count;
            tableDuyuru.Size = new System.Drawing.Size(210, (_login.duyurular.Count * 33));
            tableDuyuru.Parent = DuyurularPanel;

            if (tableDuyuru.Height > DuyurularPanel.Height)
                tableDuyuru.Width = 190;


            for (int i = 0; i < _login.duyurular.Count; i++)
            {
                tableDuyuru.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));


                DuyuruSil = new Button();
                DuyuruSil.BackColor = System.Drawing.Color.IndianRed;
                DuyuruSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                DuyuruSil.Location = new System.Drawing.Point(332, 4);
                DuyuruSil.Size = new System.Drawing.Size(42, 28);
                DuyuruSil.TabIndex = i;
                DuyuruSil.Text = "SİL";
                DuyuruSil.Name = _login.duyurular[i].Baslik;
                DuyuruSil.UseVisualStyleBackColor = false;
                DuyuruSil.Click += new EventHandler(DuyuruSil_Click);

                duyuruBas = new LinkLabel();
                duyuruBas.ActiveLinkColor = System.Drawing.Color.Brown;
                duyuruBas.AutoSize = true;
                duyuruBas.Cursor = System.Windows.Forms.Cursors.Hand;
                duyuruBas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                duyuruBas.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                duyuruBas.Location = new System.Drawing.Point(50, 1);
                duyuruBas.Size = new System.Drawing.Size(220, 30);
                duyuruBas.LinkColor = Color.LightCyan;
                duyuruBas.ActiveLinkColor = Color.DarkKhaki;
                duyuruBas.TabIndex = 27;
                duyuruBas.TabStop = true;
                duyuruBas.Name = _login.duyurular[i].Baslik;
                duyuruBas.Text = _login.duyurular[i].Baslik + " \n" + string.Format("{0:dd MMMM yyyy dddd}", _login.duyurular[i].Tarih);
                duyuruBas.LinkClicked += new LinkLabelLinkClickedEventHandler(duyuruBas_LinkClicked);


                tableDuyuru.Controls.Add(duyuruBas, 0, i);
                tableDuyuru.Controls.Add(DuyuruSil, 1, i);
            }
        }

        public void firmaGetir() 
        {
            tableFirmalar = new TableLayoutPanel();
            tableFirmalar.Size = new System.Drawing.Size(382, (_login.firmalar.Count) * 36);
            tableFirmalar.ColumnCount = 3;
            tableFirmalar.BackColor = System.Drawing.Color.LightSlateGray;
            tableFirmalar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableFirmalar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3935F));
            tableFirmalar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableFirmalar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableFirmalar.RowCount = _login.firmalar.Count;
            tableFirmalar.Location = new Point(0, 0);

            tableFirmalar.Parent = FirmalarPanel;

            if (tableFirmalar.Height > FirmalarPanel.Height)
                tableFirmalar.Width = 360;

            for (int i = 0; i < _login.firmalar.Count; i++)
            {
                //if (girisYapan.UserName == _login.firmalar[i].UserName)
                //continue;

                tableFirmalar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                // BUTTONS
                FirmaSil = new Button();
                FirmaSil.BackColor = System.Drawing.Color.IndianRed;
                FirmaSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                FirmaSil.Location = new System.Drawing.Point(332, 4);
                FirmaSil.Size = new System.Drawing.Size(42, 28);
                FirmaSil.TabIndex = i;
                FirmaSil.Text = "SİL";
                FirmaSil.Name = _login.firmalar[i].ŞirketIsmi;
                FirmaSil.UseVisualStyleBackColor = false;
                FirmaSil.Click += new EventHandler(FirmaSil_Click);


                FirmaGör = new Button();
                FirmaGör.BackColor = System.Drawing.Color.MistyRose;
                FirmaGör.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                FirmaGör.Location = new System.Drawing.Point(281, 4);
                FirmaGör.Size = new System.Drawing.Size(44, 28);
                FirmaGör.ForeColor = Color.Black;
                FirmaGör.TabIndex = i;
                FirmaGör.Text = "GÖR";
                FirmaGör.Name = _login.firmalar[i].ŞirketIsmi;
                FirmaGör.UseVisualStyleBackColor = false;
                FirmaGör.Click += new EventHandler(FirmaGör_Click);


                // Label
                FirmaIsmi = new Label();
                FirmaIsmi.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                FirmaIsmi.ForeColor = Color.LightCyan;
                FirmaIsmi.Location = new System.Drawing.Point(50, 1);
                FirmaIsmi.Size = new System.Drawing.Size(220, 30);
                FirmaIsmi.TabIndex = 25;
                FirmaIsmi.Text = _login.firmalar[i].ŞirketIsmi + "\n" + _login.firmalar[i].Adres;//+ " \n" + _login.firmalar[i].TelNo;// + " - {" + _login.firmalar[i].Pozisyon + "}";


                tableFirmalar.Controls.Add(FirmaIsmi, 0, i);
                tableFirmalar.Controls.Add(FirmaGör, 1, i);
                tableFirmalar.Controls.Add(FirmaSil, 2, i);
            }
        }

        public void kullanıcıGetir()
        {
            tableKullanıcı = new TableLayoutPanel();
            tableKullanıcı.Size = new System.Drawing.Size(382, (_login.kullanıcılar.Count) * 36);
            tableKullanıcı.ColumnCount = 4;
            tableKullanıcı.BackColor = System.Drawing.Color.LightSlateGray;
            tableKullanıcı.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableKullanıcı.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6065F));
            tableKullanıcı.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3935F));
            tableKullanıcı.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableKullanıcı.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableKullanıcı.RowCount = _login.kullanıcılar.Count;
            tableKullanıcı.Location = new Point(0, 0);

            tableKullanıcı.Parent = ÇalışanlarPanel;

            if (tableKullanıcı.Height > ÇalışanlarPanel.Height)
                tableKullanıcı.Width = 360;

            for (int i = 0; i < _login.kullanıcılar.Count; i++)
            {
                //if (girisYapan.UserName == _login.kullanicilar[i].UserName)
                //continue;

                tableKullanıcı.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                // PİCTURE
                kullaniciResim = new PictureBox();

                try { kullaniciResim.Image = Image.FromFile(_login.kullanıcılar[i].resim); }
                catch { kullaniciResim.Image = Image.FromFile(dosya + @"\usrImg\default.png"); }
                kullaniciResim.Location = new System.Drawing.Point(4, 4);
                //kullaniciResim.Name = "pictureBox4";
                kullaniciResim.Size = new System.Drawing.Size(70, 48);
                kullaniciResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


                // BUTTONS
                kullaniciSil = new Button();
                kullaniciSil.BackColor = System.Drawing.Color.IndianRed;
                kullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                kullaniciSil.Location = new System.Drawing.Point(332, 4);
                kullaniciSil.Size = new System.Drawing.Size(42, 28);
                kullaniciSil.TabIndex = i;
                kullaniciSil.Text = "SİL";
                kullaniciSil.Name = i.ToString();
                kullaniciSil.UseVisualStyleBackColor = false;
                kullaniciSil.Click += new EventHandler(kullaniciSil_Click);

                if (_login.kullanıcılar[i].GetType() == typeof(Müdür))
                    kullaniciSil.Enabled = true;

                kullaniciGor = new Button();
                kullaniciGor.BackColor = System.Drawing.Color.MistyRose;
                kullaniciGor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                kullaniciGor.Location = new System.Drawing.Point(281, 4);
                kullaniciGor.Size = new System.Drawing.Size(44, 28);
                kullaniciGor.ForeColor = Color.Black;
                kullaniciGor.TabIndex = i;
                kullaniciGor.Text = "GÖR";
                kullaniciGor.Name = _login.kullanıcılar[i].UserName;
                kullaniciGor.UseVisualStyleBackColor = false;
                kullaniciGor.Click += new EventHandler(kullaniciGor_Click);

                // Label
                kullaniciIsmi = new Label();
                kullaniciIsmi.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                kullaniciIsmi.ForeColor = Color.LightCyan;
                kullaniciIsmi.Location = new System.Drawing.Point(50, 1);
                kullaniciIsmi.Size = new System.Drawing.Size(220, 30);
                kullaniciIsmi.TabIndex = 25;
                kullaniciIsmi.Text = _login.kullanıcılar[i].Ad + " \n" + _login.kullanıcılar[i].Yas + " - {" + _login.kullanıcılar[i].GetType() + "}";


                tableKullanıcı.Controls.Add(kullaniciResim, 0, i);
                tableKullanıcı.Controls.Add(kullaniciIsmi, 1, i);
                tableKullanıcı.Controls.Add(kullaniciGor, 2, i);
                tableKullanıcı.Controls.Add(kullaniciSil, 3, i);
            }
        }

        public void kitapGetir()
        {
            tableKitaplar = new TableLayoutPanel();
            tableKitaplar.Size = new System.Drawing.Size(382, (_login.kitaplar.Count) * 36);
            tableKitaplar.ColumnCount = 3;
            tableKitaplar.BackColor = System.Drawing.Color.LightSlateGray;
            tableKitaplar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableKitaplar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6065F));
            tableKitaplar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3935F));
            tableKitaplar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableKitaplar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableKitaplar.RowCount = _login.kitaplar.Count;
            tableKitaplar.Location = new Point(0, 0);

            tableKitaplar.Parent = ÜrünlerPanel;

            if (tableKitaplar.Height > ÜrünlerPanel.Height)
                tableKitaplar.Width = 360;

            for (int i = 0; i < _login.kitaplar.Count; i++)
            {

                tableKitaplar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                // PİCTURE
                kitapResim = new PictureBox();

                try { kitapResim.Image = Image.FromFile(_login.kitaplar[i].kitapResmi); }
                catch { kitapResim.Image = Image.FromFile(dosya + @"\prdctImg\phyton.png"); }
                kitapResim.Location = new System.Drawing.Point(4, 4);
                kitapResim.Size = new System.Drawing.Size(70, 48);
                kitapResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


                // BUTTONS
                kitapSil = new Button();
                kitapSil.BackColor = System.Drawing.Color.IndianRed;
                kitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                kitapSil.Location = new System.Drawing.Point(332, 4);
                kitapSil.Size = new System.Drawing.Size(42, 28);
                kitapSil.TabIndex = i;
                kitapSil.Text = "SİL";
                kitapSil.Name = i.ToString();
                kitapSil.UseVisualStyleBackColor = false;
                kitapSil.Click += new EventHandler(ürünSil_Click);

                // Label
                kitapIsmi = new Label();
                kitapIsmi.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                kitapIsmi.ForeColor = Color.LightCyan;
                kitapIsmi.Location = new System.Drawing.Point(50, 1);
                kitapIsmi.Size = new System.Drawing.Size(220, 30);
                kitapIsmi.TabIndex = 25;
                kitapIsmi.Text = _login.kitaplar[i].kitapAdı + " \n" + _login.kitaplar[i].yazarAdı + " - {" + string.Format("{0:dd MMMM yyyy}", _login.kitaplar[i].yayınTarihi) + "}";

                tableKitaplar.Controls.Add(kitapResim, 0, i);
                tableKitaplar.Controls.Add(kitapIsmi, 1, i);
                tableKitaplar.Controls.Add(kitapSil, 2, i);
            }
        }
        
        private void kullaniciGor_Click(object sender, EventArgs e)
        {
            kullaniciGor = (sender as Button);

            if (!girisYapan.kullanıcıGör)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
                _login._kGor.ShowDialog();
        }


        private void kullaniciSil_Click(object sender, EventArgs e)
        {
            kullaniciSil = (sender as Button);
            if (!girisYapan.kullanıcıSil)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show("\"" + _login.kullanıcılar[ Convert.ToInt16(kullaniciSil.Name) ].Ad + "\" adlı kullanıcıyı silmek istediğinizden emin misiniz?", _login._şirket.cName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {

                }
            }         
        }

        private void FirmaGör_Click(object sender, EventArgs e)
        {
            FirmaGör = (sender as Button);

            if (!girisYapan.firmaGör)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
                foreach (Firmalar f in _login.firmalar)
                    if (FirmaGör.Name == f.ŞirketIsmi)
                        MessageBox.Show("Telefon : " + f.TelNo + "\n" + "Mail Adresi : " + f.Eposta + "\n" + "Adresi : " + f.Adres, f.ŞirketIsmi + " - " + _login._şirket.cName);

        }


        private void FirmaSil_Click(object sender, EventArgs e)
        {
            FirmaSil = (sender as Button);
            


            if (!girisYapan.firmaSil)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show("\"" + FirmaSil.Name + "\" adlı firmayı silmek istediğinizden emin misiniz?", _login._şirket.cName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {

                }
            }
        }


        private void ürünSil_Click(object sender, EventArgs e)
        {
            kitapSil = (sender as Button);

            if (!girisYapan.ürünSil)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
            {

                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show("\"" + kitapSil.Name + "\" adlı kitabı silmek istediğinizden emin misiniz?", _login._şirket.cName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {

                }
            }
        }

        private void DuyuruSil_Click(object sender, EventArgs e)
        {
            DuyuruSil = (sender as Button);

            if (!girisYapan.duyuruSil)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
            {

                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show("\"" + DuyuruSil.Name + "\" adlı duyuruyu silmek istediğinizden emin misiniz?", _login._şirket.cName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Secim == DialogResult.Yes)
                {
                    foreach (Duyuru d in _login.duyurular)
                        if (d.Baslik == DuyuruSil.Name)
                            _login.duyurular.Remove(d);

                    duyuruGetir();
                }
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {           
            HakkımızdaPanel.BringToFront();

            kitapGetir();
            duyuruGetir();
            firmaGetir();
            kullanıcıGetir();

            label1.Text = "{ " +_login._şirket.cName + " }";

            Text =  _login._şirket.cName + " - {Hoşgeldin, " + girisYapan.UserName + "}";
            if (girisYapan.Ad == null)
                isim.Text = "{ " + girisYapan.UserName + " }";
            else
                isim.Text = girisYapan.Ad;

            gYili.Text = girisYapan.GYili;
            dTarih.Text = string.Format("{0:dd MMMM yyyy}", girisYapan.DTarih);
            hesNo.Text = girisYapan.HesNo;
            mailAd.Text = girisYapan.Mail;
            telNo.Text = girisYapan.TelNo;
            pozisyon.Text = Kullanıcı.tipiNe(girisYapan);
            tc.Text = girisYapan.TC;

            hakkindaLabel.Text = _login._şirket.cAbout;
            try{usrPicture.Image = Image.FromFile(girisYapan.resim);}
            catch { usrPicture.Image = Image.FromFile( dosya + @"\usrImg\default.png" ); }

            yeniÇalışanLink.Visible = false;
            yeniKitapEkleLink.Visible = false;
            yeniFirmaEkleLink.Visible = false;

        }

        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            degisken_Label.Text = çalışanlarToolStripMenuItem.Text;
            ÇalışanlarPanel.BringToFront();
            yeniKitapEkleLink.Visible = false;
            hakkimizdaDuzenleLink.Visible = false;
            yeniFirmaEkleLink.Visible = false;

            yeniÇalışanLink.Visible = true;
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            degisken_Label.Text = kitaplarToolStripMenuItem.Text; 
            ÜrünlerPanel.BringToFront();
            hakkimizdaDuzenleLink.Visible = false;
            yeniFirmaEkleLink.Visible = false;
            yeniÇalışanLink.Visible = false;

            yeniKitapEkleLink.Visible = true; 
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniKitapEkleLink.Visible = false;
            yeniFirmaEkleLink.Visible = false;
            yeniÇalışanLink.Visible = false;

            degisken_Label.Text = hakkımızdaToolStripMenuItem.Text;
            HakkımızdaPanel.BringToFront();

            hakkimizdaDuzenleLink.Visible = true; 
        }

        private void firmalartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            yeniKitapEkleLink.Visible = false;
            hakkimizdaDuzenleLink.Visible = false;
            yeniÇalışanLink.Visible = false;

            yeniFirmaEkleLink.Visible = true;

            degisken_Label.Text = "Çalıştığımız " + firmalartoolStripMenuItem1.Text; 
            FirmalarPanel.BringToFront();
        }

        private void yeniDuyuruLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!girisYapan.yeniDuyuru)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
                _login._yeniDuyuru.ShowDialog();
        }

        private void yeniÇalışanLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!girisYapan.yeniKullanıcı)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
                _login._yeniÇalışan.ShowDialog();
        }

        private void yeniFirmaEkleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!girisYapan.yeniFirma)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
                _login._yeniFirma.ShowDialog();
        }


        private void hakkimizdaDuzenleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!girisYapan.hakkımızdaDüzenle)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
        }

        private void duyuruBas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!girisYapan.duyuruGör)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
            {
                duyuruBas = (sender as LinkLabel);
                foreach (Duyuru d in _login.duyurular)
                    if (duyuruBas.Name == d.Baslik)
                        MessageBox.Show(d.Icerik, d.Baslik + " - " + _login._şirket.cName);
            }
        }

        private void yeniKitapEkleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!girisYapan.yeniÜrün)
                MessageBox.Show("Bu işlemi yapmak için yetkiniz bulunmamaktadır.", _login._şirket.cName);
            else
                _login._yeniKitap.ShowDialog();
        }
    }
}
