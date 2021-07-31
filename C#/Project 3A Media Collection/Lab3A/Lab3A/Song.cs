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
	class Song: Media
	{
		public string Album { get; set; }			// store album name
		public string Artist { get; set; }			// store name of the artist

		public Song(string title, int year, string album, string artist): base(title, year)
		{
			this.Album = album;
			this.Artist = artist;
		}
		public override string ToString()
		{
			return string.Format("Song Title: {0} ({1}) \nAlbum: {2} Artist: {3}\n--------------------", base.Title, base.Year, this.Album, this.Artist);
		}
	}
}
