using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonThreadOperation.Model;

namespace REST_Services
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        void CreateUser(User user);
    }
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;
        public UserRepository(DbContext context)
        {
            _context = context;
        }
        public UserRepository GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
