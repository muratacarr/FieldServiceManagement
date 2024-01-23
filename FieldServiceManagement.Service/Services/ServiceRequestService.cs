using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Core.UniOfWorks;
using FieldServiceManagement.Service.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Service.Services
{
    public class ServiceRequestService : IServiceRequestService
    {
        private readonly IServiceRequestRepository _serviceRequestRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceRequestService(IServiceRequestRepository serviceRequestRepository, IUnitOfWork unitOfWork)
        {
            _serviceRequestRepository = serviceRequestRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<ServiceRequestDto>> CreateServiceRequestAsync(CreateServiceRequestDto createServiceRequestDto)
        {
            var serviceRequest = new ServiceRequest
            {
                CustomerId = createServiceRequestDto.CustomerId,
                ProductId = createServiceRequestDto.ProductId,
                RequestDate = createServiceRequestDto.RequestDate,
                ZoneId = createServiceRequestDto.ZoneId,
                IssueDescription = createServiceRequestDto.IssueDescription,
                StatusId = createServiceRequestDto.StatusId
            };

            var result = await _serviceRequestRepository.AddAsync(serviceRequest);
            await _unitOfWork.SaveChangesAsync();

            if (result == null)
            {
                return Response<ServiceRequestDto>.Fail(new ErrorDto("Servis talebi eklenemedi", true), 400);
            }
            return Response<ServiceRequestDto>.Success(ObjectMapper.Mapper.Map<ServiceRequestDto>(serviceRequest), 200);
        }

        public async Task<Response<List<ServiceRequestDto>>> GetOpenServiceRequestAsync()
        {
            var result = await _serviceRequestRepository.Where(x => x.StatusId==1).ToListAsync();
            if (result.Count == 0)
            {
                return Response<List<ServiceRequestDto>>.Fail(new ErrorDto("Servis talebi yok", true), 400);
            }
            return Response<List<ServiceRequestDto>>.Success(ObjectMapper.Mapper.Map<List<ServiceRequestDto>>(result), 200);
        }

        public async Task<Response<List<ServiceRequestDto>>> GetServiceRequestByCustomerIdAsync(GetServiceRequestDto getServiceRequestDto)
        {
            var result = await _serviceRequestRepository.Where(x => x.CustomerId == getServiceRequestDto.CustomerId).ToListAsync();
            if (result.Count == 0)
            {
                return Response<List<ServiceRequestDto>>.Fail(new ErrorDto("Servis talebi yok", true), 400);
            }
            return Response<List<ServiceRequestDto>>.Success(ObjectMapper.Mapper.Map<List<ServiceRequestDto>>(result), 200);
        }
    }
}
