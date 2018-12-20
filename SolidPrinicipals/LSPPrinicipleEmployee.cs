using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinicipals
{
    public class LSPPrinicipleEmployee
    {
        //2.3 Liskov substitution principle
        //Child class should not break parent class’s type definition and behavior. 
        //Employee is a parent class and Casual and Contractual employee are the child classes, inhering from employee class.
        //Solution? Break the whole thing in 2 different interfaces, 1. IProject 2. IEmployee and implement according to employee type.
    }

    public abstract class Employees
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }

    //public class CasualEmployee : Employees
    //{
    //    public override string GetProjectDetails(int employeeId)
    //    {
    //        return "child project";
    //    }
    //    public override string GetEmployeeDetails(int employeeId)
    //    {
    //        return "child employee";
    //    }
    //}

    //public class ContractualEmployee : Employees
    //{
    //    public override string GetProjectDetails(int employeeId)
    //    {
    //        return "Child Project";
    //    }
    //    // May be for contractual employee we do not need to store the details into database.
    //    public override string GetEmployeeDetails(int employeeId)
    //    {
    //        throw new NotImplementedException();
    //    }
    // }

    public class CasualEmployee : IEmplyee 
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Child Project";
        }
    }

    //Now, contractual employee will implement IEmployee not IProject.This will maintain this principle.
    public class ContractualEmployee : IProject
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }

    }
}
