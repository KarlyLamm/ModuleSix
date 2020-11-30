using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizationMemberLibrary
{
    public class CommissionEmployee : Employee
    {
        public double CommissionRate { get; set; }

        //calculate commission
        public double CalculateCommission(double hoursWorked)
        {
            double total = (HourlyRate * hoursWorked) * CommissionRate;
            return total;
        }
        // grant permission to override payAmount
        public override double PayAmount(double hoursWorked)
        {
            return (HourlyRate * hoursWorked) + CalculateCommission(hoursWorked);
        }
    }
}
