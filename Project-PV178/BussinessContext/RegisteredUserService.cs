using Project_PV178.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Project_PV178.BussinessContext
{
    public class RegisteredUserService
    {
        private int _userId;
        private RegisteredUsersDBContext _dbContext = new RegisteredUsersDBContext();

        public static async Task<RegisteredUserService> CreateAsync()
        {
            var registeredUserService = new RegisteredUserService();

            var users = await registeredUserService._dbContext.ReadAllUsersAsync();
            if (users.Count() == 0)
            {
                registeredUserService._userId = 1;
            }
            else
            {
                registeredUserService._userId = users.Last().Id + 1;
            }

            return registeredUserService;
        }

        private RegisteredUserService()
        {
            // Private constructor to prevent creating instances from outside of the class.
        }

        public bool CheckEmailValidation(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CheckEmailUniquenessAsync(string email)
        {
            var users = await _dbContext.ReadAllUsersAsync();

            return await Task.Run(() =>
            {
                foreach (RegisteredUser user in users)
                {
                    if (user.Email == email)
                    {
                        return false;
                    }
                }

                return true;
            });
        }

        public async Task RegisterNewUserAsync(string email, string password, string name, string surname, bool isSuperuser)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            var user = new RegisteredUser(_userId, email, hashedPassword, name, surname, isSuperuser);
            _userId++;

            await _dbContext.AddNewUserAsync(user);
        }

        public async Task<byte[]> GetUsersPasswordHashAsync(string email)
        {
            var users = await _dbContext.ReadAllUsersAsync();

            return await Task.Run(() =>
            {
                return users
                .Where(x => x.Email.Equals(email))
                .First()
                .PasswordHash;
            });
        }

        public async Task<RegisteredUser> IsPasswordCorrectAsync(string email, string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            byte[] originalHash = await GetUsersPasswordHashAsync(email);

            bool areEqual = false;
            if (hashedPassword.Length == originalHash.Length)
            {
                int i = 0;
                while ((i < hashedPassword.Length) && (hashedPassword[i] == originalHash[i]))
                {
                    i++;
                }

                if (i == hashedPassword.Length)
                {
                    areEqual = true;
                }
            }

            if (areEqual)
            {
                var users = await _dbContext.ReadAllUsersAsync();
                return await Task.Run(() =>
                {
                    return users
                    .Where(x => x.Email.Equals(email))
                    .First();
                });  
            }
            else
            {
                return null;
            }
        }

        public async Task<RegisteredUser> UpdateUserAsync(int userId, string newEmail, string newName, string newSurname, string newPassword)
        {
            var users = await _dbContext.ReadAllUsersAsync();
            var user = await Task.Run(() => users
                .Where(x => x.Id == userId)
                .First());

            if (newEmail.Length > 0)
            {
                user.Email = newEmail;
            }

            if (newName.Length > 0)
            {
                user.Name = newName;
            }

            if (newSurname.Length > 0)
            {
                user.Surname = newSurname;
            }

            if (newPassword.Length > 0)
            {
                SHA256 sha256 = SHA256.Create();
                byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(newPassword));
                user.PasswordHash = hashedPassword;
            }

            await _dbContext.UpdateUserAsync(user);

            return user;
        }
    }
}
