using NewRepoMODEL.Models;
using NewRepoREPOSITORY.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoREPOSITORY.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {

    }
    public class StudentRepository:Repository<Student>,IStudentRepository
    {
        public StudentRepository(Context context):base(context)
        {

        }
    }
}
