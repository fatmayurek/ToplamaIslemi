using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToplamaIslemi
{
    public partial class frmToplama : Form
    {
        public frmToplama()
        {
            InitializeComponent();
        }
        void LogYaz(string mesaj)
        {
            lwLog.Items.Add(mesaj);
        }
        private void EkranHazirla(Boolean dogru=true)
        {
            txtSayi1.Text = "0";
            txtSayi2.Text = "0";
            
            txtSayi1.Focus();

        }
        private int Topla(int sayi1,int sayi2)
        {
            return (sayi1 + sayi2);
        }
        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtSayi1.Text);
                Convert.ToInt32(txtSayi2.Text);
            }
            catch (Exception )
            {
                
                return false;
            }
            return true;
        }
        

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int birinciSayi, ikinciSayi, toplam;
            
            if (Dogrula())
            {
                birinciSayi = Convert.ToInt32(txtSayi1.Text);
                ikinciSayi = Convert.ToInt32(txtSayi2.Text);
                toplam = Topla(birinciSayi, ikinciSayi);
                txtSonuc.Text = toplam.ToString(); 
                EkranHazirla();
                LogYaz("İşlem Başarıyla Tamamlandı.Sonuç :" + toplam);
            }
            else
            {
                MessageBox.Show("Hatalı değer girişi!!");
                LogYaz("İşlem Bşarısız!");
            }
            
        }

        private void frmToplama_Shown(object sender, EventArgs e)
        {
            EkranHazirla();

        }

        private void txtSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Lütfen sadece sayı giriniz");
                e.Handled = true;
            }
        }

        private void txtSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Lütfen sadece sayı giriniz");
                e.Handled = true;
            }
        }

        private void frmToplama_Load(object sender, EventArgs e)
        {

        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            tabGenel.SelectedTab = tabLog;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabGenel.SelectedTab = tabToplama ;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lwLog.Clear();
        }
    }
}
