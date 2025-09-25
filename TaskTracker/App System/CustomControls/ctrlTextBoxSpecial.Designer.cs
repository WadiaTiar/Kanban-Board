namespace TaskTracker.App_System.CustomControls
{
    partial class ctrlTextBoxSpecial
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox.Location = new System.Drawing.Point(0, 0);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(481, 40);
            this.txtBox.TabIndex = 0;
            this.txtBox.Click += new System.EventHandler(this.txtSpecialValue_Click);
            this.txtBox.TextChanged += new System.EventHandler(this.txtSpecialValue_TextChanged);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpecialValue_KeyDown);
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpecialValue_KeyPress);
            // 
            // ctrlTextBoxSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBox);
            this.Name = "ctrlTextBoxSpecial";
            this.Size = new System.Drawing.Size(481, 40);
            this.Load += new System.EventHandler(this.ctrlTextBoxSpecial_Load);
            this.BackColorChanged += new System.EventHandler(this.ctrlTextBoxSpecial_BackColorChanged);
            this.FontChanged += new System.EventHandler(this.ctrlTextBoxSpecial_FontChanged);
            this.ForeColorChanged += new System.EventHandler(this.ctrlTextBoxSpecial_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
    }
}
