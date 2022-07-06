using NewRepoMODEL.Models;
using NewRepoREPOSITORY.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoREPOSITORY.Repositories
{
    public interface ISubjectRepository : IRepository<Subject>
    {

    }
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(Context context):base(context)
        {

        }
    }
}
