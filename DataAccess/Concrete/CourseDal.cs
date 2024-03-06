using DataAccess.Abstract;
using DataAccess.EntitiyFramework;
using Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {

        public void Add(Course course)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var addedEntity = courseDatabase.Add(course);
            addedEntity.State = EntityState.Added;
            courseDatabase.SaveChanges();
        }

        public void Delete(Course course)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var deletedEntity = courseDatabase.Remove(course);
            deletedEntity.State = EntityState.Deleted;
            courseDatabase.SaveChanges();
        }

        public List<Course> GetAll()
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            return courseDatabase.Set<Course>().ToList();

        }

        public Course GetCourse(int id)
        {
            CourseDatabase courseDatabase = new CourseDatabase();

            return courseDatabase.Set<Course>().SingleOrDefault(p => p.Id == id);
        }

        public void Update(Course course)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var updatedEntity = courseDatabase.Update(course);
            updatedEntity.State = EntityState.Modified;
            courseDatabase.SaveChanges();

        }
    }
}
