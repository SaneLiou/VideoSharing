using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VideoSharing.Data.Data.Models
{
    public class Video:IEntity
    {
        public Video(string videoTitle,string address, string description)
        {
            this.VideoTitle = videoTitle;
            this.Address = address;
            this.Description = description;
            
            this.CreatedTime = DateTime.Now;
            this.UpdatedTime = DateTime.Now;
            this.CreatedBy = "Initialised Data";
            this.UpdatedBy = "Initialised Data";
        }
        [Required]
        [StringLength(50)]
        public string VideoTitle { get; set; }
        
        public int UserId {get; set; }
        public virtual User User { get; set; }
        [Required]
        public string Address { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public string Access_Level { get; set; }
        public int Upvote_Count { get; set; }

        public int Downvote_Count { get; set; }
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<VideoComment> VideoComments { get; set; }
    }
}
