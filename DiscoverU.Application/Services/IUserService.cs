using DiscoverU.Application.Dtos.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Services
{
    public interface IUserService
    {
        List<GetUserDto> GetAll();
        GetUserDto GetById(Guid id);
        void Add(AddUserDto addUserDto);
        void Update(UpdateUserDto updateUserDto);
        void Delete(Guid id);
    }
}
