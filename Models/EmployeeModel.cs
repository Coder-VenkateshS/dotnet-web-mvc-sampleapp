using System;
using System.Collections.Generic;

namespace samplewebmvcapp.Models
{
    public class Employee
    {
        public int EmpNo { get; set;}
        public string EmpName { get; set;}
    }

    public class EmployeeDatabase : List<Employee> 
    {
        public EmployeeDatabase()
        {
            Add(new Employee(){ EmpNo = 101, EmpName = "Venkatesh"});
             Add(new Employee(){ EmpNo = 102, EmpName = "Neo"});
              Add(new Employee(){ EmpNo = 103, EmpName = "iamneo"});
        }
    }
}