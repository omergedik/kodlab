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
    public partial class Login : Form
    {
        public Anasayfa _anasayfa;
        public kullaniciGör _kGor;
        public yeniDuyuru _yeniDuyuru;
        public yeniÇalışan _yeniÇalışan;
        public yeniKitap _yeniKitap;
        public yeniFirma _yeniFirma;

        public Şirket _şirket = new Şirket("KODLAB!");
		
		
        public List<Kullanıcı> kullanıcılar = new List<Kullanıcı>();
        public List<Duyuru> duyurular = new List<Duyuru>();
        public List<Kitaplar> kitaplar = new List<Kitaplar>();
        public List<Firmalar> firmalar = new List<Firmalar>();

        public string dosya = Application.StartupPath + @"..\..\..\Dosya\";

        string[] satirlar;

        public Login()
        {
            InitializeComponent();
            _anasayfa = new Anasayfa();
            _kGor = new kullaniciGör();
            _yeniDuyuru = new yeniDuyuru();
            _yeniÇalışan = new yeniÇalışan();
            _yeniKitap = new yeniKitap();
            _yeniFirma = new yeniFirma();

            _kGor._login = this;
            _anasayfa._login = this;
            _yeniDuyuru._login = this;
            _yeniÇalışan._login = this;
            _yeniKitap._login = this;
            _yeniFirma._login = this;
        }


        private void girisyap_Btn_Click(object sender, EventArgs e)
        {
            Kullanıcı u = null;

            foreach (Kullanıcı s in kullanıcılar)
                if(textBox1.Text.ToLower() == s.UserName.ToLower())
                    u = s;


            if(u == null)
                MessageBox.Show("\"" + textBox1.Text + "\" isminde kullanıcı bulunamadı.", "KULLANICI BULUNAMADI", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            else
            {
                if (textBox2.Text == u.Password)
                {
                    _anasayfa.girisYapan = u;
                    _anasayfa.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Şifreyi yanlış girdiniz. Lütfen tekrar deneyin.", "ŞİFRE YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        public void FirmaOlustur() {
            string FirmalarDosyasi = dosya + @"\Firmalar.txt";

            var list = new List<string>();

            var fileStream = new FileStream(FirmalarDosyasi, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fileStream);
            string line;
            while ((line = sr.ReadLine()) != null)
                list.Add(line);

            satirlar = list.ToArray();
            foreach (string satir in satirlar)
            {
                string[] firmaBilgileri = satir.Split('#');

                firmalar.Add(
                    new Firmalar(
                        firmaBilgileri[0],
                        firmaBilgileri[1],
                        firmaBilgileri[2],
                        firmaBilgileri[3]
                        )
                );
                sr.Close();
            }
        
        }

        void kitapOlustur() 
        {
            string ürünlerDosyası = dosya + @"\Kitaplar.txt";

            var list = new List<string>();

            var fileStream = new FileStream(ürünlerDosyası, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fileStream);
            string line;
            while ((line = sr.ReadLine()) != null)
                list.Add(line);

            satirlar = list.ToArray();
            foreach (string satir in satirlar)
            {
                string[] kitapBilgileri = satir.Split('#');

                    kitaplar.Add(
                        new Kitaplar(
                            kitapBilgileri[0],
                            dosya + "prdctImg/" + kitapBilgileri[1],
                            kitapBilgileri[2],
                            Convert.ToDateTime(kitapBilgileri[3]),
                            Convert.ToInt32(kitapBilgileri[4])
                        )
                    );
                sr.Close();
            }
        }

        void kullaniciOlustur() 
        {
            string kullanicilarDosyasi = dosya + @"\Kullanicilar.txt";

            var list = new List<string>();

            var fileStream = new FileStream(kullanicilarDosyasi, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fileStream);
            string line;
            while ((line = sr.ReadLine()) != null)
                list.Add(line);

            satirlar = list.ToArray();

            foreach (string satir in satirlar)
            {
                bool uyeVarmi = false;
                string[] kullaniciBilgileri = satir.Split('#');

                foreach (Kullanıcı usr in kullanıcılar)
                    if (usr.UserName == kullaniciBilgileri[1])
                        uyeVarmi = true;
                if (!uyeVarmi)
                {
                    if (kullaniciBilgileri[0] == "Müdür")
                    {
                        kullanıcılar.Add(
                            new Müdür(
                            kullaniciBilgileri[1],
                            kullaniciBilgileri[2],
                            kullaniciBilgileri[3],
                            kullaniciBilgileri[4],
                            Convert.ToDateTime(kullaniciBilgileri[5]),
                            dosya + "usrImg/" + kullaniciBilgileri[6],
                            kullaniciBilgileri[7],
                            kullaniciBilgileri[8],
                            kullaniciBilgileri[9],
                            kullaniciBilgileri[10]
                            ));
                    }

                    else if (kullaniciBilgileri[0] == "Programcı")
                    {
                        kullanıcılar.Add(
                            new Programcı(
                            kullaniciBilgileri[1],
                            kullaniciBilgileri[2],
                            kullaniciBilgileri[3],
                            kullaniciBilgileri[4],
                            Convert.ToDateTime(kullaniciBilgileri[5]),
                            dosya + "usrImg/" + kullaniciBilgileri[6],
                            kullaniciBilgileri[7],
                            kullaniciBilgileri[8],
                            kullaniciBilgileri[9],
                            kullaniciBilgileri[10]
                            ));
                    }

                    else if (kullaniciBilgileri[0] == "Pazarlamacı")
                    {
                        kullanıcılar.Add(
                            new Pazarlamacı(
                            kullaniciBilgileri[1],
                            kullaniciBilgileri[2],
                            kullaniciBilgileri[3],
                            kullaniciBilgileri[4],
                            Convert.ToDateTime(kullaniciBilgileri[5]),
                            dosya + "usrImg/" + kullaniciBilgileri[6],
                            kullaniciBilgileri[7],
                            kullaniciBilgileri[8],
                            kullaniciBilgileri[9],
                            kullaniciBilgileri[10]
                            ));
                    }

                    else if (kullaniciBilgileri[0] == "Sekreter")
                    {
                        kullanıcılar.Add(
                            new Sekreter(
                            kullaniciBilgileri[1],
                            kullaniciBilgileri[2],
                            kullaniciBilgileri[3],
                            kullaniciBilgileri[4],
                            Convert.ToDateTime(kullaniciBilgileri[5]),
                            dosya + "usrImg/" + kullaniciBilgileri[6],
                            kullaniciBilgileri[7],
                            kullaniciBilgileri[8],
                            kullaniciBilgileri[9],
                            kullaniciBilgileri[10]
                            ));
                    }
                }
                sr.Close();
            }
        }


        void duyuruOlustur()
        {
            string duyurularDosyasi = dosya + @"\Duyurular.txt";

            var list = new List<string>();

            var fileStream = new FileStream(duyurularDosyasi, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fileStream);
            string line;
            while ((line = sr.ReadLine()) != null)
                list.Add(line);

            satirlar = list.ToArray();
            foreach (string satir in satirlar)
            {
               string[] duyuruBilgileri = satir.Split('#');
               duyurular.Add(
                    new Duyuru(
                        duyuruBilgileri[0],
                        duyuruBilgileri[1],
                        duyuruBilgileri[2],
                        Convert.ToDateTime(duyuruBilgileri[3])
                    )             
                );      
    
                    /*duyurular.Add(
                           new Duyuru(
                              "Henüz Duyuru Eklenmemiş",
                               "",
                               "",
                               Convert.ToDateTime("");
                           )
                   );  */                  
            }
        sr.Close();
        }
        

        private void Login_Load(object sender, EventArgs e)
        {
            kullaniciOlustur();
            duyuruOlustur();
            kitapOlustur();
            FirmaOlustur();

            label3.Text = "{ " + _şirket.cName + " }";
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
