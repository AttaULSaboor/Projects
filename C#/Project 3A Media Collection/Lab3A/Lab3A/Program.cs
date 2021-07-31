using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Prepared by : Atta ul Saboor
 * Date : November 1, 2020
 * 
 * Program Purpose:
 * The purpose of this program is to make interface of IEncryptable, Isearchable and media. 
 * Creates additional classes drived from media Book, Movie and song. The main Class has method 
 * Called ReadDatat() also show the user menu and error checking.
 * 
 * 
 * Statement of Authorship:
 * I, Atta UL Saboor, certify that this material is  my original work. No ohter 
 * person's work has been used without acknowledgement.
 * 
 */

namespace Lab3A
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = 0;					// store user input
			string searchTerm = "";         // store search key word
			bool exitLoop = false;          // loop exit flag
			bool isValidInput = true;       // valid input flag	

			do
			{
				exitLoop = false;           //rearrange loop exit flag
				isValidInput = true;        //rearrange valid input flag

				//show the options
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine("Saboor's Media Collection");
				Console.WriteLine("=========================");
				Console.ResetColor();
				Console.WriteLine("1. List All Books");
				Console.WriteLine("2. List All Movies");
				Console.WriteLine("3. List All Songs");
				Console.WriteLine("4. List All Media");
				Console.WriteLine("5. Search All Media by Title\n");
				Console.WriteLine("6. Exit Program\n");
				Console.WriteLine("Enter choice: ");

				try
				{
					//if userinput is valid
					string userInput = Console.ReadLine();
					if (userInput == "")
						isValidInput = false;

					input = int.Parse(userInput);       
				}
				catch (Exception)
				{
					//Console.clear();
					Console.WriteLine("\n**** Invalid Choice - Please Try Again ****");
					isValidInput = false;
				}
				Console.WriteLine();

				ISearchable[] data = new ISearchable[100];      // all media data

				ReadData(data);
				if (isValidInput)
				{
					foreach (ISearchable selectedData in data)
					{
						switch (input)
						{
							case 1:     //list all books
								if (selectedData as Book != null)
									Console.WriteLine(selectedData); break;

							case 2:     //list all movies
								if (selectedData as Movie != null)
									Console.WriteLine(selectedData); break;

							case 3:     //list all songs
								if (selectedData as Song != null)
									Console.WriteLine(selectedData); break;

							case 4:     //list all media
								if (selectedData != null)
									Console.WriteLine(selectedData); break;

							case 5:     //search media
								if (exitLoop == false)
								{
									// ask user for search 
									Console.Write("Enter a search string: ");
									searchTerm = Console.ReadLine();
									Console.WriteLine();

									foreach (ISearchable selectedResults in data)
									{
										//show matched books
										if (selectedResults as Book != null)
											if ((selectedResults as Book).Search(searchTerm))
												Console.WriteLine((selectedResults as Book).SearchFormat());

										//show matched books
										if (selectedResults as Movie != null)
											if ((selectedResults as Movie).Search(searchTerm))
												Console.WriteLine((selectedResults as Movie).SearFormat());

										//show matched songs
										if (selectedResults as Song != null)
											if ((selectedResults as Song).Search(searchTerm))
												Console.WriteLine(selectedResults as Song);
									}
									exitLoop = true;
								}
								break;
							case 6: Environment.Exit(1); break;     

							default:
								input = 0;
								Console.Clear();
								Console.WriteLine("\n**** Invalid Choice - Try Again ****");
								break;
						}
					}
				}
				Console.WriteLine("\nPress any key to continue . . . .");
				Console.ReadLine();
			} while (input != 6);
		}

		public static void ReadData(ISearchable[] data)
		{
			string line = "";       //store the line being read
			int arrayIndex = 0;     // Keeps the array index

			StreamReader fileData = new StreamReader("../../Data.txt");       // file reader object

			//read the file 
			while ((line = fileData.ReadLine()) != null) 
			{
				string[] splitLine = line.Split('|');
				switch (splitLine[0])
				{
					//find a book record
					case "BOOK":
						data[arrayIndex] = new Book(splitLine[1], Convert.ToInt32(splitLine[2]), splitLine[3], readSummary(fileData));
						arrayIndex++;
						break;

					//find a movie record
					case "MOVIE":
						data[arrayIndex] = new Movie(splitLine[1], Convert.ToInt32(splitLine[2]), splitLine[3], readSummary(fileData));
						arrayIndex++;
						break;

					//find a song record
					case "SONG":
						data[arrayIndex] = new Song(splitLine[1], Convert.ToInt32(splitLine[2]), splitLine[3], splitLine[4]);
						arrayIndex++;
						break;
				}
			}
		}
		//read summary
		public static string readSummary(StreamReader fileData)
		{
			string summary = "";        // store book summary
			string nextLine = "";       // store the next line

			while (nextLine != "-----")
			{
				nextLine = fileData.ReadLine();     // read next line
				if (nextLine != "-----") { summary = summary + nextLine + "\n"; }
			}
			return summary;
		}
	}
}
