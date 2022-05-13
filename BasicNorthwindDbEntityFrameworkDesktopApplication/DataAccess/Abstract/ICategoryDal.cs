using BasicNorthwindDbEntityFrameworkDesktopApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNorthwindDbEntityFrameworkDesktopApplication.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        



    }
}
