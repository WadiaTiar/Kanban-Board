namespace KanbanBoard.Task_Board.Panels.StatusSettings
{
    partial class ctrlEditStatuses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlEditStatuses));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rlClose = new KanbanBoard.CustomControls.RoundedLabel();
            this.flpStatusesList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAddNewStatus = new System.Windows.Forms.Label();
            this.ctrlFixedStatus = new KanbanBoard.Task_Board.Panels.StatusSettings.ctrlStatusElement();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChooseIconFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flpStatusesList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 239);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rlClose);
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 47);
            this.panel1.TabIndex = 1;
            // 
            // rlClose
            // 
            this.rlClose.BackColor = System.Drawing.Color.LightCoral;
            this.rlClose.CornerRadius = 10;
            this.rlClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlClose.ForeColor = System.Drawing.Color.Black;
            this.rlClose.Location = new System.Drawing.Point(395, 9);
            this.rlClose.Name = "rlClose";
            this.rlClose.Size = new System.Drawing.Size(119, 37);
            this.rlClose.TabIndex = 0;
            this.rlClose.Text = "Close";
            this.rlClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rlClose.TextAlignCustom = System.Drawing.ContentAlignment.MiddleCenter;
            this.rlClose.Click += new System.EventHandler(this.rlClose_Click);
            // 
            // flpStatusesList
            // 
            this.flpStatusesList.AllowDrop = true;
            this.flpStatusesList.AutoSize = true;
            this.flpStatusesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStatusesList.Location = new System.Drawing.Point(3, 96);
            this.flpStatusesList.Name = "flpStatusesList";
            this.flpStatusesList.Size = new System.Drawing.Size(544, 1);
            this.flpStatusesList.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblAddNewStatus);
            this.flowLayoutPanel2.Controls.Add(this.ctrlFixedStatus);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 102);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(544, 81);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lblAddNewStatus
            // 
            this.lblAddNewStatus.AutoSize = true;
            this.lblAddNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddNewStatus.Location = new System.Drawing.Point(3, 0);
            this.lblAddNewStatus.Name = "lblAddNewStatus";
            this.lblAddNewStatus.Size = new System.Drawing.Size(163, 25);
            this.lblAddNewStatus.TabIndex = 2;
            this.lblAddNewStatus.Text = "+ Add new status";
            this.lblAddNewStatus.Click += new System.EventHandler(this.lblAddNewStatus_Click);
            // 
            // ctrlFixedStatus
            // 
            this.ctrlFixedStatus.Location = new System.Drawing.Point(3, 28);
            this.ctrlFixedStatus.Name = "ctrlFixedStatus";
            this.ctrlFixedStatus.Size = new System.Drawing.Size(535, 54);
            this.ctrlFixedStatus.StatusID = 0;
            this.ctrlFixedStatus.StatusTitle = "label1";
            this.ctrlFixedStatus.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblChooseIconFolder);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 87);
            this.panel2.TabIndex = 3;
            // 
            // lblChooseIconFolder
            // 
            this.lblChooseIconFolder.BackColor = System.Drawing.Color.Turquoise;
            this.lblChooseIconFolder.Image = ((System.Drawing.Image)(resources.GetObject("lblChooseIconFolder.Image")));
            this.lblChooseIconFolder.Location = new System.Drawing.Point(458, 21);
            this.lblChooseIconFolder.Name = "lblChooseIconFolder";
            this.lblChooseIconFolder.Size = new System.Drawing.Size(56, 37);
            this.lblChooseIconFolder.TabIndex = 2;
            this.lblChooseIconFolder.Click += new System.EventHandler(this.lblChooseIconFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "     Edit Statuses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrlEditStatuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlEditStatuses";
            this.Size = new System.Drawing.Size(550, 239);
            this.BackColorChanged += new System.EventHandler(this.ctrlEditStatuses_BackColorChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpStatusesList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RoundedLabel rlClose;
        private ctrlStatusElement ctrlFixedStatus;
        private System.Windows.Forms.Label lblAddNewStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChooseIconFolder;
    }
}
