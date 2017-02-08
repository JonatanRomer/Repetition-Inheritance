using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    class DieselBil : Bil
    {
        

        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, int Tank, string RegistreringsNr, bool PartikkelFilter) : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
            this.PartikkelFilter = PartikkelFilter;
            this.Tank = Tank;
        }
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, int Tank, string RegistreringsNr)
           : this(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, Tank, RegistreringsNr, PartikkelFilter: true)
        {
        }
        public bool PartikkelFilter { get; set; }

        public int Tank { get; set; }
        public override int Rækkevidde()
        {
            int længde = Tank * KmPrLiter;
            return længde;
        }



        public override int HalvÅrligEjerafgift()
        {
            int ejerafgift = 0;
            if (KmPrLiter < 15)
            {
                ejerafgift = 2000;
            }
            if (KmPrLiter >= 15 || KmPrLiter <= 25)
            {
                ejerafgift = 1000;
            }
            if (KmPrLiter > 25)
            {
                ejerafgift = 350;
            }
            
            if (PartikkelFilter == false)
            {
                ejerafgift += 500;
            }
            return ejerafgift;
        }
    }
}
