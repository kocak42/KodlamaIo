using DataAccess.Abstract;
using DataAccess.Core.DataAccess.EntityFrameWork;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFrameWork
{
    public class EfInstractorDal:EfEntitiyRepositoryBase<Instructor,KodlamaIoContext>,IInstructorDal
    {
    }
}
