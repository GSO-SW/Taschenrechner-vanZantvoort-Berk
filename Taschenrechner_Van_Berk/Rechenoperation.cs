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
        bool Rechenteil1;
        bool Rechenteil2;
        bool Rechenteil3;

        public Rechenoperation(string Übergabe)
        {
            Rechnung = Übergabe;
            Rechenteil1 = false;
            Rechenteil2 = false;
            Rechenteil3 = false;
        }

        public void Rechnungunterteilen()
        {
            do 
            {
                //if (Rechnung.Substring())
                {
                    Rechenteil1 = true;
                }

            }while(Rechenteil1 == false);
        }
    }
}
