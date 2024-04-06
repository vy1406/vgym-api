using Vgym.Data.Contexts;
using Vgym.Models.Entities;

namespace Vgym.Server
{
    public static class DataSeeder
    {
        //might need to add an enviroment check to make sure it only does the seeding in development
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<VgymSqlDbContext>();
            //might need to remove this line when connecting to a cloud db
            context.Database.EnsureCreated();
            AddUsers(context);
        }

        private static void AddUsers(VgymSqlDbContext context)
        {
            var user1 = new User { UserName = "Ironman", Password = "123", IsAdmin = false };
            var user2 = new User { UserName = "Batman", Password = "123", IsAdmin =false };
            var user3 = new User { UserName = "Ladygaga",Password = "123", IsAdmin =true };
            
            if(!context.Users.Any() )
            {
                context.AddRange(user1, user2, user3);
                context.SaveChanges();
            }
        }
    }
}
