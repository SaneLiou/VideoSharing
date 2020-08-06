using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace IdentityServerMVC.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        //public DbSet<Owner> Owners 
        //{ 
        //    get; set;
        //}
        //public DbSet<Account> Accounts
        //{
        //    get; set;
        //}
    }
}
