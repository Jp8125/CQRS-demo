using WebApplication3.Models;

namespace WebApplication3.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        public Task<IEnumerable<T>> GetallStudents();
        public Task<T> GetStudent(int id);
        public Task<T> AddStudent(T item);
        public Task<int> UpdateStudent(T item);
        public Task<int> DeleteStudent(int id);

    }
}
