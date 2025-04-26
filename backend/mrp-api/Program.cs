using Microsoft.EntityFrameworkCore;
using mrp_api.Data;
using mrp_api.Repositorios;
using mrp_api.Repositorios.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); //Swagger desativado, não mexer

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.WebHost.UseUrls("http://0.0.0.0:5000", "https://0.0.0.0:5001");

builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<MrpDBContext>(
                    option => option.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                    );

builder.Services.AddScoped<IUserRepositorio, UserRepostorio>();
builder.Services.AddScoped<IMachineRepositorio, MachinesRepositorio>();
builder.Services.AddScoped<ICargoRepositorio, CargoRepositorio>();
builder.Services.AddScoped<ISetorRepositorio, SetorRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}  //Swagger Desativado, não mecher

app.UseCors("PermitirTudo");

app.MapGet("/", () => "API está viva!");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
