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
    public partial class kullaniciGör : Form
    {
        public Login _login;

        public kullaniciGör()
        {
            InitializeComponent();
        }

        private void kullaniciGör_Load(object sender, EventArgs e)
        {
            List<Kullanıcı> usrInfo = new List<Kullanıcı>();
            pictureBox1.Image = null;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            foreach (Kullanıcı usr in _login.kullanıcılar)
                if (usr.UserName == _login._anasayfa.kullaniciGor.Name)
                {
                    try  {pictureBox1.Image = Image.FromFile(usr.resim);}
                    catch { pictureBox1.Image = Image.FromFile(_login.dosya + "usrImg/default.png"); }
                    Text = usr.Ad; //usr.Pozisyon + " - " + usr.Ad;
                    tc.Text = usr.TC;
                    isim.Text = usr.Ad;
                    yas.Text = usr.Yas.ToString() + " {" + string.Format("{0:dd MMMM yyyy}", usr.DTarih) + "} ";
                    email.Text = usr.Mail;
                    tel.Text = usr.TelNo;
                    poz.Text = usr.GetType().ToString();
                    gyil.Text = usr.GYili;
                }           
        }
    }
}
