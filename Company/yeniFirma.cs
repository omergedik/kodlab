using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Company
{
    public partial class yeniFirma : Form
    {
        public Login _login;

        public yeniFirma()
        {
            InitializeComponent();
        }

        private void yeniFirma_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adı.Text == "" || telno.Text == "" || eposta.Text == "" || adres.Text == "")
                MessageBox.Show("Lütfen boş alanları doldurup tekrar deneyin.", _login._şirket.cName);
            else 
            {
                Hide();
                _login._anasayfa.tableFirmalar.RowStyles.Clear();
                _login.firmalar.Add(new Firmalar(adı.Text, telno.Text, eposta.Text, adres.Text));
                _login._anasayfa.firmaGetir();
                adı.Text = "";
                telno.Text = "";
                eposta.Text = "";
                adres.Text = "";
            }
        }
    }
}
