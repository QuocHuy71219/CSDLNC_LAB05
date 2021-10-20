using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Db4objects.Db4o.Linq;


namespace Lap5_DB4O
{
    class MyBusiness
    {
        public static List<Department> GetDepartments()
        {
            var filterTemp = new Department();
            var result = Database.DB.QueryByExample(filterTemp);
            return result.ToList();
        }
        public static Department GetDepartment(string name)
        {
            //var result = from Department dep in Database.DB
            //             where dep.DName.Contains(name)
            //             select new Department
            //             {
            //                 DName = dep.DName,
            //                 DNumber = dep.DNumber
            //             };
            //if (result.Count() > 0)
            //{
            //    return result.ToList()[0];
            //}

            var result = Database.DB.Query(delegate (Department dep)
            {
                return dep.DName.Contains(name);
            });
            if (result.Count > 0)
            {
                return result[0];
            }
            return null;
        }
        public static void CreateEmployees(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nEmps = int.Parse(fin.ReadLine());
                for (int i = 0; i < nEmps; i++)
                {
                    string line = fin.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(':');
                        string fname = fields[0];
                        char minit = fields[1][0];
                        string lname = fields[2];
                        int ssn = int.Parse(fields[3]);
                        string bdate = fields[4];
                        string address = fields[5];
                        char gender = fields[6][0];
                        float salary = float.Parse(fields[7]);
                        Employee e = new Employee
                        {
                            Ssn = ssn,
                            FName = fname,
                            MInit = minit,
                            LName = lname,
                            Address = address,
                            BirthDate = DateTime.Parse(bdate),
                            Salary = salary,
                            Gender = gender
                        };
                        Database.Update<Employee>(e);
                    }
                }
                fin.Close();
                fs.Close();
            }
        }
    }
}
