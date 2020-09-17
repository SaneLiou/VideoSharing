using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Repository.Repositories;
using VideoSharing.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using VideoSharing.Data.Data.Models;
using VideoSharing.Data.Context;
using Xunit;
using System.Linq;
using Microsoft.Extensions.Options;

namespace VideoSharing.Tests.Repository
{
    public class UserRepositoryTests
    {


        private readonly Mock<DbSet<User>> _dbSetMock;
        private readonly DbContextOptions<VideoSharingContext> _options = new DbContextOptionsBuilder<VideoSharingContext>()
                            .UseInMemoryDatabase(databaseName: "VideoSharingDb")
                            .Options;
        public UserRepositoryTests()
        {
            // Arrange, I am doing the arrange in the constructor so that I can reuse them in more test.
            
            _dbSetMock = new Mock<DbSet<User>>();


        }
        [Fact]
        public void FindAll_User_ReturnsIQueryableUser()
        {

            UserRepository _userRepository = new UserRepository(new VideoSharingContext(_options));
            var result = _userRepository.FindAll();
            Assert.IsAssignableFrom<IQueryable<User>>(result);
        }

        [Fact]
        public void FindAll_User_ReturnsExactNumberOfUsers()
        {

            UserRepository _userRepository = new UserRepository(new VideoSharingContext(_options));
            var result = _userRepository.FindAll();
            Assert.Equal(3, result.Count());
        }
        [Theory]
        [InlineData("3")]
        [InlineData("1")]



        public void Find_User_ReturnsTrue(string id)
        {
   
            using (var context = new VideoSharingContext(_options))
            {
                if(context.Users.Count() == 0)
                {
                    context.Users.Add(new User { Id = "1", UserName = "Liou", FirstName = "CX", LastName = "Liou", UserEmail = "yeah@gmail.com", Address = "Tampines" });
                    context.Users.Add(new User { Id = "2", UserName = "Peter", FirstName = "Peter", LastName = "Lim", UserEmail = "yahooo@gmail.com", Address = "Tampines" });
                    context.Users.Add(new User { Id = "3", UserName = "David", FirstName = "David", LastName = "Goh", UserEmail = "hotmail@gmail.com", Address = "Tampines" });
                    context.SaveChanges();

                }

            }

            UserRepository _userRepository = new UserRepository(new VideoSharingContext(_options));
            var returnedUser = _userRepository.FindByCondition(x => x.Id == id).FirstOrDefault();
            Assert.True(returnedUser.Id == id);
        }

    }
}
