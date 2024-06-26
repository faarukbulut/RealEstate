﻿using Dapper;
using RealEstate_Api.Dtos.ContactDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.ContactRepositories
{
	public class ContactRepository : IContactRepository
	{
		private readonly Context _context;

		public ContactRepository(Context context)
		{
			_context = context;
		}

		public Task CreateContactAsync(CreateContactDto createContactDto)
		{
			throw new NotImplementedException();
		}

		public Task DeleteContactAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ResultContactDto>> GetAllContactAsync()
		{
			throw new NotImplementedException();
		}

		public Task<GetByIDContactDto> GetContactAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Last4ContactResultDto>> GetLast4ContactAsync()
		{
			string query = "Select Top(4) * From Contact order by ContactID Desc";

			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<Last4ContactResultDto>(query);
				return values.ToList();
			}
		}
	}
}
