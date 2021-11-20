using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Db4objects.Db4o;
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
            //IObjectContainer db = Db4oEmbedded.OpenFile(Database.DbFileName);
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
        public static void createDepartments(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nDepts = int.Parse(fin.ReadLine());
                for (int i = 0; i < nDepts; i++)
                {
                    String line = fin.ReadLine();
                    String[] fields = line.Split(":");
                    int dnumber = int.Parse(fields[0]);
                    String dname = fields[1];
                    String ls = fields[2];//.Split(",");
                    //List<String> locs = new List<String>();
                    //for (int j = 0; j < ls.Length; j++)
                      //  locs.Add(ls[j]);
                    Department d = new Department
                    {
                        DName = dname,
                        DNumber = dnumber,
                        Locations = ls
                    };
                    Database.Update<Department>(d);
                }
                fin.Close();
                fs.Close();
            }
        }
        public static void createDependents(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader fin = new StreamReader(fs);
            int nDeps = int.Parse(fin.ReadLine());
                for (int i = 0; i < nDeps; i++)
                {
                    String line = fin.ReadLine();
                    String[] fields = line.Split(",");
                    int essn = int.Parse(fields[0]);
                    String name = fields[1];
                    char gender = fields[2][0];
                    String bdate = fields[3];
                    String relationship = fields[4];
                    IList<Employee> emps = Database.DB.Query(delegate (Employee emp)
                    {
                        return (emp.Ssn == essn);
                    
                });
                Employee e = emps[0];
                Dependent d = new Dependent
                    {
                        Name = name,
                        Gender = gender,
                        BirthDate = bdate,
                        Relationship = relationship
                    };
                    //   d.setDependentOf(e);
                    Database.Update<Dependent>(d);
                    //e.addDependent(d);
                    Database.Update<Employee>(e);
                }
 }
 }
        public static void createProjects(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nProjs = int.Parse(fin.ReadLine());
                    for (int i = 0; i<nProjs; i++) {
                        String line = fin.ReadLine();
                        String[] fields = line.Split(",");
                        int pnumber = int.Parse(fields[0]);
                        String pname = fields[1];
                        String loc = fields[2];
        Project p = new Project 
        { 
            PNumber = pnumber,
            PName = pname, 
            Location = loc 
        };
                    Database.Update<Project>(p);
                    }    
             }
        }
        private static void createWorksOn(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nWorksOn = int.Parse(fin.ReadLine());
                for (int i = 0; i<nWorksOn; i++) {
                    String line = fin.ReadLine();
                    String[] fields = line.Split(",");
                    int essn = int.Parse(fields[0]);
                    int pno = int.Parse(fields[1]);
                    float hours = float.Parse(fields[2]);
                    IList<Employee> emps = Database.DB.Query(delegate(Employee emp)
                    {
                    return (emp.Ssn == essn);
                        
                    });
 Employee e = emps[0];
    IList<Project> prjs = Database.DB.Query(delegate(Project prj) {
        return (prj.PNumber == pno);
    });
Project p = prjs[0];
WorksOn won = new WorksOn(hours);
                 //   won.Employee(e);
                  //  won.Project(p);
Database.Update<WorksOn>(won);
//e.addWorksOn(won);
//p.addWorksOn(won);
Database.Update<Employee>(e);
Database.Update<Project>(p);
                }
 }
 }
        public static void SetManagers(IObjectContainer db, string fileName) 
        { 
            if (File.Exists(fileName)) 
            { 
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nMgrs = int.Parse(fin.ReadLine());
                for (int i = 0; i < nMgrs; i++) 
                { 
                    string line = fin.ReadLine();
                    string[] fields = line.Split(',');
                    int dno = int.Parse(fields[0]);
                    int essn = int.Parse(fields[1]);
                    string startDate = fields[2];
                    IList<Department> depts = db.Query(delegate (Department dept)
                    {
                        return (dept.DNumber == dno); });
                    Department d = null;
                    if (depts != null)
                        d = depts[0];
                    IList<Employee> emps = db.Query(delegate (Employee emp) 
                    { 
                        return (emp.Ssn == essn); 
                    });
                    Employee e = null;
                    if (emps != null && emps.Count != 0) 
                        e = emps[0];
                    if (e != null && d != null) 
                    { 
                        d.MgrStartDate = startDate;
                        e.Manages = d;
                        d.Manager = e;
                        db.Store(d);
                        db.Store(e); 
                    } 
                } 
            }
        }
        public static void setControls(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nControls = int.Parse(fin.ReadLine());
                for (int i = 0; i<nControls; i++) {
                String line = fin.ReadLine();
                String[] fields = line.Split(":");
                int dno = int.Parse(fields[0]);
        String[] projects = fields[1].Split(",");
        IList<Department> depts = Database.DB.Query(delegate (Department dept)
    { 
           return (dept.DNumber == dno);        
    });
 Department d = depts[0];
 for (int j = 0; j<projects.Length; j++) {
   int pno = int.Parse(projects[j]);
    IList<Project> prjs = Database.DB.Query(delegate (Project prj)
    {
        return (prj.PNumber == pno);
    });
Project p = prjs[0];
                        //p.setControlledBy(d);
                        Database.Update<Department>(d);
//d.addProject(p); // add p to the “projects” vector of d
 }
                    Database.Update<Department>(d);
                }
 }
 }
        private static void setWorksFor(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nWorksFor = int.Parse(fin.ReadLine());
                for (int i = 0; i<nWorksFor; i++) {
                String line = fin.ReadLine();
        String[] fields = line.Split(":");
         int dno = int.Parse(fields[0]);
        String[] emps = fields[1].Split(",");
        IList<Department> depts = Database.DB.Query(delegate (Department dept)
        {
            return (dept.DNumber == dno);
        });
 Department d = depts[0];
 for (int j = 0; j<emps.Length; j++) {
  int ssn = int.Parse(emps[j]);
    IList<Employee> es = Database.DB.Query(delegate (Employee emp)
    {
        return (emp.Ssn == ssn);
    });
Employee e = es[0];
                        //e.setWorksFor(d);
                        Database.Update<Employee>(e);
//d.addEmployee(e); // add e to “employees” vector of d
 }
                    Database.Update<Department>(d);
                }
 }
 }
        private static void setSupervisors(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nSups = int.Parse(fin.ReadLine());
 for (int i = 0; i<nSups; i++) {
 String line = fin.ReadLine();
        String[] fields = line.Split(":");
         int superssn = int.Parse(fields[0]);
        String[] subs = fields[1].Split(",");
        IList<Employee> emps = Database.DB.Query(delegate (Employee emp)
        {
            return (emp.Ssn == superssn);
        });
 Employee s = emps[0];
 for (int j = 0; j<subs.Length; j++) {
  int essn = int.Parse(subs[j]);
    IList<Employee> subworkers = Database.DB.Query(delegate (Employee emp)
    { 
        return (emp.Ssn == essn);
});
Employee e = subworkers[0];
                        //e.setSupervisor(s);
                        Database.Update<Employee>(e);
//s.addSupervisee(e); // add e to “supervisees” vector of s
 }
 Database.Update<Employee>(s);
 }
 }
 }
        public void ComplexRetrievalExample(IObjectContainer db)
        {
            try
            {
                IList<Department> depts = db.Query(delegate (Department dept) 
                { 
                    int nEmps = dept.Employees.Count;
                    List<Project> prjs = dept.Projects;
                    bool foundPhoenix = false;
                    for (int i = 0; i < prjs.Count; i++) 
                    { 
                        Project p = prjs[i];
                        if (p.Location.Equals("Phoenix")) 
                        {
                            foundPhoenix = true; break; }
                    } 
                    return dept.Locations.Contains("Houston") || (nEmps < 4) || foundPhoenix; });
                //for (int i = 0; i < depts.Count; i++)
                //    Console.WriteLine("Department: " + depts[i].DName);
                    }
            catch{ }
        }
    }
}
