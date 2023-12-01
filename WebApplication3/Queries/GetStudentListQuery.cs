using MediatR;
using WebApplication3.Models;

namespace WebApplication3.Queries
{
    public class GetStudentListQuery:IRequest<IEnumerable<Student>>
    {
    }
}
