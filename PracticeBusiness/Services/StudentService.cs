using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PracticeBusiness.Models;
using PracticeData;
using PracticeEnties;

namespace PracticeBusiness.Services
{
    public interface IStudentService
    {
        IEnumerable<StudentReadModel> Get(StudentQueryModel queryModel);
        StudentModel? Get(Guid id);
        Guid Create(StudentModel model);
        void Update(StudentModel model);
        void Delete(Guid id);
    }

    public class StudentService(PracticeDbContext context, IMapper mapper) : IStudentService
    {
        public IEnumerable<StudentReadModel> Get(StudentQueryModel queryModel)
        {
            return context.Set<Student>().AsNoTracking()
                .Select(student => new StudentReadModel()
                {
                    Id = student.Id,
                    Name = student.Name,
                    Age = student.Age
                }).AsEnumerable();
        }

        public StudentModel? Get(Guid id)
        {
            return mapper.Map<StudentModel>(context.Set<Student>().Find(id));
        }

        public Guid Create(StudentModel model)
        {
            context.Set<Student>().Add(mapper.Map<Student>(model));
            context.SaveChanges();
            return model.Id;
        }

        public void Update(StudentModel model)
        {
            context.Set<Student>().Update(mapper.Map<Student>(model));
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Set<Student>().Where(s => s.Id == id).ExecuteDelete();
        }
    }
}
