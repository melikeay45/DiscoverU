using DiscoverU.Application.Dtos.QuestionDto;
using DiscoverU.Application.Services;
using DiscoverU.Domain.Entities;
using DiscoverU.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Infrastructure.Persistence.Services
{
    public class QuestionService : IQuestionService
    {
        public readonly DiscoverUDbContext _dbContext;

        public QuestionService (DiscoverUDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(AddQuestionDto addQuestionDto)
        {
            if (addQuestionDto == null) throw new ArgumentNullException(nameof(addQuestionDto));

            var question = AddQuestionDto.MapToQuestion(addQuestionDto);

             _dbContext.AddAsync(question);

        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetQuestionDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetQuestionDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateQuestionDto updateQuestionDto)
        {
            throw new NotImplementedException();
        }

        
    }
}
