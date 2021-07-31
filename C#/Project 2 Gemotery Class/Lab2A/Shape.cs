using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
  Class:   shape.cs
  Author:  Nicholas J. Corkigian
  Date:    September 4, 2017
  
  purpose: This abstract class is the base class of an object hierarchy
           that describe many other two-demensional and three-deminsional 
           shapes.
    
            as it an abstract class, there can be no instances of it.

            this code is not to be altered.
 */

namespace Lab2A
{
    public abstract class Shape
    {
        public string Type { get; protected set; }                  //The type of shape
        private static int count = 0;                               //Number of instantiated shapes
        protected const double PI = 3.141592653589793;              //Constant value for pi

        //All this constructor does is increment the number of shape instances 
        public Shape()
        {
            count++;
        }
        public abstract double CalculateArea();                         //Calculate the Shape's area (surface area if 3-d)
        public abstract double CalculateVolume();                       //Calculate the Shape's colume (if 3-d)
        public abstract void SetData();                                 //Propmpts the user for dimensions
        public override string ToString() => "";                        //Used for printing Shape data

        //Retrives the current number of Shape instances 
        public static int GetCount()
        {
            return count;
        }
    }
}
