
using Microsoft.EntityFrameworkCore;
using Vgym.Data.Contexts;
using Vgym.Server.Services;

namespace Vgym.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //Depending on enviroment the connection to db is decided
            if(builder.Environment.IsDevelopment())
            {
                builder.Services.AddDbContext<VgymSqlDbContext>(options => 
                options.UseNpgsql(builder.Configuration.GetConnectionString("LocalDb")));
            }
            else
            {
                builder.Services.AddDbContext<VgymSqlDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("CloudDb")));
            }
            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("reactApp", builder =>
                {
                    builder.WithOrigins("http://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                    //.AllowCredentials();
                });

            });

            builder.Services.AddTransient<IUserService, UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseCors("reactApp");
            app.Seed();
            app.Run();
        }
    }
}
