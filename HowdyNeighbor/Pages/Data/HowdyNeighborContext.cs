using Microsoft.EntityFrameworkCore;

namespace HowdyNeighbor.Pages.Data
{
    public class HowdyNeighborContext : DbContext
    {
        public HowdyNeighborContext()
        {
        }

        public HowdyNeighborContext (DbContextOptions<HowdyNeighborContext> options)
            : base(options)
        {
        }
        public DbSet<ChecklistTask> ChecklistTask { get; set; }
    }
}
