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
    public class CategoryDal : ICategoryDal
    {
        public List<Category> GetAll()
        {
            using (NorthwindContext context=new NorthwindContext())
            {

                return context.Categories.ToList();

            }
        }

        
    }
}
