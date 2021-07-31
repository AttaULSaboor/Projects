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
    public class Sphere : Shape
    {
        public double sphere_radius;        //store sphere radius
        
        /// <summary>
        /// sphere constructor
        /// call the SetData
        /// </summary>
        public Sphere()
        {
            this.Type = "Sphere";
            SetData();
        }

        /// <summary>
        /// ask from user for sphere radius
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Sphere Radius:");
                sphere_radius = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered.");Environment.Exit(1); }
        }

        /// <summary>
        /// calculate sphere area
        /// </summary>
        /// <returns>sphere area</returns>
        public override double CalculateArea()
        {
            return (4 * Shape.PI * Math.Pow(sphere_radius, 2));
        }

        /// <summary>
        /// calculate sphere volume
        /// </summary>
        /// <returns>sphere volume</returns>
        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Shape.PI * Math.Pow(sphere_radius, 3);
        }

        /// <summary>
        /// show sphere record 
        /// </summary>
        /// <returns>sphere data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,26:F2}{2,16:F2}{3,6:F2} r", base.Type, CalculateArea(), CalculateVolume(),sphere_radius);
        }
    }
}
