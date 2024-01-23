using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Core.UniOfWorks;
using FieldServiceManagement.Repository.Repositories;
using FieldServiceManagement.Service.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Service.Services
{
    public class JobAssignmentService : IJobAssignmentService
    {
        private readonly IJobAssignmentRepository _jobAssignmentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public JobAssignmentService(IJobAssignmentRepository jobAssignmentRepository, IUnitOfWork unitOfWork)
        {
            _jobAssignmentRepository = jobAssignmentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<JobAssignmentDto>> CreateJobAssignmentAsync(CreateJobAssignmentDto createJobAssignmentDto)
        {
            var jobAssignment = new JobAssignment
            {
                ServiceRequestId=createJobAssignmentDto.ServiceRequestId,
                AssignmentDate=createJobAssignmentDto.AssignmentDate
            };
            var result = await _jobAssignmentRepository.AddAsync(jobAssignment);
            await _unitOfWork.SaveChangesAsync();

            if (result == null)
            {
                return Response<JobAssignmentDto>.Fail(new ErrorDto("İş ataması yapılamadı", true), 400);
            }
            return Response<JobAssignmentDto>.Success(ObjectMapper.Mapper.Map<JobAssignmentDto>(result), 200);
        }

        public async Task<Response<List<JobAssignmentDto>>> GetJobAssignmentAsync()
        {
            var result = await _jobAssignmentRepository.GetAllAsync();
            if (result.Count == 0)
            {
                return Response<List<JobAssignmentDto>>.Fail(new ErrorDto("İş talebi yok", true), 400);
            }
            return Response<List<JobAssignmentDto>>.Success(ObjectMapper.Mapper.Map<List<JobAssignmentDto>>(result), 200);
        }
    }
}
