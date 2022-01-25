
namespace TimeSheet1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.empName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emp_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(809, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Timesheet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.Column2,
            this.day1,
            this.day2,
            this.day3,
            this.day4,
            this.day5,
            this.day6,
            this.day7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(237, 383);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 390);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pid.HeaderText = "Project ID";
            this.pid.MinimumWidth = 8;
            this.pid.Name = "pid";
            this.pid.Width = 132;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Task";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // day1
            // 
            this.day1.HeaderText = "Day 1";
            this.day1.MinimumWidth = 8;
            this.day1.Name = "day1";
            this.day1.Width = 150;
            // 
            // day2
            // 
            this.day2.HeaderText = "Day 2";
            this.day2.MinimumWidth = 8;
            this.day2.Name = "day2";
            this.day2.Width = 150;
            // 
            // day3
            // 
            this.day3.HeaderText = "Day 3";
            this.day3.MinimumWidth = 8;
            this.day3.Name = "day3";
            this.day3.Width = 150;
            // 
            // day4
            // 
            this.day4.HeaderText = "Day 4";
            this.day4.MinimumWidth = 8;
            this.day4.Name = "day4";
            this.day4.Width = 150;
            // 
            // day5
            // 
            this.day5.HeaderText = "Day 5";
            this.day5.MinimumWidth = 8;
            this.day5.Name = "day5";
            this.day5.Width = 150;
            // 
            // day6
            // 
            this.day6.HeaderText = "Day 6";
            this.day6.MinimumWidth = 8;
            this.day6.Name = "day6";
            this.day6.Width = 150;
            // 
            // day7
            // 
            this.day7.HeaderText = "Day 7";
            this.day7.MinimumWidth = 8;
            this.day7.Name = "day7";
            this.day7.Width = 150;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addbutton.Location = new System.Drawing.Point(606, 825);
            this.addbutton.Margin = new System.Windows.Forms.Padding(2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(155, 74);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebutton.Location = new System.Drawing.Point(839, 825);
            this.savebutton.Margin = new System.Windows.Forms.Padding(2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(151, 74);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(1074, 825);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(159, 74);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(642, 337);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(16, 25);
            this.l1.TabIndex = 6;
            this.l1.Text = ".";
            this.l1.Click += new System.EventHandler(this.l1_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(795, 337);
            this.l2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(16, 25);
            this.l2.TabIndex = 7;
            this.l2.Text = ".";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(954, 337);
            this.l3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(16, 25);
            this.l3.TabIndex = 8;
            this.l3.Text = ".";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(1098, 337);
            this.l4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(16, 25);
            this.l4.TabIndex = 9;
            this.l4.Text = ".";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(1235, 337);
            this.l5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(16, 25);
            this.l5.TabIndex = 10;
            this.l5.Text = ".";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(1388, 337);
            this.l6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(16, 25);
            this.l6.TabIndex = 11;
            this.l6.Text = ".";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(1552, 337);
            this.l7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(16, 25);
            this.l7.TabIndex = 12;
            this.l7.Text = ".";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeName.Location = new System.Drawing.Point(784, 158);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(220, 32);
            this.EmployeeName.TabIndex = 13;
            this.EmployeeName.Text = "Employee Name : ";
            this.EmployeeName.Click += new System.EventHandler(this.label2_Click);
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startdate.Location = new System.Drawing.Point(854, 261);
            this.startdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(142, 32);
            this.startdate.TabIndex = 14;
            this.startdate.Text = "Start Date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(1004, 261);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(335, 31);
            this.dtpStartDate.TabIndex = 15;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Location = new System.Drawing.Point(1022, 164);
            this.empName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(16, 25);
            this.empName.TabIndex = 16;
            this.empName.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(825, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Employee ID : ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // emp_id
            // 
            this.emp_id.AutoSize = true;
            this.emp_id.Location = new System.Drawing.Point(1022, 210);
            this.emp_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(16, 25);
            this.emp_id.TabIndex = 18;
            this.emp_id.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.emp_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TimeKeeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label startdate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn day5;
        private System.Windows.Forms.DataGridViewTextBoxColumn day6;
        private System.Windows.Forms.DataGridViewTextBoxColumn day7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emp_id;
    }
}

