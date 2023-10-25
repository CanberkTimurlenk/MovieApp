using Presentation.AssemblyReference;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
                .AddNewtonsoftJson()
                .AddApplicationPart(typeof(AssemblyReference).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.ConfigureRedis(builder.Configuration);

builder.Host.ConfigureAutofac(builder.Configuration);
builder.Services.ConfigureAspects();

builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();


builder.Services.ConfigureJwt(builder.Configuration);
builder.Services.AddHttpContextAccessor();




var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsProduction())
    app.ConfigureExceptionHandler();

app.UseHttpsRedirection();


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
