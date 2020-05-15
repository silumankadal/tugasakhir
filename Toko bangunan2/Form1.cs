using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_bangunan2
{
    public partial class Form1 : Form
    {
        class Bangunan
        {
            private string Batako;
            private string Semen;
            private string Pipa;
            private string Pasir;
            private string Total;

            public void setBatako(string val)
            {
                this.Batako = val;
            }
            public string getBatako()
            {
                return Batako;
            }
            public void setSemen(string val)
            {
                this.Semen = val;
            }
            public string getSemen()
            {
                return Semen;
            }
            public void setPipa(string val)
            {
                this.Pipa = val;
            }
            public string getPipa()
            {
                return Pipa;
            }
            public void setPasir(string val)
            {
                this.Pasir = val;
            }
            public string getPasir()
            {
                return Pasir;
            }
            public void setTotal(string val)
            {
                this.Total = val;
            }
            public string getTotal()
            {
                return Total;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Bangunan cek = new Bangunan();
            double a, b, c, d, f, batako, semen, pipa, pasir, total, diskon, harga;
            a = double.Parse(this.numericUpDown1.Text);
            b = double.Parse(this.numericUpDown2.Text);
            c = double.Parse(this.numericUpDown3.Text);
            d = double.Parse(this.numericUpDown4.Text);
            f = a + b + c + d;
            cek.setBatako("Rp50.000 per buah");
            cek.setSemen("Rp20.000 per kilogram");
            cek.setPipa("Rp10.000 per buah");
            cek.setPasir("Rp5.000 per kilogram");
            if (a + b + c + d > 1)
            {
                batako = a * 50000;
                semen = b * 20000;
                pipa = c * 10000;
                pasir = d * 5000;
                total = batako + semen + pipa + pasir;
                diskon = 0;
                for (int i = 1; i <= f; i++)
                {
                    if (i % 10 == 0)
                    {
                        diskon += 10000;
                    }
                    else
                    {
                        diskon += 1000;
                    }
                }
                harga = total - diskon;
                MessageBox.Show("total pembelian Rp" + harga);
            }
            else
            {
                MessageBox.Show("masukkan yang ingin dibeli");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bangunan cek = new Bangunan();
            cek.setBatako("Rp50000 per buah");
            MessageBox.Show("harga batako " + cek.getBatako());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Bangunan cek = new Bangunan();
            cek.setSemen("Rp20000 per kilogram");
            MessageBox.Show("harga semen " + cek.getSemen());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Bangunan cek = new Bangunan();
            cek.setPipa("Rp10000 per buah");
            MessageBox.Show("harga pipa " + cek.getPipa());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Bangunan cek = new Bangunan();
            cek.setPasir("Rp5000 per kilogram");
            MessageBox.Show("harga pasir " + cek.getPasir());
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f, batako, semen, pipa, pasir, total, diskon, harga;
            a = double.Parse(this.numericUpDown1.Text);
            b = double.Parse(this.numericUpDown2.Text);
            c = double.Parse(this.numericUpDown3.Text);
            d = double.Parse(this.numericUpDown4.Text);
            f = a + b + c + d;
            batako = a * 50000;
            semen = b * 20000;
            pipa = c * 10000;
            pasir = d * 5000;
            total = batako + semen + pipa + pasir;
            diskon = 0;
            for (int i = 1; i <= f; i++)
            {
                if (i % 10 == 0)
                {
                    diskon += 10000;
                }
                else
                {
                    diskon += 1000;
                }
            }
            this.textBox1.Text = Convert.ToString(total);
            this.textBox2.Text = Convert.ToString(diskon);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
