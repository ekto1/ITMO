using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalculatorUI.
	/// </summary>
	public class CalculatorUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox Version;
		private System.Windows.Forms.Button ButExit;
		private System.Windows.Forms.Button ButDate;
		private System.Windows.Forms.TextBox OutputBox;
		private System.Windows.Forms.Button ButClear;
		private System.Windows.Forms.Button ButMinus;
		private System.Windows.Forms.Button ButSum;
		private System.Windows.Forms.Button ButEqual;
		private System.Windows.Forms.Button ButMultiply;
		private System.Windows.Forms.Button ButDivide;
		private System.Windows.Forms.Button ButPoint;
		private System.Windows.Forms.Button ButSign;
		private System.Windows.Forms.Button ButZero;
		private System.Windows.Forms.Button ButNine;
		private System.Windows.Forms.Button ButEight;
		private System.Windows.Forms.Button ButSeven;
		private System.Windows.Forms.Button ButSix;
		private System.Windows.Forms.Button ButFive;
		private System.Windows.Forms.Button ButFour;
		private System.Windows.Forms.Button ButThree;
		private System.Windows.Forms.Button ButTwo;
		private System.Windows.Forms.Button ButOne;

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CalculatorUI()
		{
			// Required for Windows Form Designer support

			InitializeComponent();

			// Get version information from the Calculator Module.

			Version.Text = CalcEngine.GetVersion();
			OutputBox.Text = "0";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.ButDate = new System.Windows.Forms.Button();
            this.ButOne = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.TextBox();
            this.ButSix = new System.Windows.Forms.Button();
            this.ButFive = new System.Windows.Forms.Button();
            this.ButEqual = new System.Windows.Forms.Button();
            this.ButTwo = new System.Windows.Forms.Button();
            this.ButZero = new System.Windows.Forms.Button();
            this.ButThree = new System.Windows.Forms.Button();
            this.ButSum = new System.Windows.Forms.Button();
            this.ButExit = new System.Windows.Forms.Button();
            this.ButSign = new System.Windows.Forms.Button();
            this.ButSeven = new System.Windows.Forms.Button();
            this.ButPoint = new System.Windows.Forms.Button();
            this.ButNine = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ButMinus = new System.Windows.Forms.Button();
            this.ButEight = new System.Windows.Forms.Button();
            this.ButMultiply = new System.Windows.Forms.Button();
            this.ButFour = new System.Windows.Forms.Button();
            this.ButClear = new System.Windows.Forms.Button();
            this.ButDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButDate
            // 
            this.ButDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButDate.Location = new System.Drawing.Point(432, 222);
            this.ButDate.Name = "ButDate";
            this.ButDate.Size = new System.Drawing.Size(112, 70);
            this.ButDate.TabIndex = 19;
            this.ButDate.TabStop = false;
            this.ButDate.Text = "Date";
            this.ButDate.Click += new System.EventHandler(this.ButDate_Click);
            // 
            // ButOne
            // 
            this.ButOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButOne.ForeColor = System.Drawing.Color.Blue;
            this.ButOne.Location = new System.Drawing.Point(16, 310);
            this.ButOne.Name = "ButOne";
            this.ButOne.Size = new System.Drawing.Size(80, 70);
            this.ButOne.TabIndex = 2;
            this.ButOne.TabStop = false;
            this.ButOne.Text = "1";
            this.ButOne.Click += new System.EventHandler(this.ButOne_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Version.Cursor = System.Windows.Forms.Cursors.No;
            this.Version.Font = new System.Drawing.Font("Verdana", 8F);
            this.Version.Location = new System.Drawing.Point(16, 15);
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Size = new System.Drawing.Size(528, 42);
            this.Version.TabIndex = 0;
            this.Version.TabStop = false;
            this.Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButSix
            // 
            this.ButSix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButSix.ForeColor = System.Drawing.Color.Blue;
            this.ButSix.Location = new System.Drawing.Point(208, 222);
            this.ButSix.Name = "ButSix";
            this.ButSix.Size = new System.Drawing.Size(80, 70);
            this.ButSix.TabIndex = 7;
            this.ButSix.TabStop = false;
            this.ButSix.Text = "6";
            this.ButSix.Click += new System.EventHandler(this.ButSix_Click);
            // 
            // ButFive
            // 
            this.ButFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButFive.ForeColor = System.Drawing.Color.Blue;
            this.ButFive.Location = new System.Drawing.Point(112, 222);
            this.ButFive.Name = "ButFive";
            this.ButFive.Size = new System.Drawing.Size(80, 70);
            this.ButFive.TabIndex = 6;
            this.ButFive.TabStop = false;
            this.ButFive.Text = "5";
            this.ButFive.Click += new System.EventHandler(this.ButFive_Click);
            // 
            // ButEqual
            // 
            this.ButEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButEqual.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButEqual.Location = new System.Drawing.Point(432, 399);
            this.ButEqual.Name = "ButEqual";
            this.ButEqual.Size = new System.Drawing.Size(112, 70);
            this.ButEqual.TabIndex = 18;
            this.ButEqual.TabStop = false;
            this.ButEqual.Text = "=";
            this.ButEqual.Click += new System.EventHandler(this.ButEqual_Click);
            // 
            // ButTwo
            // 
            this.ButTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButTwo.ForeColor = System.Drawing.Color.Blue;
            this.ButTwo.Location = new System.Drawing.Point(112, 310);
            this.ButTwo.Name = "ButTwo";
            this.ButTwo.Size = new System.Drawing.Size(80, 70);
            this.ButTwo.TabIndex = 3;
            this.ButTwo.TabStop = false;
            this.ButTwo.Text = "2";
            this.ButTwo.Click += new System.EventHandler(this.ButTwo_Click);
            // 
            // ButZero
            // 
            this.ButZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButZero.ForeColor = System.Drawing.Color.Blue;
            this.ButZero.Location = new System.Drawing.Point(16, 399);
            this.ButZero.Name = "ButZero";
            this.ButZero.Size = new System.Drawing.Size(80, 70);
            this.ButZero.TabIndex = 11;
            this.ButZero.TabStop = false;
            this.ButZero.Text = "0";
            this.ButZero.Click += new System.EventHandler(this.ButZero_Click);
            // 
            // ButThree
            // 
            this.ButThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButThree.ForeColor = System.Drawing.Color.Blue;
            this.ButThree.Location = new System.Drawing.Point(208, 310);
            this.ButThree.Name = "ButThree";
            this.ButThree.Size = new System.Drawing.Size(80, 70);
            this.ButThree.TabIndex = 4;
            this.ButThree.TabStop = false;
            this.ButThree.Text = "3";
            this.ButThree.Click += new System.EventHandler(this.ButThree_Click);
            // 
            // ButSum
            // 
            this.ButSum.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButSum.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButSum.Location = new System.Drawing.Point(304, 399);
            this.ButSum.Name = "ButSum";
            this.ButSum.Size = new System.Drawing.Size(112, 70);
            this.ButSum.TabIndex = 12;
            this.ButSum.TabStop = false;
            this.ButSum.Text = "+";
            this.ButSum.Click += new System.EventHandler(this.ButSum_Click);
            // 
            // ButExit
            // 
            this.ButExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButExit.ForeColor = System.Drawing.Color.Red;
            this.ButExit.Location = new System.Drawing.Point(432, 310);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(112, 70);
            this.ButExit.TabIndex = 21;
            this.ButExit.TabStop = false;
            this.ButExit.Text = "Exit";
            this.ButExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // ButSign
            // 
            this.ButSign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.ButSign.ForeColor = System.Drawing.Color.Blue;
            this.ButSign.Location = new System.Drawing.Point(208, 399);
            this.ButSign.Name = "ButSign";
            this.ButSign.Size = new System.Drawing.Size(80, 70);
            this.ButSign.TabIndex = 16;
            this.ButSign.TabStop = false;
            this.ButSign.Text = "+/-";
            this.ButSign.Click += new System.EventHandler(this.ButSign_Click);
            // 
            // ButSeven
            // 
            this.ButSeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButSeven.ForeColor = System.Drawing.Color.Blue;
            this.ButSeven.Location = new System.Drawing.Point(16, 133);
            this.ButSeven.Name = "ButSeven";
            this.ButSeven.Size = new System.Drawing.Size(80, 70);
            this.ButSeven.TabIndex = 8;
            this.ButSeven.TabStop = false;
            this.ButSeven.Text = "7";
            this.ButSeven.Click += new System.EventHandler(this.ButSeven_Click);
            // 
            // ButPoint
            // 
            this.ButPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButPoint.ForeColor = System.Drawing.Color.Blue;
            this.ButPoint.Location = new System.Drawing.Point(112, 399);
            this.ButPoint.Name = "ButPoint";
            this.ButPoint.Size = new System.Drawing.Size(80, 70);
            this.ButPoint.TabIndex = 17;
            this.ButPoint.TabStop = false;
            this.ButPoint.Text = ".";
            this.ButPoint.Click += new System.EventHandler(this.ButPoint_Click);
            // 
            // ButNine
            // 
            this.ButNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButNine.ForeColor = System.Drawing.Color.Blue;
            this.ButNine.Location = new System.Drawing.Point(208, 133);
            this.ButNine.Name = "ButNine";
            this.ButNine.Size = new System.Drawing.Size(80, 70);
            this.ButNine.TabIndex = 10;
            this.ButNine.TabStop = false;
            this.ButNine.Text = "9";
            this.ButNine.Click += new System.EventHandler(this.ButNine_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OutputBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputBox.Location = new System.Drawing.Point(16, 74);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(528, 44);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.TabStop = false;
            this.OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButMinus
            // 
            this.ButMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButMinus.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButMinus.Location = new System.Drawing.Point(304, 310);
            this.ButMinus.Name = "ButMinus";
            this.ButMinus.Size = new System.Drawing.Size(112, 70);
            this.ButMinus.TabIndex = 13;
            this.ButMinus.TabStop = false;
            this.ButMinus.Text = "-";
            this.ButMinus.Click += new System.EventHandler(this.ButMinus_Click);
            // 
            // ButEight
            // 
            this.ButEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButEight.ForeColor = System.Drawing.Color.Blue;
            this.ButEight.Location = new System.Drawing.Point(112, 133);
            this.ButEight.Name = "ButEight";
            this.ButEight.Size = new System.Drawing.Size(80, 70);
            this.ButEight.TabIndex = 9;
            this.ButEight.TabStop = false;
            this.ButEight.Text = "8";
            this.ButEight.Click += new System.EventHandler(this.ButEight_Click);
            // 
            // ButMultiply
            // 
            this.ButMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButMultiply.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButMultiply.Location = new System.Drawing.Point(304, 222);
            this.ButMultiply.Name = "ButMultiply";
            this.ButMultiply.Size = new System.Drawing.Size(112, 70);
            this.ButMultiply.TabIndex = 14;
            this.ButMultiply.TabStop = false;
            this.ButMultiply.Text = "*";
            this.ButMultiply.Click += new System.EventHandler(this.ButMultiply_Click);
            // 
            // ButFour
            // 
            this.ButFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButFour.ForeColor = System.Drawing.Color.Blue;
            this.ButFour.Location = new System.Drawing.Point(16, 222);
            this.ButFour.Name = "ButFour";
            this.ButFour.Size = new System.Drawing.Size(80, 70);
            this.ButFour.TabIndex = 5;
            this.ButFour.TabStop = false;
            this.ButFour.Text = "4";
            this.ButFour.Click += new System.EventHandler(this.ButFour_Click);
            // 
            // ButClear
            // 
            this.ButClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButClear.ForeColor = System.Drawing.Color.Red;
            this.ButClear.Location = new System.Drawing.Point(432, 133);
            this.ButClear.Name = "ButClear";
            this.ButClear.Size = new System.Drawing.Size(112, 70);
            this.ButClear.TabIndex = 20;
            this.ButClear.TabStop = false;
            this.ButClear.Text = "C";
            this.ButClear.Click += new System.EventHandler(this.ButClear_Click);
            // 
            // ButDivide
            // 
            this.ButDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.ButDivide.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButDivide.Location = new System.Drawing.Point(304, 133);
            this.ButDivide.Name = "ButDivide";
            this.ButDivide.Size = new System.Drawing.Size(112, 70);
            this.ButDivide.TabIndex = 15;
            this.ButDivide.TabStop = false;
            this.ButDivide.Text = "/";
            this.ButDivide.Click += new System.EventHandler(this.ButDivide_Click);
            // 
            // CalculatorUI
            // 
            this.AcceptButton = this.ButZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(564, 489);
            this.Controls.Add(this.ButOne);
            this.Controls.Add(this.ButTwo);
            this.Controls.Add(this.ButThree);
            this.Controls.Add(this.ButFour);
            this.Controls.Add(this.ButFive);
            this.Controls.Add(this.ButSix);
            this.Controls.Add(this.ButSeven);
            this.Controls.Add(this.ButEight);
            this.Controls.Add(this.ButNine);
            this.Controls.Add(this.ButZero);
            this.Controls.Add(this.ButSum);
            this.Controls.Add(this.ButMinus);
            this.Controls.Add(this.ButMultiply);
            this.Controls.Add(this.ButDivide);
            this.Controls.Add(this.ButSign);
            this.Controls.Add(this.ButPoint);
            this.Controls.Add(this.ButEqual);
            this.Controls.Add(this.ButDate);
            this.Controls.Add(this.ButClear);
            this.Controls.Add(this.ButExit);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Version);
            this.MaximizeBox = false;
            this.Name = "CalculatorUI";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion
        
        // Numeric key click methods.
        protected void ButZero_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(zeroOut);
        }
        protected void ButOne_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(oneOut);
        }
        protected void ButTwo_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(twoOut);
        }
        protected void ButThree_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(threeOut);
        }
        protected void ButFour_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(fourOut);
        }
        protected void ButFive_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(fiveOut);
        }
        protected void ButSix_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(sixOut);
        }
        protected void ButSeven_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(sevenOut);
        }
        protected void ButEight_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(eightOut);
        }
        protected void ButNine_Click(object sender, System.EventArgs e)
        {
            OutputBox.Text = CalcEngine.CalcNumber(nineOut);
        }
        
        // Other non-numeric key click methods.
        protected void ButSum_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);
		}

		protected void ButMinus_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void ButMultiply_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eMultiply);
		}

		protected void ButDivide_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eDivide);
		}
		protected void ButSign_Click(object sender, System.EventArgs e)
		{
			OutputBox.Text = CalcEngine.CalcSign();
		}
		protected void ButPoint_Click(object sender, System.EventArgs e)
		{
			OutputBox.Text = CalcEngine.CalcDecimal();
		}
		protected void ButDate_Click(object sender, System.EventArgs e)
		{
			OutputBox.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}
		protected void ButClear_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputBox.Text = "0";
		}

		// Perform the calculation.

		protected void ButEqual_Click(object sender, System.EventArgs e)
		{
			OutputBox.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

        // End the program.

        protected void ButExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalculatorUI());
		}

    }
}
