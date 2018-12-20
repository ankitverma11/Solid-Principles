using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidPrinicipals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employees> emplist = new List<Employees>();
            emplist.Add(new ContractualEmployee());
            emplist.Add(new CasualEmployee());
            foreach (Employees dr in emplist)
            {
                dr.GetEmployeeDetails(1234);
            }
        }
    }
}
