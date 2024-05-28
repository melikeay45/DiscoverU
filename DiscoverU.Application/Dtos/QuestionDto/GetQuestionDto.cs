using DiscoverU.Application.Dtos.OptionDto;
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
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public ICollection<GetOptionDto> Options { get; set; }
    }
    public class GetOptionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
