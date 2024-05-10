using Dapper;
using RealEstate_Api.Dtos.ProductImageDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.ProductImageRepositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly Context _context;

        public ProductImageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<GetProductImageByProductIdDto>> GetProductImageListByProductId(int id)
        {
            string query = "Select * From ProductImage Where ProductID=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<GetProductImageByProductIdDto>(query, parameters);
                return value.ToList();
            }
        }
    }
}
