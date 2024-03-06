using DataAccess.Abstract;
using DataAccess.EntitiyFramework;
using Entitiy.Abstract;
using Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var addedEntity = courseDatabase.Add(category);
            addedEntity.State = EntityState.Added;
            courseDatabase.SaveChanges();

        }

        public void Delete(Category category)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var deletedEntitiy = courseDatabase.Remove(category);
            deletedEntitiy.State = EntityState.Deleted;
            courseDatabase.SaveChanges();
        }

        public List<Category> GetAll()
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            return courseDatabase.Set<Category>().ToList();
        }

        public Category GetCourse(int id)
        {
            CourseDatabase courseDatabase = new CourseDatabase();

            return courseDatabase.Set<Category>().FirstOrDefault(c => c.Id == id);
        }

        public void Update(Category category)
        {
            CourseDatabase courseDatabase = new CourseDatabase();
            var updatedEntity = courseDatabase.Entry(category);
            updatedEntity.State = EntityState.Modified;
            courseDatabase.SaveChanges();
        }
    }
}
