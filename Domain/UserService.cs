using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebForPipeline.Models;

namespace Domain
{
    public class UserService : IUserService
    {
        public UserDto GetUserById(int id)
        {
            return GetUsers().FirstOrDefault(x => x.Id == id);
        }

        public List<UserDto> GetUser()
        {
            return GetUsers();
        }

        private static List<UserDto> GetUsers()
        {
            return new List<UserDto>
            {
                new UserDto
                {
                    Id = 1,
                    Name = "Test1 Testovski1",
                    Email = "test1@test.com"
                },
                new UserDto
                {
                    Id = 2,
                    Name = "Test2 Testovski2",
                    Email = "test2@test.com"
                }
            };
        }
    }
}
