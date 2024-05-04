﻿using RealEstate_Api.Dtos.ProductImageDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.ProductImageRepositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly Context _context;

        public ProductImageRepository(Context context)
        {
            _context = context;
        }

        public Task<GetProductImageByProductIdDto> GetProductImageByProductId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
