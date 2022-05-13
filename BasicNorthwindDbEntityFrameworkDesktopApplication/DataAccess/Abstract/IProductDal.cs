using BasicNorthwindDbEntityFrameworkDesktopApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNorthwindDbEntityFrameworkDesktopApplication.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        List<Product> SearchByProductName(string key);

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


    }
}
