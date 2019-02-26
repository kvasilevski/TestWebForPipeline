using Domain;
using NUnit.Framework;

namespace Tests
{
    public class UserServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UserService_getUsers_getTwoUsers()
        {
            //arrange
            var userService = new UserService();

            //act
            var users = userService.GetUsers();

            //assert
            Assert.IsNotNull(users);
            Assert.That(users, Has.Count.EqualTo(2));
        }

        [Test]
        public void UserService_getUser_getOneUsers()
        {
            //arrange
            var userService = new UserService();

            //act
            var users = userService.GetUserById(1);

            //assert
            Assert.IsNotNull(users);
        }
    }

}