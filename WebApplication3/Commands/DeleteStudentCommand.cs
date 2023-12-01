
using MediatR;

namespace WebApplication3.Commands
{
    public class DeleteStudentCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
