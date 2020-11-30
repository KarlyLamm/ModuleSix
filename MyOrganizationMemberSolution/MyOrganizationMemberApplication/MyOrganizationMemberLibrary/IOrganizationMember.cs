using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizationMemberLibrary
{
    interface IOrganizationMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmployeeId { get; set; }
        double HourlyRate { get; set; }

        string PrintEmployeeInformation();
        double PayAmount(double hoursWorked);
    }
}
