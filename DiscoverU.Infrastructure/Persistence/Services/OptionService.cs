using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Application.Services;
using DiscoverU.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DiscoverU.Infrastructure.Persistence.Services
{
    public class OptionService:IOptionService
    {
        public readonly DiscoverUDbContext _dbContext;

        public OptionService(DiscoverUDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(ICollection<AddOptionDto> addOptionDtos)
        {

            foreach (var addOption in addOptionDtos)
            {
                var newOption = AddOptionDto.MapToOption(addOption);


                _dbContext.Options.Add(newOption);
            }
            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(Guid id)
        {
            var option = await _dbContext.Options.FirstOrDefaultAsync(option => option.Id == id);
            if (option != null)
            {
                option.IsDelete= true;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<GetOptionDto>> GetAllByQuestionIdAsync(Guid questionId)
        {
            var options = _dbContext.Options.Where(option => option.IsDelete==false && option.QuestionId == questionId).ToList();

            var getOptionDtos= options.Select(option => GetOptionDto.MapToGetOptionDto(option));

            return await Task.FromResult(getOptionDtos);
        }


        public Task<GetOptionDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        public async Task UpdateAsync(UpdateOptionDto updateOptionDto)
        {
            var option= _dbContext.Options.FirstOrDefault(option=>option.Id == updateOptionDto.Id);

            if(option != null)
            {
                option.Text = updateOptionDto.Text;
            }
            await _dbContext.SaveChangesAsync();
        }


    }
}
