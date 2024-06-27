using GoodIssueNoteApp.Data;
using Microsoft.EntityFrameworkCore;

namespace GoodIssueNoteApp.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
            
        }
            public DbSet<Goods> GoodIssue { get; set; } // GoodIssue use to refer to DbContext
    }
}
