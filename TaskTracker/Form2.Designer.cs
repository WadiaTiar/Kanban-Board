using System.Threading.Tasks;
using TaskTracker_BusinessLayer;

namespace TaskTracker
{
    partial class Form2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlEditTaskPanelSide1 = new TaskTracker.Team_Workspace.Task_Board.ctrlEditTaskPanelSide();
            this.ctrlTask1 = new TaskTracker.Task.ctrlTask();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 65);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(195, 65);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 358);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(195, 65);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 30;
            this.vScrollBar1.Location = new System.Drawing.Point(93, 195);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 199);
            this.vScrollBar1.SmallChange = 10;
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(24, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 199);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.button18);
            this.flowLayoutPanel3.Controls.Add(this.button17);
            this.flowLayoutPanel3.Controls.Add(this.button19);
            this.flowLayoutPanel3.Controls.Add(this.button20);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(450, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(201, 284);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(3, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(195, 65);
            this.button18.TabIndex = 2;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 74);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(195, 65);
            this.button17.TabIndex = 1;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(3, 145);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(195, 65);
            this.button19.TabIndex = 3;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(3, 216);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(195, 65);
            this.button20.TabIndex = 4;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.button9);
            this.flowLayoutPanel2.Controls.Add(this.button10);
            this.flowLayoutPanel2.Controls.Add(this.button11);
            this.flowLayoutPanel2.Controls.Add(this.button12);
            this.flowLayoutPanel2.Controls.Add(this.button13);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(223, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(201, 355);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(195, 65);
            this.button9.TabIndex = 1;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 74);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(195, 65);
            this.button10.TabIndex = 2;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 145);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(195, 65);
            this.button11.TabIndex = 3;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(3, 216);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(195, 65);
            this.button12.TabIndex = 4;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 287);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(195, 65);
            this.button13.TabIndex = 5;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 80);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(24, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 130);
            this.panel2.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(912, 853);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(381, 30);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // ctrlEditTaskPanelSide1
            // 
            this.ctrlEditTaskPanelSide1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlEditTaskPanelSide1.Location = new System.Drawing.Point(153, 41);
            this.ctrlEditTaskPanelSide1.Name = "ctrlEditTaskPanelSide1";
            this.ctrlEditTaskPanelSide1.Size = new System.Drawing.Size(144, 749);
            this.ctrlEditTaskPanelSide1.TabIndex = 8;
            // 
            // ctrlTask1
            // 
            this.ctrlTask1.AutoSize = true;
            this.ctrlTask1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTask1.Location = new System.Drawing.Point(637, 162);
            this.ctrlTask1.Name = "ctrlTask1";
            this.ctrlTask1.Size = new System.Drawing.Size(379, 214);
            this.ctrlTask1.TabIndex = 10;
            this.ctrlTask1.Title = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1459, 921);
            this.Controls.Add(this.ctrlTask1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.ctrlEditTaskPanelSide1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private Team_Workspace.Task_Board.ctrlEditTaskPanelSide ctrlEditTaskPanelSide1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Task.ctrlTask ctrlTask1;
    }
}