using Microsoft.EntityFrameworkCore;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Repositroy
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        private readonly DbSet<T> _dbset;
        private readonly CqrsDemoContext _context;

        public GenericRepository(CqrsDemoContext context)
        {
            _dbset=context.Set<T>();
            _context=context;
        }
        public async Task<T> AddStudent(T item)
        {
            var result=await _dbset.AddAsync(item);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudent(int id)
        {
            var item=await _dbset.FindAsync(id);
            _dbset.Remove(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetallStudents()
        {
            return  await _dbset.ToListAsync();
        }

        public async Task<T> GetStudent(int id)
        {
            var stud=await _dbset.FindAsync(id);
            return stud;
        }

        public async Task<int> UpdateStudent(T item)
        {
             _dbset.Update(item);
           return await _context.SaveChangesAsync();
        }
    }
}
