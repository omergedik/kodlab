using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Programcı : Kullanıcı
    {
        public Programcı(
            string username,
            string password,
            string ad, 
            string mail,
            DateTime dTarih, 
            string resim,
            string hesNo,
            string telNo,
            string gYili,
            string tc)
            : base(username, password, ad, mail, dTarih, resim, hesNo, telNo, gYili, tc)
        {
            //base.yetkiAyarla(this);
        }
    }
}
