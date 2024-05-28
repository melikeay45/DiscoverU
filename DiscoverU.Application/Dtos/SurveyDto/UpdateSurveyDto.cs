using DiscoverU.Application.Dtos.QuestionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.SurveyDto
{
    public class UpdateSurveyDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<UpdateQuestionDto> Questions { get; set; }
    }
    public class UpdateQuestionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public ICollection<UpdateOptionDto> Options { get; set; }
    }

    public class UpdateOptionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}