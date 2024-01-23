using FieldServiceManagement.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Services
{
    public interface IProductService
    {
        Task<Response<List<GetProductDto>>> GetProducts();
    }
}
