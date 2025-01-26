using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PracticeBusiness.Models;
using PracticeEnties;

namespace PracticeBusiness.Mappers
{
    public class StudentMapper : Profile
    {
        public StudentMapper()
        {
            CreateMap<Student, StudentModel>().ReverseMap();
        }
    }
}
