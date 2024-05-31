using DiscoverU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Domain.Entities
{
    //Anket
    public class Survey:EntityBase<Guid>
    {
       public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Question> Questions { get; set; }
        public bool IsDelete { get; set; }

        public string ImageUrl {  get; set; }

    }
}
