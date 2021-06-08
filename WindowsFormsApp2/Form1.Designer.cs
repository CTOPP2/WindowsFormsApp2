
namespace WindowsFormsApp2
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.Exam_Date = new System.Windows.Forms.DateTimePicker();
			this.Birth_Year = new System.Windows.Forms.DateTimePicker();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Out = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Month_age = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(202, 213);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(0, 20);
			this.textBox7.TabIndex = 6;
			// 
			// Exam_Date
			// 
			this.Exam_Date.Location = new System.Drawing.Point(12, 64);
			this.Exam_Date.Name = "Exam_Date";
			this.Exam_Date.Size = new System.Drawing.Size(228, 20);
			this.Exam_Date.TabIndex = 8;
			this.Exam_Date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// Birth_Year
			// 
			this.Birth_Year.Location = new System.Drawing.Point(12, 25);
			this.Birth_Year.Name = "Birth_Year";
			this.Birth_Year.Size = new System.Drawing.Size(228, 20);
			this.Birth_Year.TabIndex = 9;
			// 
			// Out
			// 
			this.Out.Location = new System.Drawing.Point(12, 125);
			this.Out.Name = "Out";
			this.Out.Size = new System.Drawing.Size(54, 20);
			this.Out.TabIndex = 10;
			this.Out.TextChanged += new System.EventHandler(this.Out_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(165, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Date of Birth";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Test Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Age";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Year";
			// 
			// Month_age
			// 
			this.Month_age.Location = new System.Drawing.Point(72, 125);
			this.Month_age.Name = "Month_age";
			this.Month_age.Size = new System.Drawing.Size(54, 20);
			this.Month_age.TabIndex = 16;
			this.Month_age.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(72, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Month";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 158);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Month_age);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Out);
			this.Controls.Add(this.Birth_Year);
			this.Controls.Add(this.Exam_Date);
			this.Controls.Add(this.textBox7);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.DateTimePicker Exam_Date;
		private System.Windows.Forms.DateTimePicker Birth_Year;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox Out;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Month_age;
		private System.Windows.Forms.Label label5;
	}
}

