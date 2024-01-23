using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Service.Mapping;
using Microsoft.AspNetCore.Identity;

namespace FieldServiceManagement.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UserService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Response<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new AppUser { Email = createUserDto.Email, Name = createUserDto.Name, Surname = createUserDto.Surname, ZoneId = createUserDto.ZoneId, UserName = createUserDto.UserName };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();
                return Response<AppUserDto>.Fail(new ErrorDto(errors, true), 400);
            }
            return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user), 200);
        }

        public async Task<Response<List<GetUserByRoleDto>>> GetTechniciansAsync()
        {
            var technicians = await _userManager.GetUsersInRoleAsync("teknisyen");
            if (technicians.Count == 0)
            {
                return Response<List<GetUserByRoleDto>>.Fail("Username not found", 404, true);
            }
            return Response<List<GetUserByRoleDto>>.Success(ObjectMapper.Mapper.Map<List<GetUserByRoleDto>>(technicians), 200);
        }

        public async Task<Response<AppUserDto>> GetUserByNameAsync(string name)
        {
            var user = await _userManager.FindByNameAsync(name);
            if (user == null)
            {
                return Response<AppUserDto>.Fail("Username not found", 404, true);
            }
            return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user), 200);
        }

    }
}
