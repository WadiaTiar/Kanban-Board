namespace KanbanBoard.Task
{
    partial class ctrlTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlTask));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTagPriority = new KanbanBoard.CustomControls.RoundedLabel();
            this.plEllepseContinaire = new System.Windows.Forms.Panel();
            this.lblEllipsesMore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.plEllepseContinaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Controls.Add(this.lblTagPriority, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.plEllepseContinaire, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTitle, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 214);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblTagPriority
            // 
            this.lblTagPriority.AutoSize = true;
            this.lblTagPriority.BackColor = System.Drawing.Color.LightGray;
            this.lblTagPriority.CornerRadius = 10;
            this.lblTagPriority.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTagPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagPriority.ForeColor = System.Drawing.Color.Black;
            this.lblTagPriority.Location = new System.Drawing.Point(38, 154);
            this.lblTagPriority.Name = "lblTagPriority";
            this.lblTagPriority.Size = new System.Drawing.Size(95, 40);
            this.lblTagPriority.TabIndex = 7;
            this.lblTagPriority.Text = "Tag Priority";
            this.lblTagPriority.TextAlignCustom = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plEllepseContinaire
            // 
            this.plEllepseContinaire.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.plEllepseContinaire.Controls.Add(this.lblEllipsesMore);
            this.plEllepseContinaire.Location = new System.Drawing.Point(352, 36);
            this.plEllepseContinaire.Name = "plEllepseContinaire";
            this.plEllepseContinaire.Size = new System.Drawing.Size(51, 100);
            this.plEllepseContinaire.TabIndex = 11;
            // 
            // lblEllipsesMore
            // 
            this.lblEllipsesMore.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblEllipsesMore.Image = ((System.Drawing.Image)(resources.GetObject("lblEllipsesMore.Image")));
            this.lblEllipsesMore.Location = new System.Drawing.Point(14, 23);
            this.lblEllipsesMore.Name = "lblEllipsesMore";
            this.lblEllipsesMore.Size = new System.Drawing.Size(25, 25);
            this.lblEllipsesMore.TabIndex = 11;
            this.lblEllipsesMore.Click += new System.EventHandler(this.lblEllipsesMore_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(38, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "label1";
            // 
            // ctrlTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ctrlTask";
            this.Size = new System.Drawing.Size(408, 214);
            this.BackColorChanged += new System.EventHandler(this.ctrlTask_BackColorChanged);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.plEllepseContinaire.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.RoundedLabel lblTagPriority;
        private System.Windows.Forms.Panel plEllepseContinaire;
        private System.Windows.Forms.Label lblEllipsesMore;
        private System.Windows.Forms.Label lblTitle;
    }
}
