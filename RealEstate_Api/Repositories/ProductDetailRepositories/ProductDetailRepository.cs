using Dapper;
using RealEstate_Api.Dtos.ProductDetailDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.ProductDetailRepositories
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        private readonly Context _context;

        public ProductDetailRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetProductDetailByIdDto> GetProductDetailByProductIdAsync(int id)
        {
            string query = "Select * From ProductDetails Where ProductID=@productId ";

            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductDetailByIdDto>(query, parameters);
                return values.FirstOrDefault();
            }
        }
    }
}
