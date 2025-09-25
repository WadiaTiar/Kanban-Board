namespace TaskTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlTasksList));
            this.cbtnSearch = new TaskTracker.CustomControls.CircularButton();
            this.cbDueTo = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.ctrlTasksList2 = new TaskTracker.Task.ctrlTasksList2();
            this.rlblAddTask = new TaskTracker.CustomControls.RoundedLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbtnSearch
            // 
            this.cbtnSearch.BackColor = System.Drawing.Color.Silver;
            this.cbtnSearch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("cbtnSearch.ButtonImage")));
            this.cbtnSearch.FlatAppearance.BorderSize = 0;
            this.cbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnSearch.ForeColor = System.Drawing.Color.White;
            this.cbtnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cbtnSearch.Location = new System.Drawing.Point(1485, 22);
            this.cbtnSearch.Name = "cbtnSearch";
            this.cbtnSearch.Size = new System.Drawing.Size(58, 58);
            this.cbtnSearch.TabIndex = 3;
            this.cbtnSearch.UseVisualStyleBackColor = false;
            this.cbtnSearch.Click += new System.EventHandler(this.cbtnSearch_Click);
            // 
            // cbDueTo
            // 
            this.cbDueTo.BackColor = System.Drawing.Color.PeachPuff;
            this.cbDueTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDueTo.FormattingEnabled = true;
            this.cbDueTo.Items.AddRange(new object[] {
            "All",
            "Today",
            "This Week",
            "Next Week",
            "This Month",
            "Next Month",
            "OverDue",
            "No Due Date"});
            this.cbDueTo.Location = new System.Drawing.Point(552, 117);
            this.cbDueTo.Name = "cbDueTo";
            this.cbDueTo.Size = new System.Drawing.Size(173, 33);
            this.cbDueTo.TabIndex = 4;
            this.cbDueTo.SelectedIndexChanged += new System.EventHandler(this.cbDueTo_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.PeachPuff;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "All",
            "Personal",
            "Health",
            "Home",
            "Stady",
            "Work",
            "Social"});
            this.cbType.Location = new System.Drawing.Point(352, 117);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(173, 33);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbPriority
            // 
            this.cbPriority.BackColor = System.Drawing.Color.PeachPuff;
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "All",
            "Optional",
            "High",
            "Medium",
            "Low"});
            this.cbPriority.Location = new System.Drawing.Point(155, 117);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(173, 33);
            this.cbPriority.TabIndex = 2;
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // ctrlTasksList2
            // 
            this.ctrlTasksList2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlTasksList2.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTasksList2.Location = new System.Drawing.Point(8, 166);
            this.ctrlTasksList2.Name = "ctrlTasksList2";
            this.ctrlTasksList2.Size = new System.Drawing.Size(1609, 722);
            this.ctrlTasksList2.TabIndex = 4;
            // 
            // rlblAddTask
            // 
            this.rlblAddTask.BackColor = System.Drawing.Color.LightGray;
            this.rlblAddTask.CornerRadius = 10;
            this.rlblAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlblAddTask.ForeColor = System.Drawing.Color.Black;
            this.rlblAddTask.Location = new System.Drawing.Point(64, 10);
            this.rlblAddTask.Name = "rlblAddTask";
            this.rlblAddTask.Size = new System.Drawing.Size(194, 42);
            this.rlblAddTask.TabIndex = 3;
            this.rlblAddTask.Text = "Add Task";
            this.rlblAddTask.TextAlignCustom = System.Drawing.ContentAlignment.MiddleCenter;
            this.rlblAddTask.Click += new System.EventHandler(this.rlblAddTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Due To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filter By:";
            // 
            // ctrlTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtnSearch);
            this.Controls.Add(this.ctrlTasksList2);
            this.Controls.Add(this.rlblAddTask);
            this.Controls.Add(this.cbDueTo);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbPriority);
            this.Name = "ctrlTasksList";
            this.Size = new System.Drawing.Size(1617, 968);
            this.MouseEnter += new System.EventHandler(this.ctrlTasksList_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbDueTo;
        private System.Windows.Forms.ComboBox cbType;
        private CustomControls.CircularButton cbtnSearch;
        private CustomControls.RoundedLabel rlblAddTask;
        //private Team_Workspace.Task_Board.ctrlEditTaskPanelSide ctrlEditTaskPanelSide1;
        private Task.ctrlTasksList2 ctrlTasksList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
