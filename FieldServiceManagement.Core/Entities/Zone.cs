using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Entities
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<AppUser>? AppUsers { get; set; }
    }
}
