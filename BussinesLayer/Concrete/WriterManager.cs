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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public void writerAdd(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void writerDelete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void writerUpdate(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
