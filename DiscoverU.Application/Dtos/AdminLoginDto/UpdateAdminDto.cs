using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.AdminLoginDto
{
    public class UpdateAdminDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
