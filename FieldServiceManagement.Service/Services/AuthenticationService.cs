using FieldServiceManagement.Core.Configuration;
using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Models;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Core.UniOfWorks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FieldServiceManagement.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly List<Client> _clients;
        private readonly ITokenService _tokenService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<UserRefreshToken> _userRefreshTokenService;

        public AuthenticationService(IGenericRepository<UserRefreshToken> userRefreshTokenService, IOptions<List<Client>> optionsClient, ITokenService tokenService, UserManager<AppUser> userManager, IUnitOfWork unitOfWork)
        {
            _userRefreshTokenService = userRefreshTokenService;
            _clients = optionsClient.Value;
            _tokenService = tokenService;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto)
        {
            if (loginDto == null) throw new ArgumentNullException(nameof(loginDto));
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) return Response<TokenDto>.Fail("Email or Password is wrong", 400, true);
            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
            {
                return Response<TokenDto>.Fail("Email or Password is wrong", 400, true);
            }
            var token = _tokenService.CreateToken(user);
            var userRefreshToken = await _userRefreshTokenService.Where(x => x.AppUserId == user.Id).SingleOrDefaultAsync();
            if (userRefreshToken == null)
            {
                await _userRefreshTokenService.AddAsync(new UserRefreshToken { AppUserId = user.Id, Code = token.RefreshToken, Expriration = token.RefreshTokenExpiration });
            }
            else
            {
                userRefreshToken.Code = token.RefreshToken;
                userRefreshToken.Expriration = token.RefreshTokenExpiration;
            }
            await _unitOfWork.SaveChangesAsync();

            return Response<TokenDto>.Success(token, 200);
        }

        public Response<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto)
        {
            var client = _clients.SingleOrDefault(x => x.Id == clientLoginDto.ClientId && x.Secret == clientLoginDto.ClientSecret);
            if (client == null) return Response<ClientTokenDto>.Fail("ClientId or ClientSecret not found", 404, true);
            var token = _tokenService.CreatetokenByClient(client);
            return Response<ClientTokenDto>.Success(token, 200);
        }

        public async Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken)
        {
            var existRefreshToken = await _userRefreshTokenService.Where(x => x.Code == refreshToken).SingleOrDefaultAsync();
            if (existRefreshToken == null) return Response<TokenDto>.Fail("Refresh token not found", 404, true);
            var user = await _userManager.FindByIdAsync(existRefreshToken.AppUserId.ToString());
            if (user == null) return Response<TokenDto>.Fail("User Id not found", 404, true);
            var tokenDto = _tokenService.CreateToken(user);
            existRefreshToken.Code = tokenDto.RefreshToken;
            existRefreshToken.Expriration = tokenDto.RefreshTokenExpiration;

            await _unitOfWork.SaveChangesAsync();

            return Response<TokenDto>.Success(tokenDto, 200);
        }

        public async Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken)
        {
            var existRefreshToken = await _userRefreshTokenService.Where(x => x.Code == refreshToken).SingleOrDefaultAsync();
            if (existRefreshToken == null) return Response<NoDataDto>.Fail("Refresh token not found", 404, true);

            _userRefreshTokenService.Delete(existRefreshToken);
            await _unitOfWork.SaveChangesAsync();

            return Response<NoDataDto>.Success(200);
        }
    }
}
