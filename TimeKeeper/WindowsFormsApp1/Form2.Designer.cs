
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWeek1Monday = new System.Windows.Forms.TextBox();
            this.txtWeek1Wednesday = new System.Windows.Forms.TextBox();
            this.txtWeek1Saturday = new System.Windows.Forms.TextBox();
            this.txtWeek1Sunday = new System.Windows.Forms.TextBox();
            this.txtWeek1Friday = new System.Windows.Forms.TextBox();
            this.txtWeek1Thursday = new System.Windows.Forms.TextBox();
            this.txtWeek1Tuesday = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtWeek2Tuesday = new System.Windows.Forms.TextBox();
            this.txtWeek2Thursday = new System.Windows.Forms.TextBox();
            this.txtWeek2Friday = new System.Windows.Forms.TextBox();
            this.txtWeek2Sunday = new System.Windows.Forms.TextBox();
            this.txtWeek2Saturday = new System.Windows.Forms.TextBox();
            this.txtWeek2Wednesday = new System.Windows.Forms.TextBox();
            this.txtWeek2Monday = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeID";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(142, 37);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(159, 22);
            this.txtEmployeeNumber.TabIndex = 1;
            this.txtEmployeeNumber.TextChanged += new System.EventHandler(this.txtEmployeeNumber_TextChanged);
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(325, 42);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(12, 17);
            this.lblEmployeeNumber.TabIndex = 2;
            this.lblEmployeeNumber.Text = ".";
            this.lblEmployeeNumber.Click += new System.EventHandler(this.lblEmployeeNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(142, 72);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(277, 22);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(41, 116);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(71, 17);
            this.EndDate.TabIndex = 5;
            this.EndDate.Text = "End Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(142, 116);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(12, 17);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sunday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saturday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Thursday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Wednesday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tuesday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Hours (Week1):";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtWeek1Monday
            // 
            this.txtWeek1Monday.Location = new System.Drawing.Point(145, 202);
            this.txtWeek1Monday.Name = "txtWeek1Monday";
            this.txtWeek1Monday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek1Monday.TabIndex = 15;
            this.txtWeek1Monday.Text = "0.00";
            this.txtWeek1Monday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek1Wednesday
            // 
            this.txtWeek1Wednesday.Location = new System.Drawing.Point(347, 202);
            this.txtWeek1Wednesday.Name = "txtWeek1Wednesday";
            this.txtWeek1Wednesday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek1Wednesday.TabIndex = 16;
            this.txtWeek1Wednesday.Text = "0.00";
            this.txtWeek1Wednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek1Saturday
            // 
            this.txtWeek1Saturday.Location = new System.Drawing.Point(628, 202);
            this.txtWeek1Saturday.Name = "txtWeek1Saturday";
            this.txtWeek1Saturday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek1Saturday.TabIndex = 17;
            this.txtWeek1Saturday.Text = "0.00";
            this.txtWeek1Saturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek1Sunday
            // 
            this.txtWeek1Sunday.Location = new System.Drawing.Point(716, 202);
            this.txtWeek1Sunday.Name = "txtWeek1Sunday";
            this.txtWeek1Sunday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek1Sunday.TabIndex = 18;
            this.txtWeek1Sunday.Text = "0.00";
            this.txtWeek1Sunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek1Friday
            // 
            this.txtWeek1Friday.Location = new System.Drawing.Point(543, 202);
            this.txtWeek1Friday.Name = "txtWeek1Friday";
            this.txtWeek1Friday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek1Friday.TabIndex = 19;
            this.txtWeek1Friday.Text = "0.00";
            this.txtWeek1Friday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek1Thursday
            // 
            this.txtWeek1Thursday.Location = new System.Drawing.Point(448, 202);
            this.txtWeek1Thursday.Name = "txtWeek1Thursday";
            this.txtWeek1Thursday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek1Thursday.TabIndex = 20;
            this.txtWeek1Thursday.Text = "0.00";
            this.txtWeek1Thursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek1Tuesday
            // 
            this.txtWeek1Tuesday.Location = new System.Drawing.Point(247, 202);
            this.txtWeek1Tuesday.Name = "txtWeek1Tuesday";
            this.txtWeek1Tuesday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek1Tuesday.TabIndex = 21;
            this.txtWeek1Tuesday.Text = "0.00";
            this.txtWeek1Tuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(142, 289);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(628, 83);
            this.txtNotes.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(444, 408);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 29);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(622, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 29);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtWeek2Tuesday
            // 
            this.txtWeek2Tuesday.Location = new System.Drawing.Point(247, 230);
            this.txtWeek2Tuesday.Name = "txtWeek2Tuesday";
            this.txtWeek2Tuesday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek2Tuesday.TabIndex = 33;
            this.txtWeek2Tuesday.Text = "0.00";
            this.txtWeek2Tuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek2Thursday
            // 
            this.txtWeek2Thursday.Location = new System.Drawing.Point(448, 230);
            this.txtWeek2Thursday.Name = "txtWeek2Thursday";
            this.txtWeek2Thursday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek2Thursday.TabIndex = 32;
            this.txtWeek2Thursday.Text = "0.00";
            this.txtWeek2Thursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek2Friday
            // 
            this.txtWeek2Friday.Location = new System.Drawing.Point(543, 230);
            this.txtWeek2Friday.Name = "txtWeek2Friday";
            this.txtWeek2Friday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek2Friday.TabIndex = 31;
            this.txtWeek2Friday.Text = "0.00";
            this.txtWeek2Friday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek2Sunday
            // 
            this.txtWeek2Sunday.Location = new System.Drawing.Point(716, 230);
            this.txtWeek2Sunday.Name = "txtWeek2Sunday";
            this.txtWeek2Sunday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek2Sunday.TabIndex = 30;
            this.txtWeek2Sunday.Text = "0.00";
            this.txtWeek2Sunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek2Saturday
            // 
            this.txtWeek2Saturday.Location = new System.Drawing.Point(628, 230);
            this.txtWeek2Saturday.Name = "txtWeek2Saturday";
            this.txtWeek2Saturday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek2Saturday.TabIndex = 29;
            this.txtWeek2Saturday.Text = "0.00";
            this.txtWeek2Saturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek2Wednesday
            // 
            this.txtWeek2Wednesday.Location = new System.Drawing.Point(347, 230);
            this.txtWeek2Wednesday.Name = "txtWeek2Wednesday";
            this.txtWeek2Wednesday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek2Wednesday.TabIndex = 28;
            this.txtWeek2Wednesday.Text = "0.00";
            this.txtWeek2Wednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeek2Monday
            // 
            this.txtWeek2Monday.Location = new System.Drawing.Point(145, 230);
            this.txtWeek2Monday.Name = "txtWeek2Monday";
            this.txtWeek2Monday.Size = new System.Drawing.Size(54, 22);
            this.txtWeek2Monday.TabIndex = 27;
            this.txtWeek2Monday.Text = "0.00";
            this.txtWeek2Monday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Hours (Week2):";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 466);
            this.Controls.Add(this.txtWeek2Tuesday);
            this.Controls.Add(this.txtWeek2Thursday);
            this.Controls.Add(this.txtWeek2Friday);
            this.Controls.Add(this.txtWeek2Sunday);
            this.Controls.Add(this.txtWeek2Saturday);
            this.Controls.Add(this.txtWeek2Wednesday);
            this.Controls.Add(this.txtWeek2Monday);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtWeek1Tuesday);
            this.Controls.Add(this.txtWeek1Thursday);
            this.Controls.Add(this.txtWeek1Friday);
            this.Controls.Add(this.txtWeek1Sunday);
            this.Controls.Add(this.txtWeek1Saturday);
            this.Controls.Add(this.txtWeek1Wednesday);
            this.Controls.Add(this.txtWeek1Monday);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWeek1Monday;
        private System.Windows.Forms.TextBox txtWeek1Wednesday;
        private System.Windows.Forms.TextBox txtWeek1Saturday;
        private System.Windows.Forms.TextBox txtWeek1Sunday;
        private System.Windows.Forms.TextBox txtWeek1Friday;
        private System.Windows.Forms.TextBox txtWeek1Thursday;
        private System.Windows.Forms.TextBox txtWeek1Tuesday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtWeek2Tuesday;
        private System.Windows.Forms.TextBox txtWeek2Thursday;
        private System.Windows.Forms.TextBox txtWeek2Friday;
        private System.Windows.Forms.TextBox txtWeek2Sunday;
        private System.Windows.Forms.TextBox txtWeek2Saturday;
        private System.Windows.Forms.TextBox txtWeek2Wednesday;
        private System.Windows.Forms.TextBox txtWeek2Monday;
        private System.Windows.Forms.Label label12;
    }
}