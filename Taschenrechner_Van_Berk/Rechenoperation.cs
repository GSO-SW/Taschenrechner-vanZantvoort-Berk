using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Van_Berk
{
    class Rechenoperation
    {
        string Rechnung;
        int n;
        bool KeinOperator;
        bool Rechenteil1;
        bool Rechenteil2;
        bool Rechenteil3;

        public Rechenoperation(string Übergabe)
        {
            n = 0;
            Rechnung = Übergabe;
            Rechenteil1 = false;
            Rechenteil2 = false;
            Rechenteil3 = false;
            KeinOperator = false;
        }

        public void Rechnungunterteilen()
        {
            do 
            {
                if (Rechnung.Contains("+") == true)
                {
                    if (Rechnung.Substring(n, n + 1) == "+")
                    {
                        Rechenteil1 = true;
                    }
                }
                else
                {
                    KeinOperator = true;
                }
                n++;
            }while(Rechenteil1 == false || KeinOperator == false);
        }
    }
}
