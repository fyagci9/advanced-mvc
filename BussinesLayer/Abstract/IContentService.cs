using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingID(int id);
        void contentAdd(Content content);

        Content GetByID(int id);
        void contentDelete(Content content);
        void contentUpdate(Content content);
    }
}
