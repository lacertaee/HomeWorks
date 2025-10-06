namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First
            var company1 = new Company("adgilobrivi");
            var emp1 = new Employee("john", "doe", "manager", 21, [9, 8, 8, 8, 8, 2, 0]);

            var percentage = company1.GetPercentage();

            Console.WriteLine($"სახელმწიფო გადასახადებში მიდის {percentage * 100}%");

            var salaryOfEmployee = emp1.GetWeeklySalary();

            Console.WriteLine($"სახელმწიფო გადასახადების გარეშე: {salaryOfEmployee}");
            Console.WriteLine($"სახელმწიფო გადასახადებით: {salaryOfEmployee - salaryOfEmployee*percentage}");
            #endregion

            #region Second
            var student = new Student("luka", 20, 2);
            var teacher = new Teacher("maka", "certified");

            var subject = student.GetRandomSubject();

            var yearsLeft = student.YearsLeft();

            Console.WriteLine($"{student.age} years old {student.name} has {yearsLeft} years left in university");

            Console.WriteLine(teacher.Check(subject));
            #endregion

            #region Third
            //var student = new Student2("luka");
            //student.Working();

            //var goodStudent = new GoodStudent("john");
            //var lazyStudent = new LazyStudent("jane");

            //goodStudent.Working();
            //lazyStudent.Working();

            //var students = new List<Student2> { goodStudent, lazyStudent };

            //var classroom = new ClassRoom(students);

            //classroom.GetStudentMethods();
            #endregion
        }
    }
}
