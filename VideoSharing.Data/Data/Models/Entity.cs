using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoSharing.Data.Data.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedTime  { get; set; }
        public DateTime UpdatedTime { get; set; }


        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }


    }
}
