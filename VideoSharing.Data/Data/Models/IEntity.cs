using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VideoSharing.Data.Data.Models
{
    interface IEntity
    {
        [Required]
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }


        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
