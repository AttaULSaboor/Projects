using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Prepared by : Atta UL Saboor
 * Date : November 22, 2020
 * 
 * Program Purpose: 
 * The purpose of this program is to read out a file labeled employees.txt into an 
 * array of type Employee. The file holds employee information used for Name, Number,
 * Rate, Hours then  request the user to sort the data by name, number rate hours and
 * gross pay. Gross pay is not given in the file then be required to be calculate. In 
 * this program Eliminates the GET() and SET() methods also eliminates the array and
 * Sort() method.
 * 
 * Statement of Authorship:
 * I, Atta UL Saboor, certify that this material is my original work. No other 
 * person's work has been used without due acknowledgement.
 * 
 */

namespace Lab4A
{
	class Program
	{
		static void Main(string[] args)
		{
			int userInput = 0;						// store user input
			bool exceptionFlag = false;				// keep track exceptions
			do
			{
				//check input for invalid characters
				try { userInput = int.Parse(Menu()); }
				catch (Exception) { exceptionFlag = true; }

				List<Employee> employees = new List<Employee>();		//store employees
				Read(employees);										//read text file

				switch (userInput)
				{
					case 1: employees = employees.OrderBy(employee => employee.name).ToList(); break;				//sort by employee name - ascending
					case 2: employees = employees.OrderBy(employee => employee.number).ToList(); break;				//sort by employee Id number - ascending
					case 3: employees = employees.OrderByDescending(employee => employee.rate).ToList(); break;		//sort by employee hourly rate - descending
					case 4: employees = employees.OrderByDescending(employee => employee.hours).ToList(); break;	//sort by employee weekly hours - descending
					case 5: employees = employees.OrderByDescending(employee => employee.gross).ToList(); break;	//sort by employee gross pay - descending
					default: break;
				}

				//display invalid user input error
				if (userInput <= 0 || userInput >= 7 || exceptionFlag == true)
					Console.WriteLine("\n****Invalid Choice - Try Again****\n");
				else
					DisplayTable(employees, userInput, exceptionFlag);
				exceptionFlag = false;			
			} while (userInput != 6);
		}

		/// <summary>
		/// Read the input file and add the data to the list
		/// </summary>
		/// <param name="employees">employees</param>
		public static void Read(List<Employee> employees)
		{
			string input;
			string fileName = @"..\..\employees.txt";

			try
			{
				StreamReader fileData = new StreamReader(fileName);

				while((input = fileData.ReadLine()) != null)
				{
					string[] row = input.Split(',');

					string name = row[0];						//employee name
					int number = int.Parse(row[1]);				//employee Id number
					decimal rate = decimal.Parse(row[2]);		//employee hourly rate
					double hours = double.Parse(row[3]);		//employee weekly hours

					// add employee to list
					employees.Add(new Employee(name, number, rate, hours));
				}
			}
			catch (Exception)
			{
				Console.WriteLine("**** File is empty - Program Aborting *****");
				Environment.Exit(0);
			}
		}

		/// <summary>
		/// Show the main menu and return user input
		/// </summary>
		/// <returns>The user's menue selection</returns>
		public static string Menu()
		{
			// display options menu
			Console.WriteLine("1. Sort by Employee Name");
			Console.WriteLine("2. Sort by Employee Number");
			Console.WriteLine("3. Sort by Employee Pay Rate");
			Console.WriteLine("4. Sort by Employee Hours");
			Console.WriteLine("5. Sort by Employee Gross Pay \n");
			Console.WriteLine("6. Exit \n");
			Console.WriteLine("Enter choice: ");

			return Console.ReadLine();
		}

		/// <summary>
		/// Show the display table
		/// </summary>
		/// <param name="employees"></param>
		/// <param name="userInput"></param>
		/// <param name="exceptionFlag"></param>
		public static void  DisplayTable(List<Employee> employees, int userInput, bool exceptionFlag) 
		{
			if (userInput >= 1 && userInput <= 6 && exceptionFlag == false)
			{
				//display table title
				Console.Clear();
				Console.WriteLine("Employee                Number    Rate     Hours    Gross Pay");
				Console.WriteLine("======================  ======    ======   =====    =========");

				foreach (Employee employee in employees)
					employee.PrintEmployee();

				Console.WriteLine("");
			}
		}
	}
}
