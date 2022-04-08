using PhoneBook.Api.BusinessEngine.Interfaces;
using PhoneBook.Api.BusinessEngine.Map;
using PhoneBook.Api.BusinessEngine.Services;
using PhoneBook.Data;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    x.JsonSerializerOptions.IgnoreNullValues = true;
});

builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddDataServices(builder.Configuration);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddMemoryCache();
builder.Services.AddScoped<IPhoneBookBusinessEngine, PhoneBookBusinessEngine>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapControllers();

app.Run();
