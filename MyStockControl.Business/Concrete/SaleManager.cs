using MyStockControl.Business.Abstract;
using MyStockControl.DataAccess.Dal.Abstract;
using MyStockControl.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.Business.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;
        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }
        public void AddSale(Sale sale)
        {
            _saleDal.Add(sale);
        }

        public void DeleteSale(Sale sale)
        {
            _saleDal.Delete(sale);
        }

        public List<Sale> GetAll()
        {
            return _saleDal.GetAll();
        }

        public Sale GetByCustomerId(int customerId)
        {
           return _saleDal.Get(s=>s.CustomerId == customerId);
        }

        public Sale GetById(int id)
        {
           return _saleDal.Get(s=>s.SaleId == id);
        }

        public void UpdateSale(Sale sale)
        {
            _saleDal.Update(sale);
        }
    }
}
