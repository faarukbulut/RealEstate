using RealEstate_Api.Dtos.ContactDtos;

namespace RealEstate_Api.Repositories.ContactRepositories
{
	public interface IContactRepository
	{
		Task<List<ResultContactDto>> GetAllContactAsync();
		Task<List<Last4ContactResultDto>> GetLast4ContactAsync();
        Task CreateContactAsync(CreateContactDto createContactDto);
        Task DeleteContactAsync(int id);
		Task<GetByIDContactDto> GetContactAsync(int id);
	}
}
