using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Core.UniOfWorks;
using FieldServiceManagement.Service.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<List<GetProductDto>>> GetProducts()
        {
            var result = await _productRepository.GetAllAsync();
            if (result.Count == 0)
            {
                return Response<List<GetProductDto>>.Fail(new ErrorDto("Product yok", true), 400);
            }
            return Response<List<GetProductDto>>.Success(ObjectMapper.Mapper.Map<List<GetProductDto>>(result), 200);
        }
    }
}
