using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Context;
using VideoSharing.Data.Data.Models;
using VideoSharing.Repository.Interfaces;

namespace VideoSharing.Repository.Repositories
{
    public class VideoCommentRepository:RepositoryBase<VideoComment>,IVideoCommentRepository
    {
        public VideoCommentRepository(VideoSharingContext context) : base(context)
        {
        }
    }
}
