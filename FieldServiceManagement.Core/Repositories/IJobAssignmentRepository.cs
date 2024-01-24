using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Repositories
{
    public interface IJobAssignmentRepository : IGenericRepository<JobAssignment>
    {
        Task<List<JobAssignment>> GetJobAssignmentWithServiceRequestAsync();
        Task<List<JobAssignment>> GetJobsByTechnicianIdWithServiceRequestAsync(int technicianId);
    }
}
