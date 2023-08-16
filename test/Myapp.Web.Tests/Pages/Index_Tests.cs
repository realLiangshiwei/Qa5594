using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Myapp.Pages;

public class Index_Tests : MyappWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
