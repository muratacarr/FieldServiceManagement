using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Core.UniOfWorks;
using FieldServiceManagement.Service.Mapping;

namespace FieldServiceManagement.Service.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StatusService(IStatusRepository statusRepository, IUnitOfWork unitOfWork)
        {
            _statusRepository = statusRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<List<StatusDto>>> GetStatusesAsync()
        {
            var result = await _statusRepository.GetAllAsync();
            if (result.Count == 0)
            {
                return Response<List<StatusDto>>.Fail(new ErrorDto("Status yok", true), 400);
            }
            return Response<List<StatusDto>>.Success(ObjectMapper.Mapper.Map<List<StatusDto>>(result), 200);
        }
    }
}
