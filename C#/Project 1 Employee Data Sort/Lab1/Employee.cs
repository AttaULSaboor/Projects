using System;
/*
 * Prepared by : Atta UL Saboor
 * Date : September 27, 2020
 * 
 * Program Purpose: 
 * The purpose of this program is to read out a file labeled employees.txt into an 
 * array of type Employee. The file holds employee information used for Name, Number,
 * Rate, Hours then  request the user to sort the data by name, number rate hours and
 * gross pay. Gross pay is not given in the file then be required to be calculate.
 * This program sort the data by Insert sort Algorithm not the standard .sort() function.
 * 
 * Statement of Authorship:
 * I, Atta UL Saboor, certify that this material is my original work. No other 
 * person's work has been used without due acknowledgement.
 * 
 */

namespace Lab1
{
    class Employee
    {
        private string name;
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross;
        private decimal extrahours;

        /// <summary>
        /// Set employees inforamtion and calculate gross pay
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="rate"></param>
        /// <param name="hours"></param>
        /// <param name="gross"></param>

        public Employee(string name, int number, decimal rate, double hours, decimal gross)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
            this.gross = 0;
            if (hours < 40)
            {
                this.gross = rate * Convert.ToDecimal(hours);
            }
            else
            {
                //calculate gross pay
                extrahours = (Convert.ToDecimal(hours) - 40);
                this.gross = rate * 40;
                this.gross += extrahours * (rate + (rate / 2)); 
            }
             
        }
        /// <summary>
        /// Return the gropss pay of employee
        /// </summary>
        /// <returns>gross</returns>
        public decimal getGross() 
        {
            return gross; 
        }
        /// <summary>
        /// Return the hours of employee
        /// </summary>
        /// <returns>hours</returns>
        public double getHours() 
        { 
            return hours;
        }
        /// <summary>
        /// Return the name of employee
        /// </summary>
        /// <returns>name</returns>
        public string getName() 
        { 
            return name;
        }
        /// <summary>
        /// Return the number of employee
        /// </summary>
        /// <returns>number</returns>
        public int getNumber() 
        { 
            return number;
        }
        /// <summary>
        /// Return the rate of employee
        /// </summary>
        /// <returns>rate</returns>
        public decimal getRate()
        { 
            return rate;
        }
        /// <summary>
        /// use a to string method and prints the table components properly formated
        /// </summary>
        /// <returns>Name,Number,rate,hours,gross</returns>
        public override string ToString()
        {
            return this.getName().PadRight(20,' ') +  this.getNumber().ToString().PadRight(10,' ') 
                +  this.getRate().ToString().PadRight(10,' ') + this.getHours().ToString().PadRight(10,' ') 
                + this.getGross().ToString().PadRight(10,' ');
        }
        /// <summary>
        /// set the hours of employee
        /// </summary>
        /// <param name="hours"></param>
        public void SetHours(double hours)
        {
            this.hours = hours;
  
        }
        /// <summary>
        /// set the name of employee
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// set the number of employee
        /// </summary>
        /// <param name="number"></param>
        public void SetNumber(int number)
        {
            this.number = number;
        }
        /// <summary>
        /// set the rate of employee
        /// </summary>
        /// <param name="rate"></param>
        public void SetRate(decimal rate)
        {
            this.rate = rate;
        }
    }
}
