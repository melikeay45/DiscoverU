using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return new GetQuestionDto
            {
                Id = question.Id,
                Text = question.Text,
                SurveyId= question.SurveyId,
                SurveyTitle = question.Survey.Title,
            };

        }

    }
    
}
