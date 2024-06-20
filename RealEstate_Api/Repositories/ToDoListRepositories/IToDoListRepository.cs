using RealEstate_Api.Dtos.ToDoListDtos;

namespace RealEstate_Api.Repositories.ToDoListRepositories
{
	public interface IToDoListRepository
	{
		Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        Task CreateToDoListAsync(CreateToDoListDto ToDoListDto);
        Task DeleteToDoListAsync(int id);
        Task UpdateToDoListAsync(UpdateToDoListDto ToDoListDto);
		Task<GetByIDToDoListDto> GetToDoListAsync(int id);
	}
}
