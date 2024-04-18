﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void writerAdd(Writer writer);
        void writerDelete(Writer writer);
        void writerUpdate(Writer writer);
        Writer GetByID(int id);
    }
}
