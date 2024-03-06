using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {

        ICourseDal _courseDal;


        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);

        }

        public List<Course> GetAll()
        {

            return _courseDal.GetAll();
        }

        public Course GetCourse(int id)
        {
          return _courseDal.GetCourse(id);

        }

        public void Update(Course course)
        {
            _courseDal.Update(course); 
        }
    }
}
