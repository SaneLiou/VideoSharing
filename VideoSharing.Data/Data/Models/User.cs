using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace VideoSharing.Data.Data.Models
{
    [Table("VideoSharingSiteUser")]
    public class User:IdentityUser,IEntity
    {
        public User() { }
        public User(string userName,string firstName,string lastName,string userEmail,string address,string gender)
        {
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserEmail = userEmail;
            this.Address = address;
            this.Gender = gender;
            this.CreatedTime = DateTime.Now;
            this.UpdatedTime = DateTime.Now;
            this.CreatedBy = "Initialised Data";
            this.UpdatedBy = "Initialised Data";
        }


        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string UserEmail { get; set; }
        [Required]
        [StringLength(200)]
        public string Address { get; set; }
        public string Gender { get; set; }
        public override string Id { get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<VideoComment> VideoComments { get; set; }
    }
}
