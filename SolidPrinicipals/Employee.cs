using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinicipals
{
   // SOLID is basically 5 principles, which will help to create a good software architecture.You can see that all design patterns are based on these principles.SOLID is basically an acronym of the following:


//S is single responsibility principle (SRP)
//O stands for open closed principle (OCP)
//L Liskov substitution principle (LSP)
//I interface segregation principle(ISP)
//D Dependency injection principle(DIP)
    //1-Single responsibility principle(SRP)
    //A class should take one responsibility and there should be one reason to change that class. 
    public class Employee
    {
        public int Employee_Id { get; set;}

        public string Employee_Name { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        public  bool InsertIntoEmployeeTable(Employee emp)
        {
            return true;
        }
        /// <summary>
        /// Method to generate report
        /// </summary>
        public void GenerateReport(Employee em)
        {
            // Report generation with employee data using crystal report.
        }

        //‘Employee’ class is taking 2 responsibilities, one is to take responsibility of employee database operation and another one is to generate employee report.
        //Employee class should not take the report generation responsibility because suppose some days after your customer asked you to give a facility to generate the report in Excel or any other reporting format, 
        //then this class will need to be changed and that is not good.
        //So according to SRP, one class should take one responsibility so we should write one different class for report generation, so that any change in report generation should not affect the ‘Employee’ class.
    }
}
