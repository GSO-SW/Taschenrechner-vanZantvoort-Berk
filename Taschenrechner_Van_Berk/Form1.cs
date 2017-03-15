using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner_Van_Berk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }

        private void btn_eins_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void btn_zwei_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void btn_drei_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void btn_vier_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void btn_fünf_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void btn_sechs_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void btn_sieben_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void btn_acht_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void btn_neun_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "-";
        }

        private void btn_mal_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "*";
        }

        private void btn_geteilt_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "/";
        }

        private void btn_Negativ_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "-";
        }

        private void btn_punkt_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";
        }

        private void btn_klammerauf_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "(";
        }

        private void btn_klammerzu_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ")";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Substring(0,Display.Text.Length - 1);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            Rechenoperation myRechenoperation = new Rechenoperation(Display.Text);
        }
    }
}
//