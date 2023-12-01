using MediatR;
using WebApplication3.Models;

namespace WebApplication3.Queries
{
    public class GetStudetByIdQuery:IRequest<Student>
    {
        public int id { get; set; }
    }
}
