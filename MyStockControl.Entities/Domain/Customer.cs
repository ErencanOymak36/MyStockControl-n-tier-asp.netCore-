using MyStockControl.Core.BaseApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.Entities.Domain
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<Sale>? Sales { get; set; }

    }
}
