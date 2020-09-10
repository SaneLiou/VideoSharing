using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using VideoSharing.Data.Data.Models;

namespace VideoSharing.Data.Context
{
    public class VideoSharingContext : DbContext
    {
        public VideoSharingContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>()
                .HasOne(x => x.User)
                .WithMany(x => x.Videos)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<VideoComment>()
                .HasOne(x => x.User)
                .WithMany(x => x.VideoComments)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<User> Users
        {
            get; set;
        }
        public DbSet<Video> Videos
        {
            get; set;
        }
        public DbSet<VideoComment> VideoComments
        {
            get; set;
        }

    }
}
