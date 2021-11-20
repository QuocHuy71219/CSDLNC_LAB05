using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Db4objects.Db4o.Linq;

namespace Lap5_DB4O
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            var template = new Department();
            var result = Database.DB.QueryByExample(template);
            dataGridView2.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var temp1 = new Department
            {
                DName = DName.Text,
                DNumber = int.Parse(DNumber.Text),
                MgrStartDate = MgrStartDate.Text,
                Locations = Locations.Text
            };
            Database.DB.Store(temp1);
            DName.Clear();
            DNumber.Clear();
            MgrStartDate.Clear();
            Locations.Clear();
            var filterTemp = new Department();
            var result = Database.DB.QueryByExample(filterTemp);
            dataGridView2.DataSource = result.ToList();
        }

        private void startT_Click(object sender, EventArgs e)
        {
            //var d = from Department p in Database.DB
            //        where p.DName.StartsWith('T')
            //        select p;
            //dataGridView2.DataSource = d.ToList();
        }
    }
}
