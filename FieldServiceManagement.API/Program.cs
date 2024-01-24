using FieldServiceManagement.Core.Configuration;
using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Core.UniOfWorks;
using FieldServiceManagement.Repository.Contexts;
using FieldServiceManagement.Repository.Repositories;
using FieldServiceManagement.Repository.UniOfWorks;
using FieldServiceManagement.Service.Helpers;
using FieldServiceManagement.Service.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FieldServiceManagement.Core.Services.IGenericService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));

builder.Services.AddScoped<IServiceRequestService, ServiceRequestService>();
builder.Services.AddScoped<IServiceRequestRepository, ServiceRequestRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IJobAssignmentService, JobAssignmentService>();
builder.Services.AddScoped<IJobAssignmentRepository, JobAssigmentRepository>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();

builder.Services.AddScoped<UserHelper>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.Configure<CustomTokenOption>(builder.Configuration.GetSection("TokenOptions"));
builder.Services.Configure<List<Client>>(builder.Configuration.GetSection("Clients"));


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Con"), sqlOptions =>
    {
        sqlOptions.MigrationsAssembly("FieldServiceManagement.Repository");
    });
});

builder.Services.AddIdentity<AppUser, AppRole>(option =>
{
    option.User.RequireUniqueEmail = true;
    option.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
{
    var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<CustomTokenOption>();
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidIssuer = tokenOptions.Issuer,
        ValidAudience = tokenOptions.Audience[0],
        IssuerSigningKey = SignService.GetSymmetricSecurityKey(tokenOptions.SecurityKey),
        ValidateIssuerSigningKey = true,
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
