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
                var subject = new Subject();
                subject.SubjectId = updateDTO.SubjectId;
                subject.SubjectName = updateDTO.SubjectName;
                subject.SubjectLanguage = updateDTO.SubjectLanguage;
                Subject _subject = await GetSubjectById(subject.SubjectId);
                if (_subject != null)
                {
                    _subject.SubjectName = subject.SubjectName;
                    _subject.SubjectLanguage = subject.SubjectLanguage;
                    await _subjectRepository.Update(_subject);
                }
                return subject;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
