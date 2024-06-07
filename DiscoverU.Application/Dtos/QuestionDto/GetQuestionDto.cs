using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Domain.Entities;
using System.Linq;

namespace DiscoverU.Application.Dtos.QuestionDto
{
    public class GetQuestionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid SurveyId { get; set; }
        public ICollection<GetOptionDto>? Options { get; set; }

        public static GetQuestionDto MapToGetQuestionDto(Question question)
        {
            List<GetOptionDto> options = new List<GetOptionDto>();

            
            var Question= new GetQuestionDto
            {
                Id = question.Id,
                Text = question.Text,
                SurveyId = question.SurveyId,
                Options = question.Options.Select(GetOptionDto.MapToGetOptionDto).ToList(),
            };
            
            return Question;

        }

    }

}
