using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
	class Rot13Algorithm
	{
		/// <summary>
		/// performs the Rot13 algorithm character rotation.
		/// Reference: http://www.dotnetperls.com/rot13
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string Transform(string value)
		{
			char[] array = value.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				int number = (int)array[i];

				if (number >= 'a' && number <= 'z')
				{
					if (number > 'm') number -= 13;
					else number += 13;
				}
				else if (number >= 'A' && number <= 'Z')
				{
					if (number > 'M') number -= 13;
					else number += 13;
				}
				array[i] = (char)number;
			}
			return new string(array);
		}
	}
}
