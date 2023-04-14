using Northwind.DataAcces.Concrete;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAll()
        {
            //bussiness code
            
            return _productDal.GetAll();
        }
    }
}
