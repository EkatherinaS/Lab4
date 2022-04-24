using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class NumberDecHexBox : TextBox
    {
        private int setting = 10;
        private ToolTip messageError = new ToolTip();
        private int number = 0;
        private string buf;

        public delegate void NumberChanged();
        public NumberChanged numberChanged;


        public NumberDecHexBox()
        {
            InitializeComponent();
            messageError.Active = false;
        }

        public NumberDecHexBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            messageError.Active = false;
        }

        public int Number
        {
            get
            {
                return number;
            }
        }

        public void SettingDec()
        { 
            setting = 10;
            Text = number.ToString();
        }

        public void SettingHex()
        {
            setting = 16;
            Text = number.ToString("X");
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !((setting == 16) &&
                (('A' <= e.KeyChar && 'F' >= e.KeyChar) || ('a' <= e.KeyChar && 'f' >= e.KeyChar))))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(Text, setting);
                ForeColor = DefaultForeColor;
                messageError.Active = false;

                if (number > 255)
                {
                    number = 255;
                    if (setting == 10) Text = "255";
                    else Text = "FF";
                }
                if (number < 0)
                {
                    number = 0;
                    Text = "0";
                }
                if (numberChanged != null)
                {
                    numberChanged();
                }
                
            }
            catch (Exception)
            {
                ForeColor = Color.Red;
                messageError.Active = true;
            }
            base.OnTextChanged(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            messageError.Show("Wrong format, possible numbers are:\n0-255 for dec\n0-FF for hex", this);
            base.OnMouseHover(e);
        }

        protected override void OnClick(EventArgs e)
        {
            buf = Text;
            Text = "";
            base.OnClick(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (Text == "") Text = buf;
            base.OnLostFocus(e);
        }
    }
}
