
using DiscoverU.Application.Dtos.QuestionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Services
{
    public interface IQuestionService
    {
        Task<IEnumerable<GetQuestionDto>> GetAllBySurveyIdAsync(Guid surveyId);
        Task<GetQuestionDto> GetByIdAsync(int id);
        Task AddAsync(AddQuestionDto addQuestionDto);
        Task UpdateAsync(UpdateQuestionDto updateQuestionDto);
        Task DeleteAsync(Guid id);

    }
}
