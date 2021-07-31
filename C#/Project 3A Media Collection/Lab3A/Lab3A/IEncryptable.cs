using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Interface:	IEncryptable.cs
	Author:		Nicholas J. Corkigian
	Date:		October 05, 2017

	Purpose: This interface has two methods that classes making use of must 
			 implement.

			 This Code is not to be altered.
*/

namespace Lab3A
{
	/// <summary>
	/// The class implementing the Encrypt() method will use some sort 
	/// of encryption algorithm to return some encrypted data.
	/// 
	/// The class implementing the Decrypt() method will use (presumably)
	/// the same encryption algorithm to return a decrypted string.
	/// </summary>
	
	public interface IEncryptable
	{
		string Encrypt();
		string Decrypt();
	}
}
