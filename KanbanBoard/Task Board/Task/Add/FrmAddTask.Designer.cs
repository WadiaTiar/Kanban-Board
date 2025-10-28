namespace KanbanBoard.Task_Board
{
    partial class FrmAddTask
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDueTo = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAssignDueTo = new System.Windows.Forms.RadioButton();
            this.rbNotAssignDueTo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoDueDate = new System.Windows.Forms.Label();
            this.plCompletedDate = new System.Windows.Forms.Panel();
            this.lblNoCompletedDate = new System.Windows.Forms.Label();
            this.dtpCompletedDate = new System.Windows.Forms.DateTimePicker();
            this.rbNotAssignCompletedDate = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAssignCompletedDate = new System.Windows.Forms.RadioButton();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.plCompletedDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(644, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 58);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(480, 642);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 58);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDueTo
            // 
            this.dtpDueTo.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpDueTo.CustomFormat = "";
            this.dtpDueTo.Enabled = false;
            this.dtpDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueTo.Location = new System.Drawing.Point(116, 34);
            this.dtpDueTo.Name = "dtpDueTo";
            this.dtpDueTo.Size = new System.Drawing.Size(218, 28);
            this.dtpDueTo.TabIndex = 25;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.DimGray;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(171, 192);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(602, 171);
            this.txtDescription.TabIndex = 22;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Due to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Priority:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title:";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(794, 74);
            this.lblFormTitle.TabIndex = 15;
            this.lblFormTitle.Text = "Add Task";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.DimGray;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(171, 98);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(602, 70);
            this.txtTitle.TabIndex = 28;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // cbPriority
            // 
            this.cbPriority.BackColor = System.Drawing.Color.DimGray;
            this.cbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.ForeColor = System.Drawing.Color.White;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Optional",
            "High",
            "Medium",
            "Low"});
            this.cbPriority.Location = new System.Drawing.Point(173, 505);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(187, 30);
            this.cbPriority.TabIndex = 29;
            this.cbPriority.Text = "Select Priority";
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.DimGray;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "New",
            "Scheduled",
            "InProgress",
            "Compeleted"});
            this.cbStatus.Location = new System.Drawing.Point(173, 456);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(187, 30);
            this.cbStatus.TabIndex = 31;
            this.cbStatus.Text = "Select Status";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Status:";
            // 
            // rbAssignDueTo
            // 
            this.rbAssignDueTo.AutoSize = true;
            this.rbAssignDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAssignDueTo.ForeColor = System.Drawing.Color.White;
            this.rbAssignDueTo.Location = new System.Drawing.Point(116, 8);
            this.rbAssignDueTo.Name = "rbAssignDueTo";
            this.rbAssignDueTo.Size = new System.Drawing.Size(81, 24);
            this.rbAssignDueTo.TabIndex = 36;
            this.rbAssignDueTo.Tag = "1";
            this.rbAssignDueTo.Text = "Assign";
            this.rbAssignDueTo.UseVisualStyleBackColor = true;
            this.rbAssignDueTo.CheckedChanged += new System.EventHandler(this.rbDueTo_CheckedChanged);
            // 
            // rbNotAssignDueTo
            // 
            this.rbNotAssignDueTo.AutoSize = true;
            this.rbNotAssignDueTo.Checked = true;
            this.rbNotAssignDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotAssignDueTo.ForeColor = System.Drawing.Color.White;
            this.rbNotAssignDueTo.Location = new System.Drawing.Point(222, 8);
            this.rbNotAssignDueTo.Name = "rbNotAssignDueTo";
            this.rbNotAssignDueTo.Size = new System.Drawing.Size(112, 24);
            this.rbNotAssignDueTo.TabIndex = 37;
            this.rbNotAssignDueTo.TabStop = true;
            this.rbNotAssignDueTo.Tag = "0";
            this.rbNotAssignDueTo.Text = "Not Assign";
            this.rbNotAssignDueTo.UseVisualStyleBackColor = true;
            this.rbNotAssignDueTo.CheckedChanged += new System.EventHandler(this.rbDueTo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNoDueDate);
            this.panel1.Controls.Add(this.dtpDueTo);
            this.panel1.Controls.Add(this.rbNotAssignDueTo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rbAssignDueTo);
            this.panel1.Location = new System.Drawing.Point(53, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 79);
            this.panel1.TabIndex = 38;
            // 
            // lblNoDueDate
            // 
            this.lblNoDueDate.BackColor = System.Drawing.Color.White;
            this.lblNoDueDate.Enabled = false;
            this.lblNoDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDueDate.Location = new System.Drawing.Point(116, 34);
            this.lblNoDueDate.Name = "lblNoDueDate";
            this.lblNoDueDate.Size = new System.Drawing.Size(166, 28);
            this.lblNoDueDate.TabIndex = 39;
            this.lblNoDueDate.Text = "No Due Date";
            this.lblNoDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plCompletedDate
            // 
            this.plCompletedDate.Controls.Add(this.lblNoCompletedDate);
            this.plCompletedDate.Controls.Add(this.dtpCompletedDate);
            this.plCompletedDate.Controls.Add(this.rbNotAssignCompletedDate);
            this.plCompletedDate.Controls.Add(this.label2);
            this.plCompletedDate.Controls.Add(this.rbAssignCompletedDate);
            this.plCompletedDate.Location = new System.Drawing.Point(398, 369);
            this.plCompletedDate.Name = "plCompletedDate";
            this.plCompletedDate.Size = new System.Drawing.Size(375, 79);
            this.plCompletedDate.TabIndex = 41;
            this.plCompletedDate.Visible = false;
            // 
            // lblNoCompletedDate
            // 
            this.lblNoCompletedDate.BackColor = System.Drawing.Color.White;
            this.lblNoCompletedDate.Enabled = false;
            this.lblNoCompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCompletedDate.Location = new System.Drawing.Point(147, 41);
            this.lblNoCompletedDate.Name = "lblNoCompletedDate";
            this.lblNoCompletedDate.Size = new System.Drawing.Size(152, 23);
            this.lblNoCompletedDate.TabIndex = 39;
            this.lblNoCompletedDate.Text = "No Comp. Date";
            this.lblNoCompletedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCompletedDate
            // 
            this.dtpCompletedDate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpCompletedDate.CustomFormat = "";
            this.dtpCompletedDate.Enabled = false;
            this.dtpCompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCompletedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompletedDate.Location = new System.Drawing.Point(140, 40);
            this.dtpCompletedDate.Name = "dtpCompletedDate";
            this.dtpCompletedDate.Size = new System.Drawing.Size(218, 28);
            this.dtpCompletedDate.TabIndex = 25;
            // 
            // rbNotAssignCompletedDate
            // 
            this.rbNotAssignCompletedDate.AutoSize = true;
            this.rbNotAssignCompletedDate.Checked = true;
            this.rbNotAssignCompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotAssignCompletedDate.ForeColor = System.Drawing.Color.White;
            this.rbNotAssignCompletedDate.Location = new System.Drawing.Point(246, 14);
            this.rbNotAssignCompletedDate.Name = "rbNotAssignCompletedDate";
            this.rbNotAssignCompletedDate.Size = new System.Drawing.Size(112, 24);
            this.rbNotAssignCompletedDate.TabIndex = 37;
            this.rbNotAssignCompletedDate.TabStop = true;
            this.rbNotAssignCompletedDate.Tag = "0";
            this.rbNotAssignCompletedDate.Text = "Not Assign";
            this.rbNotAssignCompletedDate.UseVisualStyleBackColor = true;
            this.rbNotAssignCompletedDate.CheckedChanged += new System.EventHandler(this.rbCompletedDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Comp. Date:";
            // 
            // rbAssignCompletedDate
            // 
            this.rbAssignCompletedDate.AutoSize = true;
            this.rbAssignCompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAssignCompletedDate.ForeColor = System.Drawing.Color.White;
            this.rbAssignCompletedDate.Location = new System.Drawing.Point(140, 14);
            this.rbAssignCompletedDate.Name = "rbAssignCompletedDate";
            this.rbAssignCompletedDate.Size = new System.Drawing.Size(81, 24);
            this.rbAssignCompletedDate.TabIndex = 36;
            this.rbAssignCompletedDate.Tag = "1";
            this.rbAssignCompletedDate.Text = "Assign";
            this.rbAssignCompletedDate.UseVisualStyleBackColor = true;
            this.rbAssignCompletedDate.CheckedChanged += new System.EventHandler(this.rbCompletedDate_CheckedChanged);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.DimGray;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Personal",
            "Health",
            "Home",
            "Stady",
            "Work",
            "Social"});
            this.cbType.Location = new System.Drawing.Point(173, 403);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(187, 30);
            this.cbType.TabIndex = 43;
            this.cbType.Text = "Select Type";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(86, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Type:";
            // 
            // FrmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(794, 724);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.plCompletedDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddTask";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plCompletedDate.ResumeLayout(false);
            this.plCompletedDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDueTo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbAssignDueTo;
        private System.Windows.Forms.RadioButton rbNotAssignDueTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoDueDate;
        private System.Windows.Forms.Panel plCompletedDate;
        private System.Windows.Forms.Label lblNoCompletedDate;
        private System.Windows.Forms.DateTimePicker dtpCompletedDate;
        private System.Windows.Forms.RadioButton rbNotAssignCompletedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAssignCompletedDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label7;
    }
}