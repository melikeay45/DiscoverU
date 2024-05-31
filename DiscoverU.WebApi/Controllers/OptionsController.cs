using DiscoverU.Application.Dtos.OptionDto;
using DiscoverU.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscoverU.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {

        private readonly IOptionService _optionService;

        public OptionsController(IOptionService optionService)
        {
            _optionService = optionService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(ICollection<AddOptionDto> addOptionDtos)
        {

             await _optionService.AddAsync(addOptionDtos);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await _optionService.DeleteAsync(id);
            return NoContent();
        }


        [HttpGet("{questionId}")]
        public async Task<ActionResult<IEnumerable<GetOptionDto>>> GetAllByQuestionIdAsync(Guid questionId)
        {
            var options = await _optionService.GetAllByQuestionIdAsync(questionId);
            return Ok(options);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateOptionDto updateOptionDto)
        {
            await _optionService.UpdateAsync(updateOptionDto);
            return NoContent();
        }
    }
}
