// See https://aka.ms/new-console-template for more information
using EntityFramWorkExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Runtime.CompilerServices;




TrainingDbContext context = new TrainingDbContext();

//Eagerloading(4);
//Lazyloading(4);
//FindStudentName(2);
//CourseAndStudentData();
//AllCourseDatainOne();
//getAllCourseTopics();
//GetCourseFees(4);

void CourseAndStudentData()
{
    context.Courses.Add(new Course { Name = "Laravel", Fees = 12000, ClassStartDate = DateTime.Now, IsActive = true });
    context.Courses.Add(new Course { Name = "Asp.Net", Fees = 30000, ClassStartDate = DateTime.Now, IsActive = true });
    context.Students.Add(new Student { Name = "Rayhan", CGPA = 2.78 });

    context.SaveChanges();
}



void GetCourseFees(int getFees) {
    Course course = context.Courses.Where(x => x.Id == getFees).FirstOrDefault();
    Console.WriteLine(course.Fees);
}



////course.Fees = 15000;
//context.Courses.Remove(course);

//context.SaveChanges();
//if (course?.CourseTopics == null)
//    course.CourseTopics = new List<Topic>();

//course?.CourseTopics?.AddRange(new Topic[]
//{
//     new Topic {Title="Getting Started" },
//    new Topic { Title ="Tool Installation"}
//});
//context.SaveChanges();

//code breakdown
//if (course!=null && course.CourseTopics!=null)
//{
//    course.CourseTopics = new List<Topic>();
//    Topic topic1 = new Topic();
//    topic1.Title = "Getting Started";
//    Topic topic2 = new Topic();
//    topic2.Title = "Tool Installation";

//    course.CourseTopics.Add(topic1);
//    course.CourseTopics.Add(topic2);
//}



//Eager Loading Method
void Eagerloading(int CourseIde)
{
    Course course2 = context.Courses.Where(x => x.Id == CourseIde) //specific
        .Include(y => y.CourseTopics)
    //    .ThenInclude(z => z.Schedule)  //if use subobject
    //   .Include(y => y.CourseStudents)
        .FirstOrDefault();
    foreach (var topic in course2.CourseTopics)
    {
        Console.WriteLine(topic.Title);
    }
}

void Lazyloading(int CourseIdl)
{
    Course topic = context.Courses.FirstOrDefault(x => x.Id == CourseIdl);

    if (topic != null)
    {
        // Accessing CourseTopics triggers lazy loading
        var t = topic.CourseTopics;

        if (t != null)
        {
            foreach (var item in t)
            {
                Console.WriteLine(item.Title);
            }
        }
        else
        {
            Console.WriteLine("CourseTopics collection is null.");
        }
    }
    else
    {
        Console.WriteLine("No course found with Id=4.");
    }

}

void FindStudentName(int StdId)
{
    Student std = context.Students.Where(c => c.Id == StdId).FirstOrDefault();

    Console.WriteLine(std.Name);
}

void getAllCourseTopics()
{

    List<Course> allCourses = context.Courses     //all
        .Include(y => y.CourseTopics)
        /*.ThenInclude(z => z.Schedule)*/  // if using subobject
                                           //.Include(y => y.CourseStudents)
        .ToList();

    foreach (var course in allCourses)
    {
        foreach (var topic in course.CourseTopics)
        {
            Console.WriteLine(topic.Title);
        }
    }
}

void CourseRemove(int removeIdno)
{
    Course course2 = context.Courses.Where(x => x.Id == removeIdno)
        .Include(y => y.CourseTopics).FirstOrDefault();
    context.Courses.Remove(course2);
    context.SaveChanges();
}



void AllCourseDatainOne()
{
    Course c1 = new Course
    {
        Name = "DevOps",
        Fees = 20000,
        ClassStartDate = DateTime.Now,
        CourseTopics = new List<Topic>
        {
            new Topic { Title = "Docker" },
            new Topic { Title = "AWS" }

        },

        CourseStudents = new List<CourseStudent>
        {
          new CourseStudent{Student = new Student{Name = "Hassan", CGPA = 3.0}},
           new CourseStudent{Student = new Student{Name = "Tareq", CGPA = 3.2}}

        }

    };
    context.Courses.Add(c1);
    context.SaveChanges();
}
