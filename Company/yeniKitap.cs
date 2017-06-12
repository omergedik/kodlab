using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Company
{
    public partial class yeniKitap : Form
    {
        public Login _login;

        public yeniKitap()
        {
            InitializeComponent();
        }

        private void yeniKitap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adı.Text == "" || yazarı.Text == "" || yayıntarihi.Text == "" || fiyatı.Text == "")
                MessageBox.Show("Lütfen boş alan bırakmadan tekrar deneyin.", _login._şirket.cName);
            else 
            {
                _login.kitaplar.Add(new Kitaplar(adı.Text, null, yazarı.Text, Convert.ToDateTime(yayıntarihi.Text), Convert.ToInt16(fiyatı.Text)));
                Hide();
                _login._anasayfa.kitapGetir();
                adı.Text = "";
                yazarı.Text = "";
                yayıntarihi.Text = "";
                fiyatı.Text = "";
            }
        }
    }
}
