using LevvaCoinAPI.Database;
using LevvaCoinAPI.Interfaces;
using LevvaCoinAPI.Logic.Interfaces;
using LevvaCoinAPI.Logic.MapperProfiles;
using LevvaCoinAPI.Logic.Services;
using LevvaCoinAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] {@"bin\"}, StringSplitOptions.None)[0];
var configuration = new ConfigurationBuilder()
    .SetBasePath(projectPath)
    .AddJsonFile("appsettings.json")
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");
builder.Services.AddAutoMapper(typeof(DefaultMapper));

builder.Services.AddDbContext<LevvaCoinsDbContext>(options =>
{
    options.UseMySQL(connectionString);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "levvacoins",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:5173","http://localhost:5173")
                          .AllowAnyHeader();
                      }
        );
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITransactionService, TransactionServices>();
builder.Services.AddScoped<ICategoryService, CategoryServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("levvacoins");

app.Run();
