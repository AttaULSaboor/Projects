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
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapees = new Shape[100];

            String userInput = "";

            do
            {
                int shapeIndex = Shape.GetCount();

                // title in green color
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Saboor's Geometry Class:");
                Console.ResetColor();

                // the options menu
                Console.WriteLine("A - Rectangle        E - Ellipse        I - Triangle");
                Console.WriteLine("B - Square           F - Circle         J - Tetrahedron");
                Console.WriteLine("C - Box              G - Cylinder");
                Console.WriteLine("D - Cube             H - Sphere\n\n");
                Console.WriteLine("0 - List all shapes and Exit...\n\n");
                Console.WriteLine("\t \t \t \t ({0}) shapes entered so far) \rEnter your choice: ", shapeIndex);

                //add user input
                userInput = Console.ReadLine();
                Console.WriteLine("");

                if (userInput.ToUpper() == "A")
                {
                    shapees[shapeIndex] = new Rectangle();
                }
                else if (userInput.ToUpper() == "B")
                {
                    shapees[shapeIndex] = new Square();
                }
                else if (userInput.ToUpper() == "C")
                {
                    shapees[shapeIndex] = new Box();
                }
                else if (userInput.ToUpper() == "D")
                {
                    shapees[shapeIndex] = new Cube();
                }
                else if (userInput.ToUpper() == "E")
                {
                    shapees[shapeIndex] = new Ellipse();
                }
                else if (userInput.ToUpper() == "F")
                {
                    shapees[shapeIndex] = new Circle();
                }
                else if (userInput.ToUpper() == "G")
                {
                    shapees[shapeIndex] = new Cylinder();
                }
                else if (userInput.ToUpper() == "H")
                {
                    shapees[shapeIndex] = new Sphere();
                }
                else if (userInput.ToUpper() == "I")
                {
                    shapees[shapeIndex] = new Triangle();
                }
                else if (userInput.ToUpper() == "J")
                {
                    shapees[shapeIndex] = new Tetrahedron();
                }
                else if (userInput.ToUpper()=="0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nThat is not a valid choice, please try again\n");
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadLine();
                }
            } while (userInput != "0" && Shape.GetCount() < 100);

            // the output table
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saboor's Geometry Class:\n");
            Console.ResetColor();

            // the objects in shapees array
            Console.WriteLine("There are {0} objects:\n", Shape.GetCount());

            // the table title
            Console.WriteLine("Shape            Area            Volume          Details");
            Console.WriteLine("================ =============== =============== ====================================================");

            // the record in shapees array
            for(int i = 0; i < Shape.GetCount(); i++)
            {
                Console.WriteLine(shapees[i].ToString());
            }
            Console.WriteLine("\nPress any key to exit . . .");
            Console.ReadLine();
        }
    }
}
