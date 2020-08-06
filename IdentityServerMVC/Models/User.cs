using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerMVC.Models
{
    public class User:Entity
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

    }
}
