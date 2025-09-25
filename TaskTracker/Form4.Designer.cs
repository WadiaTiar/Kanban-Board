namespace TaskTracker
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFillTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFilterTable = new System.Windows.Forms.Button();
            this.ctrlEditTaskPanelSide1 = new TaskTracker.Team_Workspace.Task_Board.ctrlEditTaskPanelSide();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillTable
            // 
            this.btnFillTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillTable.Location = new System.Drawing.Point(144, 90);
            this.btnFillTable.Name = "btnFillTable";
            this.btnFillTable.Size = new System.Drawing.Size(154, 56);
            this.btnFillTable.TabIndex = 1;
            this.btnFillTable.Text = "Fill Table";
            this.btnFillTable.UseVisualStyleBackColor = true;
            this.btnFillTable.Click += new System.EventHandler(this.btnFillTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(260, 403);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnFilterTable
            // 
            this.btnFilterTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterTable.Location = new System.Drawing.Point(317, 90);
            this.btnFilterTable.Name = "btnFilterTable";
            this.btnFilterTable.Size = new System.Drawing.Size(154, 56);
            this.btnFilterTable.TabIndex = 3;
            this.btnFilterTable.Text = "Filter Table";
            this.btnFilterTable.UseVisualStyleBackColor = true;
            this.btnFilterTable.Click += new System.EventHandler(this.btnFilterTable_Click);
            // 
            // ctrlEditTaskPanelSide1
            // 
            this.ctrlEditTaskPanelSide1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlEditTaskPanelSide1.Location = new System.Drawing.Point(572, 28);
            this.ctrlEditTaskPanelSide1.Name = "ctrlEditTaskPanelSide1";
            this.ctrlEditTaskPanelSide1.Size = new System.Drawing.Size(760, 749);
            this.ctrlEditTaskPanelSide1.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 817);
            this.Controls.Add(this.ctrlEditTaskPanelSide1);
            this.Controls.Add(this.btnFilterTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFillTable);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFillTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFilterTable;
        private Team_Workspace.Task_Board.ctrlEditTaskPanelSide ctrlEditTaskPanelSide1;
    }
}