using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Repositories
{
    public interface IServiceRequestRepository : IGenericRepository<ServiceRequest>
    {
        Task<List<ServiceRequest>> GetServiceRequestByCustomerIdWithUserAndStatusAsync(int customerId);
        Task<List<ServiceRequest>> GetOpenServiceRequestWithUserStatusProductAsync();
    }
}
