using MechanicalFaRm.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalFaRm.App.Repository
{
    internal interface R_IUserRepository
    {
        M_user GetById(int id);
        M_user GetByEmail(string email);
        void Create(M_user user);
        void Update(M_user user);
        void Delete(M_user user);   
        List<M_user> GetAllUser();
    }
}
