using DiscoverU.Application.Dtos.OptionDto;
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
        public int SurveyId { get; set; }
        public ICollection<AddOptionDto> Options { get; set; }
    }
    public class AddOptionDto
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
