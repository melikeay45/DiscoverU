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
        public string SurveyTitle { get; set; }
        public ICollection<GetOptionDto>? Options { get; set; }

        public static GetQuestionDto MapToGetQuestionDto(Question question)
        {
            List<GetOptionDto> options = new List<GetOptionDto>();

            
            return new GetQuestionDto
            {
                Id = question.Id,
                Text = question.Text,
                SurveyId = question.SurveyId,
                SurveyTitle = question.Survey.Title,
                Options = question.Options.Select(GetOptionDto.MapToGetOptionDto).ToList(),
            };

        }

    }

}
