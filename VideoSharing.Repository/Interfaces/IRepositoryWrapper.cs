using System;
using System.Collections.Generic;
using System.Text;

namespace VideoSharing.Repository.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        IVideoRepository VideoRepository { get; }
        IVideoCommentRepository VideoCommentRepository { get; }
        void Save();
    }
}
