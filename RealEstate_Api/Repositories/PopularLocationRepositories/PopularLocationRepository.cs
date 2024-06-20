using Dapper;
using RealEstate_Api.Dtos.PopularLocationDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

		public async Task CreatePopularLocationAsync(CreatePopularLocationDto popularLocationDto)
		{
			string query = "Insert into PopularLocation (CityName,ImageUrl) values (@cityName,@imageUrl)";
			var parameters = new DynamicParameters();
			parameters.Add("@cityName", popularLocationDto.CityName);
			parameters.Add("@imageUrl", popularLocationDto.ImageUrl);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task DeletePopularLocationAsync(int id)
		{
			string query = "Delete From PopularLocation Where LocationID=@locationID";
			var parameters = new DynamicParameters();
			parameters.Add("locationID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "Select * From PopularLocation";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

		public async Task<GetByIDPopularLocationDto> GetPopularLocationAsync(int id)
		{
			string query = "Select * From PopularLocation Where LocationID=@locationID";
			var parameters = new DynamicParameters();
			parameters.Add("@locationID", id);

			using (var connection = _context.CreateConnection())
			{
				var value = await connection.QueryFirstOrDefaultAsync<GetByIDPopularLocationDto>(query, parameters);
				return value;
			}
		}

		public async Task UpdatePopularLocationAsync(UpdatePopularLocationDto popularLocationDto)
		{
			string query = "Update PopularLocation Set CityName=@cityName,ImageUrl=@imageUrl where LocationID=@locationID";
			var parameters = new DynamicParameters();
			parameters.Add("@cityName", popularLocationDto.CityName);
			parameters.Add("@imageUrl", popularLocationDto.ImageUrl);
			parameters.Add("@locationID", popularLocationDto.LocationID);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
	}
}
