using MyStockControl.Core.BaseApplications;
using MyStockControl.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.DataAccess.Dal.Abstract
{
    public interface ISaleDal:IEntityRepository<Sale>
    {
    }
}
