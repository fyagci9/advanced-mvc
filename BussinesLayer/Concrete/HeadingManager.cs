﻿using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x=>x.HeadingID == id);

        }

        public List<Heading> GetList()
        {
            return _headingDal.List();

        }

        public List<Heading> GetListByWriter()
        {
            return _headingDal.List(x => x.WriterID== 4);
        }

        public void headingAdd(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void headingDelete(Heading heading)
        {
           
            _headingDal.Update(heading);
        }

        public void headingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
