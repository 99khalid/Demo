
using Demo.Applicatoin.Interfaces;
using Demo.Applicatoin;

using Infrastructure;
using Infrastructure.Repositres;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System;
using System.Reflection;

namespace Demo.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<DemoDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(DemoDbContext).Assembly.FullName));
            });
            builder.Services.AddScoped(typeof(IUserinterface<>), typeof(Basereposatry<>));
            builder.Services.AddScoped<IGitUserall, userRepositry>();
            builder.Services.AddScoped<IDepartment, DeptRepositry>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            builder.Services.AddApplicationServices();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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

            app.Run();
        }
    }
}