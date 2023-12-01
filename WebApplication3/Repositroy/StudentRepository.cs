using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Repositroy
{
    public class StudentRepository : GenericRepository<Student>,IStudent
    {
        public StudentRepository(CqrsDemoContext context) : base(context)
        {
        }
    }
}
