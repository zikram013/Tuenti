using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tuenti.Core.Repository;
using Tuenti.Core.Repository.Interface;
using Tuenti.Tuenti.Infrastucture.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar el DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Registrar repositorios y Unit of Work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IFriendRepository, FriendRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


// Configurar controladores
builder.Services.AddControllers();

// Configurar Swagger (para probar la API desde Swagger UI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Usar Swagger en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
