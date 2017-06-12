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
    public partial class Ek : Form
    {

        bool userSet = false;
        Kullanıcı _girisYapan;

        public Kullanıcı girisYapan
        {
            get { return _girisYapan; }
            set
            {
                if (!userSet)
                    _girisYapan = value; userSet = true;
            }
        }
        
        
        public Ek()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Text += " - Hoşgeldin, " + girisYapan.UserName.ToUpper();
            //labelHeader.Text = "Welcome " + LoggedUser.Name;
        }

        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                this.Left += 5;
                this.Top += 5;
                this.Left -= 5;
                this.Top -= 5;
            }
        }

    }
}
