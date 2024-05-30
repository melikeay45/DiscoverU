using DiscoverU.Application.Dtos.OptionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.QuestionDto
{
    public class UpdateQuestionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int SurveyId { get; set; }
        public ICollection<UpdateOptionDto> Options { get; set; }
    }
}
