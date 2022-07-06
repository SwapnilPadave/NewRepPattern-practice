using NewRepoDTO.StudentDTO;
using NewRepoMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoSERVICE.ServiceInterface
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetStudentById(int id);
        Task<Student> AddStudent(StudentAddDTO addDTO);
        Task<Student> UpdateStudent(StudentUpdateDTO updateDTO);
        Task<Student> DeleteStudent(int id);
    }
}
