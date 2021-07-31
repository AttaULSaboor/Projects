using System;
using System.Collections.Generic;
using System.IO;
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
    public class Square:Shape
    {
        public double square_length;    //store square length

        /// <summary>
        /// square constructor
        /// call the SetData
        /// </summary>
        public Square()
        {
            this.Type = "Square";
            SetData();
        }
        /// <summary>
        /// ask from user for sqaure length
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Square Length:");
                square_length = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("Error: Invalid data entered."); Environment.Exit(1);}
        }

        /// <summary>
        /// calculate area for square
        /// </summary>
        /// <returns>square area</returns>
        public override double CalculateArea()
        {
            return square_length * square_length;
        }

        /// <summary>
        /// calculate volume for square
        /// </summary>
        /// <returns>square volume</returns>
        public override double CalculateVolume()
        {
            return 0.0;
        }

        /// <summary>
        /// show square record
        /// </summary>
        /// <returns>square data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,26:F2}{2,22:f2} l", base.Type, CalculateArea(),square_length);
        }
    }
}
