using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.BottomGridRepositories;
using RealEstate_Api.Repositories.CategoryRepositories;
using RealEstate_Api.Repositories.PopularLocationRepositories;
using RealEstate_Api.Repositories.ProductRepositories;
using RealEstate_Api.Repositories.ServiceRepositories;
using RealEstate_Api.Repositories.WhoWeAreDetailRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
