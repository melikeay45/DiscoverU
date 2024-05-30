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
        Task<List<GetOptionDto>> GetAllAsync();
        Task<GetOptionDto> GetByIdAsync(Guid id);
        void Add(ICollection<AddOptionDto> addOptionDto);
        void Update(UpdateOptionDto updateOptionDto);
        Task DeleteAsync(Guid id);
    }
}
