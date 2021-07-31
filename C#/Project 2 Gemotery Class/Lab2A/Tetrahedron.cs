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
    public class Tetrahedron : Shape
    {
        public double tetrahedron_length;       //store tetrahedron length

        /// <summary>
        /// tetrahedron constructor
        /// call the SetData
        /// </summary>
        public Tetrahedron()
        {
            this.Type = "Tetrahedron";
            SetData();
        }

        /// <summary>
        /// ask from user for tetrahedron length
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Tetrahedron Length:");
                tetrahedron_length = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// calculate tetrahedron area
        /// </summary>
        /// <returns>tetrahedron area</returns>
        public override double CalculateArea()
        {
            return (Math.Sqrt(3) * Math.Pow(tetrahedron_length, 2));
        }

        /// <summary>
        /// calculate tetrahedron volume
        /// </summary>
        /// <returns>tetrahedron volume</returns>
        public override double CalculateVolume()
        {
            return (Math.Sqrt(2) / 12.0) * Math.Pow(tetrahedron_length, 3);
        }

        /// <summary>
        /// show tetrahedron record
        /// </summary>
        /// <returns>tetrahedron data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,21:F2}{2,16:F2} {3,5:F2} l", base.Type, CalculateArea(), CalculateVolume(), tetrahedron_length);
        }
    }
}
