using Api.Data;
using Api.Data.EfCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
var myAllowSpecificOrigins = "_var myAllowSpecificOrigins";
var conn=builder.Configuration.GetConnectionString("PodConn");
// Add services to the container.
builder.Services.AddTransient<IMarcaDao, MarcaDaoComEfCore>();
builder.Services.AddTransient<IPodDao, PodDaoComEfCore>();
builder.Services.AddCors(opts =>
{
  opts.AddPolicy(name: myAllowSpecificOrigins, builder =>
  {
    builder.WithOrigins("http://localhost:4200")
    .AllowAnyOrigin()
    .AllowAnyHeader();
  });
});
builder.Services.AddDbContext<PodContext>(opts => { opts.UseMySql(conn,ServerVersion.AutoDetect(conn));});

builder.Services.
    AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddNewtonsoftJson
    (opts => opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PodDaoComEfCore>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
