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

            /*foreach (DieselBil Dbiler in dieselBils)
            {
                Console.WriteLine("Bil Reg. nr. " + Dbiler.RegistreringsNr + ": Koster i afgift " + Dbiler.HalvÅrligEjerafgift() + ": Bilen's rækkevidde er " + Dbiler.Rækkevidde());
            }*/

            List<BenzinBil> benzinBils = new List<BenzinBil>();
            benzinBils.Add(new BenzinBil("BMW", 19000, 2009, 22, 32, "2AABD"));
            benzinBils.Add(new BenzinBil("VW", 13000, 2000, 15, 30, "33RAD"));
            benzinBils.Add(new BenzinBil("Porche", 520000, 2016, 32, 28, "6F0ED"));
            benzinBils.Add(new BenzinBil("Bugatti", 42000000, 2017, 8, 20, "9D3GE"));
            benzinBils.Add(new BenzinBil("Jaguar", 106000, 1972, 5, 24, "40FCS"));

            /*foreach (BenzinBil Bbiler in benzinBils)
            {
                Console.WriteLine("Bil Reg. nr. " + Bbiler.RegistreringsNr + ": Bil mærke" + Bbiler.Mærke + ": Prisen "
                    + Bbiler.BilPrisExAfgift + ": Købt i året " + Bbiler.KøbsÅr + ": Km per liter " + Bbiler.KmPrLiter + 
                    ": Koster i afgift " + Bbiler.HalvÅrligEjerafgift()+ ": Bilen's rækkevidde er " + Bbiler.Rækkevidde());
            }*/

            List<ElBil> elBils = new List<ElBil>();
            elBils.Add(new ElBil("BMW", 250000, 2010, 10, 20, "3D2S"));
            elBils.Add(new ElBil("Nissan", 170000, 2017, 5, 50, "4D2W"));
            elBils.Add(new ElBil("Toyota", 150000, 2017, 5, 15,"9F4T"));
            elBils.Add(new ElBil("cheveolet", 200000, 2017, 10, 23, "8Y5C"));
            elBils.Add(new ElBil("Tesla", 700000, 2017, 10, 60, "7UP9"));

            /*foreach (ElBil elBil in elBils)
            {
                Console.WriteLine("El bil Reg. nr. " + elBil.RegistreringsNr + ": ER mærke: " + elBil.Mærke + " Og koster: " + elBil.BilPrisExAfgift + " og er fra " + elBil.KøbsÅr + " og kører " + elBil.KmPrKW + " km/KW og koster i afgift " + elBil.HalvÅrligEjerafgift() + " Bilen har " + elBil.BatteriKapacitet + "KW og kan køre " + elBil.Rækkevidde() + " pr opladning");
            }*/

            List<Bil> biler = new List<Bil>();
            biler.Add(new DieselBil("BMW", 20000, 2008, 18, 22, "2A4BD"));
            biler.Add(new DieselBil("VW", 10000, 1998, 6, 25, "3ER4D", false));
            biler.Add(new DieselBil("Porche", 500000, 2017, 30, 32, "6FD3D"));
            biler.Add(new DieselBil("Bugatti", 32000000, 2016, 5, 21, "9DEG3"));
            biler.Add(new DieselBil("Jaguar", 100000, 1968, 4, 30, "4DFC5", false));
            biler.Add(new BenzinBil("BMW", 19000, 2009, 22, 32, "2AABD"));
            biler.Add(new BenzinBil("VW", 13000, 2000, 15, 30, "33RAD"));
            biler.Add(new BenzinBil("Porche", 520000, 2016, 32, 28, "6F0ED"));
            biler.Add(new BenzinBil("Bugatti", 42000000, 2017, 8, 20, "9D3GE"));
            biler.Add(new BenzinBil("Jaguar", 106000, 1972, 5, 24, "40FCS"));
            biler.Add(new ElBil("BMW", 250000, 2010, 10, 20, "3D2S"));
            biler.Add(new ElBil("Nissan", 170000, 2017, 5, 50, "4D2W"));
            biler.Add(new ElBil("Toyota", 150000, 2017, 5, 15, "9F4T"));
            biler.Add(new ElBil("cheveolet", 200000, 2017, 10, 23, "8Y5C"));
            biler.Add(new ElBil("Tesla", 700000, 2017, 10, 60, "7UP9"));
        }
    }
}
