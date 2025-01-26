using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBusiness.Models
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
    }

    public class StudentReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class StudentQueryModel
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
