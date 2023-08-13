using GameLibrary.Application.Common;
using GameLibrary.Application.Services;
using GameLibrary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionPassword = builder.Configuration["GameLibrary:ConnectionString"];
var connection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<IAppDbContext, AppDbContext>(
        options => options.UseMySql(
                connection + connectionPassword,
                new MySqlServerVersion(new Version(11,0,2))
                )
        );
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<GameService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();
