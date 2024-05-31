using DiscoverU.Application.Dtos.OptionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Services
{
    public interface IOptionService
    {
        Task<IEnumerable<GetOptionDto>> GetAllByQuestionIdAsync(Guid questionId);
        Task<GetOptionDto> GetByIdAsync(Guid id);
        Task AddAsync(ICollection<AddOptionDto> addOptionDtos);
        Task UpdateAsync(UpdateOptionDto updateOptionDto);
        Task DeleteAsync(Guid id);
    }
}
