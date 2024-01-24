using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class UpdateStatusOfServiceRequestDto
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
    }
}
