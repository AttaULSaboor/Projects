using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
	class Movie : Media
	{
		public string Director { get; set; }		// store name of the movie director
		public string Summary { get; set; }			// store movie summary

		public Movie(string title, int year, string director, string summary) : base(title, year)
		{
			base.Year = year;
			this.Director = director;
			this.Summary = summary;
		}
		public string decryptSummary()
		{
			return Rot13Algorithm.Transform(Summary);
		}
		public override string ToString()
		{
			return string.Format("movie Title: {0} ({1})\nDirector: {2}\n---------------------", base.Title, base.Year, this.Director);
		}
		public string SearFormat()
		{
			return string.Format("Movie Title: {0} ({1})\nDirector: {2}\n\n{3}--------------------", base.Title, base.Year, this.Director, decryptSummary());
		}

	}
	
}
