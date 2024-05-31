using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.QuestionDto
{
    public class AddQuestionDto
    {
        public string Text { get; set; }
        public Guid SurveyId { get; set; }

        public static Question MapToQuestion(AddQuestionDto addQuestionDto)
        {
            return new Question
            {
                Id = Guid.NewGuid(),
                Text = addQuestionDto.Text,
                SurveyId = addQuestionDto.SurveyId,
            };
        }
    }
    
    
}
