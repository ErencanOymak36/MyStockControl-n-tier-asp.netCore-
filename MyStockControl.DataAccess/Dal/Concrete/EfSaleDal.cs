using MyStockControl.Core.BaseApplications;
using MyStockControl.DataAccess.Context;
using MyStockControl.DataAccess.Dal.Abstract;
using MyStockControl.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.DataAccess.Dal.Concrete
{
    public class EfSaleDal:EfRepositoryBase<Sale, MyStockControlContext>,ISaleDal
    {
    }
}
