﻿using RealEstate_Api.Dtos.ServiceDtos;

namespace RealEstate_Api.Repositories.ServiceRepositories
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto serviceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto serviceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}