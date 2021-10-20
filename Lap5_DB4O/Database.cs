using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lap5_DB4O
{
    class Database
    {
        public static string DbFileName { get; set; }
        public static IObjectContainer DB = null;
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
    }
}
