using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_Management_System
{
    public partial class EmployeeForm : Form
    {
        Database db = Database.GetInstance();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txt_name.Text, cmb_Position.Text, Convert.ToDouble(txt_salary.Text), txt_Phone.Text);
            db.AddEmployee(emp);
            db.LoadEmployeeList(dataGridView1);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            db.LoadEmployeeList(dataGridView1);
        }
    }
}
