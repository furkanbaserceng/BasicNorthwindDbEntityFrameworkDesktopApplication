using BasicNorthwindDbEntityFrameworkDesktopApplication.DataAccess.Abstract;
using BasicNorthwindDbEntityFrameworkDesktopApplication.DataAccess.Concrete.Context;
using BasicNorthwindDbEntityFrameworkDesktopApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNorthwindDbEntityFrameworkDesktopApplication.DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (NorthwindContext context=new NorthwindContext())
            {

                return context.Products.ToList();

            }
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                return context.Products.Where(p => p.CategoryId == categoryId).ToList();

            }
        }

        public List<Product> SearchByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                return context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList(); //keye de .tolower() verilirse arama kutusuna birşey yazılıp silindiğinde boş döndürür.if tbxSarchName nullsa diye kontrol ettirilip tüm ürünleri çağıran metod çağrılabilir.

            }
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        
    }
}
