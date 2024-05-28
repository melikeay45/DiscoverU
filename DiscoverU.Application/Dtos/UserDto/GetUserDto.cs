using DiscoverU.Application.Dtos.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.UserDto
{
    public class GetUserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<GetResponseDto> Responses { get; set; }
    }
    public class GetResponseDto
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int OptionId { get; set; }
        public string OptionText { get; set; }
    }
}
