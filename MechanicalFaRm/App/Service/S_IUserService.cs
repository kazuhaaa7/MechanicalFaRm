using MechanicalFaRm.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Service
{
    internal interface S_IUserService
    {
        M_user GetById(int id);
        M_user GetByUsername(string username);
        void Create(M_user user);
        void Update(M_user user);
        void Delete(M_user user);
        List<M_user> GetAllUser();
    }
}
