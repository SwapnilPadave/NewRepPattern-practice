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
                var student = new Student();
                student.RollNo = updateDTO.RollNo;
                student.FirstName = updateDTO.FirstName;
                student.LastName = updateDTO.LastName;
                student.Gender = updateDTO.Gender;
                student.Email = updateDTO.Email;
                student.TeacherId = updateDTO.TeacherId;
                Student _student = await GetStudentById(student.RollNo);
                if (_student != null)
                {
                    _student.FirstName = student.FirstName;
                    _student.LastName = student.LastName;
                    _student.Gender = student.Gender;
                    _student.Email = student.Email;
                    _student.TeacherId = student.TeacherId;
                    await _studentRepository.Update(_student);
                }
                return student;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
