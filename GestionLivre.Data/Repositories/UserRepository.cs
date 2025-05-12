using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionLivre.Data.Context;
using GestionLivre.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace GestionLivre.Data.Repositories
{
    public class UserRepository
    {
        private readonly LibraryContext _context;

        public UserRepository(LibraryContext context)
        {
            _context = context;
        }

        public bool ValidateLogin(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return false;

            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }

        public void CreateUser(string username, string password)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            var user = new User { Username = username, PasswordHash = hashedPassword };
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
