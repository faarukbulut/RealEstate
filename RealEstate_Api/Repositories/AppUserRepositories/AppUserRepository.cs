using Dapper;
using RealEstate_Api.Dtos.AppUserDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;

        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetAppUserByProductIdDto> GetAppUserByProductIdAsync(int id)
        {
            string query = "Select * From AppUser Where UserID=@appUserId";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserId", id);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIdDto>(query, parameters);
                return value;
            }
        }
    }
}
