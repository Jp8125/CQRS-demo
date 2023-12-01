using MediatR;
using WebApplication3.Commands;
using WebApplication3.Interfaces;

namespace WebApplication3.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudent _student;

        public DeleteStudentHandler(IStudent student)
        {
            _student=student;
        }
        public Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            return _student.DeleteStudent(request.Id);
        }
    }
}
