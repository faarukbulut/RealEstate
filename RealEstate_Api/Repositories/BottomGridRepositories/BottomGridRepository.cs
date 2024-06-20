using Dapper;
using RealEstate_Api.Dtos.BottomGridDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateBottomGridAsync(CreateBottomGridDto bottomGridDto)
        {
			string query = "Insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
			var parameters = new DynamicParameters();
			parameters.Add("@icon", bottomGridDto.Icon);
			parameters.Add("@title", bottomGridDto.Title);
			parameters.Add("@description", bottomGridDto.Description);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
			
        public async Task DeleteBottomGridAsync(int id)
        {
			string query = "Delete From BottomGrid Where BottomGridID=@bottomGridID";
			var parameters = new DynamicParameters();
			parameters.Add("bottomGridID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetBottomGridDto> GetBottomGridAsync(int id)
        {
			string query = "Select * From BottomGrid Where BottomGridID=@bottomGridID";
			var parameters = new DynamicParameters();
			parameters.Add("@bottomGridID", id);

			using (var connection = _context.CreateConnection())
			{
				var value = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
				return value;
			}
		}

        public async Task UpdateBottomGridAsync(UpdateBottomGridDto bottomGridDto)
        {
			string query = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description where BottomGridID=@bottomGridID";
			var parameters = new DynamicParameters();
			parameters.Add("@icon", bottomGridDto.Icon);
			parameters.Add("@title", bottomGridDto.Title);
			parameters.Add("@description", bottomGridDto.Description);
			parameters.Add("@bottomGridID", bottomGridDto.BottomGridID);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
    }
}
