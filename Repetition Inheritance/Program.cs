using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> dieselBils = new List<DieselBil>();
            dieselBils.Add(new DieselBil("BMW", 20000, 2008, 18, 22, "2A4BD"));
            dieselBils.Add(new DieselBil("VW", 10000, 1998, 6, 25, "3ER4D", false ));
            dieselBils.Add(new DieselBil("Porche", 500000, 2017, 30, 32, "6FD3D"));
            dieselBils.Add(new DieselBil("Bugatti", 32000000, 2016, 5, 21, "9DEG3"));
            dieselBils.Add(new DieselBil("Jaguar", 100000, 1968, 4, 30, "4DFC5", false));

            foreach (DieselBil biler in dieselBils)
            {
                Console.WriteLine("Bil Reg. nr. " + biler.RegistreringsNr + ": Koster i afgift " + biler.HalvÅrligEjerafgift() + ": Bilen's rækkevidde er " + biler.Rækkevidde());
            }

            List<BenzinBil> benzinBils = new List<BenzinBil>();
            benzinBils.Add(new BenzinBil("BMW", 19000, 2009, 22, 32, "2AABD"));
            benzinBils.Add(new BenzinBil("VW", 13000, 2000, 15, 30, "33RAD"));
            benzinBils.Add(new BenzinBil("Porche", 520000, 2016, 32, 28, "6F0ED"));
            benzinBils.Add(new BenzinBil("Bugatti", 42000000, 2017, 8, 20, "9D3GE"));
            benzinBils.Add(new BenzinBil("Jaguar", 106000, 1972, 5, 24, "40FCS"));

            foreach (BenzinBil Bbiler in benzinBils)
            {
                Console.WriteLine("Bil Reg. nr. " + Bbiler.RegistreringsNr + ": Bil mærke" + Bbiler.Mærke + ": Prisen "
                    + Bbiler.BilPrisExAfgift + ": Købt i året " + Bbiler.KøbsÅr + ": Km per liter " + Bbiler.KmPrLiter + 
                    ": Koster i afgift " + Bbiler.HalvÅrligEjerafgift()+ ": Bilen's rækkevidde er " + Bbiler.Rækkevidde());
            }
        }
    }
}
