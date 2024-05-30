using DiscoverU.Application.Dtos.SurveyDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Services
{
    public interface ISurveyService
    {
        List<GetSurveyDto> GetAll();
        GetSurveyDto GetById(Guid id);
        void Add(AddSurveyDto addSurveyDto);
        void Update(UpdateSurveyDto updateSurveyDto);
        void Delete(Guid id);
    }
}
