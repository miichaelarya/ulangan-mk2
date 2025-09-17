using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        // Hitung subtotal makanan & minuman lalu totalnya
        public void Total()
        {
            int hrgMkn = 0, hrgMin = 0;
            int jmlMkn = (int)nmcjumlahmkn.Value;
            int jmlMin = 1;

            int.TryParse(txtmakanan.Text, out hrgMkn);
            int.TryParse(txtminuman.Text, out hrgMin);

            if (nmcjumlahmnm != null)
                jmlMin = (int)nmcjumlahmnm.Value;

            int subtotalMkn = hrgMkn * jmlMkn;
            int subtotalMin = hrgMin * jmlMin;

            int total = subtotalMkn + subtotalMin;
            txttotal.Text = total.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            int total, hrgmakan = 0, hrgminum = 0;
            int.TryParse(txtmakanan.Text, out hrgmakan);
            int.TryParse(txtminuman.Text, out hrgminum);

            total = hrgmakan + hrgminum;
            txttotal.Text = Convert.ToString(total);
        }


        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            if (txtbayar.Text == "" || txtbayar.Text == "")
            {
                txtbayar.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txtbayar.Text);
                int b = Convert.ToInt32(txttotal.Text);
                int kembali = 0;
                kembali = a - b;

                txtkembali.Text = kembali.ToString();
            }
        }


        private void btnproses_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbayar.Text, out int bayar) && int.TryParse(txttotal.Text, out int total))
            {
                if (bayar >= total)
                {
                    int kembali = bayar - total;
                    txtkembali.Text = kembali.ToString();

                    string struk = "========= STRUK PEMBAYARAN =========\n" +
                                   "Kasir   : " + txtnamakasir.Text + "\n" +
                                   "Tanggal : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n" +
                                   "-----------------------------------\n" +
                                   "Makanan : " + cmbmakanan.SelectedItem?.ToString() + " x " + nmcjumlahmkn.Value + "\n" +
                                   "Minuman : " + cmbminuman.SelectedItem?.ToString() + " x " + nmcjumlahmnm.Value + "\n" +
                                   "-----------------------------------\n" +
                                   "Total    : Rp " + total.ToString("N0") + "\n" +
                                   "Bayar    : Rp " + bayar.ToString("N0") + "\n" +
                                   "Kembali  : Rp " + kembali.ToString("N0") + "\n" +
                                   "===================================\n" +
                                   "   Terima Kasih, Selamat Datang!   \n" +
                                   "===================================";

                    MessageBox.Show(struk, "Struk Pembayaran");
                }
                else
                {
                    MessageBox.Show("Uang bayar kurang!");
                }
            }
            else
            {
                MessageBox.Show("Input tidak valid!");
            }

        }

        // Form2.cs
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        //  Saat pilih makanan
        private void cmbmakanan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int price = 0;
            switch (cmbmakanan.SelectedIndex)
            {
                case 0: price = 12000; break; 
                case 1: price = 15000; break; 
                case 2: price = 13000; break; 
            }

            txtmakanan.Text = price.ToString();

            nmcjumlahmkn.Value = 1;
            txtjumlahmkn.Text = nmcjumlahmkn.Value.ToString();

            Total();
        }



        private void cmbminuman_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int pilih;
            pilih = cmbminuman.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtminuman.Text = "12000";
                    break;
                case 1:
                    txtminuman.Text = "10000";
                    break;
                case 2:
                    txtminuman.Text = "12000";
                    break;

            }
            Total();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtminuman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtjumlahmkn_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmcjumlahmkn_ValueChanged_1(object sender, EventArgs e)
        {
            int txtmakanan = 0;
            int.TryParse(this.txtmakanan.Text, out txtmakanan);

            // subtotal makanan
            int subtotalMkn = txtmakanan * (int)nmcjumlahmkn.Value;
            txtjumlahmkn.Text = subtotalMkn.ToString();

            Total();
        }

        private void nmcjumlahmnm_ValueChanged(object sender, EventArgs e)
        {
            int hrgMin = 0;
            int.TryParse(txtminuman.Text, out hrgMin);

            // subtotal minuman
            int subtotalMin = hrgMin * (int)nmcjumlahmnm.Value;
            txtjumlahmnm.Text = subtotalMin.ToString();

            Total();
        }

        private void txtjumlahmnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtnamakasir_TextChanged(object sender, EventArgs e)
        {
          
        }
    }

}

