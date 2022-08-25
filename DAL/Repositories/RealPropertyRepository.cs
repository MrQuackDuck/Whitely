using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Whitely.DAL.Interfaces;
using Whitely.Domain.Models;

namespace Whitely.DAL.Repositories
{
    public class RealPropertyRepository : IRealPropertyRepository
    {
        private ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        public RealPropertyRepository(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _dbContext = context;
            _hostEnvironment = hostEnvironment;
        }
        
        public bool Create(RealProperty entity)
        {
            _dbContext.RealProperty.Add(entity);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(RealProperty entity)
        {
            _dbContext.RealProperty.Add(entity);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(RealProperty entity)
        {
            _dbContext.RealProperty.Remove(entity);
            var filePath = ("wwwroot/img/" + entity.Id + ".jpg");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteImage(int id)
        {
            var filePath = ("wwwroot/img/" + id + ".jpg");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return true;
        }

        public RealProperty Get(int id)
        {
            return _dbContext.RealProperty.FirstOrDefault(property => property.Id == id);
        }

        public List<RealProperty> Select()
        {
            return _dbContext.RealProperty.ToList();
        }

        public RealProperty GetByName(string name)
        {
            return _dbContext.RealProperty.FirstOrDefault(property => property.Title == name);
        }
    }
}