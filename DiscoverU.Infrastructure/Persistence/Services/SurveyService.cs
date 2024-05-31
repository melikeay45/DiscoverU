using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Application.Dtos.SurveyDto;
using DiscoverU.Application.Services;
using DiscoverU.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Infrastructure.Persistence.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly DiscoverUDbContext _dbContext;
        public SurveyService(DiscoverUDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(AddSurveyDto addSurveyDto)
        {
            var survey = AddSurveyDto.MapToSurvey(addSurveyDto);
            _dbContext.Surveys.Add(survey);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var survay =await _dbContext.Surveys.FirstOrDefaultAsync(survay => survay.Id == id);

            survay.IsDelete = true;
            await _dbContext.SaveChangesAsync();
        }

       

        public async Task<IEnumerable<GetSurveyDto>> GetAllAsync()
        {
            var surveys = _dbContext.Surveys.Where(survay => survay.IsDelete==false).ToList();

            var getSurveyDtos = surveys.Select(survey => GetSurveyDto.MapToGetSurveyDto(survey));

            return await Task.FromResult(getSurveyDtos);

        }

        public async Task<GetSurveyDto> GetByIdAsync(Guid id)
        {
            var survey = await _dbContext.Surveys.FirstOrDefaultAsync(survay => survay.IsDelete! && survay.Id == id);

            return GetSurveyDto.MapToGetSurveyDto(survey);
        }

        public async Task UpdateAsync(UpdateSurveyDto updateSurveyDto)
        {
            var survey =await _dbContext.Surveys.FirstOrDefaultAsync(survay => survay.IsDelete==false && survay.Id == updateSurveyDto.Id);

            if (survey is not null)
            {
                survey.Title = updateSurveyDto.Title;
                survey.Description = updateSurveyDto.Description;
                survey. ImageUrl=updateSurveyDto.ImageUrl;
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
