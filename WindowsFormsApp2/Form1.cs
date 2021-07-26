using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\ac-dc2\student$\Year13\Samuel.Cuanang\GitHub\WindowsFormsApp2\WindowsFormsApp2\Database1.mdf;Integrated Security=True";
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
			if (Day<0)
			{
				Month = Month - 1;
			}
			if (Month < 0)
			{
				Year = Year - 1;
			}

			long TMonth = (DayM - dobM);
			if(TMonth<0)
			{
				TMonth = 12 + TMonth;
			}
			//if statements cuz how time works
			Month_age.Text = TMonth.ToString();
			Out.Text = Year.ToString();
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
			try

			{
				string elisionValue = this.Elision_box.Text;
				connection.Open();
				String sql = "select percentiile_Rank,Elision,Scaled_Score from Elision where Elision = " + elisionValue;



				SqlCommand command = new SqlCommand(sql, connection);



				SqlDataReader reader = command.ExecuteReader();



				if (reader.HasRows)

				{

					while (reader.Read())

					{


						string percentileRank = reader.GetString(0);
						string Elision = reader.GetString(1);
						string Scaled_Score = reader.GetString(2);



						Console.WriteLine("Elision=" + Elision + ";percentile Rank =" + percentileRank);

						Percentile_rank_box.Text = percentileRank;
						Scaled_score_box.Text = Scaled_Score;
						//Elision_box.Text = Elision;

					}

				}
				connection.Close();

			}

			catch (Exception err)

			{



				MessageBox.Show(err.Message);



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

		//hi justin
	}
}
