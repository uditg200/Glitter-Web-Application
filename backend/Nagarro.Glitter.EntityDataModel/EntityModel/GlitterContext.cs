using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Nagarro.Glitter.EntityDataModel.EntityModel
{
    public class GlitterContext : DbContext
    {
        public GlitterContext() : base("GlitterDB") { }
        public DbSet<UserDetails> AllUsers { get; set; }
        public DbSet<TweetDetails> AllTweets { get; set; }
    }
}
