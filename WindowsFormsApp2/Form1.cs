﻿using System;
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
			try

			{

				connection.Open();

				String sql = "select * from Elision";



				SqlCommand command = new SqlCommand(sql, connection);



				SqlDataReader reader = command.ExecuteReader();



				if (reader.HasRows)

				{

					while (reader.Read())

					{



						string id = reader.GetString(1);

						string percentileRank = reader.GetString(2);



						Console.WriteLine("id=" + id + ";percentile Rank =" + percentileRank);





					}

				}

			}

			catch (Exception err)

			{



				MessageBox.Show(err.Message);



			}
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
			
			
			long Year = (DayY-dobY);
			long Month = (DayM - dobM);
			long Day = (DayD - dobD);
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

			Month_age.Text = TMonth.ToString();
			Out.Text = Year.ToString();
	

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

		//hi justin
    }
}
