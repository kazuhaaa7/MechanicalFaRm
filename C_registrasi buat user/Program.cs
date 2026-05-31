using System;

namespace MechanicalFaRm
{
  
    abstract class Akun
    {
        public abstract void Registrasi();
    }

    class UserAccount : Akun
    {
        private string username;
        private string password;
        private string noTelepon;
        private string email;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string NoTelepon
        {
            get { return noTelepon; }
            set { noTelepon = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override void Registrasi()
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("     REGISTRASI BERHASIL");
            Console.WriteLine("=================================");
            Console.WriteLine("Username   : " + Username);
            Console.WriteLine("No Telepon : " + NoTelepon);
            Console.WriteLine("Email      : " + Email);
        }
    }

    class ProgramMechanicalFarm
    {
        static void Main(string[] args)
        {
            UserAccount user = new UserAccount();

            Console.WriteLine("=================================");
            Console.WriteLine("      REGISTER MECHANICALFARM");
            Console.WriteLine("=================================");

            while (true)
            {
                Console.Write("\nUsername   : ");
                user.Username = Console.ReadLine();

                Console.Write("Password   : ");
                user.Password = Console.ReadLine();

                Console.Write("No Telepon : ");
                user.NoTelepon = Console.ReadLine();

                Console.Write("Email      : ");
                user.Email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(user.Username) ||
                    string.IsNullOrWhiteSpace(user.Password) ||
                    string.IsNullOrWhiteSpace(user.NoTelepon) ||
                    string.IsNullOrWhiteSpace(user.Email))
                {
                    Console.WriteLine("\nRegistrasi Gagal!");
                    Console.WriteLine("Semua data wajib diisi.");
                }
                else if (user.Password.Length < 5)
                {
                    Console.WriteLine("\nRegistrasi Gagal!");
                    Console.WriteLine("Password harus minimal 5 karakter.");
                }
                else
                {
                    break;
                }
            }

            user.Registrasi();

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}