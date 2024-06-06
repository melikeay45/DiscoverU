using DiscoverU.Domain.Entities;

namespace DiscoverU.Application.Dtos.OptionDto
{
    public class GetOptionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid QuestionId { get; set; }


        public static GetOptionDto MapToGetOptionDto(Option option)
        {
            return new GetOptionDto
            {
                Id =option.Id,
                Text = option.Text,
                QuestionId = option.QuestionId,
            };

        }
    }


}
