using FieldServiceManagement.Core.Configuration;
using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(AppUser appUser);
        ClientTokenDto CreatetokenByClient(Client client);
    }
}
