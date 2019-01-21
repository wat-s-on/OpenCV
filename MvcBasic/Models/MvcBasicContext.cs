using System.Data.Entity;

namespace MvcBasic.Models
{
    class MvcBasicContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}