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
    public partial class yeniDuyuru : Form
    {
        public Login _login;
        public yeniDuyuru()
        {
            InitializeComponent();
        }

        private void yeniDuyuru_Load(object sender, EventArgs e)
        {
            yazar.Text = _login._anasayfa.girisYapan.UserName;
            tarih.Text = DateTime.Now.ToLongDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baslik.Text == "" || içerik.Text == "")
                MessageBox.Show("Boş alan bırakmadan tekrar deneyin.", _login._şirket.cName);
            else 
            {
                _login.duyurular.Add(new Duyuru(baslik.Text, içerik.Text, yazar.Text, Convert.ToDateTime(DateTime.Now.ToShortDateString())));
                Hide();
                _login._anasayfa.duyuruGetir();
                baslik.Text = "";
                içerik.Text = "";
            }
        }
    }
}
