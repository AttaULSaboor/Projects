using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] myEmployees = LoadEmployees();

            if (myEmployees != null)
            {
                EmployeeView employeeView = new EmployeeView(myEmployees);
                employeeView.ProcessUserSelection();
            }
            else
            {
                Console.WriteLine("Program terminated please click any key to close");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// read the file 
        /// </summary>
        /// <returns>employee</returns>
        private static Employee[] LoadEmployees()
        {
            Employee[] myEmployees = new Employee[99];
            int count = 0;
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(@"..\..\Employees.txt", FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream && count < myEmployees.Length)
                {
                    //Read the next line
                    string input = sr.ReadLine();

                    //parse the values
                    string[] values = input.Split(',');
                    string name = values[0];                                        // employee name
                    if (int.TryParse(values[1], out int number) == false)           // employee number
                        Console.WriteLine("Could not be parsed.");
                    if (decimal.TryParse(values[2], out decimal rate) == false)     // employee rate
                        Console.WriteLine("Could not be parsed.");
                    if (double.TryParse(values[3], out double hours) == false)      // employee hours
                        Console.WriteLine("Could not be parsed.");
                    
                    //create a new employee
                    myEmployees[count] = new Employee(name, number, rate, hours, 0);;
                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception loading employees from file due to: {ex.Message}");
                return null;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
                if (sr != null)
                    sr.Close();
            }
            return myEmployees;
        }
    }
}