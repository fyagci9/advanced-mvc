﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();
        void AdminAdd(Admin admin);

        Admin GetByID(int id);
        void adminDelete(Admin admin);
        void adminUpdate(Admin admin);
    }
}
