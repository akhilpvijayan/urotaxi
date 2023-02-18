using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.DataServices;
using UroTaxi.Business.Services;
using UroTaxi.Business.Services.DataServices;
using UroTaxi.Business.Services.Services;
using UroTaxi.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddDbContext<ApplicationDBContext>();
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IBookingDataService, BookingDataService>();
builder.Services.AddScoped<ICarTypeService, CarTypeService>();
builder.Services.AddScoped<ICarTypeDataService, CarTypeDataService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICityDataService, CityDataService>();

builder.Services.AddCors();

builder.Services.AddHttpContextAccessor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
     .AllowAnyMethod()
     .AllowAnyHeader()
     .SetIsOriginAllowed(origin => true) // allow any origin
     .AllowCredentials()); // allow credentials

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
