using FieldServiceManagement.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Services
{
    public interface IStatusService
    {
        Task<Response<List<StatusDto>>> GetStatusesAsync();
    }
}
