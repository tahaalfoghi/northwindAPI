using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace northwindAPI.Data.ModelDTO
{
    public class ProductDTO
    {
        public int ProductId {get; set;}
        public string ProductName { get; set; } = null!;

        public int? SupplierId { get; set; }

        public int? CategoryId { get; set; }

        public string? QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

    }
}