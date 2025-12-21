namespace KanbanBoard.Task_Board.PanelTasks
{
    partial class ctrlPanelTasks
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
            this.lblTasksSum = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreateTask = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbStatusIcon = new System.Windows.Forms.PictureBox();
            this.plScrollAbove = new System.Windows.Forms.Panel();
            this.plScrollDown = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlAddTask1 = new KanbanBoard.Task_Board.ctrlAddTask();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTasksSum
            // 
            this.lblTasksSum.AutoSize = true;
            this.lblTasksSum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTasksSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTasksSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasksSum.ForeColor = System.Drawing.Color.Gray;
            this.lblTasksSum.Location = new System.Drawing.Point(371, 11);
            this.lblTasksSum.Name = "lblTasksSum";
            this.lblTasksSum.Size = new System.Drawing.Size(45, 54);
            this.lblTasksSum.TabIndex = 7;
            this.lblTasksSum.Text = "1";
            this.lblTasksSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatusTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusTitle.ImageIndex = 2;
            this.lblStatusTitle.Location = new System.Drawing.Point(66, 11);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(299, 42);
            this.lblStatusTitle.TabIndex = 6;
            this.lblStatusTitle.Text = "Status Title";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.ctrlAddTask1);
            this.flowLayoutPanel1.Controls.Add(this.lblCreateTask);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 602);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Tag = "0";
            // 
            // lblCreateTask
            // 
            this.lblCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateTask.Location = new System.Drawing.Point(3, 221);
            this.lblCreateTask.Name = "lblCreateTask";
            this.lblCreateTask.Size = new System.Drawing.Size(403, 41);
            this.lblCreateTask.TabIndex = 1;
            this.lblCreateTask.Text = "Create task +";
            this.lblCreateTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateTask.Click += new System.EventHandler(this.lblCreateTask_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plScrollAbove, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.plScrollDown, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 735);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.11957F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.88043F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Controls.Add(this.lblTasksSum, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStatusTitle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.98113F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.01887F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 74);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.pbStatusIcon);
            this.panel2.Location = new System.Drawing.Point(3, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 48);
            this.panel2.TabIndex = 9;
            // 
            // pbStatusIcon
            // 
            this.pbStatusIcon.Location = new System.Drawing.Point(3, 3);
            this.pbStatusIcon.Name = "pbStatusIcon";
            this.pbStatusIcon.Size = new System.Drawing.Size(51, 42);
            this.pbStatusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusIcon.TabIndex = 8;
            this.pbStatusIcon.TabStop = false;
            // 
            // plScrollAbove
            // 
            this.plScrollAbove.AllowDrop = true;
            this.plScrollAbove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plScrollAbove.Location = new System.Drawing.Point(3, 83);
            this.plScrollAbove.Name = "plScrollAbove";
            this.plScrollAbove.Size = new System.Drawing.Size(421, 9);
            this.plScrollAbove.TabIndex = 10;
            // 
            // plScrollDown
            // 
            this.plScrollDown.AllowDrop = true;
            this.plScrollDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plScrollDown.Location = new System.Drawing.Point(3, 712);
            this.plScrollDown.Name = "plScrollDown";
            this.plScrollDown.Size = new System.Drawing.Size(421, 20);
            this.plScrollDown.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 608);
            this.panel1.TabIndex = 8;
            // 
            // ctrlAddTask1
            // 
            this.ctrlAddTask1.AutoSize = true;
            this.ctrlAddTask1.Location = new System.Drawing.Point(3, 3);
            this.ctrlAddTask1.Name = "ctrlAddTask1";
            this.ctrlAddTask1.Size = new System.Drawing.Size(408, 215);
            this.ctrlAddTask1.TabIndex = 0;
            // 
            // ctrlPanelTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlPanelTasks";
            this.Size = new System.Drawing.Size(427, 735);
            this.Load += new System.EventHandler(this.ctrlPanelTasks_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTasksSum;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel plScrollAbove;
        private System.Windows.Forms.Panel plScrollDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbStatusIcon;
        private System.Windows.Forms.Panel panel1;
        private ctrlAddTask ctrlAddTask1;
        private System.Windows.Forms.Label lblCreateTask;
    }
}
