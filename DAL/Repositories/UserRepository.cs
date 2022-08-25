using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whitely.Controllers;
using Whitely.DAL.Interfaces;
using Whitely.Domain.Models;

namespace Whitely.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public bool Create(User entity)
        {
            entity.Password = EncryptOperations.EncodePasswordToBase64(entity.Password);
            _dbContext.User.Add(entity);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(User entity)
        {
            _dbContext.User.Remove(entity);
            _dbContext.SaveChanges();
            return true;
        }

        public User Get(int id)
        {
            return _dbContext.User.FirstOrDefault(user => user.Id == id);
        }

        public User GetByUsername(string username)
        {
            return (_dbContext.User.FirstOrDefault(user => user.Username == username));
        }

        public List<User> Select()
        {
            return _dbContext.User.ToList();
        }

    }
}
