using DiscoverU.Application.Dtos.QuestionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.SurveyDto
{
    public class GetSurveyDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<GetQuestionDto> Questions { get; set; }
    }
    public class GetQuestionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public ICollection<GetOptionDto> Options { get; set; }
    }

    public class GetOptionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
