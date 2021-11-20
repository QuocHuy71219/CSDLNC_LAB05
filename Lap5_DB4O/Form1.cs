using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o.Linq;

namespace Lap5_DB4O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Demo 1: Test DB4O NET Core
            //IObjectContainer db = Db4oEmbedded.OpenFile("demo.db");
            //var dep1 = new Department()
            //{
            //    DName = "Khoa CNTT",
            //    DNumber = 81
            //};
            //var dep2 = new Department()
            //{
            //    DName = "Phòng KHTC",
            //    DNumber = 32
            //};
            //db.Store(dep1);
            //db.Store(dep2);

            //var tempDep = new Department();
            //var result = db.QueryByExample(tempDep);

            //dataGridView1.DataSource = result.ToList();

            //db.Close();
            #endregion

            #region Demo 2: Insert Database with relationship - Employee vs Department
            var emp = new Employee
            {
                Ssn = 45104005,
                FName = "ABC",
                MInit = 'F',
                LName = "David",
                Address = "280 An Dương Vương",
                BirthDate = new DateTime(2003, 2, 12),
                Salary = 234,
                Gender = 'M'
            };

            var department = MyBusiness.GetDepartment("Khoa CNTT");
            if (department == null)
            {
                department = new Department
                {
                    DName = "Khoa CNTT",
                    DNumber = 81
                };
            }
            emp.WorksFor = department;


            Database.Update<Employee>(emp);

            var filterTemp = new Employee();
            //var filterTemp = new Department();
            var result = Database.DB.QueryByExample(filterTemp);
            dataGridView1.DataSource = result.ToList();
            #endregion
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp1 = new Employee
            {
                Ssn = int.Parse(Ssn.Text),
                FName = FName.Text,
                MInit = char.Parse(MInit.Text),
                LName = LName.Text,
                Address = Address.Text,
                BirthDate = DateTime.Parse(BirthDate.Text),
                Salary = float.Parse(Salary.Text),
                Gender = char.Parse(Gender.Text),
            };
            var department = MyBusiness.GetDepartment("Khoa CNTT");
            if (department == null)
            {
                department = new Department
                {
                    DName = "Khoa CNTT",
                    DNumber = 81
                };
            }
            temp1.WorksFor = department;


            Database.Update<Employee>(temp1);

            var filterTemp = new Employee();
            var result = Database.DB.QueryByExample(filterTemp);
            dataGridView1.DataSource = result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var temp1 = new Employee
            {
                Ssn = int.Parse(Ssn.Text),
                FName = FName.Text,
                MInit = char.Parse(MInit.Text),
                LName = LName.Text,
                Address = Address.Text,
                BirthDate = DateTime.Parse(BirthDate.Text),
                Salary = float.Parse(Salary.Text),
                Gender = char.Parse(Gender.Text),
            };
            var department = MyBusiness.GetDepartment("Khoa CNTT");
            if (department == null)
            {
                department = new Department
                {
                    DName = "Khoa CNTT",
                    DNumber = 81
                };
            }
            temp1.WorksFor = department;




            var result = Database.DB.QueryByExample(temp1);
            Employee p = (Employee)result[0];
            Database.DB.Delete(p);
            var filterTemp = new Employee();
            var result1 = Database.DB.QueryByExample(filterTemp);
            dataGridView1.DataSource = result1.ToList();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            var temp1 = new Employee
            {
                Ssn = int.Parse(Ssn.Text),
                //FName = FName.Text,
                //MInit = char.Parse(MInit.Text),
                //LName = LName.Text,
                //Address = Address.Text,
                //BirthDate = DateTime.Parse(BirthDate.Text),
                //Salary = float.Parse(Salary.Text),
                //Gender = char.Parse(Gender.Text),
            };
            var department = MyBusiness.GetDepartment("Khoa CNTT");
            if (department == null)
            {
                department = new Department
                {
                    DName = "Khoa CNTT",
                    DNumber = 81
                };
            }
            temp1.WorksFor = department;


            var result = Database.DB.QueryByExample(temp1);
            Employee p = (Employee)result.Next();
            //Employee p = (Employee)result[0];
            //p.AddSsn(int.Parse(Ssn.Text));
            p.AddFName(FName.Text);
            p.AddMInit(char.Parse(MInit.Text));
            p.AddLName(LName.Text);
            p.AddAddress(Address.Text);
            p.AddBirthDate(DateTime.Parse(BirthDate.Text));
            p.AddSalary(float.Parse(Salary.Text));
            p.AddGender(char.Parse(Gender.Text));
            Database.DB.Store(p);
            var filterTemp = new Employee();
            var result1 = Database.DB.QueryByExample(filterTemp);
            dataGridView1.DataSource = result1.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var m = from Employee p in Database.DB
                                      where p.Gender.ToString().Contains('M')
                                        select p;
             dataGridView1.DataSource = m.ToList();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var d = from Department p in Database.DB
                    where p.DName.StartsWith('T')
                    select p;
            dataGridView1.DataSource = d.ToList();
        }
        //private void LoadAllEmployeeWithStartT()
        //{
        //    dataGridView1.DataSource = Database.HandleEmployeeWithStartT();
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            LoadAllEmployeeNameContaAandworkLe10hours();
        }
        private void LoadAllEmployeeNameContaAandworkLe10hours()
        {
            dataGridView1.DataSource = Database.HandleEmployeeNameContaAandworkLe10hours();
        }
        private void loadData()
        {
            var template = new Employee();
            var result = Database.DB.QueryByExample(template);
            dataGridView1.DataSource = result.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}