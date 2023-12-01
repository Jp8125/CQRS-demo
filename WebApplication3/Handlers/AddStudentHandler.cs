using MediatR;
using WebApplication3.Commands;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Handlers
{
    public class AddStudentHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudent _student;

        public AddStudentHandler(IStudent student)
        {
            _student=student;
        }
        public async Task<Student> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student=new Student();
            student.Name = request.Name;
            student.Age = request.Age;
            student.Class = request.Class;
            return await _student.AddStudent(student);
        }
    }
}
