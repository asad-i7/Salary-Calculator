using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalaryCalculator
{
    public partial class _default : System.Web.UI.Page
    {

        // variables for user input and calculations
        double taxable;
        double niDeduct;
        public string poundSign = "£";
        public double yearlyTaxDeducted;
        public double monthlyTaxDeducted;
        public double weeklyTaxDeducted;
        public double dailyTaxDeducted;
        public double yearlyNationalInsurance;
        public double monthlyNationalInsurance;
        public double weeklyNationalInsurance;
        public double dailyNationalInsurance;
        public double yearlyTotalTax;
        public double monthlyTotalTax;
        public double weeklyTotalTax;
        public double dailyTotalTax;
        public double yearlyGross;
        public double monthlyGross;
        public double weeklyGross;
        public double dailyGross;
        public double yearlyNet;
        public double monthlyNet;
        public double weeklyNet;
        public double dailyNet;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateButton(object sender, EventArgs e) // to calculate the tax, national insruance and net wage for the user.
        {            
            yearlyGross = double.Parse(wageperyear.Text); // gets user wage from textbox         

            //if statements used for selected values from the tax code dropdown list

            if (taxcodes.SelectedItem.Value == "1100L")
            {
                // gets tax and national insurance decutions from the methods that calculate them
                taxable = calculations.getTax1100L(yearlyGross);
                niDeduct = calculations.getNI(yearlyGross);

                //stores values for each variable

                yearlyTaxDeducted = taxable;
                yearlyNationalInsurance = niDeduct;
                yearlyTotalTax = niDeduct + taxable;
                yearlyNet = yearlyGross - taxable - niDeduct;

                // monthly values are yearly values divided by 12 months in a year
                monthlyGross = yearlyGross / 12;
                monthlyTaxDeducted = yearlyTaxDeducted / 12;
                monthlyNationalInsurance = yearlyNationalInsurance / 12;
                monthlyTotalTax = yearlyTotalTax / 12;
                monthlyNet = yearlyNet / 12;

                // weekly values are yearly values divided by 52 weeks in a year
                weeklyGross = yearlyGross / 52;
                weeklyTaxDeducted = yearlyTaxDeducted / 52;
                weeklyNationalInsurance = yearlyNationalInsurance / 52;
                weeklyTotalTax = yearlyTotalTax / 52;
                weeklyNet = yearlyNet / 52;

                // daily values are yearly values divided by 52 weeks in a year
                dailyGross = yearlyGross / 260;
               dailyTaxDeducted = yearlyTaxDeducted / 260;
                dailyNationalInsurance = yearlyNationalInsurance / 260;
                dailyTotalTax = yearlyTotalTax / 260;
                dailyNet = yearlyNet / 260;

                // outputs all variables to decimal places.
                yearlyTaxDeducted = Math.Round(yearlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                yearlyNationalInsurance = Math.Round(yearlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                yearlyTotalTax = Math.Round(yearlyTotalTax, 2, MidpointRounding.AwayFromZero);
                yearlyNet = Math.Round(yearlyNet, 2, MidpointRounding.AwayFromZero);
                monthlyGross = Math.Round(monthlyGross, 2, MidpointRounding.AwayFromZero);
                monthlyTaxDeducted = Math.Round(monthlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                monthlyNationalInsurance = Math.Round(monthlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                monthlyTotalTax = Math.Round(monthlyTotalTax, 2, MidpointRounding.AwayFromZero);
                monthlyNet = Math.Round(monthlyNet, 2, MidpointRounding.AwayFromZero);
                weeklyGross = Math.Round(weeklyGross, 2, MidpointRounding.AwayFromZero);
                weeklyTaxDeducted = Math.Round(weeklyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                weeklyNationalInsurance = Math.Round(weeklyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                weeklyTotalTax = Math.Round(weeklyTotalTax, 2, MidpointRounding.AwayFromZero);
                weeklyNet = Math.Round(weeklyNet, 2, MidpointRounding.AwayFromZero);
                dailyGross = Math.Round(dailyGross, 2, MidpointRounding.AwayFromZero);
                dailyTaxDeducted = Math.Round(dailyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                dailyNationalInsurance = Math.Round(dailyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                dailyTotalTax = Math.Round(dailyTotalTax, 2, MidpointRounding.AwayFromZero);
                dailyNet = Math.Round(dailyNet, 2, MidpointRounding.AwayFromZero);
            }

            else if (taxcodes.SelectedItem.Value == "BR")
            {

                taxable = calculations.getTaxBR(yearlyGross);
                niDeduct = calculations.getNI(yearlyGross);

                //stores values for each variable

                yearlyTaxDeducted = taxable;
                yearlyNationalInsurance = niDeduct;
                yearlyTotalTax = niDeduct + taxable;
                yearlyNet = yearlyGross - taxable - niDeduct;

                // monthly values are yearly values divided by 12 months in a year
                monthlyGross = yearlyGross / 12;
                monthlyTaxDeducted = yearlyTaxDeducted / 12;
                monthlyNationalInsurance = yearlyNationalInsurance / 12;
                monthlyTotalTax = yearlyTotalTax / 12;
                monthlyNet = yearlyNet / 12;

                // weekly values are yearly values divided by 52 weeks in a year
                weeklyGross = yearlyGross / 52;
                weeklyTaxDeducted = yearlyTaxDeducted / 52;
                weeklyNationalInsurance = yearlyNationalInsurance / 52;
                weeklyTotalTax = yearlyTotalTax / 52;
                weeklyNet = yearlyNet / 52;

                // daily values are yearly values divided by 52 weeks in a year
                dailyGross = yearlyGross / 260;
                dailyTaxDeducted = yearlyTaxDeducted / 260;
                dailyNationalInsurance = yearlyNationalInsurance / 260;
                dailyTotalTax = yearlyTotalTax / 260;
                dailyNet = yearlyNet / 260;

                // outputs all variables to decimal places.
                yearlyTaxDeducted = Math.Round(yearlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                yearlyNationalInsurance = Math.Round(yearlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                yearlyTotalTax = Math.Round(yearlyTotalTax, 2, MidpointRounding.AwayFromZero);
                yearlyNet = Math.Round(yearlyNet, 2, MidpointRounding.AwayFromZero);
                monthlyGross = Math.Round(monthlyGross, 2, MidpointRounding.AwayFromZero);
                monthlyTaxDeducted = Math.Round(monthlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                monthlyNationalInsurance = Math.Round(monthlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                monthlyTotalTax = Math.Round(monthlyTotalTax, 2, MidpointRounding.AwayFromZero);
                monthlyNet = Math.Round(monthlyNet, 2, MidpointRounding.AwayFromZero);
                weeklyGross = Math.Round(weeklyGross, 2, MidpointRounding.AwayFromZero);
                weeklyTaxDeducted = Math.Round(weeklyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                weeklyNationalInsurance = Math.Round(weeklyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                weeklyTotalTax = Math.Round(weeklyTotalTax, 2, MidpointRounding.AwayFromZero);
                weeklyNet = Math.Round(weeklyNet, 2, MidpointRounding.AwayFromZero);
                dailyGross = Math.Round(dailyGross, 2, MidpointRounding.AwayFromZero);
                dailyTaxDeducted = Math.Round(dailyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                dailyNationalInsurance = Math.Round(dailyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                dailyTotalTax = Math.Round(dailyTotalTax, 2, MidpointRounding.AwayFromZero);
                dailyNet = Math.Round(dailyNet, 2, MidpointRounding.AwayFromZero);
            }

            else if (taxcodes.SelectedItem.Value == "D0")
            {

                taxable = calculations.getTaxD0(yearlyGross);
                niDeduct = calculations.getNI(yearlyGross);

                //stores values for each variable

                yearlyTaxDeducted = taxable;
                yearlyNationalInsurance = niDeduct;
                yearlyTotalTax = niDeduct + taxable;
                yearlyNet = yearlyGross - taxable - niDeduct;

                // monthly values are yearly values divided by 12 months in a year
                monthlyGross = yearlyGross / 12;
                monthlyTaxDeducted = yearlyTaxDeducted / 12;
                monthlyNationalInsurance = yearlyNationalInsurance / 12;
                monthlyTotalTax = yearlyTotalTax / 12;
                monthlyNet = yearlyNet / 12;

                // weekly values are yearly values divided by 52 weeks in a year
                weeklyGross = yearlyGross / 52;
                weeklyTaxDeducted = yearlyTaxDeducted / 52;
                weeklyNationalInsurance = yearlyNationalInsurance / 52;
                weeklyTotalTax = yearlyTotalTax / 52;
                weeklyNet = yearlyNet / 52;

                // daily values are yearly values divided by 52 weeks in a year
                dailyGross = yearlyGross / 260;
                dailyTaxDeducted = yearlyTaxDeducted / 260;
                dailyNationalInsurance = yearlyNationalInsurance / 260;
                dailyTotalTax = yearlyTotalTax / 260;
                dailyNet = yearlyNet / 260;

                // outputs all variables to decimal places.
                yearlyTaxDeducted = Math.Round(yearlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                yearlyNationalInsurance = Math.Round(yearlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                yearlyTotalTax = Math.Round(yearlyTotalTax, 2, MidpointRounding.AwayFromZero);
                yearlyNet = Math.Round(yearlyNet, 2, MidpointRounding.AwayFromZero);
                monthlyGross = Math.Round(monthlyGross, 2, MidpointRounding.AwayFromZero);
                monthlyTaxDeducted = Math.Round(monthlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                monthlyNationalInsurance = Math.Round(monthlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                monthlyTotalTax = Math.Round(monthlyTotalTax, 2, MidpointRounding.AwayFromZero);
                monthlyNet = Math.Round(monthlyNet, 2, MidpointRounding.AwayFromZero);
                weeklyGross = Math.Round(weeklyGross, 2, MidpointRounding.AwayFromZero);
                weeklyTaxDeducted = Math.Round(weeklyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                weeklyNationalInsurance = Math.Round(weeklyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                weeklyTotalTax = Math.Round(weeklyTotalTax, 2, MidpointRounding.AwayFromZero);
                weeklyNet = Math.Round(weeklyNet, 2, MidpointRounding.AwayFromZero);
                dailyGross = Math.Round(dailyGross, 2, MidpointRounding.AwayFromZero);
                dailyTaxDeducted = Math.Round(dailyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                dailyNationalInsurance = Math.Round(dailyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                dailyTotalTax = Math.Round(dailyTotalTax, 2, MidpointRounding.AwayFromZero);
                dailyNet = Math.Round(dailyNet, 2, MidpointRounding.AwayFromZero);
            }

            else if (taxcodes.SelectedItem.Value == "D1")
            {

                taxable = calculations.getTaxD1(yearlyGross);
                niDeduct = calculations.getNI(yearlyGross);

                //stores values for each variable

                yearlyTaxDeducted = taxable;
                yearlyNationalInsurance = niDeduct;
                yearlyTotalTax = niDeduct + taxable;
                yearlyNet = yearlyGross - taxable - niDeduct;

                // monthly values are yearly values divided by 12 months in a year
                monthlyGross = yearlyGross / 12;
                monthlyTaxDeducted = yearlyTaxDeducted / 12;
                monthlyNationalInsurance = yearlyNationalInsurance / 12;
                monthlyTotalTax = yearlyTotalTax / 12;
                monthlyNet = yearlyNet / 12;

                // weekly values are yearly values divided by 52 weeks in a year
                weeklyGross = yearlyGross / 52;
                weeklyTaxDeducted = yearlyTaxDeducted / 52;
                weeklyNationalInsurance = yearlyNationalInsurance / 52;
                weeklyTotalTax = yearlyTotalTax / 52;
                weeklyNet = yearlyNet / 52;

                // daily values are yearly values divided by 52 weeks in a year
                dailyGross = yearlyGross / 260;
                dailyTaxDeducted = yearlyTaxDeducted / 260;
                dailyNationalInsurance = yearlyNationalInsurance / 260;
                dailyTotalTax = yearlyTotalTax / 260;
                dailyNet = yearlyNet / 260;

                // outputs all variables to decimal places.
                yearlyTaxDeducted = Math.Round(yearlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                yearlyNationalInsurance = Math.Round(yearlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                yearlyTotalTax = Math.Round(yearlyTotalTax, 2, MidpointRounding.AwayFromZero);
                yearlyNet = Math.Round(yearlyNet, 2, MidpointRounding.AwayFromZero);
                monthlyGross = Math.Round(monthlyGross, 2, MidpointRounding.AwayFromZero);
                monthlyTaxDeducted = Math.Round(monthlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                monthlyNationalInsurance = Math.Round(monthlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                monthlyTotalTax = Math.Round(monthlyTotalTax, 2, MidpointRounding.AwayFromZero);
                monthlyNet = Math.Round(monthlyNet, 2, MidpointRounding.AwayFromZero);
                weeklyGross = Math.Round(weeklyGross, 2, MidpointRounding.AwayFromZero);
                weeklyTaxDeducted = Math.Round(weeklyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                weeklyNationalInsurance = Math.Round(weeklyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                weeklyTotalTax = Math.Round(weeklyTotalTax, 2, MidpointRounding.AwayFromZero);
                weeklyNet = Math.Round(weeklyNet, 2, MidpointRounding.AwayFromZero);
                dailyGross = Math.Round(dailyGross, 2, MidpointRounding.AwayFromZero);
                dailyTaxDeducted = Math.Round(dailyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                dailyNationalInsurance = Math.Round(dailyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                dailyTotalTax = Math.Round(dailyTotalTax, 2, MidpointRounding.AwayFromZero);
                dailyNet = Math.Round(dailyNet, 2, MidpointRounding.AwayFromZero);
            }


            else if (taxcodes.SelectedItem.Value == "NT") // for when the NT tax code is selected. 
            {
                taxable = 0;
                niDeduct = calculations.getNI(yearlyGross);

                //stores values for each variable

                yearlyTaxDeducted = taxable;
                yearlyNationalInsurance = niDeduct;
                yearlyTotalTax = niDeduct + taxable;
                yearlyNet = yearlyGross - taxable - niDeduct;

                // monthly values are yearly values divided by 12 months in a year
                monthlyGross = yearlyGross / 12;
                monthlyTaxDeducted = yearlyTaxDeducted / 12;
                monthlyNationalInsurance = yearlyNationalInsurance / 12;
                monthlyTotalTax = yearlyTotalTax / 12;
                monthlyNet = yearlyNet / 12;

                // weekly values are yearly values divided by 52 weeks in a year
                weeklyGross = yearlyGross / 52;
                weeklyTaxDeducted = yearlyTaxDeducted / 52;
                weeklyNationalInsurance = yearlyNationalInsurance / 52;
                weeklyTotalTax = yearlyTotalTax / 52;
                weeklyNet = yearlyNet / 52;

                // daily values are yearly values divided by 52 weeks in a year
                dailyGross = yearlyGross / 260;
                dailyTaxDeducted = yearlyTaxDeducted / 260;
                dailyNationalInsurance = yearlyNationalInsurance / 260;
                dailyTotalTax = yearlyTotalTax / 260;
                dailyNet = yearlyNet / 260;

                // outputs all variables to decimal places.
                yearlyTaxDeducted = Math.Round(yearlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                yearlyNationalInsurance = Math.Round(yearlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                yearlyTotalTax = Math.Round(yearlyTotalTax, 2, MidpointRounding.AwayFromZero);
                yearlyNet = Math.Round(yearlyNet, 2, MidpointRounding.AwayFromZero);
                monthlyGross = Math.Round(monthlyGross, 2, MidpointRounding.AwayFromZero);
                monthlyTaxDeducted = Math.Round(monthlyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                monthlyNationalInsurance = Math.Round(monthlyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                monthlyTotalTax = Math.Round(monthlyTotalTax, 2, MidpointRounding.AwayFromZero);
                monthlyNet = Math.Round(monthlyNet, 2, MidpointRounding.AwayFromZero);
                weeklyGross = Math.Round(weeklyGross, 2, MidpointRounding.AwayFromZero);
                weeklyTaxDeducted = Math.Round(weeklyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                weeklyNationalInsurance = Math.Round(weeklyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                weeklyTotalTax = Math.Round(weeklyTotalTax, 2, MidpointRounding.AwayFromZero);
                weeklyNet = Math.Round(weeklyNet, 2, MidpointRounding.AwayFromZero);
                dailyGross = Math.Round(dailyGross, 2, MidpointRounding.AwayFromZero);
                dailyTaxDeducted = Math.Round(dailyTaxDeducted, 2, MidpointRounding.AwayFromZero);
                dailyNationalInsurance = Math.Round(dailyNationalInsurance, 2, MidpointRounding.AwayFromZero);
                dailyTotalTax = Math.Round(dailyTotalTax, 2, MidpointRounding.AwayFromZero);
                dailyNet = Math.Round(dailyNet, 2, MidpointRounding.AwayFromZero);
            }
        }

    }
}