using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Context;
using VideoSharing.Repository.Interfaces;

namespace VideoSharing.Repository.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private VideoSharingContext _context;
        private IUserRepository _userRepository;
        private IVideoRepository _videoRepository;
        private IVideoCommentRepository _videoCommentRepository;
        public IUserRepository UserRepository
        {
            get
            {
                if(_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }
                return _userRepository;
            }
        }

        public IVideoRepository VideoRepository
        {
            get
            {
                if(_videoRepository == null)
                {
                    _videoRepository = new VideoRepository(_context);
                }
                return _videoRepository;
            }
        }

        public IVideoCommentRepository VideoCommentRepository
        {
            get
            {
                if(_videoCommentRepository == null)
                {
                    _videoCommentRepository = new VideoCommentRepository(_context);
                }
                return _videoCommentRepository;
            }
        }
        public RepositoryWrapper(VideoSharingContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
