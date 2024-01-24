using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.DTOs
{
    public class StatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Percent { get; set; }
        public string Color { get; set; } = null!;
        public bool ShowTechnician { get; set; }

    }
}
