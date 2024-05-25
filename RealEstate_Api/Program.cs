using RealEstate_Api.Hubs;
using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.AppUserRepositories;
using RealEstate_Api.Repositories.BottomGridRepositories;
using RealEstate_Api.Repositories.CategoryRepositories;
using RealEstate_Api.Repositories.ChartRepositories;
using RealEstate_Api.Repositories.ContactRepositories;
using RealEstate_Api.Repositories.EmployeeRepositories;
using RealEstate_Api.Repositories.MessageRepositories;
using RealEstate_Api.Repositories.PopularLocationRepositories;
using RealEstate_Api.Repositories.ProductDetailRepositories;
using RealEstate_Api.Repositories.ProductImageRepositories;
using RealEstate_Api.Repositories.ProductRepositories;
using RealEstate_Api.Repositories.ServiceRepositories;
using RealEstate_Api.Repositories.StatisticRepositories;
using RealEstate_Api.Repositories.TestimonialRepositories;
using RealEstate_Api.Repositories.ToDoListRepositories;
using RealEstate_Api.Repositories.WhoWeAreDetailRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IProductDetailRepository, ProductDetailRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticRepository, StatisticRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<IChartRepository, ChartRepository>();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();
builder.Services.AddTransient<IProductImageRepository, ProductImageRepository>();
builder.Services.AddTransient<IAppUserRepository, AppUserRepository>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
               .AllowAnyMethod()
               .SetIsOriginAllowed((host) => true)
               .AllowCredentials();
    });
});

builder.Services.AddSignalR();

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

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
