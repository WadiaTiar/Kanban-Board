namespace TaskTracker.Team_Workspace.Task_Board.Task
{
    partial class ctrlEllipsisCommandMenu
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
            this.lblDeleteTask = new System.Windows.Forms.Label();
            this.lblDuplicateTask = new System.Windows.Forms.Label();
            this.lblChangeType = new System.Windows.Forms.Label();
            this.lblCompleteTask = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteTask
            // 
            this.lblDeleteTask.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblDeleteTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTask.ForeColor = System.Drawing.Color.White;
            this.lblDeleteTask.Location = new System.Drawing.Point(3, 135);
            this.lblDeleteTask.Name = "lblDeleteTask";
            this.lblDeleteTask.Size = new System.Drawing.Size(214, 45);
            this.lblDeleteTask.TabIndex = 3;
            this.lblDeleteTask.Text = "Delete task";
            this.lblDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeleteTask.Click += new System.EventHandler(this.lblDeleteTask_Click);
            this.lblDeleteTask.MouseEnter += new System.EventHandler(this.EllipsisCommandItems_MouseEnter);
            this.lblDeleteTask.MouseLeave += new System.EventHandler(this.EllipsisCommandItems_MouseLeave);
            // 
            // lblDuplicateTask
            // 
            this.lblDuplicateTask.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblDuplicateTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuplicateTask.ForeColor = System.Drawing.Color.White;
            this.lblDuplicateTask.Location = new System.Drawing.Point(3, 90);
            this.lblDuplicateTask.Name = "lblDuplicateTask";
            this.lblDuplicateTask.Size = new System.Drawing.Size(214, 45);
            this.lblDuplicateTask.TabIndex = 2;
            this.lblDuplicateTask.Text = "Duplicate task";
            this.lblDuplicateTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDuplicateTask.Click += new System.EventHandler(this.lblDuplicateTask_Click);
            this.lblDuplicateTask.MouseEnter += new System.EventHandler(this.EllipsisCommandItems_MouseEnter);
            this.lblDuplicateTask.MouseLeave += new System.EventHandler(this.EllipsisCommandItems_MouseLeave);
            // 
            // lblChangeType
            // 
            this.lblChangeType.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblChangeType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeType.ForeColor = System.Drawing.Color.White;
            this.lblChangeType.Location = new System.Drawing.Point(3, 45);
            this.lblChangeType.Name = "lblChangeType";
            this.lblChangeType.Size = new System.Drawing.Size(214, 45);
            this.lblChangeType.TabIndex = 1;
            this.lblChangeType.Text = "Change Type";
            this.lblChangeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChangeType.Click += new System.EventHandler(this.lblChangeType_Click);
            this.lblChangeType.MouseEnter += new System.EventHandler(this.EllipsisCommandItems_MouseEnter);
            this.lblChangeType.MouseLeave += new System.EventHandler(this.EllipsisCommandItems_MouseLeave);
            // 
            // lblCompleteTask
            // 
            this.lblCompleteTask.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblCompleteTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteTask.ForeColor = System.Drawing.Color.White;
            this.lblCompleteTask.Location = new System.Drawing.Point(3, 0);
            this.lblCompleteTask.Name = "lblCompleteTask";
            this.lblCompleteTask.Size = new System.Drawing.Size(214, 45);
            this.lblCompleteTask.TabIndex = 0;
            this.lblCompleteTask.Text = "Complete task";
            this.lblCompleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompleteTask.Click += new System.EventHandler(this.lblCompleteTask_Click);
            this.lblCompleteTask.MouseEnter += new System.EventHandler(this.EllipsisCommandItems_MouseEnter);
            this.lblCompleteTask.MouseLeave += new System.EventHandler(this.EllipsisCommandItems_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCompleteTask);
            this.flowLayoutPanel1.Controls.Add(this.lblChangeType);
            this.flowLayoutPanel1.Controls.Add(this.lblDuplicateTask);
            this.flowLayoutPanel1.Controls.Add(this.lblDeleteTask);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 193);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ctrlEllipsisCommandMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ctrlEllipsisCommandMenu";
            this.Size = new System.Drawing.Size(233, 214);
            this.VisibleChanged += new System.EventHandler(this.ctrlEllipsisCommandMenu_VisibleChanged);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCompleteTask;
        private System.Windows.Forms.Label lblDeleteTask;
        private System.Windows.Forms.Label lblDuplicateTask;
        private System.Windows.Forms.Label lblChangeType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
