using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepoDTO.StudentDTO;
using NewRepoMODEL.Models;
using NewRepoSERVICE.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewRepoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Student>))]
        public async Task<IActionResult> GetStudentList()
        {
            IEnumerable<Student> student = await _studentService.GetAllStudent();
            return Ok(student);
        }
        [HttpPost]
        [Produces(typeof(Student))]
        public async Task<IActionResult> AddStudent(StudentAddDTO addDTO)
        {
            return Ok(await _studentService.AddStudent(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateStudent(StudentUpdateDTO updateDTO)
        {
            return Ok(await _studentService.UpdateStudent(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<Student> DeleteStudent(int id)
        {
            return await _studentService.DeleteStudent(id);
        }
    }
}
