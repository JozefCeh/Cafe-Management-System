using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_Systems
{
    class Coffee
    {
        //Default Constuctor
        public Coffee()
        {
            newlatte_Coff = 0.0;
            newespress = 0.0;
            newIcedLatte = 0.0;
            newvale_Coff = 0.0;
            newAfri_Coff = 0.0;
            newCapp_Coff = 0.0;
            newiCapp_Coff = 0.0;

            newc_Cakes = 0.0;
            newvl_Cakes = 0.0;
            newbF_Cakes = 0.0;
            newcB_Cakes = 0.0;
            newcL_Cakes = 0.0;
            newcC_Cakes = 0.0;
            newcK_Cakes = 0.0;
        }

        //overload constructor

        public Coffee(double latte_Coff, double espress, double IcedLatte, double vale_Coff, double Afri_Coff, double Capp_Coff,
            double iCapp_Coff, double c_Cakes, double vl_Cakes, double bF_Cakes, double cB_Cakes, double cL_Cakes,
            double cC_Cakes, double cK_Cakes)
        {
            //coffee
            newlatte_Coff = latte_Coff;
            newespress = espress;
            newIcedLatte = IcedLatte;
            newvale_Coff = vale_Coff;
            newAfri_Coff = Afri_Coff;
            newCapp_Coff = Capp_Coff;
            newiCapp_Coff = iCapp_Coff;
            //Cakes
            newc_Cakes = c_Cakes;
            newvl_Cakes = vl_Cakes;
            newbF_Cakes = bF_Cakes;
            newcB_Cakes = cB_Cakes;
            newcL_Cakes = cL_Cakes;
            newcC_Cakes = cC_Cakes;
            newcK_Cakes = cK_Cakes;
        }
        //Accessor function

        public double getlatte_Coff()
        {
            return newlatte_Coff;
        }
        public double getespress()
        {
            return newespress;
        }
        public double getIcedLatte()
        {
            return newIcedLatte;
        }
        public double getvale_Coff()
        {
            return newvale_Coff;
        }
        public double getAfri_Coff()
        {
            return newAfri_Coff;
        }
        public double getCapp_Coff()
        {
            return newCapp_Coff;
        }
        public double getiCapp_Coff()
        {
            return newiCapp_Coff;
        }
        public double getc_Cakes()
        {
            return newc_Cakes;
        }
        public double getvl_Cakes()
        {
            return newvl_Cakes;
        }
        public double getbF_Cakes()
        {
            return newbF_Cakes;
        }
        public double getcB_Cakes()
        {
            return newcB_Cakes;
        }
        public double getcL_Cakes()
        {
            return newcL_Cakes;
        }
        public double getcC_Cakes()
        {
            return newcC_Cakes;
        }
        public double getcK_Cakes()
        {
            return newcK_Cakes;
        }

        //Member variables declared for coffee
        private double newlatte_Coff;
        private double newespress;
        private double newIcedLatte;
        private double newvale_Coff;
        private double newAfri_Coff;
        private double newCapp_Coff;
        private double newiCapp_Coff;

        //Member variables declared for cakes
        private double newc_Cakes;
        private double newvl_Cakes;
        private double newbF_Cakes;
        private double newcB_Cakes;
        private double newcL_Cakes;
        private double newcC_Cakes;
        private double newcK_Cakes;

    }
}
