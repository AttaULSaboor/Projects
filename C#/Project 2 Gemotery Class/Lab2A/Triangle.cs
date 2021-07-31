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
    public class Triangle : Shape
    {
        public double triangle_base;        //store triangle base
        public double triangle_height;      //store triangle height

        /// <summary>
        /// triangle constructor
        /// call the SetData
        /// </summary>
        public Triangle()
        {
            this.Type = "Triangle";
            SetData();
        }

        /// <summary>
        ///ask from user for triangle base and height 
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Triangle Base:");
                triangle_base = double.Parse(Console.ReadLine());

                Console.Write("Enter the Triangle Height:");
                triangle_height = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// calculate triangle area
        /// </summary>
        /// <returns>triangle area</returns>
        public override double CalculateArea()
        {
            return (1.0 / 2.0) * triangle_base * triangle_height;
        }

        /// <summary>
        /// calculate triangle volume
        /// </summary>
        /// <returns>triangle volume</returns>
        public override double CalculateVolume()
        {
            return 0.0;
        }

        /// <summary>
        /// show triangle record
        /// </summary>
        /// <returns>triangle data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,24:F2}{2,22:F2} b x {3,4:F2} h", base.Type, CalculateArea(), triangle_base, triangle_height);
        }
    }
}
