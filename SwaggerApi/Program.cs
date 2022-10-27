using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opts =>
{
    opts.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Our User API (this is our title)",
        Description = "This is the description about our API.",
        TermsOfService = new Uri("https://tilox.com"),
        Contact = new OpenApiContact
        {
            Name = "Mark Zilkovskyi",
            Url = new Uri("https://tiox.com")
        },
        License = new OpenApiLicense
        {
            Name = "Cool License",
            Url = new Uri("https://tilox.com")
        }
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    opts.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFile));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(opts =>
    {
        //opts.SerializeAsV2 = true;
    });
    app.UseSwaggerUI(opts =>
    {
        opts.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        opts.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
