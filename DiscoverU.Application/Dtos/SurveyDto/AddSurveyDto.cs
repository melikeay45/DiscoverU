using DiscoverU.Application.Dtos.QuestionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.SurveyDto
{
    public class AddSurveyDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<AddQuestionDto> Questions { get; set; }
    }
    public class AddQuestionDto
    {
        public string Text { get; set; }
        public ICollection<AddOptionDto> Options { get; set; }
    }

    public class AddOptionDto
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
