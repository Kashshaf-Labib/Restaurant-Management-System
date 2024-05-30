namespace Restuarant_Management_System
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            lbl_totalEarning = new Label();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_salary = new TextBox();
            txt_Phone = new TextBox();
            label5 = new Label();
            cmb_Position = new ComboBox();
            btn_AddEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(578, 460);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(664, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 789);
            panel1.TabIndex = 1;
            // 
            // lbl_totalEarning
            // 
            lbl_totalEarning.AutoSize = true;
            lbl_totalEarning.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalEarning.Location = new Point(32, 56);
            lbl_totalEarning.Name = "lbl_totalEarning";
            lbl_totalEarning.Size = new Size(232, 30);
            lbl_totalEarning.TabIndex = 4;
            lbl_totalEarning.Text = "Existing Employees";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(709, 56);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 5;
            label1.Text = "Add New Employee";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(709, 162);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(289, 27);
            txt_name.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(709, 129);
            label2.Name = "label2";
            label2.Size = new Size(63, 26);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(709, 217);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 9;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(709, 300);
            label4.Name = "label4";
            label4.Size = new Size(60, 26);
            label4.TabIndex = 11;
            label4.Text = "Salary";
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(709, 333);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(289, 27);
            txt_salary.TabIndex = 10;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(709, 413);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(289, 27);
            txt_Phone.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(709, 380);
            label5.Name = "label5";
            label5.Size = new Size(66, 26);
            label5.TabIndex = 11;
            label5.Text = "Phone";
            // 
            // cmb_Position
            // 
            cmb_Position.FormattingEnabled = true;
            cmb_Position.Items.AddRange(new object[] { "Chef", "Kitchen Staff", "Waiter", "Cleaner" });
            cmb_Position.Location = new Point(709, 256);
            cmb_Position.Name = "cmb_Position";
            cmb_Position.Size = new Size(289, 28);
            cmb_Position.TabIndex = 12;
            // 
            // btn_AddEmployee
            // 
            btn_AddEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddEmployee.Location = new Point(764, 492);
            btn_AddEmployee.Name = "btn_AddEmployee";
            btn_AddEmployee.Size = new Size(161, 77);
            btn_AddEmployee.TabIndex = 13;
            btn_AddEmployee.Text = "Add";
            btn_AddEmployee.UseVisualStyleBackColor = true;
            btn_AddEmployee.Click += btn_AddEmployee_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 773);
            Controls.Add(btn_AddEmployee);
            Controls.Add(cmb_Position);
            Controls.Add(label5);
            Controls.Add(txt_Phone);
            Controls.Add(label4);
            Controls.Add(txt_salary);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Controls.Add(lbl_totalEarning);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label lbl_totalEarning;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_salary;
        private TextBox txt_Phone;
        private Label label5;
        private ComboBox cmb_Position;
        private Button btn_AddEmployee;
    }
}