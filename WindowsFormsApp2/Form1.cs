﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connString);
		
		public Form1()
		{
			InitializeComponent();
			
		}

		
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Out_TextChanged(object sender, EventArgs e)
		{
			
		}

		public void button1_Click(object sender, EventArgs e)
		{
			
			long DayD = Exam_Date.Value.Day;
			long dobD = Birth_Year.Value.Day;
			long DayM = Exam_Date.Value.Month;
			long dobM = Birth_Year.Value.Month;
			long DayY = Exam_Date.Value.Year;
			long dobY = Birth_Year.Value.Year;
			//git the daters
			
			long Year = (DayY-dobY);
			long Month = (DayM - dobM);
			long Day = (DayD - dobD);
			//make dates math
			if (Day < 0)
			{
				Month = Month - 1;
			}
			long TotalMonth = Month + Year * 12;
			//if statement 
			Month_age.Text = TotalMonth.ToString();
			//output

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_2(object sender, EventArgs e)
		{

		}

        private void Form1_Load(object sender, EventArgs e)
        {
			System.Diagnostics.Debug.WriteLine("Git Hub was here..");
        }

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

			if (!string.IsNullOrEmpty(Month_age.Text))
			{


				// Elison
				string elisionValue = this.Elision_raw_box.Text;

			if (!string.IsNullOrEmpty(elisionValue)) { 
				try

				{
				
					connection.Open();

					String sql = "select percentiile_Rank,Elision,Scaled_Score from Elision where Elision = " + elisionValue + "and " + Month_age.Text + " between min_months and max_months ";
					//select percentiile_Rank,Elision,Scaled_Score, min_months, max_months from Elision where Elision = 27 and 145 between min_months and max_months


					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string Elision = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Elision=" + Elision + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							Percentile_rank_box.Text = percentileRank;
							Scaled_score_box.Text = Scaled_Score;
							//Elision_box.Text = Elision;

						}


					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();
						String sql2 = "select percentiile_Rank,Elision,Scaled_Score from Elision where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE' ";

						//String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								Percentile_rank_box.Text = percentileRank;
								Scaled_score_box.Text = Scaled_Score;

							}

						}


					}

					connection.Close();

				}
				

				catch (Exception err)

				{



				}
			}



			//Blended words
			string blendedvalue = this.Blended_raw_box.Text;
			if (!string.IsNullOrEmpty(blendedvalue))
			{
				try

				{

					connection.Open();
					String sql = "select percenile_rank,Blending_Words,Scaled_Score from blendingwords where Blending_Words = " + blendedvalue + "and " + Month_age.Text + " between min_months and max_months";



					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string blended = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Blending Words=" + blended + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							blended_percentile.Text = percentileRank;
							blended_scale.Text = Scaled_Score;
							//Blending_Words.Text = Blending_Words;

						}

					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();
						String sql2 = "select percenile_rank,Blending_Words,Scaled_Score from blendingwords where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";

						//String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								blended_percentile.Text = percentileRank;
								blended_scale.Text = Scaled_Score;
							}

						}


					}
					connection.Close();

				}

				catch (Exception err)

				{






				}


			}




			//phoneme
			string phonemevalue = this.phoneme_box.Text;
			if (!string.IsNullOrEmpty(phonemevalue))
			{
				try

				{

					connection.Open();
					String sql = "select Percentile_Rank,Phoneme_Isolation,Scaled_Score from phoneme_iso where Phoneme_Isolation = " + phonemevalue + "and " + Month_age.Text + " between min_months and max_months";



					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string phoneme = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Phoneme Isolation=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							phoneme_percentile.Text = percentileRank;
							phoneme_scaled.Text = Scaled_Score;
							//Phoneme_Isolation.Text = Phoneme_Isolation;

						}

					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();
						String sql2 = "select Percentile_Rank,Phoneme_Isolation,Scaled_Score from phoneme_iso where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";

						//String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								phoneme_percentile.Text = percentileRank;
								phoneme_scaled.Text = Scaled_Score;
							}

						}


					}
					connection.Close();

				}

				catch (Exception err)

				{







				}
			}
			//memory for digits
			string memory_for_digits = this.memory_digit_box.Text;
			if (!string.IsNullOrEmpty(memory_for_digits))
			{
				try

				{

					connection.Open();
					String sql = "select Percentile_Rank,Memory_for_digits,Scaled_Score from memorydigits where Memory_for_digits = " + memory_for_digits + "and " + Month_age.Text + " between min_months and max_months";



					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string phoneme = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Memory for digits=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							memory_percentile.Text = percentileRank;
							memory_scaled.Text = Scaled_Score;
							//Memory_for_digits_box.Text = Memory_for_digits;

						}

					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();
						String sql2 = "select Percentile_Rank,Memory_for_digits,Scaled_Score from memorydigits where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";
						//String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								memory_percentile.Text = percentileRank;
								memory_scaled.Text = Scaled_Score;
							}

						}


					}
					connection.Close();

				}

				catch (Exception err)

				{







				}
			}


			//nonword repitition
			string nonword_repitition = this.nonword_box.Text;
			if (!string.IsNullOrEmpty(nonword_repitition))
			{
				try

				{

					connection.Open();
					String sql = "select Percentile_Rank,Nonword_Repitition,Scaled_Score from nonword_repitition where Nonword_Repitition = " + nonword_repitition + "and " + Month_age.Text + " between min_months and max_months";




					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string phoneme = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Nonword repitition=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							nonword_percentile.Text = percentileRank;
							nonword_scaled.Text = Scaled_Score;
							//Nonword_repitition_box.Text = Nonword_repitition;

						}

					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();
						String sql2 = "select Percentile_Rank,Nonword_Repitition,Scaled_Score from nonword_repitition where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";

						//String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								nonword_percentile.Text = percentileRank;
								nonword_scaled.Text = Scaled_Score;
								//Segmenting_Nonwords.Text = Segmenting_Nonwords;

							}

						}


					}

					connection.Close();

				}

				catch (Exception err)

				{







				}
			}
			//Blending_nonwords
			string blending_nonwords = this.rawblendnonwords.Text;
			if (!string.IsNullOrEmpty(blending_nonwords))
			{
				try

				{

					connection.Open();
					String sql = "select Percentile_Rank,Blending_Nonwords,Scaled_Score from blending_nonwords where Blending_Nonwords = " + blending_nonwords + "and " + Month_age.Text + " between min_months and max_months";




					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string phoneme = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Blending nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							percentblendnonwords.Text = percentileRank;
							scaledblendnonwords.Text = Scaled_Score;
							//Blending_nonwords_box.Text = Blending_nonwords;

						}

					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();
						String sql2 = "select Percentile_Rank,Blending_Nonwords,Scaled_Score from blending_nonwords where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";

						//String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								percentblendnonwords.Text = percentileRank;
								scaledblendnonwords.Text = Scaled_Score;
								//Segmenting_Nonwords.Text = Segmenting_Nonwords;

							}

						}


					}
					connection.Close();

				}

				catch (Exception err)

				{







				}
			}
			//Segmenting_Nonwords
			string Segmenting_Nonwords = this.RawSegmentingNonwords.Text;
			if (!string.IsNullOrEmpty(Segmenting_Nonwords))
			{
				try

				{

					connection.Open();
					String sql = "select Percentile_Rank,Segmenting_Nonwords,Scaled_Score from segmenting_nonwords where Segmenting_Nonwords = " + Segmenting_Nonwords + "and " + Month_age.Text + " between min_months and max_months";




					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string phoneme = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							PercentSegmentingNonwords.Text = percentileRank;
							ScaledSegmentingNonwords.Text = Scaled_Score;
							//Segmenting_Nonwords.Text = Segmenting_Nonwords;

						}

					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();
						String sql2 = "select Percentile_Rank,Segmenting_Nonwords,Scaled_Score from segmenting_nonwords where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";

						//String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								PercentSegmentingNonwords.Text = percentileRank;
								ScaledSegmentingNonwords.Text = Scaled_Score;
								//Segmenting_Nonwords.Text = Segmenting_Nonwords;

							}

						}


					}

					connection.Close();

				}

				catch (Exception err)

				{







				}
			}


			//Rapid digit naming
			string rapid_Digit_Naming = this.RapidDscore.Text;
			if (!string.IsNullOrEmpty(rapid_Digit_Naming))
			{
				try

				{

					connection.Open();
					String sql = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where Rapid_digit_naming = " + rapid_Digit_Naming + "and " + Month_age.Text + " between min_months and max_months";



					SqlCommand command = new SqlCommand(sql, connection);



					SqlDataReader reader = command.ExecuteReader();



					if (reader.HasRows)

					{

						while (reader.Read())

						{


							string percentileRank = reader.GetString(0);
							string phoneme = reader.GetString(1);
							string Scaled_Score = reader.GetString(2);



							Console.WriteLine("Rapid_digit_naming=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

							Rapid_percentille.Text = percentileRank;
							Rapid_score.Text = Scaled_Score;
							//Segmenting_Nonwords.Text = Segmenting_Nonwords;

						}

					}
					else
					{
						Console.WriteLine("No result for rapid digit naming");
						// No rows found. We will look for max values
						connection.Close();

						connection.Open();

						String sql2 = "select Percentile_Rank,Rapid_Digit_Naming,Scaled_Score from Rapid_digit_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";




						SqlCommand command2 = new SqlCommand(sql2, connection);



						SqlDataReader reader2 = command2.ExecuteReader();

						Console.WriteLine("Did it crash?");

						if (reader2.HasRows)

						{

							while (reader2.Read())

							{


								string percentileRank = reader2.GetString(0);
								string phoneme = reader2.GetString(1);
								string Scaled_Score = reader2.GetString(2);



								Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								Rapid_percentille.Text = percentileRank;
								Rapid_score.Text = Scaled_Score;
								//Segmenting_Nonwords.Text = Segmenting_Nonwords;

							}

						}


					}
					connection.Close();

				}


				catch (Exception err)

				{


					Console.WriteLine("Yes. Crashed");
					//MessageBox.Show(err.Message);



				}
			}


				//rapid_letter_naming
				string rapid_letter_naming = this.rapidLscore.Text;
				if (!string.IsNullOrEmpty(rapid_letter_naming))
				{
					try

					{

						connection.Open();
						String sql = "select Percentile_Rank,Rapid_Letter_Naming,Scaled_Score from rapid_letter_naming where rapid_letter_naming = " + rapid_letter_naming + "and " + Month_age.Text + " between min_months and max_months";



						SqlCommand command = new SqlCommand(sql, connection);



						SqlDataReader reader = command.ExecuteReader();



						if (reader.HasRows)

						{

							while (reader.Read())

							{


								string percentileRank = reader.GetString(0);
								string phoneme = reader.GetString(1);
								string Scaled_Score = reader.GetString(2);



								Console.WriteLine("Rapid_digit_naming=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

								letter_naming.Text = percentileRank;
								letter_score.Text = Scaled_Score;
								//Segmenting_Nonwords.Text = Segmenting_Nonwords;

							}

						}
						else
						{
							Console.WriteLine("No result for rapid digit naming");
							// No rows found. We will look for max values
							connection.Close();

							connection.Open();

							String sql2 = "select Percentile_Rank,Rapid_Letter_Naming,Scaled_Score from rapid_letter_naming where " + Month_age.Text + " between min_months and max_months and is_max = 'TRUE'";

							SqlCommand command2 = new SqlCommand(sql2, connection);

							SqlDataReader reader2 = command2.ExecuteReader();

							Console.WriteLine("Did it crash?");

							if (reader2.HasRows)

							{

								while (reader2.Read())

								{

									string percentileRank = reader2.GetString(0);
									string phoneme = reader2.GetString(1);
									string Scaled_Score = reader2.GetString(2);



									Console.WriteLine("Segmenting nonwords=" + phoneme + ";percentile Rank =" + percentileRank + ";scaled Score=" + Scaled_Score);

									letter_naming.Text = percentileRank;
									letter_score.Text = Scaled_Score;
									//Segmenting_Nonwords.Text = Segmenting_Nonwords;

								}

							}


						}
						connection.Close();

					}


					catch (Exception err)

					{


						Console.WriteLine("Yes. Crashed");




					}
				}
			}
		}

	


		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void label20_Click(object sender, EventArgs e)
		{

		}

		private void label19_Click(object sender, EventArgs e)
		{

		}

		private void label21_Click(object sender, EventArgs e)
		{

		}

		private void clear_Click(object sender, EventArgs e)
		{
			Elision_raw_box.Text = "";
			Month_age.Text = "";
			Percentile_rank_box.Text = "";
			Scaled_score_box.Text = "";
			Blended_raw_box.Text = "";
			blended_percentile.Text = "";
			blended_scale.Text = "";
			phoneme_box.Text = "";
			phoneme_percentile.Text = "";
			phoneme_scaled.Text = "";
			memory_digit_box.Text = "";
			memory_percentile.Text = "";
			memory_scaled.Text = "";
			nonword_box.Text = "";
			nonword_percentile.Text = "";
			nonword_scaled.Text = "";
			RapidDscore.Text = "";
			Rapid_percentille.Text = "";
			Rapid_score.Text = "";
			rapidLscore.Text = "";
			letter_naming.Text = "";
			letter_score.Text = "";
			rawblendnonwords.Text = "";
			percentblendnonwords.Text = "";
			scaledblendnonwords.Text = "";
			RawSegmentingNonwords.Text = "";
			PercentSegmentingNonwords.Text = "";
			ScaledSegmentingNonwords.Text = "";

		}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //hi justin
    }
}
