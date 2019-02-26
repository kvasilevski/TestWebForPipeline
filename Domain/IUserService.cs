using System.Collections.Generic;
using TestWebForPipeline.Models;

namespace Domain
{
    public interface IUserService
    {
        UserDto GetUserById(int id);

        List<UserDto> GetUsers();
    }
}