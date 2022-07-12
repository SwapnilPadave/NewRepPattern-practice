using NewRepoDTO.TeacherDTO;
using NewRepoMODEL.Models;
using NewRepoREPOSITORY.Repositories;
using NewRepoSERVICE.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoSERVICE.Services
{
    public class TeacherService:ITeacherService
    {
        private readonly ITeacherReposiory _teacherReposiory;
        public TeacherService(ITeacherReposiory teacherReposiory)
        {
            _teacherReposiory = teacherReposiory;
        }

        public async Task<Teacher> AddTeacher(TeacherAddDTO addDTO)
        {
            try
            {
                var teacher = new Teacher();
                teacher.TeacherName = addDTO.TeacherName;
                teacher.Gender = addDTO.Gender;
                teacher.SubjectId = addDTO.SubjectId;
                await _teacherReposiory.Add(teacher);
                return teacher;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Teacher> DeleteTeacher(int id)
        {
            Teacher teacher = await GetTeacherById(id);
            if (teacher != null)
            {
                await _teacherReposiory.Delete(teacher);
                return teacher;
            }
            return teacher;
        }

        public async Task<IEnumerable<Teacher>> GetAllTeacher()
        {
            return await _teacherReposiory.Get();
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            return await _teacherReposiory.GetById(id);
        }

        public async Task<Teacher> UpdateTeacher(TeacherUpdateDTO updateDTO)
        {
            try
            {  
                Teacher _teacher = await _teacherReposiory.GetById(updateDTO.TeacherId);
                if (_teacher != null)
                {
                    _teacher.TeacherId = updateDTO.TeacherId;
                    _teacher.TeacherName = updateDTO.TeacherName;
                    _teacher.Gender = updateDTO.Gender;
                    _teacher.SubjectId = updateDTO.SubjectId;
                    await _teacherReposiory.Update(_teacher);
                }
                return _teacher;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
