using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PopoErEnLuder.Models
{
    public class PopoErEnLuderContext : DbContext
    {
        public PopoErEnLuderContext (DbContextOptions<PopoErEnLuderContext> options)
            : base(options)
        {
        }

        public DbSet<PopoErEnLuder.Models.Post> Post { get; set; }
    }
}
