namespace TaskTracker.Team_Workspace.Task_Board
{
    partial class ctrlAddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddTask));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new TaskTracker.CustomControls.CircularButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.rlbtnSave = new TaskTracker.CustomControls.RoundedLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 234);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ButtonImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(373, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblTaskTitle);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(24, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 104);
            this.panel1.TabIndex = 11;
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTaskTitle.Location = new System.Drawing.Point(10, 0);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(120, 29);
            this.lblTaskTitle.TabIndex = 10;
            this.lblTaskTitle.Text = "Task Title";
            this.lblTaskTitle.Click += new System.EventHandler(this.lblTaskTitle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(5, 0);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(335, 32);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(373, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 104);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCalendar);
            this.panel3.Controls.Add(this.btnType);
            this.panel3.Controls.Add(this.btnPriority);
            this.panel3.Controls.Add(this.rlbtnSave);
            this.panel3.Location = new System.Drawing.Point(24, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 78);
            this.panel3.TabIndex = 13;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.Location = new System.Drawing.Point(15, 7);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(40, 39);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.Image = ((System.Drawing.Image)(resources.GetObject("btnType.Image")));
            this.btnType.Location = new System.Drawing.Point(123, 12);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(30, 29);
            this.btnType.TabIndex = 2;
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriority.Image = ((System.Drawing.Image)(resources.GetObject("btnPriority.Image")));
            this.btnPriority.Location = new System.Drawing.Point(75, 12);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(30, 29);
            this.btnPriority.TabIndex = 1;
            this.btnPriority.UseVisualStyleBackColor = false;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // rlbtnSave
            // 
            this.rlbtnSave.BackColor = System.Drawing.Color.MediumOrchid;
            this.rlbtnSave.CornerRadius = 10;
            this.rlbtnSave.Enabled = false;
            this.rlbtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbtnSave.ForeColor = System.Drawing.Color.White;
            this.rlbtnSave.Location = new System.Drawing.Point(239, 11);
            this.rlbtnSave.Name = "rlbtnSave";
            this.rlbtnSave.Size = new System.Drawing.Size(90, 39);
            this.rlbtnSave.TabIndex = 0;
            this.rlbtnSave.Text = "Save";
            this.rlbtnSave.TextAlignCustom = System.Drawing.ContentAlignment.MiddleCenter;
            this.rlbtnSave.Click += new System.EventHandler(this.rlbtnSave_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "keyboard_arrow_down_25dp.png");
            this.imageList1.Images.SetKeyName(1, "keyboard_arrow_up_25dp.png");
            // 
            // ctrlAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlAddTask";
            this.Size = new System.Drawing.Size(408, 234);
            this.VisibleChanged += new System.EventHandler(this.ctrlAddTask_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CircularButton btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnPriority;
        private CustomControls.RoundedLabel rlbtnSave;
        private System.Windows.Forms.Button btnCalendar;
    }
}
