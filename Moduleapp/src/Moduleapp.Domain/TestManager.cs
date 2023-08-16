using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Services;
using Volo.Abp.Identity;

namespace Moduleapp;

public class TestManager : DomainService
{
    private readonly IIdentityUserAppService _identityUserAppService;

    public TestManager(IIdentityUserAppService identityUserAppService)
    {
        _identityUserAppService = identityUserAppService;
    }

    public async Task<PagedResultDto<IdentityUserDto>> GetUsersAsync()
    {
       return await _identityUserAppService.GetListAsync(new GetIdentityUsersInput());
    }
}