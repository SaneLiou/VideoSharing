using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using VideoSharing.Data.Configuration;
using VideoSharing.Data.Data.Models;

namespace VideoSharing.Data.Context
{
    public class VideoSharingContext : IdentityDbContext<User>
    {
        public VideoSharingContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CX: Now  we are using IdentityDbContext instead of DbContext, so  need to call base.OnModelCreating()
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.Entity<Video>()
                .HasOne(x => x.User)
                .WithMany(x => x.Videos)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<VideoComment>()
                .HasOne(x => x.User)
                .WithMany(x => x.VideoComments)
                .OnDelete(DeleteBehavior.Restrict);
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
