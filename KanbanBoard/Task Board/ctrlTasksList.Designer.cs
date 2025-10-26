namespace TaskTracker.Task
{
    partial class ctrlTasksList
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.plScrollDown = new System.Windows.Forms.Panel();
            this.plScrollAbove = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlPanelTasks4 = new TaskTracker.Task_Board.PanelTasks.ctrlPanelTasks();
            this.ctrlPanelTasks3 = new TaskTracker.Task_Board.PanelTasks.ctrlPanelTasks();
            this.ctrlPanelTasks2 = new TaskTracker.Task_Board.PanelTasks.ctrlPanelTasks();
            this.ctrlPanelTasks1 = new TaskTracker.Task_Board.PanelTasks.ctrlPanelTasks();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 30;
            this.vScrollBar1.Location = new System.Drawing.Point(1701, 95);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(31, 674);
            this.vScrollBar1.SmallChange = 10;
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // plScrollDown
            // 
            this.plScrollDown.AllowDrop = true;
            this.plScrollDown.Location = new System.Drawing.Point(15, 761);
            this.plScrollDown.Name = "plScrollDown";
            this.plScrollDown.Size = new System.Drawing.Size(1673, 15);
            this.plScrollDown.TabIndex = 7;
            this.plScrollDown.DragOver += new System.Windows.Forms.DragEventHandler(this.plScrollDown_DragOver);
            // 
            // plScrollAbove
            // 
            this.plScrollAbove.AllowDrop = true;
            this.plScrollAbove.Location = new System.Drawing.Point(2, 62);
            this.plScrollAbove.Name = "plScrollAbove";
            this.plScrollAbove.Size = new System.Drawing.Size(1673, 10);
            this.plScrollAbove.TabIndex = 8;
            this.plScrollAbove.DragOver += new System.Windows.Forms.DragEventHandler(this.plScrollAbove_DragOver);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.plScrollAbove);
            this.panel1.Controls.Add(this.ctrlPanelTasks4);
            this.panel1.Controls.Add(this.ctrlPanelTasks3);
            this.panel1.Controls.Add(this.ctrlPanelTasks2);
            this.panel1.Controls.Add(this.ctrlPanelTasks1);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1678, 736);
            this.panel1.TabIndex = 0;
            // 
            // ctrlPanelTasks4
            // 
            this.ctrlPanelTasks4.dataTable = null;
            this.ctrlPanelTasks4.Location = new System.Drawing.Point(1259, 0);
            this.ctrlPanelTasks4.Name = "ctrlPanelTasks4";
            this.ctrlPanelTasks4.Size = new System.Drawing.Size(414, 722);
            this.ctrlPanelTasks4.TabIndex = 12;
            // 
            // ctrlPanelTasks3
            // 
            this.ctrlPanelTasks3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPanelTasks3.dataTable = null;
            this.ctrlPanelTasks3.Location = new System.Drawing.Point(840, 0);
            this.ctrlPanelTasks3.Name = "ctrlPanelTasks3";
            this.ctrlPanelTasks3.Size = new System.Drawing.Size(414, 722);
            this.ctrlPanelTasks3.TabIndex = 11;
            // 
            // ctrlPanelTasks2
            // 
            this.ctrlPanelTasks2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPanelTasks2.dataTable = null;
            this.ctrlPanelTasks2.Location = new System.Drawing.Point(420, 0);
            this.ctrlPanelTasks2.Name = "ctrlPanelTasks2";
            this.ctrlPanelTasks2.Size = new System.Drawing.Size(414, 722);
            this.ctrlPanelTasks2.TabIndex = 10;
            // 
            // ctrlPanelTasks1
            // 
            this.ctrlPanelTasks1.dataTable = null;
            this.ctrlPanelTasks1.Location = new System.Drawing.Point(2, 0);
            this.ctrlPanelTasks1.Name = "ctrlPanelTasks1";
            this.ctrlPanelTasks1.Size = new System.Drawing.Size(414, 722);
            this.ctrlPanelTasks1.TabIndex = 13;
            // 
            // ctrlTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.plScrollDown);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Name = "ctrlTasksList";
            this.Size = new System.Drawing.Size(1756, 787);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel plScrollDown;
        private System.Windows.Forms.Panel plScrollAbove;
        private System.Windows.Forms.Panel panel1;
        private Task_Board.PanelTasks.ctrlPanelTasks ctrlPanelTasks3;
        private Task_Board.PanelTasks.ctrlPanelTasks ctrlPanelTasks2;
        private Task_Board.PanelTasks.ctrlPanelTasks ctrlPanelTasks4;
        private Task_Board.PanelTasks.ctrlPanelTasks ctrlPanelTasks1;
    }
}
