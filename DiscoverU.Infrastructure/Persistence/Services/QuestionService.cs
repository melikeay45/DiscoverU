using DiscoverU.Application.Dtos.QuestionDto;
using DiscoverU.Application.Services;
using DiscoverU.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DiscoverU.Infrastructure.Persistence.Services
{
    public class QuestionService : IQuestionService
    {
        public readonly DiscoverUDbContext _dbContext;

        public QuestionService (DiscoverUDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(AddQuestionDto addQuestionDto)
        {
            if (addQuestionDto == null) throw new ArgumentNullException(nameof(addQuestionDto));

            var question = AddQuestionDto.MapToQuestion(addQuestionDto);

             _dbContext.AddAsync(question);

            await _dbContext.SaveChangesAsync();

        }


        public async Task DeleteAsync(Guid id)
        {
            var question = await _dbContext.Question.FirstOrDefaultAsync(question => question.Id == id);
            if (question != null)
            {
                question.IsDelete = true;
                await _dbContext.SaveChangesAsync();
            }
        }


        public async Task<IEnumerable<GetQuestionDto>> GetAllBySurveyIdAsync(Guid surveyId)
        {
            var questions=_dbContext.Question.Where(question => question.IsDelete! && question.SurveyId==surveyId).ToList();

            var getQuestionDtos = questions.Select(question => GetQuestionDto.MapToGetQuestionDto(question));

            return await Task.FromResult(getQuestionDtos);
        }

        public Task<GetQuestionDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }


        public async Task UpdateAsync(UpdateQuestionDto updateQuestionDto)
        {
            var question = await _dbContext.Question.FirstOrDefaultAsync(question => question.Id == updateQuestionDto.Id);

            if (question != null)
            {
                question.Text = updateQuestionDto.Text;
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
