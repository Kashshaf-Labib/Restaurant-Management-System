namespace Restuarant_Management_System
{
    partial class OrderPage
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
            lbl_totalEarning = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            btn_Confirm = new Button();
            lbl_Subtotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(586, 384);
            dataGridView1.TabIndex = 0;
            // 
            // lbl_totalEarning
            // 
            lbl_totalEarning.AutoSize = true;
            lbl_totalEarning.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalEarning.Location = new Point(99, 46);
            lbl_totalEarning.Name = "lbl_totalEarning";
            lbl_totalEarning.Size = new Size(77, 30);
            lbl_totalEarning.TabIndex = 4;
            lbl_totalEarning.Text = "Menu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1060, 37);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 6;
            label1.Text = "Ordered";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1060, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(390, 384);
            dataGridView2.TabIndex = 5;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirm.Location = new Point(793, 622);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(162, 100);
            btn_Confirm.TabIndex = 7;
            btn_Confirm.Text = "Confirm";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal.Location = new Point(1060, 506);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(115, 30);
            lbl_Subtotal.TabIndex = 8;
            lbl_Subtotal.Text = "Subtotal:";
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 750);
            Controls.Add(lbl_Subtotal);
            Controls.Add(btn_Confirm);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(lbl_totalEarning);
            Controls.Add(dataGridView1);
            Name = "OrderPage";
            Text = "OrderPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_totalEarning;
        private Label label1;
        private DataGridView dataGridView2;
        private Button btn_Confirm;
        private Label lbl_Subtotal;
    }
}