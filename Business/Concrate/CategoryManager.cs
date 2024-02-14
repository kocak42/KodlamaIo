using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
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
           
            return new List<Category>(_categoryDal.GetAll());
        }

       

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        Category ICategoryService.GetById(int id)
        {

            return _categoryDal.Get(c=>c.CategoryId == id);
        }
    }
}
