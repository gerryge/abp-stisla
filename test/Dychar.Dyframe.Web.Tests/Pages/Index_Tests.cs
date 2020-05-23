using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Dychar.Dyframe.Pages
{
    public class Index_Tests : DyframeWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
