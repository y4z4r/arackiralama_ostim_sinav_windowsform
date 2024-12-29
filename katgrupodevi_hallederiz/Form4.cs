using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katgrupodevi_hallederiz
{
    public partial class Form_sistem : Form
    {
        int sonfiyat = 0;
        int passat = 2300;
        int fiat = 1400;
        int c4 = 2100;
        int bmw = 5000;
        int pg = 2200;
        public Form_sistem()
        {
            InitializeComponent();
            comboBox_arac.Items.Add("Volkswagen Passat");
            comboBox_arac.Items.Add("Fiat Egea");
            comboBox_arac.Items.Add("Citreon C4");
            comboBox_arac.Items.Add("BMW 420i");
            comboBox_arac.Items.Add("Peugeot 408");
        }

        private void boskontrol()
        {
            if (maskedTextBox_kart.MaskCompleted && maskedTextBox_tarih.MaskCompleted && maskedTextBox_cvc.MaskCompleted)
            {
                button_ode.Visible = true;
                label_top.Visible = true;
                label_tfiyat.Visible = true;
            }
            else
            {
                button_ode.Visible = false;
                label_top.Visible = false;
                label_tfiyat.Visible = false;
            }
        }
        private void maskedTextBox_kart_TextChanged(object sender, EventArgs e)
        {
            boskontrol();
        }

        private void maskedTextBox_tarih_TextChanged(object sender, EventArgs e)
        {
            boskontrol();
        }

        private void maskedTextBox_cvc_TextChanged(object sender, EventArgs e)
        {
            boskontrol();
        }

        private void comboBox_arac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_arac.SelectedItem != null)
            {
                switch (comboBox_arac.SelectedItem.ToString())
                {
                    case "Volkswagen Passat":
                        sonfiyat = passat;
                        break;
                    case "Fiat Egea":
                        sonfiyat = fiat;
                        break;
                    case "Citreon C4":
                        sonfiyat = c4;
                        break;
                    case "BMW 420i":
                        sonfiyat = bmw;
                        break;
                    case "Peugeot 408":
                        sonfiyat = pg;
                        break;
                }
                HesaplaFiyat();
            }
        }

        private void HesaplaFiyat()
        {
            int gunSayisi = (int)numericUpDown_gun.Value;
            int toplamFiyat = sonfiyat * gunSayisi;

            label_tfiyat.Text = toplamFiyat.ToString() + " TL";
        }
        private void numericUpDown_gun_ValueChanged(object sender, EventArgs e)
        {
            HesaplaFiyat();
        }

        private void button_ode_Click(object sender, EventArgs e)
        {
            label_sip.Visible = true;
            maskedTextBox_cvc.Enabled = false;
            maskedTextBox_kart.Enabled = false;
            maskedTextBox_tarih.Enabled = false;
            numericUpDown_gun.Enabled = false;
            comboBox_arac.Enabled = false;
        }
    }
}

