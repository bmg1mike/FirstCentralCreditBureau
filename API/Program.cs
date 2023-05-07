using Serilog;
using Service;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider serviceProvider, LoggerConfiguration config) =>
{
    config.ReadFrom
        .Configuration(context.Configuration)
        .ReadFrom.Services(serviceProvider);
});

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( x =>
{
    x.IncludeXmlComments("API.xml");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
