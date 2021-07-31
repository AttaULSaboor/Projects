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
    public class Cylinder : Shape
    {
        public double cylinder_radius;      //store cylinder radius
        public double cylinder_height;      //store cylinder height

        /// <summary>
        /// cylinder constructor
        /// call the SetData
        /// </summary>
        public Cylinder()
        {
            this.Type = "Cylinder";
            SetData();
        }

        /// <summary>
        /// ask from user for cylinder radius and height
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Cylinder Radius:");
                cylinder_radius = double.Parse(Console.ReadLine());

                Console.Write("Enter the Cylinder Height:");
                cylinder_height = double.Parse(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("ERROR: Invalid data entered."); Environment.Exit(1); }
        }

        /// <summary>
        /// calculate cylinder area
        /// </summary>
        /// <returns>cylinder area</returns>
        public override double CalculateArea()
        {
            return (2 * Shape.PI * Math.Pow(cylinder_radius, 2)) + (2 * Shape.PI * cylinder_radius * cylinder_height);
        }

        /// <summary>
        /// calculate cylinder volume
        /// </summary>
        /// <returns>cylinder volume</returns>
        public override double CalculateVolume()
        {
            return (Shape.PI * Math.Pow(cylinder_radius, 2) * cylinder_height);
        }

        /// <summary>
        /// show cylinder record
        /// </summary>
        /// <returns>cylinder data</returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,24:F2}{2,16:f2}{3,6:f2} r x {4,4:f2} h", base.Type, CalculateArea(), CalculateVolume(), cylinder_radius, cylinder_height);
        }
    }
}
