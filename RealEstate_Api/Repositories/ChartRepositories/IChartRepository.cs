using RealEstate_Api.Dtos.ChartDtos;

namespace RealEstate_Api.Repositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> Get5CityForChartAsync();
    }
}
