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
        Double Ergebnis = 0;
        String Operator = "";
        bool Operatorvorhanden = false;
        bool neueRechnung = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if ((Display.Text == "0")||(Operatorvorhanden == true)||(neueRechnung == true))
                Display.Clear();
            Operatorvorhanden = false;
            Button b = (Button)sender;
            Display.Text = Display.Text + b.Text;
            neueRechnung = false;
        }

        private void Operator_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Operator = b.Text;
            Ergebnis = Double.Parse(Display.Text);
            Operatorvorhanden = true;
            Rechnunglable.Text = Ergebnis + " " + Operator;
            Display.Text = "0";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            Operatorvorhanden = false;
            Rechnunglable.Text = "";
            switch (Operator)
            {
                case "+":
                    Display.Text = (Ergebnis + Double.Parse(Display.Text)).ToString();
                    neueRechnung = true;
                    break;
                case "-":
                    Display.Text = (Ergebnis - Double.Parse(Display.Text)).ToString();
                    neueRechnung = true;
                    break;
                case "*":
                    Display.Text = (Ergebnis * Double.Parse(Display.Text)).ToString();
                    neueRechnung = true;
                    break;
                case "/":
                    Display.Text = (Ergebnis / Double.Parse(Display.Text)).ToString();
                    neueRechnung = true;
                    break;
                default:
                    break;
            }
            Operator = "";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Display.Clear();
            Ergebnis = 0;
            Display.Text = "0";
        }

        private void btn_klammerauf_Click(object sender, EventArgs e)
        {

        }

        private void btn_Negativ_Click(object sender, EventArgs e)
        {
            Display.Text = "-" + Display.Text;
        }
    }
}