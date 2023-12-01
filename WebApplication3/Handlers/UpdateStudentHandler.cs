using MediatR;
using WebApplication3.Commands;
using WebApplication3.Interfaces;

namespace WebApplication3.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IStudent _student;

        public UpdateStudentHandler(IStudent student)
        {
            _student = student;
        }
        public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student =await _student.GetStudent(request.Id);
            if(student == null)
            {
                return  default;
            }
            student.Name = request.Name;
            student.Age = request.Age;
            student.Class = request.Class;
           return await _student.UpdateStudent(student);
        }
    }
}
