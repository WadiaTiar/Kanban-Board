namespace KanbanBoard.Task_Board.Task.Card
{
    partial class ctrlNotification
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plNotifyColor = new System.Windows.Forms.Panel();
            this.lblNotificationText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.339192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.6608F));
            this.tableLayoutPanel1.Controls.Add(this.plNotifyColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNotificationText, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // plNotifyColor
            // 
            this.plNotifyColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plNotifyColor.Location = new System.Drawing.Point(3, 3);
            this.plNotifyColor.Name = "plNotifyColor";
            this.plNotifyColor.Size = new System.Drawing.Size(13, 48);
            this.plNotifyColor.TabIndex = 0;
            // 
            // lblNotificationText
            // 
            this.lblNotificationText.AutoSize = true;
            this.lblNotificationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.lblNotificationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationText.Location = new System.Drawing.Point(22, 0);
            this.lblNotificationText.Name = "lblNotificationText";
            this.lblNotificationText.Size = new System.Drawing.Size(544, 54);
            this.lblNotificationText.TabIndex = 1;
            this.lblNotificationText.Text = "Notification text";
            this.lblNotificationText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlNotification";
            this.Size = new System.Drawing.Size(569, 54);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel plNotifyColor;
        private System.Windows.Forms.Label lblNotificationText;
        private System.Windows.Forms.Timer timer1;
    }
}
