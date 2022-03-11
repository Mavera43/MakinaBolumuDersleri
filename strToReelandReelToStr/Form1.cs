using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strToReelandReelToStr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sonuc = int.Parse(txtSayı1.Text) + int.Parse(txtSayı2.Text);
            txtSonuc.Text = sonuc.ToString();

        }
    }
}
