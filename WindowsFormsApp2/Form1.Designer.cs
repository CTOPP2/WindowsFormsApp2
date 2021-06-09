
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
            this.textBox7.Location = new System.Drawing.Point(269, 262);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(0, 22);
            this.textBox7.TabIndex = 6;
            // 
            // Exam_Date
            // 
            this.Exam_Date.Location = new System.Drawing.Point(16, 79);
            this.Exam_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exam_Date.Name = "Exam_Date";
            this.Exam_Date.Size = new System.Drawing.Size(303, 22);
            this.Exam_Date.TabIndex = 8;
            this.Exam_Date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Birth_Year
            // 
            this.Birth_Year.Location = new System.Drawing.Point(16, 31);
            this.Birth_Year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Birth_Year.Name = "Birth_Year";
            this.Birth_Year.Size = new System.Drawing.Size(303, 22);
            this.Birth_Year.TabIndex = 9;
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(16, 154);
            this.Out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(71, 22);
            this.Out.TabIndex = 10;
            this.Out.TextChanged += new System.EventHandler(this.Out_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Test Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Year";
            // 
            // Month_age
            // 
            this.Month_age.Location = new System.Drawing.Point(96, 154);
            this.Month_age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Month_age.Name = "Month_age";
            this.Month_age.Size = new System.Drawing.Size(71, 22);
            this.Month_age.TabIndex = 16;
            this.Month_age.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Month";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 194);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

