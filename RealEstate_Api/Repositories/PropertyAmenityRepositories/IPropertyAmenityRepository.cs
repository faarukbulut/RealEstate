﻿using RealEstate_Api.Dtos.PropertyAmenityDtos;

namespace RealEstate_Api.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrueAsync(int id);
    }
}
