using DiscoverU.Application.Dtos.AdminLoginDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Services
{
    public interface IAdminLoginService
    {
        List<GetAdminDto> GetAll();
        GetAdminDto GetById(Guid id);
        void Add(AddAdminDto addAdminDto);
        void Update(UpdateAdminDto updateAdminDto);
        void Delete(Guid id);
    }
}
