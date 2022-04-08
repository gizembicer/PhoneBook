using PhoneBook.Api.BusinessEngine.Interfaces;
using PhoneBook.Api.BusinessEngine.Map;
using PhoneBook.Api.BusinessEngine.Services;
using PhoneBook.Data;
using PhoneBook.Data.UnitOfWorks;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();



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
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//builder.Services.AddSwaggerGen(options =>
//{
//    options.SwaggerDoc("v1", new OpenApiInfo { Title = "PhoneBook.Api.Host", Version = "v1" });
//    options.OperationFilter<AddRequiredHeaderParameter>();
  
    
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.Run();