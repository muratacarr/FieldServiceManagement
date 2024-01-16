using FieldServiceManagement.Core.Configuration;
using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;

namespace FieldServiceManagement.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(AppUser appUser);
        ClientTokenDto CreatetokenByClient(Client client);
    }
}
