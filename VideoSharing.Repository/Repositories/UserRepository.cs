using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Context;
using VideoSharing.Data.Data.Models;
using VideoSharing.Repository.Interfaces;

namespace VideoSharing.Repository.Repositories
{
    public class UserRepository: RepositoryBase<User>, IUserRepository
    {
        public UserRepository(VideoSharingContext context) : base(context) 
        {
        }
    }
}
