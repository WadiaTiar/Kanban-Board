namespace TaskTracker.Team_Workspace.Task_Board
{
    partial class ctrlEditTaskPanelSide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlEditTaskPanelSide));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseEditTaskWindow = new System.Windows.Forms.Button();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTaskTitleNotice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoDueDate = new System.Windows.Forms.Label();
            this.rbNotAssignDueTo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAssignDueTo = new System.Windows.Forms.RadioButton();
            this.dtpDueTo = new System.Windows.Forms.DateTimePicker();
            this.plCompletedDate = new System.Windows.Forms.Panel();
            this.lblNoCompletedDate = new System.Windows.Forms.Label();
            this.dtpCompletedDate = new System.Windows.Forms.DateTimePicker();
            this.rbNotAssignCompletedDate = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAssignCompletedDate = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plCompletedDate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(83, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseEditTaskWindow
            // 
            this.btnCloseEditTaskWindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloseEditTaskWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseEditTaskWindow.ForeColor = System.Drawing.Color.Black;
            this.btnCloseEditTaskWindow.Location = new System.Drawing.Point(3, 0);
            this.btnCloseEditTaskWindow.Name = "btnCloseEditTaskWindow";
            this.btnCloseEditTaskWindow.Size = new System.Drawing.Size(56, 53);
            this.btnCloseEditTaskWindow.TabIndex = 7;
            this.btnCloseEditTaskWindow.Text = "x";
            this.btnCloseEditTaskWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseEditTaskWindow.UseVisualStyleBackColor = false;
            this.btnCloseEditTaskWindow.Click += new System.EventHandler(this.btnCloseEditTaskWindow_Click);
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTaskTitle.Location = new System.Drawing.Point(25, 92);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(159, 38);
            this.lblTaskTitle.TabIndex = 9;
            this.lblTaskTitle.Text = "Task Title";
            this.lblTaskTitle.Click += new System.EventHandler(this.lblTaskTitle_Click);
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTaskDescription.Location = new System.Drawing.Point(26, 451);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(174, 25);
            this.lblTaskDescription.TabIndex = 10;
            this.lblTaskDescription.Text = "Task Description";
            this.lblTaskDescription.Click += new System.EventHandler(this.lblTaskDescription_Click);
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTaskTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.Location = new System.Drawing.Point(18, 92);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(640, 38);
            this.txtTaskTitle.TabIndex = 11;
            this.txtTaskTitle.TextChanged += new System.EventHandler(this.txtTaskTitle_TextChanged);
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTaskDescription.Location = new System.Drawing.Point(19, 448);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(640, 244);
            this.txtTaskDescription.TabIndex = 12;
            this.txtTaskDescription.TextChanged += new System.EventHandler(this.txtTaskDescription_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "New",
            "Scheduled",
            "In Progress",
            "Compeleted"});
            this.cbStatus.Location = new System.Drawing.Point(118, 88);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(187, 30);
            this.cbStatus.TabIndex = 37;
            this.cbStatus.Text = "Select Status";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Status:";
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Optional",
            "High",
            "Medium",
            "Low"});
            this.cbPriority.Location = new System.Drawing.Point(118, 141);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(187, 30);
            this.cbPriority.TabIndex = 35;
            this.cbPriority.Text = "Select Priority";
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Priority:";
            // 
            // lblTaskTitleNotice
            // 
            this.lblTaskTitleNotice.AutoSize = true;
            this.lblTaskTitleNotice.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitleNotice.ForeColor = System.Drawing.Color.Red;
            this.lblTaskTitleNotice.Location = new System.Drawing.Point(36, 133);
            this.lblTaskTitleNotice.Name = "lblTaskTitleNotice";
            this.lblTaskTitleNotice.Size = new System.Drawing.Size(163, 19);
            this.lblTaskTitleNotice.TabIndex = 38;
            this.lblTaskTitleNotice.Text = "Task title is required";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNoDueDate);
            this.panel1.Controls.Add(this.rbNotAssignDueTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbAssignDueTo);
            this.panel1.Controls.Add(this.dtpDueTo);
            this.panel1.Location = new System.Drawing.Point(3, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 79);
            this.panel1.TabIndex = 39;
            // 
            // lblNoDueDate
            // 
            this.lblNoDueDate.BackColor = System.Drawing.Color.White;
            this.lblNoDueDate.Enabled = false;
            this.lblNoDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDueDate.Location = new System.Drawing.Point(160, 46);
            this.lblNoDueDate.Name = "lblNoDueDate";
            this.lblNoDueDate.Size = new System.Drawing.Size(152, 23);
            this.lblNoDueDate.TabIndex = 39;
            this.lblNoDueDate.Text = "No Due Date";
            this.lblNoDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbNotAssignDueTo
            // 
            this.rbNotAssignDueTo.AutoSize = true;
            this.rbNotAssignDueTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbNotAssignDueTo.Checked = true;
            this.rbNotAssignDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotAssignDueTo.ForeColor = System.Drawing.Color.Black;
            this.rbNotAssignDueTo.Location = new System.Drawing.Point(264, 13);
            this.rbNotAssignDueTo.Name = "rbNotAssignDueTo";
            this.rbNotAssignDueTo.Size = new System.Drawing.Size(112, 24);
            this.rbNotAssignDueTo.TabIndex = 37;
            this.rbNotAssignDueTo.TabStop = true;
            this.rbNotAssignDueTo.Tag = "0";
            this.rbNotAssignDueTo.Text = "Not Assign";
            this.rbNotAssignDueTo.UseVisualStyleBackColor = false;
            this.rbNotAssignDueTo.CheckedChanged += new System.EventHandler(this.rbDuteTo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Due to:";
            // 
            // rbAssignDueTo
            // 
            this.rbAssignDueTo.AutoSize = true;
            this.rbAssignDueTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbAssignDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAssignDueTo.ForeColor = System.Drawing.Color.Black;
            this.rbAssignDueTo.Location = new System.Drawing.Point(158, 13);
            this.rbAssignDueTo.Name = "rbAssignDueTo";
            this.rbAssignDueTo.Size = new System.Drawing.Size(81, 24);
            this.rbAssignDueTo.TabIndex = 36;
            this.rbAssignDueTo.Tag = "1";
            this.rbAssignDueTo.Text = "Assign";
            this.rbAssignDueTo.UseVisualStyleBackColor = false;
            this.rbAssignDueTo.CheckedChanged += new System.EventHandler(this.rbDuteTo_CheckedChanged);
            // 
            // dtpDueTo
            // 
            this.dtpDueTo.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpDueTo.CustomFormat = "";
            this.dtpDueTo.Enabled = false;
            this.dtpDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueTo.Location = new System.Drawing.Point(158, 43);
            this.dtpDueTo.Name = "dtpDueTo";
            this.dtpDueTo.Size = new System.Drawing.Size(218, 28);
            this.dtpDueTo.TabIndex = 41;
            // 
            // plCompletedDate
            // 
            this.plCompletedDate.Controls.Add(this.lblNoCompletedDate);
            this.plCompletedDate.Controls.Add(this.dtpCompletedDate);
            this.plCompletedDate.Controls.Add(this.rbNotAssignCompletedDate);
            this.plCompletedDate.Controls.Add(this.label6);
            this.plCompletedDate.Controls.Add(this.rbAssignCompletedDate);
            this.plCompletedDate.Location = new System.Drawing.Point(3, 286);
            this.plCompletedDate.Name = "plCompletedDate";
            this.plCompletedDate.Size = new System.Drawing.Size(392, 79);
            this.plCompletedDate.TabIndex = 40;
            this.plCompletedDate.Visible = false;
            // 
            // lblNoCompletedDate
            // 
            this.lblNoCompletedDate.BackColor = System.Drawing.Color.White;
            this.lblNoCompletedDate.Enabled = false;
            this.lblNoCompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCompletedDate.Location = new System.Drawing.Point(165, 43);
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
            this.dtpCompletedDate.Location = new System.Drawing.Point(158, 41);
            this.dtpCompletedDate.Name = "dtpCompletedDate";
            this.dtpCompletedDate.Size = new System.Drawing.Size(218, 28);
            this.dtpCompletedDate.TabIndex = 25;
            // 
            // rbNotAssignCompletedDate
            // 
            this.rbNotAssignCompletedDate.AutoSize = true;
            this.rbNotAssignCompletedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbNotAssignCompletedDate.Checked = true;
            this.rbNotAssignCompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotAssignCompletedDate.ForeColor = System.Drawing.Color.Black;
            this.rbNotAssignCompletedDate.Location = new System.Drawing.Point(264, 15);
            this.rbNotAssignCompletedDate.Name = "rbNotAssignCompletedDate";
            this.rbNotAssignCompletedDate.Size = new System.Drawing.Size(112, 24);
            this.rbNotAssignCompletedDate.TabIndex = 37;
            this.rbNotAssignCompletedDate.TabStop = true;
            this.rbNotAssignCompletedDate.Tag = "0";
            this.rbNotAssignCompletedDate.Text = "Not Assign";
            this.rbNotAssignCompletedDate.UseVisualStyleBackColor = false;
            this.rbNotAssignCompletedDate.CheckedChanged += new System.EventHandler(this.rbCompletedDate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Comp. Date:";
            // 
            // rbAssignCompletedDate
            // 
            this.rbAssignCompletedDate.AutoSize = true;
            this.rbAssignCompletedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbAssignCompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAssignCompletedDate.ForeColor = System.Drawing.Color.Black;
            this.rbAssignCompletedDate.Location = new System.Drawing.Point(158, 15);
            this.rbAssignCompletedDate.Name = "rbAssignCompletedDate";
            this.rbAssignCompletedDate.Size = new System.Drawing.Size(81, 24);
            this.rbAssignCompletedDate.TabIndex = 36;
            this.rbAssignCompletedDate.Tag = "1";
            this.rbAssignCompletedDate.Text = "Assign";
            this.rbAssignCompletedDate.UseVisualStyleBackColor = false;
            this.rbAssignCompletedDate.CheckedChanged += new System.EventHandler(this.rbCompletedDate_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.plCompletedDate);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbPriority);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTaskDescription);
            this.panel2.Controls.Add(this.txtTaskDescription);
            this.panel2.Location = new System.Drawing.Point(9, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 559);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(19, 713);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 16);
            this.panel3.TabIndex = 43;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Personal",
            "Health",
            "Home",
            "Stady",
            "Work",
            "Social"});
            this.cbType.Location = new System.Drawing.Point(118, 26);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(187, 30);
            this.cbType.TabIndex = 42;
            this.cbType.Text = "Select Type";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Type:";
            // 
            // ctrlEditTaskPanelSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnCloseEditTaskWindow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.lblTaskTitleNotice);
            this.Controls.Add(this.txtTaskTitle);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "ctrlEditTaskPanelSide";
            this.Size = new System.Drawing.Size(742, 769);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plCompletedDate.ResumeLayout(false);
            this.plCompletedDate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseEditTaskWindow;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTaskTitleNotice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoDueDate;
        private System.Windows.Forms.RadioButton rbNotAssignDueTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAssignDueTo;
        private System.Windows.Forms.Panel plCompletedDate;
        private System.Windows.Forms.Label lblNoCompletedDate;
        private System.Windows.Forms.DateTimePicker dtpCompletedDate;
        private System.Windows.Forms.RadioButton rbNotAssignCompletedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAssignCompletedDate;
        private System.Windows.Forms.DateTimePicker dtpDueTo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}
