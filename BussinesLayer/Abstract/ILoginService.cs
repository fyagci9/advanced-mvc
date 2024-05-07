using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface ILoginService
    {
        List<Admin> GetList();
        void adminAdd(Admin admin);

      
    }
}
