using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public override int Id { get => base.Id; set => base.Id = value; }
    }
}
