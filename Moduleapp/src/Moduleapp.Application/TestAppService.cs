using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace Moduleapp;

public class TestAppService : ApplicationService
{
    private readonly TestManager _testManager;

    public TestAppService(TestManager testManager)
    {
        _testManager = testManager;
    }

    public async Task<PagedResultDto<IdentityUserDto>> GetUsersAsync()
    {
        return await _testManager.GetUsersAsync();
    }
}