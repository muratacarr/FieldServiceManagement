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
    public class ServiceRequestRepository : GenericRepository<ServiceRequest>, IServiceRequestRepository
    {
        public ServiceRequestRepository(AppDbContext appDbContext) : base(appDbContext)
        { 
        }
        
        public async Task<List<ServiceRequest>> GetServiceRequestByCustomerIdWithUserAndStatusAsync(int customerId)
        {
            return await _dbSet.Include(x=>x.AppUser).Include(x=>x.Status).Include(x=>x.Product).Where(x=>x.CustomerId==customerId).ToListAsync();
        }
        public async Task<List<ServiceRequest>> GetOpenServiceRequestWithUserStatusProductAsync()
        {
            return await _dbSet.Include(x => x.AppUser).ThenInclude(x=>x.Zone).Include(x => x.Status).Include(x => x.Product).Where(x => x.StatusId == 1).ToListAsync();
        }


    }
}
