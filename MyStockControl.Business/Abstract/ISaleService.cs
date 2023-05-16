using MyStockControl.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.Business.Abstract
{
    public interface ISaleService
    {
        List<Sale> GetAll();
        Sale GetById(int id);
        Sale GetByCustomerId(int customerId);
        void AddSale(Sale sale);
        void UpdateSale(Sale sale);
        void DeleteSale(Sale sale);
    }
}
