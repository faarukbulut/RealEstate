using RealEstate_Api.Dtos.ToDoListDtos;

namespace RealEstate_Api.Repositories.ToDoListRepositories
{
	public interface IToDoListRepository
	{
		Task<List<ResultToDoListDto>> GetAllToDoListAsync();
		void CreateToDoList(CreateToDoListDto ToDoListDto);
		void DeleteToDoList(int id);
		void UpdateToDoList(UpdateToDoListDto ToDoListDto);
		Task<GetByIDToDoListDto> GetToDoList(int id);
	}
}
