using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lap5_DB4O
{
    class Database
    {
        //public static string DbFileName { get; set; }
        public static string DbFileName = "database.yap";
        public static IObjectContainer DB= Db4oEmbedded.OpenFile(DbFileName);
        public static void OpenDatabase()
        {
            DB = Db4oEmbedded.OpenFile(DbFileName);
        }

        public static void Close()
        {
            DB.Close();
        }

        public static void Update<T>(T obj)
        {
            try
            {
                DB.Store(obj);
                DB.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DB.Rollback();
            }
            finally
            {
                //Close();
            }
        }
        public static void Delete<T>(T obj)
        {
            try
            {
                DB.Delete(obj);
                DB.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DB.Rollback();
            }
            finally
            {
                //Close();
            }
        }
        //public static List<Employee> GetAllNguoiThueNam()
        //{
        //    //IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
        //    IList<Employee> list = DB.Query(delegate (Employee m)
        //    {
        //        return m.Gender == 'M';
        //    });
        //    List<Employee> result = DB.QueryByExample(list);
        //    return result.ToList();
        //    //return result.ToList();
        //    //List<Employee> res = result.ToList();
        //    //DB.Close();
        //    //return res;
        //}

        public static List<Department> HandleProjectHoston()
        {
            IList<Department> list = DB.Query(delegate (Department m) {
                return m.Locations.Contains("Houston");
            });

            List<Department> res = list.ToList();
            DB.Close();
            return res;
        }

        public static List<Department> HandleEmployeeWithStartT()
        {
            IList<Department> list = DB.Query(delegate (Department m) {
                return m.DName.StartsWith('T');
            });

            List<Department> res = list.ToList();
            DB.Close();
            return res;
        }

        public static List<Department> HandleEmployeeNameContaAandworkLe10hours()
        {
          

            IList<Department> list = DB.Query(delegate (Department m)
            {
            return m.DName.Contains('A') || m.Employees.Any(n => n.WorksOn.Any(x => x.Hours < 10));
            });

            List<Department> res = list.ToList();
            DB.Close();
            return res;
            
            
        }
    }
}
