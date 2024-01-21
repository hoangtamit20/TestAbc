using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OCLP.Data.DbContext;
using OCLP.Data.Entities;
using OCLP.Repositories.Auth;
using OCLP.Services.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<OCLPDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// add identity
builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<OCLPDbContext>()
    .AddDefaultTokenProviders();


// add service
{
    builder.Services.AddScoped<ILoginService, LoginService>();
    builder.Services.AddScoped<IAuthRepository, AuthRepository>();
}

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
