using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VideoSharing.Data.Data.Models
{
    public class VideoComment : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public int VideoId { get; set; }
        public virtual Video Video { get; set; }

        public string Body { get; set; }
    }
}
