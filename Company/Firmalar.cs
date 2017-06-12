using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Firmalar
    {
        private string _ŞirketIsmi;
        private string _TelNo;
        private string _Eposta;
        private string _Adres;

        public Firmalar(string gŞirketIsmi, string gTelno, string gEposta, string gAdres)
        {
            _ŞirketIsmi = gŞirketIsmi;
            _TelNo = gTelno;
            _Eposta = gEposta;
            _Adres = gAdres;
        }

        public string ŞirketIsmi { get { return _ŞirketIsmi; } }
        public string TelNo { get { return _TelNo; } }
        public string Eposta { get { return _Eposta; } }
        public string Adres { get { return _Adres; } }
    }
}


