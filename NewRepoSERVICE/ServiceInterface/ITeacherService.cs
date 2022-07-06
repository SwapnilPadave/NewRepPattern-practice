using NewRepoDTO.TeacherDTO;
using NewRepoMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoSERVICE.ServiceInterface
{
    public interface ITeacherService
    {
        Task<IEnumerable<Teacher>> GetAllTeacher();
        Task<Teacher> GetTeacherById(int id);
        Task<Teacher> AddTeacher(TeacherAddDTO addDTO);
        Task<Teacher> UpdateTeacher(TeacherUpdateDTO updateDTO);
        Task<Teacher> DeleteTeacher(int id);
    }
}
