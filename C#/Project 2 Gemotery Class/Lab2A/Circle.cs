using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    public class Circle : Shape
    {
        public double circle_radius;        //store circle radius

        /// <summary>
        /// circle constructor
        /// call the SetData
        /// </summary>
        public Circle()
        {
            this.Type = "Circle";
            SetData();
        }

        /// <summary>
        /// ask from user for circle radius
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Circle Radius:");
                circle_radius = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// calculate circle area
        /// </summary>
        /// <returns>circle area</returns>
        public override double CalculateArea()
        {
            return Shape.PI * Math.Pow(circle_radius, 2);
        }

        /// <summary>
        /// calculate circle volume
        /// </summary>
        /// <returns>circle volume</returns>
        public override double CalculateVolume()
        {
            return 0.0;
        }

        /// <summary>
        /// show circle record
        /// </summary>
        /// <returns>circle data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,26:F2}{2,22:f2} r", base.Type, CalculateArea(), circle_radius);
        }
    }
}
