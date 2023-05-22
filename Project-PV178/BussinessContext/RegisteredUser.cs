using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PV178.BussinessContext
{
    public class RegisteredUser
    {
        public int Id { get; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsSuperuser { get; }

        public RegisteredUser(int id, string email, byte[] passwordHash, string name, string surname, bool isSuperuser)
        {
            Id = id;
            Email = email;
            PasswordHash = passwordHash;
            Name = name;
            Surname = surname;
            IsSuperuser = isSuperuser;
        }
    }
}
