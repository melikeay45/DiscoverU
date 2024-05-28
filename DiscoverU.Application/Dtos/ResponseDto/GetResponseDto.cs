using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.ResponseDto
{
    public class GetResponseDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int OptionId { get; set; }
        public string OptionText { get; set; }
    }
}
