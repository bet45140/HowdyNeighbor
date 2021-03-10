using System;
using System.Linq;

namespace HowdyNeighbor.Pages.Data
{
    public class DbInitializer
    {
        public static void Initialize(HowdyNeighborContext context)
        {
            context.Database.EnsureCreated();

            if (context.ChecklistTask.Any())
            {
                return; // Database has been seeded
            }

            var tasks = new ChecklistTask[]
            {
                new ChecklistTask{Id=1, Action="Make sure that utilities are set up", IsComplete=false, Date=DateTime.Now},
                new ChecklistTask{Id=2, Action = "Transfer perscriptions to new pharmacy", IsComplete=false, Date=DateTime.Now.AddDays(1)},
                new ChecklistTask{Id=3, Action = "Get in contact with new neighbors", IsComplete=false, Date=DateTime.Now.AddDays(6)},
                new ChecklistTask{Id=4, Action = "Purchase parks membership", IsComplete=false, Date=DateTime.Now.AddDays(14)},
            };

            context.ChecklistTask.AddRange(tasks);
            context.SaveChanges();
        }
    }
}
