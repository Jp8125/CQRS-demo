using MediatR;

namespace WebApplication3.Commands
{
    public class UpdateStudentCommand:IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Age { get; set; }
        public UpdateStudentCommand(int id,string studentName,string studentClass,int studentAge)
        {
            Id = id;
            Name = studentName;
            Class = studentClass;
            Age = studentAge;
        }

    }
}
