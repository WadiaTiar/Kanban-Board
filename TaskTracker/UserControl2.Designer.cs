namespace TaskTracker
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.ctrlTask1 = new TaskTracker.Task.ctrlTask();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCompletedTaskCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCreateTask_InProgress = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInProgressCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCreateTask_Scheduled = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScheduledTaskCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCreateTask_New = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewTaskCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTask1
            // 
            this.ctrlTask1.AutoSize = true;
            this.ctrlTask1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTask1.Title = " Hello World! ";
            this.ctrlTask1.Location = new System.Drawing.Point(3, 3);
            this.ctrlTask1.Name = "ctrlTask1";
            this.ctrlTask1.Size = new System.Drawing.Size(381, 195);
            this.ctrlTask1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel4.Controls.Add(this.ctrlTask1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(387, 655);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.flowLayoutPanel4);
            this.panel4.Location = new System.Drawing.Point(1161, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 717);
            this.panel4.TabIndex = 9;
            // 
            // lblCompletedTaskCount
            // 
            this.lblCompletedTaskCount.AutoSize = true;
            this.lblCompletedTaskCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCompletedTaskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTaskCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCompletedTaskCount.Location = new System.Drawing.Point(307, 16);
            this.lblCompletedTaskCount.Name = "lblCompletedTaskCount";
            this.lblCompletedTaskCount.Size = new System.Drawing.Size(23, 25);
            this.lblCompletedTaskCount.TabIndex = 10;
            this.lblCompletedTaskCount.Text = "1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(73, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "Completed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.Controls.Add(this.lblCompletedTaskCount);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(1161, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(380, 57);
            this.panel8.TabIndex = 6;
            // 
            // lblCreateTask_InProgress
            // 
            this.lblCreateTask_InProgress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateTask_InProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask_InProgress.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateTask_InProgress.Location = new System.Drawing.Point(0, 3);
            this.lblCreateTask_InProgress.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCreateTask_InProgress.Name = "lblCreateTask_InProgress";
            this.lblCreateTask_InProgress.Size = new System.Drawing.Size(372, 26);
            this.lblCreateTask_InProgress.TabIndex = 4;
            this.lblCreateTask_InProgress.Tag = "InProgress";
            this.lblCreateTask_InProgress.Text = "+  Create Task";
            this.lblCreateTask_InProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel3.Controls.Add(this.lblCreateTask_InProgress);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(380, 655);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Location = new System.Drawing.Point(775, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 717);
            this.panel3.TabIndex = 7;
            // 
            // lblInProgressCount
            // 
            this.lblInProgressCount.AutoSize = true;
            this.lblInProgressCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInProgressCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgressCount.ForeColor = System.Drawing.Color.Gray;
            this.lblInProgressCount.Location = new System.Drawing.Point(294, 16);
            this.lblInProgressCount.Name = "lblInProgressCount";
            this.lblInProgressCount.Size = new System.Drawing.Size(23, 25);
            this.lblInProgressCount.TabIndex = 9;
            this.lblInProgressCount.Text = "1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(57, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "In Progress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.lblInProgressCount);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(775, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 57);
            this.panel7.TabIndex = 6;
            // 
            // lblCreateTask_Scheduled
            // 
            this.lblCreateTask_Scheduled.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateTask_Scheduled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask_Scheduled.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateTask_Scheduled.Location = new System.Drawing.Point(0, 3);
            this.lblCreateTask_Scheduled.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCreateTask_Scheduled.Name = "lblCreateTask_Scheduled";
            this.lblCreateTask_Scheduled.Size = new System.Drawing.Size(372, 26);
            this.lblCreateTask_Scheduled.TabIndex = 4;
            this.lblCreateTask_Scheduled.Tag = "Scheduled";
            this.lblCreateTask_Scheduled.Text = "+  Create Task";
            this.lblCreateTask_Scheduled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel2.Controls.Add(this.lblCreateTask_Scheduled);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(380, 655);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(389, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 717);
            this.panel2.TabIndex = 5;
            // 
            // lblScheduledTaskCount
            // 
            this.lblScheduledTaskCount.AutoSize = true;
            this.lblScheduledTaskCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScheduledTaskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledTaskCount.ForeColor = System.Drawing.Color.Gray;
            this.lblScheduledTaskCount.Location = new System.Drawing.Point(305, 16);
            this.lblScheduledTaskCount.Name = "lblScheduledTaskCount";
            this.lblScheduledTaskCount.Size = new System.Drawing.Size(23, 25);
            this.lblScheduledTaskCount.TabIndex = 8;
            this.lblScheduledTaskCount.Text = "1";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(72, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 60);
            this.label8.TabIndex = 6;
            this.label8.Text = "Scheduled";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.lblScheduledTaskCount);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(389, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 57);
            this.panel6.TabIndex = 6;
            // 
            // lblCreateTask_New
            // 
            this.lblCreateTask_New.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreateTask_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask_New.ForeColor = System.Drawing.Color.Gray;
            this.lblCreateTask_New.Location = new System.Drawing.Point(0, 3);
            this.lblCreateTask_New.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCreateTask_New.Name = "lblCreateTask_New";
            this.lblCreateTask_New.Size = new System.Drawing.Size(380, 26);
            this.lblCreateTask_New.TabIndex = 4;
            this.lblCreateTask_New.Tag = "New";
            this.lblCreateTask_New.Text = "+  Create Task";
            this.lblCreateTask_New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.lblCreateTask_New);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(767, 655);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 717);
            this.panel1.TabIndex = 0;
            // 
            // lblNewTaskCount
            // 
            this.lblNewTaskCount.AutoSize = true;
            this.lblNewTaskCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewTaskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTaskCount.ForeColor = System.Drawing.Color.Gray;
            this.lblNewTaskCount.Location = new System.Drawing.Point(288, 16);
            this.lblNewTaskCount.Name = "lblNewTaskCount";
            this.lblNewTaskCount.Size = new System.Drawing.Size(23, 25);
            this.lblNewTaskCount.TabIndex = 7;
            this.lblNewTaskCount.Text = "1";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(72, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 60);
            this.label7.TabIndex = 6;
            this.label7.Text = "New task";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.lblNewTaskCount);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 57);
            this.panel5.TabIndex = 5;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 30;
            this.vScrollBar1.Location = new System.Drawing.Point(1530, 53);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(31, 780);
            this.vScrollBar1.SmallChange = 10;
            this.vScrollBar1.TabIndex = 7;
            this.vScrollBar1.Visible = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel5.Controls.Add(this.panel5);
            this.flowLayoutPanel5.Controls.Add(this.panel1);
            this.flowLayoutPanel5.Controls.Add(this.panel6);
            this.flowLayoutPanel5.Controls.Add(this.panel2);
            this.flowLayoutPanel5.Controls.Add(this.panel7);
            this.flowLayoutPanel5.Controls.Add(this.panel3);
            this.flowLayoutPanel5.Controls.Add(this.panel8);
            this.flowLayoutPanel5.Controls.Add(this.panel4);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(-22, 50);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1549, 793);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1833, 892);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Task.ctrlTask ctrlTask1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCompletedTaskCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCreateTask_InProgress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInProgressCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCreateTask_Scheduled;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblScheduledTaskCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCreateTask_New;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewTaskCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}
