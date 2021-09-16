
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Exam_Date = new System.Windows.Forms.DateTimePicker();
			this.Birth_Year = new System.Windows.Forms.DateTimePicker();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Month_age = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.Percentile_rank_box = new System.Windows.Forms.TextBox();
			this.Scaled_score_box = new System.Windows.Forms.TextBox();
			this.Elision_raw_box = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.phoneme_scaled = new System.Windows.Forms.TextBox();
			this.phoneme_percentile = new System.Windows.Forms.TextBox();
			this.phoneme_box = new System.Windows.Forms.TextBox();
			this.blended_scale = new System.Windows.Forms.TextBox();
			this.blended_percentile = new System.Windows.Forms.TextBox();
			this.Blended_raw_box = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.memory_scaled = new System.Windows.Forms.TextBox();
			this.nonword_scaled = new System.Windows.Forms.TextBox();
			this.nonword_percentile = new System.Windows.Forms.TextBox();
			this.nonword_box = new System.Windows.Forms.TextBox();
			this.memory_percentile = new System.Windows.Forms.TextBox();
			this.memory_digit_box = new System.Windows.Forms.TextBox();
			this.Rapid_score = new System.Windows.Forms.TextBox();
			this.Rapid_percentille = new System.Windows.Forms.TextBox();
			this.RapidDscore = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.ScaledSegmentingNonwords = new System.Windows.Forms.TextBox();
			this.PercentSegmentingNonwords = new System.Windows.Forms.TextBox();
			this.RawSegmentingNonwords = new System.Windows.Forms.TextBox();
			this.scaledblendnonwords = new System.Windows.Forms.TextBox();
			this.percentblendnonwords = new System.Windows.Forms.TextBox();
			this.rawblendnonwords = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(165, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "calculate age";
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
			// Month_age
			// 
			this.Month_age.Location = new System.Drawing.Point(12, 125);
			this.Month_age.Name = "Month_age";
			this.Month_age.Size = new System.Drawing.Size(132, 20);
			this.Month_age.TabIndex = 16;
			this.Month_age.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Month";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Elision";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(127, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Raw Score";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(203, 169);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Percentile Rank";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(298, 169);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Scaled Score";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(644, 256);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(0, 13);
			this.label10.TabIndex = 22;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(380, 218);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 23;
			this.button2.Text = "calculate";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Percentile_rank_box
			// 
			this.Percentile_rank_box.Location = new System.Drawing.Point(216, 220);
			this.Percentile_rank_box.Name = "Percentile_rank_box";
			this.Percentile_rank_box.Size = new System.Drawing.Size(54, 20);
			this.Percentile_rank_box.TabIndex = 25;
			// 
			// Scaled_score_box
			// 
			this.Scaled_score_box.Location = new System.Drawing.Point(301, 220);
			this.Scaled_score_box.Name = "Scaled_score_box";
			this.Scaled_score_box.Size = new System.Drawing.Size(54, 20);
			this.Scaled_score_box.TabIndex = 26;
			// 
			// Elision_raw_box
			// 
			this.Elision_raw_box.Location = new System.Drawing.Point(130, 220);
			this.Elision_raw_box.Name = "Elision_raw_box";
			this.Elision_raw_box.Size = new System.Drawing.Size(54, 20);
			this.Elision_raw_box.TabIndex = 27;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 256);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(79, 13);
			this.label11.TabIndex = 28;
			this.label11.Text = "Blending words";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(9, 290);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 13);
			this.label12.TabIndex = 29;
			this.label12.Text = "Phoneme Isolation";
			// 
			// phoneme_scaled
			// 
			this.phoneme_scaled.Location = new System.Drawing.Point(301, 287);
			this.phoneme_scaled.Name = "phoneme_scaled";
			this.phoneme_scaled.Size = new System.Drawing.Size(54, 20);
			this.phoneme_scaled.TabIndex = 30;
			// 
			// phoneme_percentile
			// 
			this.phoneme_percentile.Location = new System.Drawing.Point(216, 287);
			this.phoneme_percentile.Name = "phoneme_percentile";
			this.phoneme_percentile.Size = new System.Drawing.Size(54, 20);
			this.phoneme_percentile.TabIndex = 31;
			// 
			// phoneme_box
			// 
			this.phoneme_box.Location = new System.Drawing.Point(130, 287);
			this.phoneme_box.Name = "phoneme_box";
			this.phoneme_box.Size = new System.Drawing.Size(54, 20);
			this.phoneme_box.TabIndex = 32;
			// 
			// blended_scale
			// 
			this.blended_scale.Location = new System.Drawing.Point(301, 253);
			this.blended_scale.Name = "blended_scale";
			this.blended_scale.Size = new System.Drawing.Size(54, 20);
			this.blended_scale.TabIndex = 33;
			// 
			// blended_percentile
			// 
			this.blended_percentile.Location = new System.Drawing.Point(216, 253);
			this.blended_percentile.Name = "blended_percentile";
			this.blended_percentile.Size = new System.Drawing.Size(54, 20);
			this.blended_percentile.TabIndex = 34;
			// 
			// Blended_raw_box
			// 
			this.Blended_raw_box.Location = new System.Drawing.Point(130, 253);
			this.Blended_raw_box.Name = "Blended_raw_box";
			this.Blended_raw_box.Size = new System.Drawing.Size(54, 20);
			this.Blended_raw_box.TabIndex = 35;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 556);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(114, 13);
			this.label13.TabIndex = 36;
			this.label13.Text = "Segmenting Nonwords";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(9, 519);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(99, 13);
			this.label14.TabIndex = 37;
			this.label14.Text = "Blending Nonwords";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(9, 463);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(104, 13);
			this.label15.TabIndex = 38;
			this.label15.Text = "Rapid Letter Naming";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(9, 420);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(98, 13);
			this.label16.TabIndex = 39;
			this.label16.Text = "Rapid Digit Naming";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(9, 374);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(101, 13);
			this.label17.TabIndex = 40;
			this.label17.Text = "Nonword Repetition";
			this.label17.Click += new System.EventHandler(this.label17_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(9, 329);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(88, 13);
			this.label18.TabIndex = 41;
			this.label18.Text = "Memory for Digits";
			// 
			// memory_scaled
			// 
			this.memory_scaled.Location = new System.Drawing.Point(301, 326);
			this.memory_scaled.Name = "memory_scaled";
			this.memory_scaled.Size = new System.Drawing.Size(54, 20);
			this.memory_scaled.TabIndex = 42;
			// 
			// nonword_scaled
			// 
			this.nonword_scaled.Location = new System.Drawing.Point(301, 371);
			this.nonword_scaled.Name = "nonword_scaled";
			this.nonword_scaled.Size = new System.Drawing.Size(54, 20);
			this.nonword_scaled.TabIndex = 43;
			// 
			// nonword_percentile
			// 
			this.nonword_percentile.Location = new System.Drawing.Point(216, 371);
			this.nonword_percentile.Name = "nonword_percentile";
			this.nonword_percentile.Size = new System.Drawing.Size(54, 20);
			this.nonword_percentile.TabIndex = 44;
			// 
			// nonword_box
			// 
			this.nonword_box.Location = new System.Drawing.Point(130, 371);
			this.nonword_box.Name = "nonword_box";
			this.nonword_box.Size = new System.Drawing.Size(54, 20);
			this.nonword_box.TabIndex = 45;
			// 
			// memory_percentile
			// 
			this.memory_percentile.Location = new System.Drawing.Point(216, 326);
			this.memory_percentile.Name = "memory_percentile";
			this.memory_percentile.Size = new System.Drawing.Size(54, 20);
			this.memory_percentile.TabIndex = 46;
			// 
			// memory_digit_box
			// 
			this.memory_digit_box.Location = new System.Drawing.Point(130, 326);
			this.memory_digit_box.Name = "memory_digit_box";
			this.memory_digit_box.Size = new System.Drawing.Size(54, 20);
			this.memory_digit_box.TabIndex = 47;
			// 
			// Rapid_score
			// 
			this.Rapid_score.Location = new System.Drawing.Point(301, 417);
			this.Rapid_score.Name = "Rapid_score";
			this.Rapid_score.Size = new System.Drawing.Size(54, 20);
			this.Rapid_score.TabIndex = 48;
			// 
			// Rapid_percentille
			// 
			this.Rapid_percentille.Location = new System.Drawing.Point(216, 417);
			this.Rapid_percentille.Name = "Rapid_percentille";
			this.Rapid_percentille.Size = new System.Drawing.Size(54, 20);
			this.Rapid_percentille.TabIndex = 49;
			// 
			// RapidDscore
			// 
			this.RapidDscore.Location = new System.Drawing.Point(130, 417);
			this.RapidDscore.Name = "RapidDscore";
			this.RapidDscore.Size = new System.Drawing.Size(54, 20);
			this.RapidDscore.TabIndex = 50;
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(301, 460);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(54, 20);
			this.textBox16.TabIndex = 51;
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(216, 460);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(54, 20);
			this.textBox17.TabIndex = 52;
			// 
			// textBox18
			// 
			this.textBox18.Location = new System.Drawing.Point(130, 460);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(54, 20);
			this.textBox18.TabIndex = 53;
			// 
			// ScaledSegmentingNonwords
			// 
			this.ScaledSegmentingNonwords.Location = new System.Drawing.Point(301, 553);
			this.ScaledSegmentingNonwords.Name = "ScaledSegmentingNonwords";
			this.ScaledSegmentingNonwords.Size = new System.Drawing.Size(54, 20);
			this.ScaledSegmentingNonwords.TabIndex = 54;
			// 
			// PercentSegmentingNonwords
			// 
			this.PercentSegmentingNonwords.Location = new System.Drawing.Point(216, 553);
			this.PercentSegmentingNonwords.Name = "PercentSegmentingNonwords";
			this.PercentSegmentingNonwords.Size = new System.Drawing.Size(54, 20);
			this.PercentSegmentingNonwords.TabIndex = 55;
			// 
			// RawSegmentingNonwords
			// 
			this.RawSegmentingNonwords.Location = new System.Drawing.Point(130, 553);
			this.RawSegmentingNonwords.Name = "RawSegmentingNonwords";
			this.RawSegmentingNonwords.Size = new System.Drawing.Size(54, 20);
			this.RawSegmentingNonwords.TabIndex = 56;
			// 
			// scaledblendnonwords
			// 
			this.scaledblendnonwords.Location = new System.Drawing.Point(301, 516);
			this.scaledblendnonwords.Name = "scaledblendnonwords";
			this.scaledblendnonwords.Size = new System.Drawing.Size(54, 20);
			this.scaledblendnonwords.TabIndex = 57;
			// 
			// percentblendnonwords
			// 
			this.percentblendnonwords.Location = new System.Drawing.Point(216, 516);
			this.percentblendnonwords.Name = "percentblendnonwords";
			this.percentblendnonwords.Size = new System.Drawing.Size(54, 20);
			this.percentblendnonwords.TabIndex = 58;
			// 
			// rawblendnonwords
			// 
			this.rawblendnonwords.Location = new System.Drawing.Point(130, 516);
			this.rawblendnonwords.Name = "rawblendnonwords";
			this.rawblendnonwords.Size = new System.Drawing.Size(54, 20);
			this.rawblendnonwords.TabIndex = 59;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(18, 493);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(83, 13);
			this.label19.TabIndex = 60;
			this.label19.Text = "Supplemental";
			this.label19.Click += new System.EventHandler(this.label19_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(18, 199);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(33, 13);
			this.label20.TabIndex = 61;
			this.label20.Text = "Core";
			this.label20.Click += new System.EventHandler(this.label20_Click);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(12, 169);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(43, 13);
			this.label21.TabIndex = 62;
			this.label21.Text = "Subtest";
			this.label21.Click += new System.EventHandler(this.label21_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 597);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.rawblendnonwords);
			this.Controls.Add(this.percentblendnonwords);
			this.Controls.Add(this.scaledblendnonwords);
			this.Controls.Add(this.RawSegmentingNonwords);
			this.Controls.Add(this.PercentSegmentingNonwords);
			this.Controls.Add(this.ScaledSegmentingNonwords);
			this.Controls.Add(this.textBox18);
			this.Controls.Add(this.textBox17);
			this.Controls.Add(this.textBox16);
			this.Controls.Add(this.RapidDscore);
			this.Controls.Add(this.Rapid_percentille);
			this.Controls.Add(this.Rapid_score);
			this.Controls.Add(this.memory_digit_box);
			this.Controls.Add(this.memory_percentile);
			this.Controls.Add(this.nonword_box);
			this.Controls.Add(this.nonword_percentile);
			this.Controls.Add(this.nonword_scaled);
			this.Controls.Add(this.memory_scaled);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.Blended_raw_box);
			this.Controls.Add(this.blended_percentile);
			this.Controls.Add(this.blended_scale);
			this.Controls.Add(this.phoneme_box);
			this.Controls.Add(this.phoneme_percentile);
			this.Controls.Add(this.phoneme_scaled);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.Elision_raw_box);
			this.Controls.Add(this.Scaled_score_box);
			this.Controls.Add(this.Percentile_rank_box);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Month_age);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Birth_Year);
			this.Controls.Add(this.Exam_Date);
			this.Name = "Form1";
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker Exam_Date;
		private System.Windows.Forms.DateTimePicker Birth_Year;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Month_age;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox Percentile_rank_box;
		private System.Windows.Forms.TextBox Scaled_score_box;
		private System.Windows.Forms.TextBox Elision_raw_box;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox phoneme_scaled;
		private System.Windows.Forms.TextBox phoneme_percentile;
		private System.Windows.Forms.TextBox phoneme_box;
		private System.Windows.Forms.TextBox blended_scale;
		private System.Windows.Forms.TextBox blended_percentile;
		private System.Windows.Forms.TextBox Blended_raw_box;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox memory_scaled;
		private System.Windows.Forms.TextBox nonword_scaled;
		private System.Windows.Forms.TextBox nonword_percentile;
		private System.Windows.Forms.TextBox nonword_box;
		private System.Windows.Forms.TextBox memory_percentile;
		private System.Windows.Forms.TextBox memory_digit_box;
		private System.Windows.Forms.TextBox Rapid_score;
		private System.Windows.Forms.TextBox Rapid_percentille;
		private System.Windows.Forms.TextBox RapidDscore;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox ScaledSegmentingNonwords;
		private System.Windows.Forms.TextBox PercentSegmentingNonwords;
		private System.Windows.Forms.TextBox RawSegmentingNonwords;
		private System.Windows.Forms.TextBox scaledblendnonwords;
		private System.Windows.Forms.TextBox percentblendnonwords;
		private System.Windows.Forms.TextBox rawblendnonwords;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
	}
}

