using MyStockControl.Core;
using MyStockControl.Core.BaseApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.Entities.Domain
{
    public class Sale : IEntity
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? Quantity { get; set; }
        public double Price { get; set; }
        public double? TotalPrice { get; set; }
        public Product? Product { get; set; }
        public Customer? Customer { get; set; }
    }
}
