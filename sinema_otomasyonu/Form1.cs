using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bilet, salon;
        int[] koltuk = new int[4];
        private void olustur_btn_Click(object sender, EventArgs e)
        {
            salon = int.Parse(comboBox1.Text);
            koltuk[salon] = koltuk[salon] + int.Parse(koltukTexBox.Text);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");


        }

        private void boskoltuk_lbl_Click(object sender, EventArgs e)
        {

        }

        private void boskoltuk_btn_Click(object sender, EventArgs e)
        {
            salon = int.Parse(comboBox1.Text);
            boskoltuk_lbl.Text = koltuk[salon].ToString();
        }

        private void bakiye_btn_Click(object sender, EventArgs e)
        {
            salon = int.Parse(comboBox1.Text);
            MessageBox.Show("Sinema Bakiyesi = " + bilet);
        }

        private void biletsat_btn_Click(object sender, EventArgs e)
        {
            koltuk[salon] = koltuk[salon] - 1;

            salon = int.Parse(comboBox1.Text);
            if (false)
            {
                bilet = bilet + 10;
            }
            else
            {
                bilet = bilet + 20;
            }
        }

        private void biletiptal_btn_Click(object sender, EventArgs e)
        {
            salon = int.Parse(comboBox1.Text);
            koltuk[salon] = koltuk[salon] + 1;

            if (true)
            {
                bilet = bilet - 10;
            }
            else
            {
                bilet = bilet - 20;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
