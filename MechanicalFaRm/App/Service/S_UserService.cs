using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Service
{
    internal class S_UserService : S_IUserService
    {
        private R_UserRepository _userRepository = new R_UserRepository();

        public M_user? GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public M_user GetByUsername(string username)
        {

        }

        public M_user? Login(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);
            if (user == null) return null;
            SE_userSession.id_user = user._id_user;
            SE_userSession.userName = user.username;
            SE_userSession.email = user.email;
            SE_userSession.role = user.role;

            return user;
        }
        public void Create(M_user user);
        public void Update(M_user user);
        public void Delete(M_user user);
        public List<M_user> GetAllUser();
    }
}
