using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Kişi
    {
        protected string _ad;
        protected string _mail;
        protected DateTime _dTarih;
        protected string _tc;


        public string Ad { get { return _ad; } }

        public string TC { get { return _tc; } }

        public string Mail { get { return _mail; } }

        public DateTime DTarih { get { return _dTarih; } }
    }
}
