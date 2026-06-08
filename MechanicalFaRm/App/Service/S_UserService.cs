using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Service
{
    internal class S_UserService
    {
        private R_UserRepository _userRepository;

        public M_user? GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
