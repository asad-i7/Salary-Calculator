using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryCalculator
{
    public class calculations
    {

        public static double getTax1100L(double yearlyGross) //calulates tax on the default tax rate
        {
            // initialize variables
            double personalAllowance;
            double taxable;
            double taxhr;
            double taxar;

            if (yearlyGross >= 11000 && yearlyGross < 43000) //for basic tax rate
            {
                taxable = yearlyGross - 11000;
                taxable = taxable * 0.2;
                return taxable;
            }

            else if (yearlyGross >= 43000 && yearlyGross < 161000)  // for individuals in the higher rate tax bracket
            {
                if (yearlyGross >= 122000)
                {
                    taxable = yearlyGross;
                    taxhr = 6400;
                    taxable = taxable - 32000;
                    taxable = taxable * 0.4;
                    taxable = taxable + taxhr;
                    return taxable;
                }

                else if (yearlyGross >= 100000 && yearlyGross < 122000)
                {
                    personalAllowance = yearlyGross - 100000;
                    personalAllowance = personalAllowance / 2;
                    personalAllowance = 11000 - personalAllowance;
                    taxable = yearlyGross - personalAllowance;
                    taxhr = 6400;
                    taxable = taxable - 32000;
                    taxable = taxable * 0.4;
                    taxable = taxable + taxhr;
                    return taxable;
                }

                else
                {
                    taxable = yearlyGross - 11000;
                    taxhr = 6400;
                    taxable = taxable - 32000;
                    taxable = taxable * 0.4;
                    taxable = taxable + taxhr;
                    return taxable;
                }

            }

            else if (yearlyGross >= 161000) //for additional tax rate
            {
                taxable = yearlyGross;
                taxhr = 6400;
                taxar = 47200;
                taxable = taxable - 150000;
                taxable = taxable * 0.45;
                taxable = taxable + taxhr + taxar;
                return taxable;
            }

            else // returns 0 when lower than tax threshold
            {
                taxable = 0;
                return taxable;
            }

        }

        public static double getTaxBR(double yearlyGross) // calulates tax at 20%
        {

            double taxable = yearlyGross;
            taxable = taxable * 0.2;
            return taxable;

        }

        public static double getTaxD0(double yearlyGross) // calulates tax at 40%
        {

            double taxable = yearlyGross;
            taxable = taxable * 0.4;
            return taxable;

        }

        public static double getTaxD1(double yearlyGross) // calulates tax at 45%
        {
            double taxable = yearlyGross;
            taxable = taxable * 0.45;
            return taxable;
        }


        public static double getNI(double yearlyGross) // gets NI deduction
        {
            double niDeduct;
            double nihr;

            if (yearlyGross >= 8060 && yearlyGross < 43004) //for basic NI rate 
            {
                niDeduct = yearlyGross - 8060;
                niDeduct = niDeduct * 0.12;
                return niDeduct;
            }

            else if (yearlyGross >= 43004) // for higher NI rate
            {
                niDeduct = yearlyGross - 8060;
                nihr = 4193.28;
                niDeduct = niDeduct - 34944;
                niDeduct = niDeduct * 0.02;
                niDeduct = niDeduct + nihr;
                return niDeduct;
            }

            else // for lower than NI threshold
            {
                niDeduct = 0;
                return niDeduct;
            }

        }
    }
}