using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Models
{
	public class Product
	{   [Key]
        public int ProductId { get; set; }
        [Display(Name = "Name")]
        public string ProductName { get; set; }
        [Display(Name = "Supplier Id")]
        public int? SupplierId { get; set; }
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }
        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }
        [Display(Name = "In Stock")]
        public short? UnitsInStock { get; set; }
        [Display(Name = "On Order")]
        public short? UnitsOnOrder { get; set; }
        [Display(Name = "Recorder Level")]
        public short? ReorderLevel { get; set; }
        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; }

        public object Category { get; set; }
        public object Supplier { get; set; }
        public object[] OrderDetails { get; set; }

        public int SelectedCategory { get; set; }
    }
}
