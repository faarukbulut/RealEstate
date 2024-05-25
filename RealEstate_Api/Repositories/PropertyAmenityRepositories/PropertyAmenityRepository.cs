using Dapper;
using RealEstate_Api.Dtos.PropertyAmenityDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;

        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id)
        {
            string query = "Select PropertyAmenityId,Title From PropertyAmenity Inner Join Amenity On Amenity.AmenityId=PropertyAmenityId Where PropertyId=@propertyId And Status=@status";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            parameters.Add("@status", true);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
