using DataAccess.Abstract;
using DataAccess.EntitiyFramework;
using Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        public void Add(Instructor ınstructor)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var addedEntity = courseDatabase.Add(ınstructor);
            addedEntity.State = EntityState.Added;
            courseDatabase.SaveChanges();

        }

        public void Delete(Instructor ınstructor)
        {
           CourseDatabase courseDatabase = new CourseDatabase();
            var deletedEntity = courseDatabase.Remove(ınstructor);
            deletedEntity.State = EntityState.Deleted;
            courseDatabase.SaveChanges();


        }

        public List<Instructor> GetAll()
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            return courseDatabase.Set<Instructor>().ToList();

        }

        public Instructor GetCourse(int id)
        {
            CourseDatabase courseDatabase = new CourseDatabase();

            return courseDatabase.Set<Instructor>().SingleOrDefault(p => p.Id == id);
        }

        public void Update(Instructor ınstructor)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var updatedEntity = courseDatabase.Update(ınstructor);
            updatedEntity.State = EntityState.Modified;
            courseDatabase.SaveChanges();

        }
    }
}
