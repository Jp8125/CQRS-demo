using MediatR;
using WebApplication3.Interfaces;
using WebApplication3.Models;
using WebApplication3.Queries;

namespace WebApplication3.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, IEnumerable<Student>>
    {
        private readonly IStudent _student;

        public GetStudentListHandler(IStudent student)
        {
            _student = student;
        }
        public async Task<IEnumerable<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _student.GetallStudents();
        }
    }
}
