using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entitiy.Concrete;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());
            courseManager.Add(new Course { CategoryId = 2, CourseName = "C#", Description = " 2 Aylık proje bazlı eğitim kampı", InstructorId = 1 });
            courseManager.Add(new Course { CategoryId = 2, CourseName = "JAVA ", Description = "3 Aylık proje bazlı eğitim kampı", InstructorId = 1 });
            courseManager.Add(new Course { CategoryId = 2, CourseName = "PYTHON & Selenium", Description = "2 Aylık proje bazlı eğitim kampı", InstructorId = 2 });

            foreach (var course in courseManager.GetAll())
            {
                Console.WriteLine("{0},{1},{2},{3}", course.Id, course.CourseName, course.Description, course.InstructorId);

            }
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            categoryManager.Add(new Category { CategoryName = "Tümü" });
            categoryManager.Add(new Category { CategoryName = "Programlama" });

            InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
            ınstructorManager.Add(new Instructor { InstructorFirstName = " Engin", InstructorLastName = "Demiroğ" });
            ınstructorManager.Add(new Instructor { InstructorFirstName = "Halit Enes ", InstructorLastName = " Kalaycı" });



        }

    }
}
