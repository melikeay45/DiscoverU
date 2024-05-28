using DiscoverU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Domain.Entities
{
    //Tek soru
    public class Response:EntityBase<Guid>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
        public int OptionId { get; set; }

        public Option Option { get; set; }
    }
}
