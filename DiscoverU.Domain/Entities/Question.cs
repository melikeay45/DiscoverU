using DiscoverU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Domain.Entities
{
    public class Question:EntityBase<Guid>
    {
        public string Text { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set;}
        public ICollection<Option> Options { get; set; }
        public bool IsDelete { get; set; }


    }
}
