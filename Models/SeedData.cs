using ExercicesEFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace ExercicesEFCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExercicesEFCoreContext(serviceProvider.GetRequiredService<DbContextOptions<ExercicesEFCoreContext>>()))
            {
                //if (context.ToDo.Any())
                //{
                //    return;
                //}
                context.ToDo.AddRange(
                    new ToDo
                    {
                        Title = "Teeeeeeest1",
                        Description = "Teeeeeeeeeeeeeeeeeeeest 1 description",
                        IsDone = true,
                    },
                    new ToDo
                    {
                        Title = "Teeeeeest2",
                        Description = "Teeeeeeeeeeeeeeeeeeest 2 description",
                        IsDone = false,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
