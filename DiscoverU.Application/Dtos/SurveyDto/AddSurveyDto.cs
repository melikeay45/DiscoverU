using DiscoverU.Application.Dtos.QuestionDto;
using DiscoverU.Domain.Entities;
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


        public static Survey MapToSurvey(AddSurveyDto addSurveyDto)
        {
            return new Survey
            {
                Id = Guid.NewGuid(),
                Title = addSurveyDto.Title,
                Description = addSurveyDto.Description,
            };
        }
    }
    
}
