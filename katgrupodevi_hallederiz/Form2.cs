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
    public partial class Form_anaekran : Form
    {
        public Form_anaekran()
        {
            InitializeComponent();
        }

        private void boskontrol()
        {
            if (!string.IsNullOrWhiteSpace(textBox_adsoyad.Text) &&
                 maskedTextBox_num.MaskCompleted)
            {
                button_sistemgiris.Enabled = true;
            }
            else
            {
                button_sistemgiris.Enabled = false;
            }
        }
        private void textBox_adsoyad_TextChanged(object sender, EventArgs e)
        {
            boskontrol();
        }

        private void maskedTextBox_num_TextChanged(object sender, EventArgs e)
        {
            boskontrol();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_talimat Form_talimat = new Form_talimat();
            Form_talimat.ShowDialog();
        }

        private void button_sistemgiris_Click(object sender, EventArgs e)
        {
            Form_sistem Form_sistem = new Form_sistem();
            Form_sistem.ShowDialog();
        }
    }
}
