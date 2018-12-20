using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinicipals
{
    public class Interfacesegregationprinciple
    {
        //2.4 Interface segregation principle(ISP)
        //This principle states that any client should not be forced to use an interface which is irrelevant to it.Now what does this mean, suppose there is one database for storing data of all types of employees (i.e.Permanent, non-permanent).
       
        //We are forcing non-permanent employee class to show their details from database.So, the solution is to give this responsibility to another interface.
        //public interface IAddOperation
        //{
        //    bool AddEmployeeDetails();
        //}
        //public interface IGetOperation
        //{
        //    bool ShowEmployeeDetails(int employeeId);
        //}
        // And non-permanent employee will implement only IAddOperation and permanent employee will implement both the interface.
    }

    public interface IEmplyee
    {
        string GetEmployeeDetails(int employeeId);
    }


    
}
