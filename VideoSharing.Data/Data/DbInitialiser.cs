using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Context;
using VideoSharing.Data.Data.Models;

namespace VideoSharing.Data.Data
{
    public class DbInitialiser
    {
        public static void Seed(VideoSharingContext context)
        {
            context.Users.Add(new User("ChengXiang","Cheng Xiang","Liou","chengxiangliou@gmail.com","Tampines","Male"));


            context.SaveChanges();

        }
    }
}
