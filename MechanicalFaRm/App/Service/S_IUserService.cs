using MechanicalFaRm.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Service
{
    public interface S_IUserService
    {

        M_user GetById(int id);
        public M_user GetByUsername(string username);
        M_user GetByEmail(string email);
        public M_user? Login(string username, string password);
        bool Register(string username, string password, string no_telp, string email);
        bool UpdateUser(M_user user);
        List<M_user> GetAllCust();
    }
}
