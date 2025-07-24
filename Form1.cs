using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Form
	{
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnSubtract;
		private System.Windows.Forms.Button btnAdd;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.txtResult = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(16, 16);
			this.txtResult.Name = "txtResult";
			this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtResult.Size = new System.Drawing.Size(256, 20);
			this.txtResult.TabIndex = 0;
			this.txtResult.Text = "0";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(16, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(256, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "textBox2";
			// 
			// btnMultiply
			// 
			this.btnMultiply.Location = new System.Drawing.Point(256, 176);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(24, 24);
			this.btnMultiply.TabIndex = 2;
			this.btnMultiply.Text = "*";
			// 
			// btnDivide
			// 
			this.btnDivide.Location = new System.Drawing.Point(256, 216);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(24, 24);
			this.btnDivide.TabIndex = 3;
			this.btnDivide.Text = "/";
			// 
			// btnSubtract
			// 
			this.btnSubtract.Location = new System.Drawing.Point(256, 136);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(24, 24);
			this.btnSubtract.TabIndex = 4;
			this.btnSubtract.Text = "-";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(256, 96);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(24, 24);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "+";
			this.btnAdd.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(18, 126);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(190, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "textBox3";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 272);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnSubtract);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btnMultiply);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.txtResult);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
