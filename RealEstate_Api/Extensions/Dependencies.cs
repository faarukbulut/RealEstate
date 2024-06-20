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
using RealEstate_Api.Repositories.PropertyAmenityRepositories;
using RealEstate_Api.Repositories.ServiceRepositories;
using RealEstate_Api.Repositories.StatisticRepositories;
using RealEstate_Api.Repositories.SubFeatureRepositories;
using RealEstate_Api.Repositories.TestimonialRepositories;
using RealEstate_Api.Repositories.ToDoListRepositories;
using RealEstate_Api.Repositories.WhoWeAreDetailRepositories;

namespace RealEstate_Api.Extensions
{
    public static class Dependencies
    {
        public static void DependenciesExtension(this IServiceCollection services)
        {
            services.AddTransient<Context>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductDetailRepository, ProductDetailRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        } 
    }
}
