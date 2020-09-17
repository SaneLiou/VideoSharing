using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Context;
using VideoSharing.Data.Data.Models;
using VideoSharing.Repository.Interfaces;

namespace VideoSharing.Repository.Repositories
{
    public class VideoRepository:RepositoryBase<Video>,IVideoRepository
    {
        public VideoRepository(VideoSharingContext context) : base(context)
        {
        }
    }
}
