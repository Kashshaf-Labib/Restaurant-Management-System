namespace Restuarant_Management_System
{
    public partial class Form1 : Form
    {
        Database db = Database.GetInstance();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            new OrderPage().Show();
        }

        private void btn_Add_Edit_Menu_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {

        }

        private void btn_Table_Click(object sender, EventArgs e)
        {

        }
    }
}