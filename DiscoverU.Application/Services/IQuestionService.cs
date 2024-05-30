
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
        Task<List<GetQuestionDto>> GetAllAsync();
        Task<GetQuestionDto> GetByIdAsync(int id);
        void Add(AddQuestionDto addQuestionDto);
        void Update(UpdateQuestionDto updateQuestionDto);
        Task DeleteAsync(Guid id);
    }
}
