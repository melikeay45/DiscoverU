using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Domain.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}
