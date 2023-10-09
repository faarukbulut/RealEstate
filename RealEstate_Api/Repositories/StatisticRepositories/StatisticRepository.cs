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

        public int ActiveCategoryCount()
        {
            string query = "Select Count(*) From Category Where CategoryStatus=@status";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, new {status = 1});
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) From Employee Where Status=@status";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, new { status = 1 });
                return values;
            }
        }

        public int ApartmentCount()
        {
            throw new NotImplementedException();
        }

        public decimal AverageProductByRent()
        {
            throw new NotImplementedException();
        }

        public decimal AverageProductBySale()
        {
            throw new NotImplementedException();
        }

        public int AverageRoomCount()
        {
            throw new NotImplementedException();
        }

        public int CategoryCount()
        {
            throw new NotImplementedException();
        }

        public string CategoryNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public string CityNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public int DifferentCityCount()
        {
            throw new NotImplementedException();
        }

        public string EmployeeNameByMaxProductCount()
        {
            throw new NotImplementedException();
        }

        public decimal LastProductPrice()
        {
            throw new NotImplementedException();
        }

        public string NewestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public string OldestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public int PassiveCategoryCount()
        {
            throw new NotImplementedException();
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }
    }
}
