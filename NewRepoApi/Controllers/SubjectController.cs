using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepoDTO.SubjectDTO;
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
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Subject>))]
        public async Task<IActionResult> GetSubjectList()
        {
            IEnumerable<Subject> subject = await _subjectService.GetAllSubject();
            return Ok(subject);
        }
        [HttpPost]
        [Produces(typeof(Subject))]
        public async Task<IActionResult> AddSubject(SubjectAddDTO addDTO)
        {
            return Ok(await _subjectService.AddSubject(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateSubject(SubjectUpdateDTO updateDTO)
        {
            return Ok(await _subjectService.UpdateSubject(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<Subject> DeleteSubject(int id)
        {
            return await _subjectService.DeleteSubject(id);
        }
    }
}
