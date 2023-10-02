using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgeni_alan_ve_çavre_hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, alan, cevre;


            kenar1 = Convert.ToInt32(txtKenar1.Text);  
            kenar2 = Convert.ToInt32(txtKenar2.Text); 

            alan= kenar1 * kenar2;
            cevre = kenar2 * 2 + kenar2 * 2;

            lblAlan.Text = "dikdortken alanı"+ alan.ToString();
            lblCevre.Text = "dikdortken cevresi "+ cevre.ToString();

        }   
    }
}
