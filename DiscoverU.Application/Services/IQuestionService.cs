
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
        List<GetQuestionDto> GetAll();
        GetQuestionDto GetById(Guid id);
        void Add(AddQuestionDto addQuestionDto);
        void Update(UpdateQuestionDto updateQuestionDto);
        void Delete(Guid id);
    }
}
