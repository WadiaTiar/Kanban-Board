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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPanelTasks));
            this.plTitleContainer1 = new System.Windows.Forms.Panel();
            this.lblTasksSum = new System.Windows.Forms.Label();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreateTask = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlCreateTask = new KanbanBoard.Task_Board.ctrlAddTask();
            this.plTitleContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTitleContainer1
            // 
            this.plTitleContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plTitleContainer1.Controls.Add(this.lblTasksSum);
            this.plTitleContainer1.Controls.Add(this.lblPanelTitle);
            this.plTitleContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plTitleContainer1.Location = new System.Drawing.Point(3, 3);
            this.plTitleContainer1.Name = "plTitleContainer1";
            this.plTitleContainer1.Size = new System.Drawing.Size(419, 74);
            this.plTitleContainer1.TabIndex = 7;
            // 
            // lblTasksSum
            // 
            this.lblTasksSum.AutoSize = true;
            this.lblTasksSum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTasksSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasksSum.ForeColor = System.Drawing.Color.Gray;
            this.lblTasksSum.Location = new System.Drawing.Point(314, 14);
            this.lblTasksSum.Name = "lblTasksSum";
            this.lblTasksSum.Size = new System.Drawing.Size(23, 25);
            this.lblTasksSum.TabIndex = 7;
            this.lblTasksSum.Text = "1";
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPanelTitle.ImageList = this.imageList1;
            this.lblPanelTitle.Location = new System.Drawing.Point(65, -3);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(291, 57);
            this.lblPanelTitle.TabIndex = 6;
            this.lblPanelTitle.Text = "Panel Title";
            this.lblPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NewTask_48.png");
            this.imageList1.Images.SetKeyName(1, "Scheduled_48.png");
            this.imageList1.Images.SetKeyName(2, "InProgress_48.png");
            this.imageList1.Images.SetKeyName(3, "Completed_48.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.ctrlCreateTask);
            this.flowLayoutPanel1.Controls.Add(this.lblCreateTask);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 630);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Tag = "0";
            // 
            // lblCreateTask
            // 
            this.lblCreateTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateTask.Location = new System.Drawing.Point(0, 224);
            this.lblCreateTask.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCreateTask.Name = "lblCreateTask";
            this.lblCreateTask.Size = new System.Drawing.Size(398, 40);
            this.lblCreateTask.TabIndex = 4;
            this.lblCreateTask.Tag = "1";
            this.lblCreateTask.Text = "+  Create Task";
            this.lblCreateTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateTask.Click += new System.EventHandler(this.lblCreateTask_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.plTitleContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 722);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 636);
            this.panel1.TabIndex = 8;
            // 
            // ctrlCreateTask
            // 
            this.ctrlCreateTask.AutoSize = true;
            this.ctrlCreateTask.Location = new System.Drawing.Point(3, 3);
            this.ctrlCreateTask.Name = "ctrlCreateTask";
            this.ctrlCreateTask.Size = new System.Drawing.Size(408, 215);
            this.ctrlCreateTask.TabIndex = 5;
            this.ctrlCreateTask.Tag = "0";
            // 
            // ctrlPanelTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlPanelTasks";
            this.Size = new System.Drawing.Size(425, 722);
            this.Load += new System.EventHandler(this.ctrlPanelTasks_Load);
            this.plTitleContainer1.ResumeLayout(false);
            this.plTitleContainer1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTitleContainer1;
        private System.Windows.Forms.Label lblTasksSum;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Task_Board.ctrlAddTask ctrlCreateTask;
        private System.Windows.Forms.Label lblCreateTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
