using System;
using System.Collections.Generic;
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
    class EmployeeView
    {
        private Employee[] employees;

        public EmployeeView(Employee[] employees)
        {
            this.employees = employees;
        }
        public void ProcessUserSelection()
        {
            // show table title
            Console.Clear();
            Console.WriteLine("Employee".PadRight(20,' ')+"Number".PadRight(10,' ') +"Rate".PadRight(10,' ')
                +"Hours".PadRight(10,' ')+"Gross Pay".PadRight(20,' ')+"Saboor Company");
            Console.WriteLine("================    ======    ====      =====     =========           --------------");
            Console.WriteLine("");
            for (int i = 0; i < employees.Length; i++)
            {
                Employee myEmployee = employees[i];
                if (myEmployee != null)
                    Console.WriteLine(myEmployee);
            }
            // show options menu
            Console.WriteLine("");
            Console.WriteLine("1. sort by Employee Name");
            Console.WriteLine("2. sort by Employee Number");
            Console.WriteLine("3. sort by Employee Pay Rate");
            Console.WriteLine("4. sort by Employee Hours");
            Console.WriteLine("5. sort by Employee Gross Pay");
            Console.WriteLine("6. Exit");
            Console.WriteLine("\n Enter choice:");

            //check input for invalid characters
            while (true)
            {
                string input = Console.ReadLine();

                // show invalid user input error
                if ((int.TryParse(input, out int userSelection) == false) ||
                    userSelection < 1 || userSelection > 6)
                {
                    Console.WriteLine("Please enter a value between 1 to 6.");
                    continue;
                }
                if (userSelection == 1)
                {
                    this.employees = Sort(employees, 1);
                    ProcessUserSelection();
                }
                else if (userSelection == 2)
                {
                    this.employees = Sort(employees, 2);
                    ProcessUserSelection();
                }
                else if (userSelection == 3)
                {
                    this.employees = Sort(employees, 3);
                    ProcessUserSelection();
                }
                else if (userSelection == 4)
                {
                    this.employees = Sort(employees, 4);
                    ProcessUserSelection();
                }
                else if (userSelection == 5)
                {
                    this.employees = Sort(employees, 5);
                    ProcessUserSelection();
                }
                else // userSelction must be 6, so exit
                    System.Environment.Exit(1);
            }
        }
        /// <summary>
        /// Insert Sort Algorithm
        /// Reference:  www.codecodex.com/wiki/Insertion_sort
        /// 
        /// A component is related to all the previous components up untill a smaller component is found.
        /// </summary>

        static Employee[] Sort(Employee[] array, int option)
        {
            int arrayIndex, arrayElement;

            for (arrayIndex = 1; arrayIndex < array.Length; arrayIndex++)
            {
                Employee value = array[arrayIndex];
                arrayElement = arrayIndex - 1;

                if (value != null)
                {
                    if (option == 1)
                    {
                        // Sort by Name
                        while ((arrayElement >= 0) && (array[arrayElement].getName().CompareTo(value.getName()) > 0))
                        {
                            array[arrayElement + 1] = array[arrayElement];
                            arrayElement = arrayElement - 1;
                        }
                    } 
                    else if (option == 2)
                    {
                        // Sort by Number
                        while ((arrayElement >= 0) && (array[arrayElement].getNumber().CompareTo(value.getNumber()) > 0))
                        {
                            array[arrayElement + 1] = array[arrayElement];
                            arrayElement = arrayElement - 1;
                        }
                    } 
                    else if (option == 3)
                    {
                        // Sort by Rate
                        while ((arrayElement >= 0) && (array[arrayElement].getRate().CompareTo(value.getRate()) < 0))
                        {
                            array[arrayElement + 1] = array[arrayElement];
                            arrayElement = arrayElement - 1;
                        }
                    }
                    else if (option == 4)
                    {
                        // Sort by Hours
                        while ((arrayElement >= 0) && (array[arrayElement].getHours().CompareTo(value.getHours()) < 0))
                        {
                            array[arrayElement + 1] = array[arrayElement];
                            arrayElement = arrayElement - 1;
                        }
                    }
                    else if (option == 5)
                    {
                        // Sort by Gross
                        while ((arrayElement >= 0) && (array[arrayElement].getGross().CompareTo(value.getGross()) < 0))
                        {
                            array[arrayElement + 1] = array[arrayElement];
                            arrayElement = arrayElement - 1;
                        }
                    }
                    
                    array[arrayElement + 1] = value;
                }
            }
            return array;
        }
    }
}
