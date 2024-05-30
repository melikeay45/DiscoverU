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
        List<GetOptionDto> GetAll();
        GetOptionDto GetById(Guid id);
        void Add(AddOptionDto addOptionDto);
        void Update(UpdateOptionDto updateOptionDto);
        void Delete(Guid id);
    }
}
