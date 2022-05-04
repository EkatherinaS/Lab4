using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class ColorSelect : UserControl
    {
        public event EventHandler ColorChanged;
        public Color currentColor;

        protected virtual void OnColorChanged(EventArgs e)
        {
            EventHandler handler = this.ColorChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        private void HandleColorChanged()
        {
            currentColor = Color.FromArgb(numDHRed.Number, numDHGreen.Number, numDHBlue.Number);
            pbColor.BackColor = currentColor;
            this.OnColorChanged(EventArgs.Empty);
        }

        public ColorSelect()
        {
            
            InitializeComponent();
            foreach (NumberDecHexBox DH in this.Controls.OfType<NumberDecHexBox>())
            {
                DH.numberChanged = this.HandleColorChanged;
                DH.SettingDec();
                DH.Text = "0";
            }
            this.HandleColorChanged();
        }

        private void rbtnDec_Click(object sender, System.EventArgs e)
        {
            foreach (NumberDecHexBox DH in this.Controls.OfType<NumberDecHexBox>())
            {
                DH.SettingDec();
            }
            rbtnHex.Checked = false;
        }

        private void rbtnHex_Click(object sender, System.EventArgs e)
        {
            foreach (NumberDecHexBox DH in this.Controls.OfType<NumberDecHexBox>())
            {
                DH.SettingHex();
            }
            rbtnDec.Checked = false;
        }
    }
}
