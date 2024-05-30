using DiscoverU.Application.Dtos.QuestionDto;
using DiscoverU.Application.Dtos.SurveyDto;
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
            var question = new Question
            {
                Id = Guid.NewGuid(),
                Text = addQuestionDto.Text,
                SurveyId = addQuestionDto.SurveyId,
                Options = addQuestionDto.Options.Select(o => new Option
                {
                    Id = Guid.NewGuid(),
                    Text = o.Text,
                    QuestionId = o.QuestionId,
                }).ToList()
            };

            _dbContext.Question.Add(question);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var question = _dbContext.Question.Find(id);
            if (question == null) return;

            _dbContext.Question.Remove(question);
            _dbContext.SaveChanges();
        }

        public List<GetQuestionDto> GetAll()
        {
            var questions = _dbContext.Question.Include(q => q.Options).ToList();

            return questions.Select(q => new GetQuestionDto
            {
                Id = q.Id,
                Text = q.Text,
                SurveyId = q.SurveyId,
                Options = q.Options.Select(o => new GetOptionDto
                {
                    Id = o.Id,
                    Text = o.Text,
                    QuestionId = o.QuestionId,
                    QuestionText = q.Text
                }).ToList()
            }).ToList();
        }

        public GetQuestionDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public GetQuestionDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateQuestionDto updateQuestionDto)
        {
            throw new NotImplementedException();
        }
    }
}
