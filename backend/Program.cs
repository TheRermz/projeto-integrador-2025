
using api_mrp.Data;
using api_mrp.Repositorios;
using api_mrp.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_mrp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost", policy =>
                {
                    policy.WithOrigins("http://127.0.0.1:3000")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<UserDBContext>(
                    option => option.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                    );


            // Repositories
            builder.Services.AddScoped<IUserRepostorio, UserRepostorio>();
            builder.Services.AddScoped<IMachineRepository, MachineRepository>();
            builder.Services.AddScoped<IProductsRepositorio, ProductsRepositorio>();
            builder.Services.AddScoped<IInsumosRepository, InsumosRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowLocalhost");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
