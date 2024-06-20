using Dapper;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly Context _context;

        public StatisticRepository(Context context)
        {
            _context = context;
        }

        // Durumu aktif olan kategori sayısı
        public async Task<int> ActiveCategoryCountAsync()
        {
            string query = "Select Count(*) From Category Where CategoryStatus=@status";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, new {status = 1});
                return values;
            }
        }

        // Durumu aktif olan Employee sayısı
        public async Task<int> ActiveEmployeeCountAsync()
        {
            string query = "Select Count(*) From Employee Where Status=@status";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, new { status = 1 });
                return values;
            }
        }

        // Product tablosundaki daire'lerin toplam sayısı
        public async Task<int> ApartmentCountAsync()
        {
            string query = "Select Count(*) From Product Where Title like @parameter";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, new { parameter = "%Daire%"});
                return values;
            }
        }

        // Kiralık ilanların ortalama fiyatı
        public async Task<decimal> AverageProductPriceByRentAsync()
        {
            string query = "Select Avg(Price) From Product Where Type=@type";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query, new { type = "Kiralık" });
                return values;
            }
        }

        // Satılık ilanların ortalama fiyatı
        public async Task<decimal> AverageProductPriceBySaleAsync()
        {
            string query = "Select Avg(Price) From Product Where Type=@type";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query, new { type = "Satılık" });
                return values;
            }
        }

        // İlanların ortalama oda sayısı
        public async Task<int> AverageRoomCountAsync()
        {
            string query = "Select Avg(RoomCount) From ProductDetails";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        // Toplam kategori sayısı
        public async Task<int> CategoryCountAsync()
        {
            string query = "Select Count(*) From Category";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        // En çok ilan olan kategori adı
        public async Task<string> CategoryNameByMaxProductCountAsync()
        {
            string query = "Select top(1) CategoryName,Count(*) From Product INNER JOIN Category On Product.ProductCategory=Category.CategoryID Group By CategoryName ORDER BY Count(*) DESC";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        // En çok ilan olan şehir adı
        public async Task<string> CityNameByMaxProductCountAsync()
        {
            string query = "SELECT Top(1) City, Count(*) as 'product_count' FROM Product GROUP BY City ORDER BY product_count DESC";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        // Toplam kaç farklı şehir sayısı
        public async Task<int> DifferentCityCountAsync()
        {
            string query = "SELECT Count(DISTINCT(City)) FROM Product";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        // En çok ilan olan employee
        public async Task<string> EmployeeNameByMaxProductCountAsync()
        {
            string query = "SELECT Name,Count(*) as 'product_count' FROM Product INNER JOIN Employee ON Product.EmployeeID = Employee.EmployeeID GROUP BY Name ORDER BY 'product_count' DESC";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        // Eklenen son ürünün fiyatı
        public async Task<decimal> LastProductPriceAsync()
        {
            string query = "SELECT Top(1) Price FROM Product ORDER BY ProductID DESC";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }


        // İlanlardaki en yeni bina yılı
        public async Task<string> NewestBuildingYearAsync()
        {
            string query = "SELECT Top(1) BuildYear FROM ProductDetails ORDER BY BuildYear DESC";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }


        // İlanlardaki en eski bina yılı
        public async Task<string> OldestBuildingYearAsync()
        {
            string query = "SELECT Top(1) BuildYear FROM ProductDetails ORDER BY BuildYear ASC";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        // Durumu pasif olan kategori sayısı
        public async Task<int> PassiveCategoryCountAsync()
        {
            string query = "Select Count(*) From Category Where CategoryStatus=@status";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, new { status = 0 });
                return values;
            }
        }


        // Toplam ilan sayısı
        public async Task<int> ProductCountAsync()
        {
            string query = "SELECT Count(*) From Product";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public async Task<int> ProductCountByEmployeeIdAsync(int id)
        {
            string query = "SELECT Count(*) From Product Where EmployeeID=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("employeeId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }

        public async Task<int> ProductCountByStatusFalseAsync(int id)
        {
            string query = "SELECT Count(*) From Product Where EmployeeID=@employeeId And ProductStatus=@productStatus";
            var parameters = new DynamicParameters();
            parameters.Add("employeeId", id);
            parameters.Add("productStatus", false);

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }

        public async Task<int> ProductCountByStatusTrueAsync(int id)
        {
            string query = "SELECT Count(*) From Product Where EmployeeID=@employeeId And ProductStatus=@productStatus";
            var parameters = new DynamicParameters();
            parameters.Add("employeeId", id);
            parameters.Add("productStatus", true);

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }
    }
}
