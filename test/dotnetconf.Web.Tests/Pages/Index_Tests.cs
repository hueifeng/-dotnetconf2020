using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace dotnetconf.Pages
{
    public class Index_Tests : dotnetconfWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
