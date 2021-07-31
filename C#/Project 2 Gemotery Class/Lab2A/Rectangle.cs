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
    public class Rectangle : Shape
    {
        public double rectangle_length;     //store rectangle length
        public double rectangle_width;      //store rectangle width

        /// <summary>
        ///Rectangle constructor
        ///Call the SetData 
        /// </summary>
        public Rectangle()
        {
            this.Type = "Rectangle";
            SetData();
        }

        /// <summary>
        /// Ask from user for rectangle length and width
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Rectangle Length:");
                rectangle_length = double.Parse(Console.ReadLine());

                Console.Write("Enter the Rectangle Width:");
                rectangle_width = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// Calculate area for rectangle
        /// </summary>
        /// <returns>rectangle area</returns>
        public override double CalculateArea()
        {
            return rectangle_length * rectangle_width;
        }

        /// <summary>
        /// Calculate volume for rectangle
        /// </summary>
        /// <returns>rectangle volume</returns>
        public override double CalculateVolume()
        {
            return 0.0;
        }

        /// <summary>
        /// show rectangle record
        /// </summary>
        /// <returns>rectangle data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,23:F2}{2,22:F2} l x {3:F2} w", base.Type, CalculateArea(),rectangle_length,rectangle_width);
        }
    }
}
