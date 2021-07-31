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
    public class Ellipse : Shape
    {
        public double ellipse_semiMajor_length;     //store ellipse semi major length
        public double ellipse_semiMinor_length;     //store ellipse semi minor length

        /// <summary>
        /// ellipse constructor
        /// call the SetData
        /// </summary>
        public Ellipse()
        {
            this.Type = "Ellipse";
            SetData();
        }

        /// <summary>
        /// ask from user for ellipse semi major length and ellipse semi minor length
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Ellipse Semi-Major Axis Length:");
                ellipse_semiMajor_length = double.Parse(Console.ReadLine());

                Console.Write("Enter the Ellipse Semi-Minor Axis Length:");
                ellipse_semiMinor_length = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// calculate ellipse area
        /// </summary>
        /// <returns>ellipse area</returns>
        public override double CalculateArea()
        {
            return (Shape.PI * ellipse_semiMajor_length) * ellipse_semiMinor_length;
        }

        /// <summary>
        /// calculate ellipse volume
        /// </summary>
        /// <returns>ellipse volume</returns>
        public override double CalculateVolume()
        {
            return 0.0;
        }

        /// <summary>
        /// show ellipse record
        /// </summary>
        /// <returns>ellipse data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,25:F2}{2,22:F2} s.major x {3,5:F2} s.minor", base.Type, CalculateArea(), ellipse_semiMajor_length, ellipse_semiMinor_length) ;
        }
    }

}
