using Microsoft.EntityFrameworkCore;
using mrp_api.Data;
using mrp_api.Repositorios;
using mrp_api.Repositorios.Interface;

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
                .AddDbContext<MrpDBContext>(
                    option => option.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                    );

builder.Services.AddScoped<IUserRepositorio, UserRepostorio>();
builder.Services.AddScoped<IMachineRepositorio, MachinesRepositorio>();

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
