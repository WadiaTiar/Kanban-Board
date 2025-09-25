using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker.App_System.CustomControls
{
    public partial class ctrlTextBoxSpecial : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<KeyPressEventArgs> OnTextBoxSpecial_KeyPress;
        // Create a protected method to raise the event with a parameter
        protected virtual void TextBoxSpecial_KeyPress(KeyPressEventArgs e)
        {
            Action<KeyPressEventArgs> handler = OnTextBoxSpecial_KeyPress;
            if (handler != null)
            {
                handler(e); // Raise the event with the parameter
            }
        }


        public event Action<EventArgs> OnTextBoxSpecial_TextChanged;
        // Create a protected method to raise the event with a parameter
        protected virtual void TextBoxSpecial_TextChanged(EventArgs e)
        {
            Action<EventArgs> handler = OnTextBoxSpecial_TextChanged;
            if (handler != null)
            {
                handler(e); // Raise the event with the parameter
            }
        }

        private bool IsbtnClickedCancel = false;
        private string PreviousText = "";
        public string txtSpecialValue = "";
        public string TextDefault = "";


        public ctrlTextBoxSpecial()
        {
            InitializeComponent();
            txtBox.SelectionStart = 0;
        }

        private void txtSpecialValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text) && IsbtnClickedCancel)
            {
                TextDefaultMethod();
                IsbtnClickedCancel = false;
            }

            if (this.ForeColor != Color.Gray)
                txtSpecialValue = txtBox.Text;
            else
                txtSpecialValue = "";
            
                

            if (OnTextBoxSpecial_TextChanged != null)
                OnTextBoxSpecial_TextChanged(e);
        }

        private void txtSpecialValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnTextBoxSpecial_KeyPress != null)
            {
                OnTextBoxSpecial_KeyPress(e);

                if (e.Handled)
                    return;
            }

            /*if (txtBox.SelectionStart == 0 && (txtBox.SelectionLength == txtBox.Text.Length || txtBox.ForeColor == Color.Gray))
            {
                if (txtBox.Text != "" && this.ForeColor !=  Color.Gray)
                    PreviousText = txtBox.Text;



                this.ForeColor = Color.Black;
                txtBox.Text = "";

            }*/


            if (txtBox.SelectionStart == 0 && (txtBox.SelectionLength == txtBox.Text.Length || txtBox.ForeColor == Color.Gray))
            {
                if (txtBox.Text != "" && this.ForeColor != Color.Gray)
                    PreviousText = txtBox.Text;



                this.ForeColor = Color.Black;
                txtBox.Text = "";

            }


            if (txtBox.ForeColor == Color.Gray)
                txtBox.SelectionStart = 0;
        }

        private void txtSpecialValue_Click(object sender, EventArgs e)
        {
            if (txtBox.ForeColor == Color.Gray)
            {
                txtBox.SelectionStart = 0;
                txtBox.SelectionLength = 0;
            }
        }

        private void txtSpecialValue_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.Control && e.KeyCode == Keys.Z)// && txtBox.SelectionStart != 0)
            {
                this.ForeColor = Color.Black;
                txtBox.Text = PreviousText;
                txtBox.SelectionStart = txtBox.Text.Length;
            }

            if ((e.KeyCode == Keys.Back || txtBox.SelectionStart != 0) && txtBox.ForeColor == Color.Gray)
                e.SuppressKeyPress = true;



            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;

            else if (e.KeyCode == Keys.Back)
                IsbtnClickedCancel = true;
            else
                IsbtnClickedCancel = false;
        }

        void TextDefaultMethod()
        {
            this.ForeColor = Color.Gray;
            txtBox.Text = TextDefault;
        }

        void TextSpecialValueMethod()
        {
            this.ForeColor = Color.Black;
            txtBox.Text = txtSpecialValue;
        }

        private void ctrlTextBoxSpecial_ForeColorChanged(object sender, EventArgs e)
        {
            txtBox.ForeColor = this.ForeColor;
        }

        private void ctrlTextBoxSpecial_FontChanged(object sender, EventArgs e)
        {
            txtBox.Font = this.Font;
        }

        public void TextBoxSpecialValue_Method(string value)
        {
            txtBox.Text = value;
        }

        private void ctrlTextBoxSpecial_Load(object sender, EventArgs e)
        {
            if (txtSpecialValue != "")
                TextSpecialValueMethod();
            else
                TextDefaultMethod();
        }

        private void ctrlTextBoxSpecial_BackColorChanged(object sender, EventArgs e)
        {
            txtBox.BackColor = this.BackColor;
        }
    }
}
