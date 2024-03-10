using System;
using System.Collections.Generic;

namespace DBFirstEFCore.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string Brand { get; set; } = null!;
    }
}
