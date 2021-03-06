using NewRepoDTO.SubjectDTO;
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
    public class SubjectService:ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public async Task<Subject> AddSubject(SubjectAddDTO addDTO)
        {
            try
            {
                var subject = new Subject();
                subject.SubjectName = addDTO.SubjectName;
                subject.SubjectLanguage = addDTO.SubjectLanguage;
                await _subjectRepository.Add(subject);
                return subject;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Subject> DeleteSubject(int id)
        {
            Subject subject = await GetSubjectById(id);
            if (subject != null)
            {
                await _subjectRepository.Delete(subject);
                return subject;
            }
            return subject;
        }

        public async Task<IEnumerable<Subject>> GetAllSubject()
        {
            return await _subjectRepository.Get();
        }

        public async Task<Subject> GetSubjectById(int id)
        {
            return await _subjectRepository.GetById(id);
        }

        public async Task<Subject> UpdateSubject(SubjectUpdateDTO updateDTO)
        {
            try
            {              
               
                Subject _subject = await GetSubjectById(updateDTO.SubjectId);
                if (_subject != null)
                {
                    _subject.SubjectId = updateDTO.SubjectId;
                    _subject.SubjectName = updateDTO.SubjectName;
                    _subject.SubjectLanguage = updateDTO.SubjectLanguage;
                    await _subjectRepository.Update(_subject);
                }
                return _subject;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
