using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Service
{
    public class S_UserService
    {
        private R_UserRepository _userRepository = new R_UserRepository();

        public M_user? GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public M_user GetByUsername(string username)
        {
            return _userRepository.GetByUsername(username);
        }

        public M_user GetByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public M_user? Login(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);
            if (user == null) return null;
            SE_userSession.id_user = user._id_user;
            SE_userSession.username = user.username;
            SE_userSession.email = user.email;
            SE_userSession.no_telp = user.no_telepon;
            SE_userSession.role = user.role;

            return user;
        }

        public bool Register(string username, string password, string no_telp, string email)
        {
            //---VALUDASI USERNAME
            if (username.Length < 4)
            {
                MessageBox.Show("Username harus lebih dari 4 karater!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //---VALUDASI PASSWORD
            if (password.Length < 5)
            {
                MessageBox.Show("Password harus lebih dari 5 karater!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //---VALIDASI EMAIL
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email TIdak Valid!","Invalid",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_userRepository.GetUserByEmail(email) != null) 
            {
                MessageBox.Show("Email sudah terpakai. Silahkan gunakan email lain!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_userRepository.GetByUsername(username) != null)
            {
                MessageBox.Show("Username sudah terpakai. Silahkan gunakan email lain!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //---VALUDASI NO TELP
            if (no_telp.Length<10 || no_telp.Length > 15 || !no_telp.All(char.IsDigit))
            {
                MessageBox.Show("No telp Tidak Valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_userRepository.GetByNotelp(no_telp)!= null)
            {
                MessageBox.Show("No telp sudah terpakai", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _userRepository.Register(new M_user
            {
                username = username,
                password = password,
                no_telepon  = no_telp,
                email = email
            });
            return true;
        }
        public bool UpdateUser(M_user user) 
        {
            int id=  SE_userSession.id_user;
            M_user datalama = _userRepository.GetById(id);
            if(datalama == null)
            {
                MessageBox.Show("Data tidak ditemukan!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //--VALIDASI USERNAME
            if(!string.IsNullOrEmpty(user.username))
            {
                if (user.username.Length < 4)
                {
                    MessageBox.Show("Username harus lebih dari 4 karater!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                datalama.username = user.username;
            }
            //--VALIDASI EMAIL
            if (!string.IsNullOrEmpty(user.email))
            {
                if (!user.email.Contains("@"))
                {
                    MessageBox.Show("Email TIdak Valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                datalama.email = user.email;
            }
            //--VALIDASI Telepon
            if (!string.IsNullOrEmpty(user.no_telepon))
            {
                if(user.no_telepon.Length < 10 || user.no_telepon.Length > 15 || !user.no_telepon.All(char.IsDigit))
                {
                    MessageBox.Show("No telp Tidak Valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                datalama.no_telepon = user.no_telepon;
            }
            //--VALIDASI PASSWORD
            if (!string.IsNullOrEmpty(user.password))
            {
                datalama.password = user.password;
            }

            _userRepository.UpdateUser(datalama);
            return true;
        }
        public void Delete(M_user user) { }
        public List<M_user> GetAllCust() 
        {
        return _userRepository.GetAllCust();
        }


    }
}
