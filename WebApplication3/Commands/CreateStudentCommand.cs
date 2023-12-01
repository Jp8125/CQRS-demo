using MediatR;
using WebApplication3.Models;

namespace WebApplication3.Commands
{
    public class CreateStudentCommand:IRequest<Student>
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Age { get; set; }
        public CreateStudentCommand(string studentName,string studentClass,int studentAge)
        {
            Name = studentName;
            Class = studentClass;
            Age = studentAge;
        }

    }
}
