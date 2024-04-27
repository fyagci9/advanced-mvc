using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void aboutAdd(About about);

        About GetByID(int id);
        void aboutDelete(About abouty);
        void aboutUpdate(About about);

    }
}
