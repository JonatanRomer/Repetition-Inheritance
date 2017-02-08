﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    class ElBil : Bil, IMotor
    {
        public ElBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrKW, int BatteriKapacitet, string RegistreringsNr) : base(Mærke, PrisExAfgift, KøbsÅr, RegistreringsNr)
        {
            this.KmPrKW = KmPrKW;
            this.BatteriKapacitet = BatteriKapacitet;
        }

        public int BatteriKapacitet { get; set; }

        public int KmPrKW { get; set; }

        public override double RegistreringsAfgift()
        {
            double regafgift = 0;
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    regafgift = (BilPrisExAfgift * 1.05) / 100;
                }
                if (BilPrisExAfgift > 80500)
                {
                    regafgift = (BilPrisExAfgift * 1.8) / 100;
                }
            }
            if (KøbsÅr >= 2015)
            {
                if (BilPrisExAfgift <= 81700)
                {
                    regafgift = (BilPrisExAfgift * 1.05) / 100;
                }
                if (BilPrisExAfgift > 81700)
                {
                    regafgift = (BilPrisExAfgift * 1.8) / 100;
                }
            }
            regafgift = regafgift * 0.2;
            return regafgift;

        }

        public override int HalvÅrligEjerafgift()
        {
            return 0;
        }

        public override int Rækkevidde()
        {
            int længde = BatteriKapacitet * KmPrKW;
            return længde;
        }

        public int LadeTid()
        {
            return 5;
        }
    }
}
