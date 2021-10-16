using System;
using PS.Template.Domain.Commands;
using Microsoft.EntityFrameworkCore;

namespace PS.Template.AccessData.Commands
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly DBContext _context;
        public GenericsRepository(DBContext dbContext)
        {
            _context = dbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
