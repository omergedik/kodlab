using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Duyuru
    {
        private string _baslik;
        private string _icerik;
        private string _yazar;
        private DateTime _tarih;

        public string Baslik { get { return _baslik; } }
        public string Icerik { get { return _icerik; } }
        public string Yazar { get { return _yazar; } }
        public DateTime Tarih { get { return _tarih; } }

        public Duyuru(string gbaslik, string gicerik, string gyazar, DateTime gtarih)
        {
            _baslik = gbaslik;
            _icerik = gicerik;
            _yazar = gyazar;
            _tarih = gtarih;
        }
    }
}
