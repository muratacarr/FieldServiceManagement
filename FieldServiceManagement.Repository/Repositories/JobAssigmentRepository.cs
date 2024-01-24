using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Repository.Repositories
{
    public class JobAssigmentRepository : GenericRepository<JobAssignment>, IJobAssignmentRepository
    {
        public JobAssigmentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public async Task<List<JobAssignment>> GetJobAssignmentWithServiceRequestAsync()
        {
            return await _dbSet.Include(x => x.ServiceRequest).ThenInclude(x=>x.AppUser).Include(x => x.ServiceRequest).ThenInclude(x=>x.Product).Include(x => x.ServiceRequest).ThenInclude(x=>x.Status).Include(x => x.AppUserTechnician).ToListAsync();
        }
        public async Task<List<JobAssignment>> GetJobsByTechnicianIdWithServiceRequestAsync(int technicianId)
        {
            return await _dbSet.Include(x => x.ServiceRequest).ThenInclude(x => x.AppUser).Include(x => x.ServiceRequest).ThenInclude(x => x.Product).Include(x => x.ServiceRequest).ThenInclude(x => x.Status).Include(x => x.AppUserTechnician).Where(x=>x.TechnicianId==technicianId).ToListAsync();
        }

    }
}
