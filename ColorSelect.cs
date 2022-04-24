using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class ColorSelect : UserControl
    {
        public ColorSelect()
        {
            InitializeComponent();
            foreach (NumberDecHexBox DH in this.Controls.OfType<NumberDecHexBox>())
            {
                DH.numberChanged = ColorChanged;
                DH.SettingDec();
                DH.Text = "0";
            }
            ColorChanged();
        }

        private void ColorChanged()
        {
            pbColor.BackColor = Color.FromArgb(numDHRed.Number, numDHGreen.Number, numDHBlue.Number);
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
