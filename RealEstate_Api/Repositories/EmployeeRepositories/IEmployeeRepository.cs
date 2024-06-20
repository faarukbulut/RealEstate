using RealEstate_Api.Dtos.EmployeeDtos;

namespace RealEstate_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        Task CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto);
        Task DeleteEmployeeAsync(int id);
        Task UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);
        Task<GetByIDEmployeeDto> GetEmployeeAsync(int id);
    }
}
