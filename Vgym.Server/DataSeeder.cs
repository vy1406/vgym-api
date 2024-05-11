using Vgym.Data.Contexts;
using Vgym.Models.Entities;
using Vgym.Server.Utilities.Enums;


namespace Vgym.Server
{
    public static class DataSeeder
    {
        //might need to add an enviroment check to make sure it only does the seeding in development
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<VgymDbContext>();
            //might need to remove this line when connecting to a cloud db
            
            AddUsers(context);
            AddPrograms(context);
        }

        private static void AddUsers(VgymDbContext context)
        {
            var user1 = new User { Username = "Ironman", Password = "123", IsAdmin = false };
            var user2 = new User { Username = "Batman", Password = "123", IsAdmin =false };
            var user3 = new User { Username = "Ladygaga",Password = "123", IsAdmin =true };
            
            if(!context.Users.Any() )
            {
                context.AddRange(user1, user2, user3);
                context.SaveChanges();
            }
        }

        private static void AddPrograms(VgymDbContext context)
        {
            var p1 = new TrainingProgram { Title = "Squat Challenge", Type = ProgramType.ADVANCED, Duration = 3, BackgroundImage = "/Images/squat_challange.jpg" };
            var p2 = new TrainingProgram { Title = "Cardio Blast", Type = ProgramType.POPULAR, Duration = 4, BackgroundImage = "/Images/cardio_workout.jpeg" };  
            var p3 = new TrainingProgram { Title = "Full Body", Type = ProgramType.BASIC, Duration = 1, BackgroundImage = "/Images/full_body_workout.jpg" };  
            var p4 = new TrainingProgram { Title = "Advanced Full Body", Type = ProgramType.ADVANCED, Duration = 5, BackgroundImage = "/Images/advanced_full_body_workout.webp" };  
            var p5 = new TrainingProgram { Title = "Dumbells Only", Type = ProgramType.BASIC, Duration = 3, BackgroundImage = "/Images/dumbell_workout.webp" };  
            var p6 = new TrainingProgram { Title = "Six Pack Abs", Type = ProgramType.POPULAR, Duration = 4, BackgroundImage = "/Images/abs_workout.png" };

            if (!context.TrainingPrograms.Any())
            {
                context.AddRange(p1, p2, p3, p4, p5, p6);
                context.SaveChanges();
            }
        }
    }
}
