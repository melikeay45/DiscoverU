using DiscoverU.Application.Dtos.QuestionDto;
using DiscoverU.Application.Services;
using DiscoverU.Infrastructure.Persistence.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscoverU.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(AddQuestionDto addQuestionDto)
        {

            await _questionService.AddAsync(addQuestionDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _questionService.DeleteAsync(id);
            return NoContent();
        }


        [HttpGet("{questionId}")]
        public async Task<ActionResult<IEnumerable<GetQuestionDto>>> GetAllByQuestionId(Guid surveyId)
        {
            var options = await _questionService.GetAllBySurveyIdAsync(surveyId);
            return Ok(options);
        }

     

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateQuestionDto updateQuestionDto)
        {
            await _questionService.UpdateAsync(updateQuestionDto);
            return NoContent();
        }
    }
}
