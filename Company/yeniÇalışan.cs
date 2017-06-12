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
    public partial class yeniÇalışan : Form
    {
        public Login _login;

        public yeniÇalışan()
        {
            InitializeComponent();
        }

        private void yeniÇalışan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "" || isim.Text == "" || eposta.Text == "" || doğumtarihi.Text == "" || hesapno.Text == "" || telno.Text == "" || tc.Text == "")
                MessageBox.Show("Lütfen boş alan bırakmadan tekrar deneyin.", _login._şirket.cName);
            else
            {
                bool uyeVarmi = false;

                foreach (Kullanıcı usr in _login.kullanıcılar)
                {
                    if (usr.UserName == username.Text) 
                        uyeVarmi = true;
                    break;
                }

                if (uyeVarmi)
                    MessageBox.Show(username.Text + " bu kullanıcı adı kullanılmaktadır. Lütfen başka bir kullanıcı adı deneyin.");
                else
                {
                    if (pozisyonCombo.SelectedItem.ToString() == "Müdür")
                    {
                        _login.kullanıcılar.Add(
                            new Müdür(
                                username.Text,
                                password.Text,
                                isim.Text,
                                eposta.Text,
                                Convert.ToDateTime(doğumtarihi.Text),
                                null,
                                hesapno.Text,
                                telno.Text,
                                DateTime.Now.Year.ToString(),
                                tc.Text
                            ));
                    }

                    else if (pozisyonCombo.SelectedItem.ToString() == "Programcı")
                    {
                        _login.kullanıcılar.Add(
                            new Programcı(
                                username.Text,
                                password.Text,
                                isim.Text,
                                eposta.Text,
                                Convert.ToDateTime(doğumtarihi.Text),
                                null,
                                hesapno.Text,
                                telno.Text,
                                DateTime.Now.Year.ToString(),
                                tc.Text
                            ));
                    }

                    else if (pozisyonCombo.SelectedItem.ToString() == "Pazarlamacı")
                    {
                        _login.kullanıcılar.Add(
                            new Pazarlamacı(
                                username.Text,
                                password.Text,
                                isim.Text,
                                eposta.Text,
                                Convert.ToDateTime(doğumtarihi.Text),
                                null,
                                hesapno.Text,
                                telno.Text,
                                DateTime.Now.Year.ToString(),
                                tc.Text
                            ));
                    }

                    else if (pozisyonCombo.SelectedItem.ToString() == "Sekreter")
                    {
                        _login.kullanıcılar.Add(
                            new Sekreter(
                                username.Text,
                                password.Text,
                                isim.Text,
                                eposta.Text,
                                Convert.ToDateTime(doğumtarihi.Text),
                                null,
                                hesapno.Text,
                                telno.Text,
                                DateTime.Now.Year.ToString(),
                                tc.Text
                            ));
                    }

                    Hide();
                    _login._anasayfa.kullanıcıGetir();

                    password.Text = "";
                    isim.Text = "";
                    eposta.Text = "";
                    doğumtarihi.Text = "";
                    hesapno.Text = "";
                    telno.Text = "";
                    tc.Text = "";
                }
            }
        }
    }
}
