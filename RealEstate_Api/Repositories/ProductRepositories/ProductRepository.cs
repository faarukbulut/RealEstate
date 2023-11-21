using Dapper;
using RealEstate_Api.Dtos.Category;
using RealEstate_Api.Dtos.ProductDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address,DealOfTheDay From Product INNER JOIN Category ON Product.ProductCategory=Category.CategoryID";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

		public async void ProductDealOfTheDayStatusChangeOfToTrue(int id)
		{
			string query = "Update Product Set DealOfTheDay=@dealOfTheDay where ProductID=@productID";
			var parameters = new DynamicParameters();
			parameters.Add("@dealOfTheDay", true);
			parameters.Add("@productID", id);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async void ProductDealOfTheDayStatusChangeOfToFalse(int id)
		{
			string query = "Update Product Set DealOfTheDay=@dealOfTheDay where ProductID=@productID";
			var parameters = new DynamicParameters();
			parameters.Add("@dealOfTheDay", false);
			parameters.Add("@productID", id);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

	}
}
