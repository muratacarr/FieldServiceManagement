using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Services
{
    public interface IJobAssignmentService
    {
        Task<Response<List<JobAssignmentDto>>> GetJobAssignmentAsync();
        Task<Response<JobAssignmentDto>> CreateJobAssignmentAsync(CreateJobAssignmentDto createJobAssignmentDto);
    }
}
