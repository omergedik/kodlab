using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Şirket
    {
        private string _cName = "Şirket Adı";
        private string _cDate = "01.01.1999";
        private string _cAbout = "Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir Anonymous! şirketi, ... yılında kurulmuş olup o günlerden beri hizmet vermektedir";
 

        public string cName { get { return _cName; } }

        public string cDate { get { return _cDate; } }

        public string cAbout { get { return _cAbout; } }


        public Şirket(string name) 
        {
            if(name != "")
                _cName = name; 
        }

        /*public Şirket(string ŞirketAdi, string KuruluşTarihi)
        {
            _cName = cDate; _cDate = cDate;
        }*/
    }
}
