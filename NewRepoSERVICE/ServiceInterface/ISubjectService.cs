using NewRepoDTO.SubjectDTO;
using NewRepoMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoSERVICE.ServiceInterface
{
    public interface ISubjectService
    {
        Task<IEnumerable<Subject>> GetAllSubject();
        Task<Subject> GetSubjectById(int id);
        Task<Subject> AddSubject(SubjectAddDTO addDTO);
        Task<Subject> UpdateSubject(SubjectUpdateDTO updateDTO);
        Task<Subject> DeleteSubject(int id); 
    }
}
