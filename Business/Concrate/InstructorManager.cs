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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }
          
        public List<Instructor> GetAll()
        {
            return new List<Instructor>(_instructorDal.GetAll());
           
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get(i=>i.InstructorId == id);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}
