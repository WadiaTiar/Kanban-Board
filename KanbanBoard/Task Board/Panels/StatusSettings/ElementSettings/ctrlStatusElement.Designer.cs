namespace KanbanBoard.Task_Board.Panels.StatusSettings
{
    partial class ctrlStatusElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlStatusElement));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbStatusIcon = new System.Windows.Forms.PictureBox();
            this.lblDrag = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMoreEdit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDrag, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbStatusIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(45, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 42);
            this.panel1.TabIndex = 1;
            // 
            // pbStatusIcon
            // 
            this.pbStatusIcon.Location = new System.Drawing.Point(3, 6);
            this.pbStatusIcon.Name = "pbStatusIcon";
            this.pbStatusIcon.Size = new System.Drawing.Size(34, 29);
            this.pbStatusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusIcon.TabIndex = 0;
            this.pbStatusIcon.TabStop = false;
            this.pbStatusIcon.Click += new System.EventHandler(this.pbStatusIcon_Click);
            // 
            // lblDrag
            // 
            this.lblDrag.AutoSize = true;
            this.lblDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDrag.Image = ((System.Drawing.Image)(resources.GetObject("lblDrag.Image")));
            this.lblDrag.Location = new System.Drawing.Point(3, 0);
            this.lblDrag.Name = "lblDrag";
            this.lblDrag.Size = new System.Drawing.Size(36, 48);
            this.lblDrag.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMoreEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(487, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 42);
            this.panel2.TabIndex = 5;
            // 
            // lblMoreEdit
            // 
            this.lblMoreEdit.Image = ((System.Drawing.Image)(resources.GetObject("lblMoreEdit.Image")));
            this.lblMoreEdit.Location = new System.Drawing.Point(8, 8);
            this.lblMoreEdit.Name = "lblMoreEdit";
            this.lblMoreEdit.Size = new System.Drawing.Size(28, 25);
            this.lblMoreEdit.TabIndex = 0;
            this.lblMoreEdit.Click += new System.EventHandler(this.lblMoreEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblStatusTitle);
            this.panel3.Location = new System.Drawing.Point(92, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 42);
            this.panel3.TabIndex = 6;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.Location = new System.Drawing.Point(3, 6);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(383, 30);
            this.lblStatusTitle.TabIndex = 6;
            this.lblStatusTitle.Text = "label1";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrlStatusElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlStatusElement";
            this.Size = new System.Drawing.Size(535, 48);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbStatusIcon;
        private System.Windows.Forms.Label lblDrag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMoreEdit;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Panel panel3;
    }
}
