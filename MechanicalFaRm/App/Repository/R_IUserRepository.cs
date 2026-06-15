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
        M_user GetUserByEmail(string email);
        void Register(M_user user);
        void UpdateUser(M_user user);
        void Delete(M_user user);   
        List<M_user> GetAllCust();
    }
}
