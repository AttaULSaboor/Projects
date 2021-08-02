using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment2.Models
{
	public class PurchaseDateValidation : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			var PurchaseDate = Convert.ToDateTime(value);
			return PurchaseDate <= DateTime.Now;
		}
	}
}
