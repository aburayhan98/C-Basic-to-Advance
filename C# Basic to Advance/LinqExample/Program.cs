
using LinqExample;

List<Course> courses = new List<Course>();

courses.Add(new Course() { Id = 1, Fees = 8000, Title="C#"});
courses.Add(new Course() {Id=2, Fees = 10000, Title = "Java"});
courses.Add(new Course() { Id = 3, Fees = 5000, Title = "Python" });

List<Student> students = new List<Student>();
students.Add(new Student() { Id = 1,  Name = "Jalaluddin", CourseId = 2});
students.Add(new Student() { Id = 2, Name = "Tareq",CourseId = 2});
students.Add(new Student() { Id = 3, Name = "Hasan", CourseId = 3 });

var query = from s in students
            join c in courses on s.CourseId equals c.Id
            select (name: s.Name, fees: c.Fees);

var name = (from q in query
           where q.fees > 5000
           select q.name).FirstOrDefault();
var name2 = query.Where(x => x.fees > 5000).Select(y => y.name).FirstOrDefault();

Console.WriteLine(name);
Console.WriteLine(name2);