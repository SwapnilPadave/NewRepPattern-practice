using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepoDTO.TeacherDTO;
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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Teacher>))]
        public async Task<IActionResult> GetTeacherList()
        {
            IEnumerable<Teacher> teacher = await _teacherService.GetAllTeacher();
            return Ok(teacher);
        }
        [HttpPost]
        [Produces(typeof(Teacher))]
        public async Task<IActionResult> AddTeacher(TeacherAddDTO addDTO)
        {
            return Ok(await _teacherService.AddTeacher(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateTeacher(TeacherUpdateDTO updateDTO)
        {
            return Ok(await _teacherService.UpdateTeacher(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<Teacher> Delete(int id)
        {
            return await _teacherService.DeleteTeacher(id);

        }
    }
}
