namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
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
            label2 = new Label();
            ID = new TextBox();
            FName = new TextBox();
            label3 = new Label();
            LName = new TextBox();
            label4 = new Label();
            Position = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            dataGridEmployee = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colPosition = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 1;
            label2.Text = "Employee ID *";
            // 
            // ID
            // 
            ID.Font = new Font("Segoe UI", 12F);
            ID.Location = new Point(12, 66);
            ID.Name = "ID";
            ID.Size = new Size(200, 29);
            ID.TabIndex = 2;
            // 
            // FName
            // 
            FName.Font = new Font("Segoe UI", 12F);
            FName.Location = new Point(12, 122);
            FName.Name = "FName";
            FName.Size = new Size(200, 29);
            FName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 3;
            label3.Text = "First Name *";
            // 
            // LName
            // 
            LName.Font = new Font("Segoe UI", 12F);
            LName.Location = new Point(12, 178);
            LName.Name = "LName";
            LName.Size = new Size(200, 29);
            LName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 5;
            label4.Text = "Last Name *";
            // 
            // Position
            // 
            Position.Font = new Font("Segoe UI", 12F);
            Position.Location = new Point(12, 234);
            Position.Name = "Position";
            Position.Size = new Size(200, 29);
            Position.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 210);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 7;
            label5.Text = "Position *";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(56, 269);
            button1.Name = "button1";
            button1.Size = new Size(108, 36);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(213, 9);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 10;
            label6.Text = "Employee List:";
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployee.Columns.AddRange(new DataGridViewColumn[] { colID, colFirstName, colLastName, colPosition });
            dataGridEmployee.Location = new Point(218, 35);
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.Size = new Size(443, 270);
            dataGridEmployee.TabIndex = 11;
            // 
            // colID
            // 
            colID.HeaderText = "id";
            colID.Name = "colID";
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "firstName";
            colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            colLastName.HeaderText = "lastName";
            colLastName.Name = "colLastName";
            // 
            // colPosition
            // 
            colPosition.HeaderText = "position";
            colPosition.Name = "colPosition";
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 315);
            Controls.Add(dataGridEmployee);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(Position);
            Controls.Add(label5);
            Controls.Add(LName);
            Controls.Add(label4);
            Controls.Add(FName);
            Controls.Add(label3);
            Controls.Add(ID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmployeeDatabase";
            Text = "Employee Database";
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ID;
        private TextBox FName;
        private Label label3;
        private TextBox LName;
        private Label label4;
        private TextBox Position;
        private Label label5;
        private Button button1;
        private Label label6;
        private DataGridView dataGridEmployee;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn PositionData;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colPosition;
    }
}
