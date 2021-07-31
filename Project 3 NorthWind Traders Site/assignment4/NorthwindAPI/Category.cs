using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindAPI
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
       // public virtual DbSet<Category> Categories { get; set; }
    }
}
