using DiscoverU.Application.Dtos.OptionDto;
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
        Task<IEnumerable<GetSurveyDto>> GetAllAsync();
        Task<GetSurveyDto> GetByIdAsync(Guid id);
        Task AddAsync(AddSurveyDto addSurveyDto);
        Task UpdateAsync(UpdateSurveyDto updateSurveyDto);
        Task DeleteAsync(Guid id);
    }
}
