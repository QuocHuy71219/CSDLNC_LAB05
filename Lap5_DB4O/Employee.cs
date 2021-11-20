using System;
using System.Collections.Generic;
using System.Text;

namespace Lap5_DB4O
{
    public class Employee
    {
        public int Ssn { get; set; }
        public string FName { get; set; }
        public char MInit { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public float Salary { get; set; }
        public char Gender { get; set; }
        // relationships
        public List<WorksOn> WorksOn { get; set; }
        public Department WorksFor { get; set; }
        public Department Manages { get; set; }
        public Employee Supervisor { get; set; }
        public List<Employee> Supervisees { get; set; }
        public List<Dependent> Dependents { get; set; }
        public void AddSsn(int Ssn)
        {
            this.Ssn = Ssn;
        }
        public void AddFName(string FName)
        {
            this.FName = FName;
        }
        public void AddMInit(char MInit)
        {
            this.MInit = MInit;
        }
        public void AddLName(string LName)
        {
            this.LName = LName;
        }
        public void AddAddress(string Address)
        {
            this.Address = Address;
        }
        public void AddBirthDate(DateTime BirthDate)
        {
            this.BirthDate = BirthDate;
        }
        public void AddSalary(float Salary)
        {
            this.Salary = Salary;
        }
        public void AddGender(char Gender)
        {
            this.Gender = Gender;
        }
        public int getssn()
        {
            return Ssn;
        }
        public void setssn(int ssn)
        {
            this.Ssn = ssn;
        }
    }
}
