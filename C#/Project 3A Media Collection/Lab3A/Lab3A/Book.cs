using System;
using System.Collections.Generic;
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
	class Book : Media
	{
		public string Author { get; set; }		//store author name
		public string Summary { get; set; }		//store book summary

		public Book(string title, int year, string author, string summary): base(title, year)
		{
			this.Author = author;
			this.Summary = summary;
		}
		public string decryptSummary()
		{
			return Rot13Algorithm.Transform(Summary);
		}
		public override string ToString()
		{
			return string.Format("Book Title: {0} ({1}) \nAuthor: [2]\n--------------------", base.Title, base.Year, this.Author);
		}
		public string SearchFormat()
		{
			return string.Format("Book Title: {0} ({1})\nAuthor: {2}\n\n{3}--------------------", base.Title, base.Year, this.Author, decryptSummary());
		}
	}
}
