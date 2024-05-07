using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class LoginManager:ILoginService
    {
        ILoginDal _loginDal;

        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public void adminAdd(Admin admin)
        {
            throw new NotImplementedException();
        }

        List<Admin> ILoginService.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
