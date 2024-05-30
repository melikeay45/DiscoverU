using DiscoverU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Domain.Entities
{
    //Seçenekler
    public class Option:EntityBase<Guid>
    {
        public string Text { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
        public bool IsDelete { get; set; }
        
    }
}
