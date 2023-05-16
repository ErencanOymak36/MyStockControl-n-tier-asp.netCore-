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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
           _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
           return _customerDal.Get(c=>c.CustomerId == id);
        }

        public Customer GetByName(string name)
        {
            return _customerDal.Get(c=>c.FirstName == name);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
