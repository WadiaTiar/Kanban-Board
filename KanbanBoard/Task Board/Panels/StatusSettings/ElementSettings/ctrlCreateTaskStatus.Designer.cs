namespace KanbanBoard.Task_Board.Panels.StatusSettings.ElementSettings
{
    partial class ctrlCreateTaskStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCreateTaskStatus));
            this.lblGuide = new System.Windows.Forms.Label();
            this.btnCreateTaskStatus = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new KanbanBoard.CustomControls.RoundedPanel();
            this.pbStatusIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.BackColor = System.Drawing.SystemColors.Window;
            this.lblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.ForeColor = System.Drawing.Color.Red;
            this.lblGuide.Location = new System.Drawing.Point(57, 154);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(155, 24);
            this.lblGuide.TabIndex = 11;
            this.lblGuide.Text = "Task status name";
            // 
            // btnCreateTaskStatus
            // 
            this.btnCreateTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTaskStatus.Location = new System.Drawing.Point(322, 222);
            this.btnCreateTaskStatus.Name = "btnCreateTaskStatus";
            this.btnCreateTaskStatus.Size = new System.Drawing.Size(185, 41);
            this.btnCreateTaskStatus.TabIndex = 10;
            this.btnCreateTaskStatus.Text = "Create Task Status";
            this.btnCreateTaskStatus.UseVisualStyleBackColor = true;
            this.btnCreateTaskStatus.Click += new System.EventHandler(this.btnCreateTaskStatus_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(196, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(49, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 28);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create Task Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Gray;
            this.roundedPanel1.Controls.Add(this.pbStatusIcon);
            this.roundedPanel1.CornerRadius = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(49, 89);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(438, 44);
            this.roundedPanel1.TabIndex = 12;
            this.roundedPanel1.Click += new System.EventHandler(this.chooseIcon_Click);
            // 
            // pbStatusIcon
            // 
            this.pbStatusIcon.Location = new System.Drawing.Point(203, 3);
            this.pbStatusIcon.Name = "pbStatusIcon";
            this.pbStatusIcon.Size = new System.Drawing.Size(45, 37);
            this.pbStatusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStatusIcon.TabIndex = 0;
            this.pbStatusIcon.TabStop = false;
            this.pbStatusIcon.Click += new System.EventHandler(this.chooseIcon_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 10);
            this.label2.TabIndex = 13;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image_25dp.png");
            // 
            // ctrlCreateTaskStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.btnCreateTaskStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ctrlCreateTaskStatus";
            this.Size = new System.Drawing.Size(538, 271);
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Button btnCreateTaskStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pbStatusIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
    }
}
