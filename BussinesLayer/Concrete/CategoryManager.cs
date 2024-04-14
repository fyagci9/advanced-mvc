using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void categoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void categoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void categoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
           return _categoryDal.Get(x=>x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }



    }
}
