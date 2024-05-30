using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.ResponseDto
{
    public class AddReponseDto
    {
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
        public int OptionId { get; set; }
    }
}
