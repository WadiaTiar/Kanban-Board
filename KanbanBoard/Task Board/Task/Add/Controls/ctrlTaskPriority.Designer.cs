namespace KanbanBoard.Task_Board.Task.AddTask.Controls
{
    partial class ctrlTaskPriority
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
            this.lblOptional = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOptional
            // 
            this.lblOptional.BackColor = System.Drawing.Color.Gainsboro;
            this.lblOptional.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional.ForeColor = System.Drawing.Color.Black;
            this.lblOptional.Location = new System.Drawing.Point(3, 0);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(189, 45);
            this.lblOptional.TabIndex = 0;
            this.lblOptional.Tag = "0";
            this.lblOptional.Text = "Optional";
            this.lblOptional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOptional.Click += new System.EventHandler(this.lblPriority_Click);
            this.lblOptional.MouseEnter += new System.EventHandler(this.PriorityMenuItems_MouseEnter);
            this.lblOptional.MouseLeave += new System.EventHandler(this.PriorityMenuItems_MouseLeave);
            // 
            // lblHigh
            // 
            this.lblHigh.BackColor = System.Drawing.Color.GhostWhite;
            this.lblHigh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Black;
            this.lblHigh.Location = new System.Drawing.Point(3, 45);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(189, 45);
            this.lblHigh.TabIndex = 1;
            this.lblHigh.Tag = "1";
            this.lblHigh.Text = "High";
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHigh.Click += new System.EventHandler(this.lblPriority_Click);
            this.lblHigh.MouseEnter += new System.EventHandler(this.PriorityMenuItems_MouseEnter);
            this.lblHigh.MouseLeave += new System.EventHandler(this.PriorityMenuItems_MouseLeave);
            // 
            // lblMedium
            // 
            this.lblMedium.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMedium.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.ForeColor = System.Drawing.Color.Black;
            this.lblMedium.Location = new System.Drawing.Point(3, 90);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(189, 45);
            this.lblMedium.TabIndex = 2;
            this.lblMedium.Tag = "2";
            this.lblMedium.Text = "Medium";
            this.lblMedium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMedium.Click += new System.EventHandler(this.lblPriority_Click);
            this.lblMedium.MouseEnter += new System.EventHandler(this.PriorityMenuItems_MouseEnter);
            this.lblMedium.MouseLeave += new System.EventHandler(this.PriorityMenuItems_MouseLeave);
            // 
            // lblLow
            // 
            this.lblLow.BackColor = System.Drawing.Color.GhostWhite;
            this.lblLow.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.Black;
            this.lblLow.Location = new System.Drawing.Point(3, 135);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(189, 45);
            this.lblLow.TabIndex = 3;
            this.lblLow.Tag = "3";
            this.lblLow.Text = "Low";
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLow.Click += new System.EventHandler(this.lblPriority_Click);
            this.lblLow.MouseEnter += new System.EventHandler(this.PriorityMenuItems_MouseEnter);
            this.lblLow.MouseLeave += new System.EventHandler(this.PriorityMenuItems_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblOptional);
            this.flowLayoutPanel1.Controls.Add(this.lblHigh);
            this.flowLayoutPanel1.Controls.Add(this.lblMedium);
            this.flowLayoutPanel1.Controls.Add(this.lblLow);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 192);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(37, 180);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 45);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 45);
            this.label3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 45);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 45);
            this.label1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 195);
            this.panel1.TabIndex = 7;
            // 
            // ctrlTaskPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlTaskPriority";
            this.Size = new System.Drawing.Size(239, 199);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
