﻿using System;
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

        public List<UserDto> GetUsers()
        {
            return GetDummyUsers();
        }

        private static List<UserDto> GetDummyUsers()
        {
            return new List<UserDto>
            {
                new UserDto
                {
                    Id = 1,
                    Name = "Initial Testovski1",
                    Email = "test1@test.com"
                },
                new UserDto
                {
                    Id = 2,
                    Name = "Test2 Testovski2",
                    Email = "test2@test.com"
                },
                new UserDto
                {
                    Id = 3,
                    Name = "Test3 Testovski3",
                    Email = "test2@test.com"
                },
                new UserDto
                {
                    Id = 4,
                    Name = "UpdateService7 -describe-clusters7",
                    Email = "test2@test.com"
                },
                new UserDto
                {
                    Id = 4,
                    Name = "Final7 Finalovski7",
                    Email = "test2@test.com"
                }
            };
        }
    }
}
