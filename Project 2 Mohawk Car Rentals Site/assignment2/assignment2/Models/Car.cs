using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment2.Models
{
	public class Car
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Make { get; set; }
		[Required]
		public string Model { get; set; }
		[Required]
		public string Colour { get; set; }

		public int Year { get; set; }

		[DataType(DataType.Date)]
		[Display(Name ="Purchase Date")]
		[PurchaseDateValidation(ErrorMessage = "Date can't be in future.")]
		public DateTime? PurchaseDate { get; set; }

		[DisplayFormat(DataFormatString = "{0:n0}")]
		[Range(0, 999)]
		public int? Kilometeres { get; set; }
	}
}
