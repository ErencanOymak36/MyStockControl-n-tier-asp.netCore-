using MyStockControl.Core.BaseApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.Entities.Domain
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public virtual Category? Category { get; set; }
        public ICollection<Sale>? Sales { get; set; }
    }
}
