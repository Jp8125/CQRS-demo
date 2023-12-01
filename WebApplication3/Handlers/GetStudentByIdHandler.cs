using MediatR;
using WebApplication3.Interfaces;
using WebApplication3.Models;
using WebApplication3.Queries;

namespace WebApplication3.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudetByIdQuery, Student>
    {
        private readonly IStudent _student;

        public GetStudentByIdHandler(IStudent student)
        {
            _student = student;
        }
        public  async Task<Student> Handle(GetStudetByIdQuery request, CancellationToken cancellationToken)
        {
            return await _student.GetStudent(request.id);
        }
    }
}
