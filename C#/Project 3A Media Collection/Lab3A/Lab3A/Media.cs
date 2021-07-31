using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
	Class:	Media.cs
	Author: Nicholas J. Corkigian
	Date:	October 5, 2017
	
			This code is not to be altered.
 */

namespace Lab3A
{
	/// <summary>
	/// Purpose: This abstract class represents a single object of a media type,
	///			 be it something like a book, movie, or song.
	///			 
	///			 Other classses must be derived from this class.
	///			 
	///			 Because it implements the Isearchable interface, all derived
	///			 Classes will also need to implement the methods of that
	///			 interface as well.
	/// </summary>
	
	public abstract class Media: ISearchable
	{
		public string Title { get; protected set; }			//Title of the media object
		public int Year { get; protected set; }				//The year this media object was released

		/// <summary>
		/// Two-argument constructor sets the two properties that all media objects have 
		/// </summary>
		/// <param name="title">The title of the media objects</param>
		/// <param name="year">The year of publication and/or release</param>
		
		public Media(string title, int year)
		{
			Title = title;
			Year = year;
		}

		#region Isearchable

		/// <summary>
		/// All Media objects are searchable on their Tilte property.
		/// 
		/// For an individual Media objects, this means that given a string as a
		/// search key, the Search() method will either locate that string in
		/// the Title property or it will not.
		/// 
		/// If not overriden, this method can be used by all derived classes 'as is'.
		/// </summary>
		/// <param name="key">The string to be searching for</param>
		/// <returns>A flag indicating whether the search string was found (true) or not (false)</returns>
		
		public bool Search(string key)
		{
			// Make the searh casse insensitive by treating strings as lowercase 
			string temp = Title.ToLower();

			if (temp.IndexOf(key.ToLower()) >= 0)
				return true;		//	Found it
			else
				return false;		//	Didn't find it
		}

		#endregion		// End Isearchable
	}
}
