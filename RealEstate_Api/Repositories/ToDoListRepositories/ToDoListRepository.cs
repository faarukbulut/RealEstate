using Dapper;
using RealEstate_Api.Dtos.ToDoListDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.ToDoListRepositories
{
	public class ToDoListRepository : IToDoListRepository
	{
		private readonly Context _context;

		public ToDoListRepository(Context context)
		{
			_context = context;
		}

		public Task CreateToDoListAsync(CreateToDoListDto ToDoListDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteToDoListAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ResultToDoListDto>> GetAllToDoListAsync()
		{
			string query = "Select * From ToDoList";

			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultToDoListDto>(query);
				return values.ToList();
			}
		}

		public Task<GetByIDToDoListDto> GetToDoListAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateToDoListAsync(UpdateToDoListDto ToDoListDto)
		{
			throw new NotImplementedException();
		}
	}
}
