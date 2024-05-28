using DiscoverU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Domain.Entities
{
    public class AdminLogin:EntityBase<Guid>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
