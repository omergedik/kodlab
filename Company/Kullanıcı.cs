using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public abstract class Kullanıcı : Kişi
    {
        #region Yetkiler
        private bool _yeniKullanıcı = false;
        private bool _kullanıcıSil = false;
        private bool _kullanıcıGör = false;

        private bool _yeniÜrün = false;
        private bool _ürünSil = false;

        private bool _yeniFirma = false;
        private bool _firmaSil = false;
        private bool _firmaGör = false;

        private bool _yeniDuyuru = false;
        private bool _duyuruSil = false;
        private bool _duyuruGör = false;

        private bool _hakkımızdaDuzenle = false;

        public bool yeniKullanıcı { get { return _yeniKullanıcı; } private set { _yeniKullanıcı = value; } }
        public bool kullanıcıSil { get { return _kullanıcıSil; } private set { _kullanıcıSil = value; } }
        public bool kullanıcıGör { get { return _kullanıcıGör; } private set { _kullanıcıGör = value; } }

        public bool yeniÜrün { get { return _yeniÜrün; } private set { _yeniÜrün = value; } }
        public bool ürünSil { get { return _ürünSil; } private set { _ürünSil = value; } }

        public bool yeniFirma { get { return _yeniFirma; } private set { _yeniFirma = value; } }
        public bool firmaSil { get { return _firmaSil; } private set { _firmaSil = value; } }
        public bool firmaGör { get { return _firmaGör; } private set { _firmaGör = value; } }

        public bool yeniDuyuru { get { return _yeniDuyuru; } private set { _yeniDuyuru = value; } }
        public bool duyuruSil { get { return _duyuruSil; } private set { _duyuruSil = value; } }
        public bool duyuruGör { get { return _duyuruGör; } private set { _duyuruGör = value; } }

        public bool hakkımızdaDüzenle { get { return _hakkımızdaDuzenle; } private set { _hakkımızdaDuzenle = value; } }
        #endregion

        private string _username;
        private string _password;
        private string _resim;
        private string _hesNo;
        private string _telNo;
        private string _gYili;

        public string UserName { get { return _username; } }

        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }

        public string resim { get { return _resim; } }

        public string HesNo { get { return _hesNo; } }

        public string TelNo { get { return _telNo; } }

        public string GYili { get { return _gYili; } }

        public int Yas { get { return yasHesapla(DTarih); } }

        public List<bool> KullanıcıYetkileri = new List<bool>();

        public Kullanıcı(string username, string password, string ad, string mail, DateTime dTarih, string resim, string hesNo, string telNo, string gYili, string tc)
        {
            _username = username;
            _password = password;
            _ad = ad;
            _mail = mail;
            _dTarih = dTarih;
            _resim = resim;
            _hesNo = hesNo;
            _telNo = telNo;
            _gYili = gYili;
            _tc = tc;

            yetkiAyarla(this);
        }

        private static int yasHesapla(DateTime dogumTarihi)
        {
            int yas = 0;
            yas = DateTime.Now.Year - dogumTarihi.Year;
            if (DateTime.Now.DayOfYear < dogumTarihi.DayOfYear)
                yas = yas - 1;

            return yas;
        }

        public static void yetkiAyarla(Kullanıcı k)
        {
            if (k.GetType() == typeof(Müdür))
            {
                k.yeniKullanıcı = true;
                k.kullanıcıSil = true;
                k.kullanıcıGör = true;

                k.yeniÜrün = true;
                k.ürünSil = true;

                k.yeniFirma = true;
                k.firmaSil = true;
                k.firmaGör = true;

                k.yeniDuyuru = true;
                k.duyuruSil = true;
                k.duyuruGör = true;

                k.hakkımızdaDüzenle = true;
            }
            else if (k.GetType() == typeof(Programcı))
            {
                k.yeniKullanıcı = true;
                k.kullanıcıSil = true;
                k.kullanıcıGör = true;

                k.duyuruGör = true;

                k.hakkımızdaDüzenle = true;
            }
            else if (k.GetType() == typeof(Pazarlamacı))
            {
                k.kullanıcıGör = true;

                k.yeniÜrün = true;
                k.ürünSil = true;

                k.yeniFirma = true;
                k.firmaSil = true;

                k.duyuruGör = true;
            }
            else if (k.GetType() == typeof(Sekreter))
            {
                k.kullanıcıGör = true;

                k.firmaGör = true;

                k.yeniDuyuru = true;
                k.duyuruGör = true;
            }
        }

        public string tipiNe()
        {
            if (this.GetType() == typeof(Müdür))
                return "Müdür";
            else if (this.GetType() == typeof(Programcı))
                return "Programcı";
            else if (this.GetType() == typeof(Pazarlamacı))
                return "Pazarlamacı";
            else if (this.GetType() == typeof(Sekreter))
                return "Sekreter"; ;
            return "Vasıfsız";
        }

        public static string tipiNe(Kullanıcı k)
        {
            if (k.GetType() == typeof(Müdür))
                return "Müdür";
            else if (k.GetType() == typeof(Programcı))
                return "Programcı";
            else if (k.GetType() == typeof(Pazarlamacı))
                return "Pazarlamacı";
            else if (k.GetType() == typeof(Sekreter))
                return "Sekreter"; ;
            return "Vasıfsız";
        }
    }
}
