using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Kitaplar
    {
        private string _kitapAdı;
        private string _kitapResmi;
        private string _yazarAdı;
        private DateTime _yayınTarihi;
        private int _Fiyat;

        public string kitapAdı { get { return _kitapAdı; } }
        public string kitapResmi { get { return _kitapResmi; } }
        public string yazarAdı { get { return _yazarAdı; } }
        public DateTime yayınTarihi { get { return _yayınTarihi; } }
        public int Fiyat { get { return _Fiyat; } }


        public Kitaplar(string gkitapAdı, string gkitapResmi, string gyazarAdı, DateTime gyayınTarihi, int gFiyat) {

            _kitapAdı = gkitapAdı;
            _kitapResmi = gkitapResmi;
            _yazarAdı = gyazarAdı;
            _yayınTarihi = gyayınTarihi;
            _Fiyat = gFiyat;
        }

    }
}
