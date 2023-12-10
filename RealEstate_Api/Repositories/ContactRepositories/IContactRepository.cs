using RealEstate_Api.Dtos.ContactDtos;

namespace RealEstate_Api.Repositories.ContactRepositories
{
	public interface IContactRepository
	{
		Task<List<ResultContactDto>> GetAllContactAsync();
		Task<List<Last4ContactResultDto>> GetLast4ContactAsync();
		void CreateContact(CreateContactDto createContactDto);
		void DeleteContact(int id);
		Task<GetByIDContactDto> GetContact(int id);
	}
}
