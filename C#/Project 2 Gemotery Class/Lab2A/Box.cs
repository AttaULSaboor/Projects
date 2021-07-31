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
    public class Box : Shape
    {
        public double box_length;       //store box length
        public double box_width;        //store box width
        public double box_height;       //store box height 

        /// <summary>
        /// box constructor
        /// call the SetData
        /// </summary>
        public Box()
        {
            this.Type = "Box";
            SetData();
        }
        /// <summary>
        /// ask from user for box length, width, and height
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Box Length:");
                box_length = double.Parse(Console.ReadLine());

                Console.Write("Enter the Box Width:");
                box_width = double.Parse(Console.ReadLine());

                Console.Write("Enter the Box Height:");
                box_height = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// calculate area for box
        /// </summary>
        /// <returns>box area</returns>
        public override double CalculateArea()
        {
            return ((box_length * box_width) + (box_length * box_height) + (box_width * box_height)) * 2.0;
        }

        /// <summary>
        /// calculate volume for box
        /// </summary>
        /// <returns>box volume</returns>
        public override double CalculateVolume()
        {
            return (box_length * box_width) * box_height;
        }

        /// <summary>
        /// show box record
        /// </summary>
        /// <returns>box data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,29:F2}{2,16:F2}{3,6:F2} l x {4,4:F2} w x {5,4:F2} h", base.Type, CalculateArea(), CalculateVolume(), box_length, box_width, box_height);
        }
    }
}
