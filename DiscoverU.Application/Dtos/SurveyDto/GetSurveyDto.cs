using DiscoverU.Application.Dtos.QuestionDto;
using DiscoverU.Domain.Entities;
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

        public string ImageUrl { get; set; }

        public static GetSurveyDto MapToGetSurveyDto(Survey survey)
        {
            return new GetSurveyDto
            {
                Id = survey.Id,
                Title = survey.Title,
                Description = survey.Description,
                ImageUrl = survey.ImageUrl,
            };

        }
    }
 
}
