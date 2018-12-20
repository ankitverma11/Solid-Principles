using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinicipals
{
    public class ReportGeneration
    {
      
        public string ReportType { get; set; }

        public void GenerateReport(Employee em)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }

       
    }

    //2.2 Open closed principle(OCP)
    // too much ‘If’ clauses are there and if we want to introduce another new report type like ‘Excel’, then you need to write another ‘if’. This class should be open for extension but closed for modification.

    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        public virtual void GenerateReport(Employee em)
        {
            // From base
        }
    }

    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            base.GenerateReport(em);
        }
    }

    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            base.GenerateReport(em);
        }
    }

    //So if you want to introduce a new report type, then just inherit from IReportGeneration.So IReportGeneration is open for extension but closed for modification.

}
