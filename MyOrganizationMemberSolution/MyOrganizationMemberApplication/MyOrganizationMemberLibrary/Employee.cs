using System;

namespace MyOrganizationMemberLibrary
{//Inheriting from interface
    public class Employee: IOrganizationMember 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }

        private double rate;

        public double HourlyRate
        {
            get { return rate; }
            set 
            {
                if (value > 0)
                {
                    rate = value;
                }
                else
                {
                    throw new ApplicationException("The rate must be greater than 0");
                }
            }
        }
        //add virtual to override for commission employees
        public virtual double PayAmount(double hoursWorked)
        {
            return hoursWorked * rate;
        }
        public string PrintEmployeeInformation()
        {
            return $"Name is {FirstName} {LastName} and Employee Id is: {EmployeeId}";
        }

    }
}
