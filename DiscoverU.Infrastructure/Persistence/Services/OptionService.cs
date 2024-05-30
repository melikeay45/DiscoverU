using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Application.Services;
using DiscoverU.Domain.Entities;
using DiscoverU.Infrastructure.Persistence.Contexts;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Infrastructure.Persistence.Services
{
    public class OptionService:IOptionService
    {
        public readonly DiscoverUDbContext _dbContext;

        public OptionService(DiscoverUDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(ICollection<AddOptionDto> addOptionDto)
        {

            foreach (var option in addOptionDto)
            {
                var newOption= new AddOptionDto()
                {
                    Text = option.Text,
                    QuestionId = option.QuestionId,
                };
                
                _dbContext.Add(newOption);
            }          
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetOptionDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetOptionDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateOptionDto updateOptionDto)
        {
            throw new NotImplementedException();
        }

        void IOptionService.Update(UpdateOptionDto updateOptionDto)
        {
            throw new NotImplementedException();
        }
    }
}
