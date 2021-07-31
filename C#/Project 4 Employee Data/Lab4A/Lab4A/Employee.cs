using System;
using System.Collections.Generic;
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
	/// <summary>
	/// This class describes the employee
	/// </summary>
	class Employee
	{
		public string name { get; set; }			// The employee name
		public int number { get; set; }				// The employee ID
		public decimal rate { get; set; }			// The employee hourly rate
		public double hours { get; set; }			// The employee weekly hours 
		public decimal gross { get; set; }			// The employee gross pay

		/// <summary>
		/// Constructor for employee and calculates gross pay
		/// </summary>
		/// <param name="name">Employee name</param>
		/// <param name="number">Employee number</param>
		/// <param name="rate">Employee hourly rate of pay</param>
		/// <param name="hours">Employee hours worked in a week</param>
		public Employee(string name, int number, decimal rate, double hours)
		{
			this.name = name;
			this.number = number;
			this.rate = rate;
			this.hours = hours;

			//Calculate gross pay
			if (hours < 40)
				gross = (decimal)hours * rate;
			else
				gross = (40.0m * rate) + (((decimal)hours - 40.0m) * rate * 1.5m);
		}

		/// <summary>
		/// prints the table components properly formated
		/// </summary>
		public void PrintEmployee()
		{
			Console.WriteLine("{0, -20} {1, 9:D5} {2, 9:C} {3, 7:#0.00} {4, 12:C}", name, number, rate, hours, gross);
		}
	}
}
