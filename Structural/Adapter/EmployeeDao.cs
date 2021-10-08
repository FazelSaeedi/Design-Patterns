using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Adapter
{
    public class EmployeeDao
    {
        public void save(Employee employee)
        {
            Console.WriteLine( "Id from Dto is  : {0} " , employee.id.ToString());
            Console.WriteLine("Code from Dto is  : {0} ", employee.code);
            Console.WriteLine("FullName from Dto is  : {0} ", employee.fullName);
        }
    }

}
