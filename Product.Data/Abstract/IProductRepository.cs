using ProductAPI.Entities.Concrete;
using ProductAPI.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Data.Abstract
{
    public interface IProductRepository:IEntityRepository<Product>
    {
    }
}
