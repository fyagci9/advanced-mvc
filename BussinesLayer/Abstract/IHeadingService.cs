using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void headingAdd(Heading heading);

        Heading GetByID(int id);
        void headingDelete(Heading heading);
        void headingUpdate(Heading heading);

    }
}
