using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.ToDoListRepositories;

namespace RealEstate_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ToDoListsController : ControllerBase
	{
		private readonly IToDoListRepository _todoListRepository;

		public ToDoListsController(IToDoListRepository todoListRepository)
		{
			_todoListRepository = todoListRepository;
		}

		[HttpGet]
		public async Task<IActionResult> ToDoListList()
		{
			var values = await _todoListRepository.GetAllToDoListAsync();
			return Ok(values);
		}
	}
}
