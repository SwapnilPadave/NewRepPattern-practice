using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoDTO.TeacherDTO
{
    public class TeacherUpdateDTO
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Gender { get; set; }
        public int SubjectId { get; set; }
    }
}
