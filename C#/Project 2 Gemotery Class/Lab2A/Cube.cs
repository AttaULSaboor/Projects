using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Prepared by : Atta UL Saboor
 * Date : October 11, 2020
 * 
 * Program Purpose: 
 * The purpose of this program is to make an abstract class called Shape which represents 
 * one single shape and an object hierarchy for all classes. The user via a menu to create 
 * an intance of one of your shapes. Usse polymoorphism to store shapes into a list 
 * continues to prompt until the user selects the exit option.Display a neat, orderly table 
 * of all instantiated shapes their dimensions, areas and, in the case of three-dimensional
 * shapes, their volume.
 * 
 * 
 * Statement of Authorship:
 * I, Atta UL Saboor, certify that this material is my original work. No other 
 * person's work has been used without due acknowledgement.
 * 
 */

namespace Lab2A
{
    public class Cube : Shape
    {
        public double cube_length;      //store cube length

        /// <summary>
        /// cube constructor
        /// call the SetData
        /// </summary>
        public Cube()
        {
            this.Type = "Cube";
            SetData();
        }

        /// <summary>
        /// ask from user for cube length
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Cube Length:");
                cube_length = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// calculate area for cube
        /// </summary>
        /// <returns>cube area</returns>
        public override double CalculateArea()
        {
            return 6 * Math.Pow(cube_length, 2);
        }

        /// <summary>
        /// calculate volume for cube
        /// </summary>
        /// <returns>cube volume</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(cube_length, 3);
        }

        /// <summary>
        /// show cube record
        /// </summary>
        /// <returns>cube data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,28:F2}{2,16:F2}{3,6:F2} l", base.Type, CalculateArea(), CalculateVolume(), cube_length);
        }
    }
}
