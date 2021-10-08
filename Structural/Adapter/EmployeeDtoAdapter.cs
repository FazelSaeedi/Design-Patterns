using System;

namespace Design_Patterns.Structural.Adapter
{
    public class EmployeeDtoAdapter : Employee
    {
        private EmployeeDto employeeDto { get; set; }

        public EmployeeDtoAdapter(EmployeeDto employeeDto)
        {
            Console.WriteLine("EmployeeDto Adapter received A new employeeDto");
            this.employeeDto = employeeDto;
        }

        public override long id 
        { 
            get => employeeDto.id; 
        }

        public override string code 
        {
            get => employeeDto.code; 
        }

        public override string fullName 
        {
            get => employeeDto.firstName + " " + employeeDto.lastName;
        }

    }

}
