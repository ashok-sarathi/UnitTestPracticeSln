using AutoMapper;
using Moq;
using Moq.EntityFrameworkCore;
using PracticeBusiness.Models;
using PracticeBusiness.Services;
using PracticeData;
using PracticeEnties;
using FluentAssertions;

namespace PracticeBusiness.Test
{
    public class StudentServiceTest
    {
        private readonly Mock<PracticeDbContext> _dbContext;
        private readonly Mock<IMapper> _mapper;
        public StudentServiceTest()
        {
            _dbContext = new Mock<PracticeDbContext>();
        }

        [Fact]
        public void ValidateGetAll()
        {
            _dbContext.Setup(d => d.Set<Student>()).ReturnsDbSet(new List<Student>());
            var studentService = new StudentService(_dbContext.Object, _mapper.Object);

            var result = studentService.Get(new StudentQueryModel());

            result.Should().NotBeNull();
            result.Should().BeEmpty();
        }
    }
}