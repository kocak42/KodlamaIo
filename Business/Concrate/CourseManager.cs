using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFrameWork;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
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
            return new List<Course>(_courseDal.GetAll());
        }

        public Course GetById(int id)
        {
            return _courseDal.Get(cr => cr.CourseId == id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
