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
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //this button will place order for a customer and if the customer isnt in database it will create the customer
            //Also it will add transaction in the payment table

        }
    }
}
