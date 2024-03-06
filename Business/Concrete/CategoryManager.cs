using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
           _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
           return _categoryDal.GetAll().ToList();
        }

        public Category GetCourse(int id)
        {
            return _categoryDal.GetCourse(id);
        }

        public void Update(Category category)
        {
           _categoryDal.Update(category);
        }
    }
}
