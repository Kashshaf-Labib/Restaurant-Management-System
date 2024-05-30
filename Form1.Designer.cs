namespace Restuarant_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_PlaceOrder = new Button();
            btn_mkReservation = new Button();
            btn_AddEmployee = new Button();
            btn_Add_Edit_Menu = new Button();
            btn_Items = new Button();
            lbl_totalEarning = new Label();
            btn_Table = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trajan Pro", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(252, 43);
            label1.Name = "label1";
            label1.Size = new Size(642, 43);
            label1.TabIndex = 0;
            label1.Text = "Restaurant Management System";
            // 
            // btn_PlaceOrder
            // 
            btn_PlaceOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PlaceOrder.Location = new Point(149, 263);
            btn_PlaceOrder.Name = "btn_PlaceOrder";
            btn_PlaceOrder.Size = new Size(162, 100);
            btn_PlaceOrder.TabIndex = 1;
            btn_PlaceOrder.Text = "Place an Order";
            btn_PlaceOrder.UseVisualStyleBackColor = true;
            btn_PlaceOrder.Click += btn_PlaceOrder_Click;
            // 
            // btn_mkReservation
            // 
            btn_mkReservation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mkReservation.Location = new Point(149, 387);
            btn_mkReservation.Name = "btn_mkReservation";
            btn_mkReservation.Size = new Size(162, 100);
            btn_mkReservation.TabIndex = 1;
            btn_mkReservation.Text = "Make a Reservation";
            btn_mkReservation.UseVisualStyleBackColor = true;
            // 
            // btn_AddEmployee
            // 
            btn_AddEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddEmployee.Location = new Point(719, 387);
            btn_AddEmployee.Name = "btn_AddEmployee";
            btn_AddEmployee.Size = new Size(162, 100);
            btn_AddEmployee.TabIndex = 1;
            btn_AddEmployee.Text = "Employee Section";
            btn_AddEmployee.UseVisualStyleBackColor = true;
            btn_AddEmployee.Click += btn_AddEmployee_Click;
            // 
            // btn_Add_Edit_Menu
            // 
            btn_Add_Edit_Menu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add_Edit_Menu.Location = new Point(719, 263);
            btn_Add_Edit_Menu.Name = "btn_Add_Edit_Menu";
            btn_Add_Edit_Menu.Size = new Size(162, 100);
            btn_Add_Edit_Menu.TabIndex = 2;
            btn_Add_Edit_Menu.Text = "Add/Edit Menu";
            btn_Add_Edit_Menu.UseVisualStyleBackColor = true;
            btn_Add_Edit_Menu.Click += btn_Add_Edit_Menu_Click;
            // 
            // btn_Items
            // 
            btn_Items.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Items.Location = new Point(907, 263);
            btn_Items.Name = "btn_Items";
            btn_Items.Size = new Size(162, 100);
            btn_Items.TabIndex = 1;
            btn_Items.Text = "Add Items";
            btn_Items.UseVisualStyleBackColor = true;
            btn_Items.Click += btn_Items_Click;
            // 
            // lbl_totalEarning
            // 
            lbl_totalEarning.AutoSize = true;
            lbl_totalEarning.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalEarning.Location = new Point(149, 522);
            lbl_totalEarning.Name = "lbl_totalEarning";
            lbl_totalEarning.Size = new Size(168, 30);
            lbl_totalEarning.TabIndex = 3;
            lbl_totalEarning.Text = "Total Earning:";
            // 
            // btn_Table
            // 
            btn_Table.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Table.Location = new Point(907, 387);
            btn_Table.Name = "btn_Table";
            btn_Table.Size = new Size(162, 100);
            btn_Table.TabIndex = 4;
            btn_Table.Text = "Add Table Information";
            btn_Table.UseVisualStyleBackColor = true;
            btn_Table.Click += btn_Table_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 740);
            Controls.Add(btn_Table);
            Controls.Add(lbl_totalEarning);
            Controls.Add(btn_Add_Edit_Menu);
            Controls.Add(btn_Items);
            Controls.Add(btn_AddEmployee);
            Controls.Add(btn_mkReservation);
            Controls.Add(btn_PlaceOrder);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_PlaceOrder;
        private Button btn_mkReservation;
        private Button btn_AddEmployee;
        private Button btn_Add_Edit_Menu;
        private Button btn_Items;
        private Label lbl_totalEarning;
        private Button btn_Table;
    }
}