namespace KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings
{
    partial class ctrlElementMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlElementMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRenameStatus = new System.Windows.Forms.Label();
            this.lblDeleteStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Turquoise;
            this.flowLayoutPanel1.Controls.Add(this.lblRenameStatus);
            this.flowLayoutPanel1.Controls.Add(this.lblDeleteStatus);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 96);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lblRenameStatus
            // 
            this.lblRenameStatus.BackColor = System.Drawing.Color.Turquoise;
            this.lblRenameStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenameStatus.ForeColor = System.Drawing.Color.Black;
            this.lblRenameStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblRenameStatus.Image")));
            this.lblRenameStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRenameStatus.Location = new System.Drawing.Point(3, 0);
            this.lblRenameStatus.Name = "lblRenameStatus";
            this.lblRenameStatus.Size = new System.Drawing.Size(214, 45);
            this.lblRenameStatus.TabIndex = 0;
            this.lblRenameStatus.Text = "Rename status";
            this.lblRenameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRenameStatus.Click += new System.EventHandler(this.lblRenameStatus_Click);
            this.lblRenameStatus.MouseEnter += new System.EventHandler(this.lblMenuItem_MouseEnter);
            this.lblRenameStatus.MouseLeave += new System.EventHandler(this.lblMenuItem_MouseLeave);
            // 
            // lblDeleteStatus
            // 
            this.lblDeleteStatus.BackColor = System.Drawing.Color.Turquoise;
            this.lblDeleteStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteStatus.ForeColor = System.Drawing.Color.Black;
            this.lblDeleteStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblDeleteStatus.Image")));
            this.lblDeleteStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDeleteStatus.Location = new System.Drawing.Point(3, 45);
            this.lblDeleteStatus.Name = "lblDeleteStatus";
            this.lblDeleteStatus.Size = new System.Drawing.Size(214, 45);
            this.lblDeleteStatus.TabIndex = 3;
            this.lblDeleteStatus.Text = "Delete status";
            this.lblDeleteStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeleteStatus.Click += new System.EventHandler(this.lblDeleteStatus_Click);
            this.lblDeleteStatus.MouseEnter += new System.EventHandler(this.lblMenuItem_MouseEnter);
            this.lblDeleteStatus.MouseLeave += new System.EventHandler(this.lblMenuItem_MouseLeave);
            // 
            // ctrlElementMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ctrlElementMenu";
            this.Size = new System.Drawing.Size(226, 104);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblRenameStatus;
        private System.Windows.Forms.Label lblDeleteStatus;
    }
}
