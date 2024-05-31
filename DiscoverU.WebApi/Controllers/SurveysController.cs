using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Application.Dtos.SurveyDto;
using DiscoverU.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiscoverU.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        private readonly ISurveyService _surveyService;

        public SurveysController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(AddSurveyDto addSurveyDto)
        {

            await _surveyService.AddAsync(addSurveyDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await _surveyService.DeleteAsync(id);
            return NoContent();
        }


        [HttpGet("{questionId}")]
        public async Task<ActionResult<IEnumerable<GetOptionDto>>> GetAllAsync()
        {
            var surveys = await _surveyService.GetAllAsync();
            return Ok(surveys);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateSurveyDto updateSurveyDto)
        {
            await _surveyService.UpdateAsync(updateSurveyDto);
            return NoContent();
        }
    }
}
