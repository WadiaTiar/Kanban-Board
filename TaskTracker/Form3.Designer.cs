namespace TaskTracker
{
    partial class Form3
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlTask1 = new TaskTracker.Task.ctrlTask();
            this.ctrlTask2 = new TaskTracker.Task.ctrlTask();
            this.lblCreateTask1 = new System.Windows.Forms.Label();
            this.lblCreateTask2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScheduled = new System.Windows.Forms.Label();
            this.lblNewTaskCount = new System.Windows.Forms.Label();
            this.lblScheduledCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlTask3 = new TaskTracker.Task.ctrlTask();
            this.ctrlTask5 = new TaskTracker.Task.ctrlTask();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ScrollDown = new System.Windows.Forms.Panel();
            this.ScrollAbove = new System.Windows.Forms.Panel();
            this.ctrlTask4 = new TaskTracker.Task.ctrlTask();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel1.Controls.Add(this.ctrlTask1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlTask2);
            this.flowLayoutPanel1.Controls.Add(this.lblCreateTask1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(498, 185);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 549);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ctrlTask1
            // 
            this.ctrlTask1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTask1.Location = new System.Drawing.Point(3, 3);
            this.ctrlTask1.Name = "ctrlTask1";
            this.ctrlTask1.Size = new System.Drawing.Size(374, 195);
            this.ctrlTask1.TabIndex = 4;
            this.ctrlTask1.Title = "oooo! ";
            // 
            // ctrlTask2
            // 
            this.ctrlTask2.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTask2.Location = new System.Drawing.Point(3, 204);
            this.ctrlTask2.Name = "ctrlTask2";
            this.ctrlTask2.Size = new System.Drawing.Size(374, 195);
            this.ctrlTask2.TabIndex = 6;
            this.ctrlTask2.Title = "Ahmed";
            // 
            // lblCreateTask1
            // 
            this.lblCreateTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask1.Location = new System.Drawing.Point(0, 405);
            this.lblCreateTask1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCreateTask1.Name = "lblCreateTask1";
            this.lblCreateTask1.Size = new System.Drawing.Size(377, 26);
            this.lblCreateTask1.TabIndex = 3;
            this.lblCreateTask1.Text = "+  Create Task";
            this.lblCreateTask1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateTask1.Visible = false;
            // 
            // lblCreateTask2
            // 
            this.lblCreateTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTask2.Location = new System.Drawing.Point(0, 405);
            this.lblCreateTask2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCreateTask2.Name = "lblCreateTask2";
            this.lblCreateTask2.Size = new System.Drawing.Size(373, 26);
            this.lblCreateTask2.TabIndex = 4;
            this.lblCreateTask2.Text = "+  Create Task";
            this.lblCreateTask2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateTask2.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "New task";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScheduled
            // 
            this.lblScheduled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduled.Location = new System.Drawing.Point(1055, 113);
            this.lblScheduled.Name = "lblScheduled";
            this.lblScheduled.Size = new System.Drawing.Size(381, 45);
            this.lblScheduled.TabIndex = 4;
            this.lblScheduled.Text = "Scheduled";
            this.lblScheduled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewTaskCount
            // 
            this.lblNewTaskCount.AutoSize = true;
            this.lblNewTaskCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblNewTaskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTaskCount.ForeColor = System.Drawing.Color.Gray;
            this.lblNewTaskCount.Location = new System.Drawing.Point(756, 124);
            this.lblNewTaskCount.Name = "lblNewTaskCount";
            this.lblNewTaskCount.Size = new System.Drawing.Size(23, 25);
            this.lblNewTaskCount.TabIndex = 5;
            this.lblNewTaskCount.Text = "1";
            // 
            // lblScheduledCount
            // 
            this.lblScheduledCount.AutoSize = true;
            this.lblScheduledCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblScheduledCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledCount.ForeColor = System.Drawing.Color.Gray;
            this.lblScheduledCount.Location = new System.Drawing.Point(1127, 124);
            this.lblScheduledCount.Name = "lblScheduledCount";
            this.lblScheduledCount.Size = new System.Drawing.Size(23, 25);
            this.lblScheduledCount.TabIndex = 6;
            this.lblScheduledCount.Text = "1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel2.Controls.Add(this.ctrlTask3);
            this.flowLayoutPanel2.Controls.Add(this.ctrlTask5);
            this.flowLayoutPanel2.Controls.Add(this.lblCreateTask2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1058, 182);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 552);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // ctrlTask3
            // 
            this.ctrlTask3.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTask3.Location = new System.Drawing.Point(3, 3);
            this.ctrlTask3.Name = "ctrlTask3";
            this.ctrlTask3.Size = new System.Drawing.Size(374, 195);
            this.ctrlTask3.TabIndex = 9;
            this.ctrlTask3.Title = " Hello World! ";
            // 
            // ctrlTask5
            // 
            this.ctrlTask5.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTask5.Location = new System.Drawing.Point(3, 204);
            this.ctrlTask5.Name = "ctrlTask5";
            this.ctrlTask5.Size = new System.Drawing.Size(374, 195);
            this.ctrlTask5.TabIndex = 7;
            this.ctrlTask5.Title = "World! ";
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(37, 45);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(134, 58);
            this.pnlBoard.TabIndex = 10;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(187, 26);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 87);
            this.vScrollBar1.TabIndex = 11;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // ScrollDown
            // 
            this.ScrollDown.AllowDrop = true;
            this.ScrollDown.Location = new System.Drawing.Point(37, 113);
            this.ScrollDown.Name = "ScrollDown";
            this.ScrollDown.Size = new System.Drawing.Size(134, 18);
            this.ScrollDown.TabIndex = 12;
            this.ScrollDown.DragOver += new System.Windows.Forms.DragEventHandler(this.ScrollDown_DragOver);
            // 
            // ScrollAbove
            // 
            this.ScrollAbove.AllowDrop = true;
            this.ScrollAbove.Location = new System.Drawing.Point(37, 16);
            this.ScrollAbove.Name = "ScrollAbove";
            this.ScrollAbove.Size = new System.Drawing.Size(134, 10);
            this.ScrollAbove.TabIndex = 13;
            this.ScrollAbove.DragOver += new System.Windows.Forms.DragEventHandler(this.ScrollAbove_DragOver);
            // 
            // ctrlTask4
            // 
            this.ctrlTask4.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTask4.Location = new System.Drawing.Point(72, 320);
            this.ctrlTask4.Name = "ctrlTask4";
            this.ctrlTask4.Size = new System.Drawing.Size(374, 220);
            this.ctrlTask4.TabIndex = 14;
            this.ctrlTask4.Title = "Hello world";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1619, 950);
            this.Controls.Add(this.ctrlTask4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ScrollAbove);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.ScrollDown);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.lblScheduledCount);
            this.Controls.Add(this.lblNewTaskCount);
            this.Controls.Add(this.lblScheduled);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCreateTask1;
        private System.Windows.Forms.Label lblCreateTask2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScheduled;
        private System.Windows.Forms.Label lblNewTaskCount;
        private System.Windows.Forms.Label lblScheduledCount;
        private Task.ctrlTask ctrlTask1;
        private Task.ctrlTask ctrlTask5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Task.ctrlTask ctrlTask2;
        private Task.ctrlTask ctrlTask3;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel ScrollDown;
        private System.Windows.Forms.Panel ScrollAbove;
        private Task.ctrlTask ctrlTask4;
    }
}