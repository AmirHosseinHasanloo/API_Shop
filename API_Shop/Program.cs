using API_Shop.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NSwag.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add NSwag
builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "Shop API";
    config.Version = "v1";
    config.Description = "This is an NSwag-generated OpenAPI doc.";
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


#region DbContext

builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseInMemoryDatabase("ShopNonStaticData");
});

#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseDeveloperExceptionPage();
}


app.UseOpenApi();
app.UseSwaggerUi(options =>
{
    options.DocumentPath = "/swagger/v1/swagger.json";
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
