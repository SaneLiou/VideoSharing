using System;
using System.Collections.Generic;
using System.Text;

namespace VideoSharing.Data.Data.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string VideoTitle { get; set; }
        public string Owner_Id {get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Access_Level { get; set; }
        public int Upvote_Count { get; set; }

        public int Downvote_Count { get; set; }


    }
}
