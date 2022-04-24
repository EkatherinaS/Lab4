namespace Lab_4
{
    partial class ColorSelect
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
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.rbtnDec = new System.Windows.Forms.RadioButton();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.numDHBlue = new Lab_4.NumberDecHexBox(this.components);
            this.numDHGreen = new Lab_4.NumberDecHexBox(this.components);
            this.numDHRed = new Lab_4.NumberDecHexBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(4, 64);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(34, 16);
            this.lblBlue.TabIndex = 3;
            this.lblBlue.Text = "Blue";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(4, 6);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(33, 16);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(4, 35);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(44, 16);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "Green";
            // 
            // rbtnDec
            // 
            this.rbtnDec.AutoSize = true;
            this.rbtnDec.Checked = true;
            this.rbtnDec.Location = new System.Drawing.Point(7, 89);
            this.rbtnDec.Name = "rbtnDec";
            this.rbtnDec.Size = new System.Drawing.Size(53, 20);
            this.rbtnDec.TabIndex = 6;
            this.rbtnDec.TabStop = true;
            this.rbtnDec.Text = "Dec";
            this.rbtnDec.UseVisualStyleBackColor = true;
            this.rbtnDec.Click += new System.EventHandler(this.rbtnDec_Click);
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(78, 89);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(52, 20);
            this.rbtnHex.TabIndex = 7;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.Click += new System.EventHandler(this.rbtnHex_Click);
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(136, 3);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(105, 105);
            this.pbColor.TabIndex = 8;
            this.pbColor.TabStop = false;
            // 
            // numDHBlue
            // 
            this.numDHBlue.ForeColor = System.Drawing.Color.Black;
            this.numDHBlue.Location = new System.Drawing.Point(69, 61);
            this.numDHBlue.Name = "numDHBlue";
            this.numDHBlue.Size = new System.Drawing.Size(61, 22);
            this.numDHBlue.TabIndex = 11;
            this.numDHBlue.Text = "0";
            // 
            // numDHGreen
            // 
            this.numDHGreen.ForeColor = System.Drawing.Color.Black;
            this.numDHGreen.Location = new System.Drawing.Point(69, 32);
            this.numDHGreen.Name = "numDHGreen";
            this.numDHGreen.Size = new System.Drawing.Size(61, 22);
            this.numDHGreen.TabIndex = 10;
            this.numDHGreen.Text = "0";
            // 
            // numDHRed
            // 
            this.numDHRed.ForeColor = System.Drawing.Color.Black;
            this.numDHRed.Location = new System.Drawing.Point(69, 3);
            this.numDHRed.Name = "numDHRed";
            this.numDHRed.Size = new System.Drawing.Size(61, 22);
            this.numDHRed.TabIndex = 9;
            this.numDHRed.Text = "0";
            // 
            // ColorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numDHBlue);
            this.Controls.Add(this.numDHGreen);
            this.Controls.Add(this.numDHRed);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.rbtnHex);
            this.Controls.Add(this.rbtnDec);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblBlue);
            this.Name = "ColorSelect";
            this.Size = new System.Drawing.Size(247, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.RadioButton rbtnDec;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.PictureBox pbColor;
        private NumberDecHexBox numDHRed;
        private NumberDecHexBox numDHGreen;
        private NumberDecHexBox numDHBlue;
    }
}
