using NewRepoMODEL.Models;
using NewRepoREPOSITORY.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoREPOSITORY.Repositories
{
    public interface ITeacherReposiory : IRepository<Teacher>
    {

    }
    public class TeacherRepository : Repository<Teacher>, ITeacherReposiory
    {
        public TeacherRepository(Context context):base(context)
        {

        }
    }
  
}
