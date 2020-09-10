using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Data.Models;

namespace VideoSharing.Data.Context
{
    public class VideoSharingContext : DbContext
    {
        public VideoSharingContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users
        {
            get; set;
        }
        public DbSet<Video> Videos
        {
            get; set;
        }
    }
}
