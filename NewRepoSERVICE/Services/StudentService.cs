using NewRepoDTO.StudentDTO;
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
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> AddStudent(StudentAddDTO addDTO)
        {
            try
            {
                var student = new Student();
                student.FirstName = addDTO.FirstName;
                student.LastName = addDTO.LastName;
                student.Gender = addDTO.Gender;
                student.Email = addDTO.Email;
                student.TeacherId = addDTO.TeacherId;
                await _studentRepository.Add(student);
                return student;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Student> DeleteStudent(int id)
        {
            Student student = await GetStudentById(id);
            if (student != null)
            {
                await _studentRepository.Delete(student);
                return student;
            }
            return student;
        }

        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            return await _studentRepository.Get();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _studentRepository.GetById(id);
        }

        public async Task<Student> UpdateStudent(StudentUpdateDTO updateDTO)
        {
            try
            {                
                               
                Student _student = await GetStudentById(updateDTO.RollNo);
                if (_student != null)
                {
                    _student.RollNo = updateDTO.RollNo;
                    _student.FirstName = updateDTO.LastName;
                    _student.Gender = updateDTO.Gender;
                    _student.Gender = updateDTO.Gender;
                    _student.Email = updateDTO.Email;
                    _student.TeacherId = updateDTO.TeacherId;
                    await _studentRepository.Update(_student);
                }
                return _student;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
