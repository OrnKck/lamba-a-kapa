using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamba_aç_kapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked== true)
            {
                Durum.Items.Add("Lamba Açık");
            }
            else
            {
                Durum.Items.Add("Lamba Kapalı");
            }
            if (checkBox2.Checked== true)
            {
                Durum.Items.Add("Kombi Açık");
            }
            else
            {
                Durum.Items.Add("Kombi Kapalı");
            }
        }
    }
}
