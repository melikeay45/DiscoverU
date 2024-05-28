using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.OptionDto
{
    public class UpdateOptionDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }        
        public int QuestionId { get; set; }
    }
    
}
