using Beyonic.Services;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BeyonicEndpoints.Test
{
    public class BeyonicEnpoints_Tests
    {
        [Test]
        [Category("beyonicnetworks")]
        public async Task BeyonicEnpoints_Networks_Tests()
        {
            var networksAPI = new BeyonicServices();
            var reasonPhrase = await networksAPI.GetNetworks();
            Assert.True(reasonPhrase!=null);
        }
        [Test]
        [Category("beyoniccurrencies")]
        public async Task BeyonicEnpoints_Currencies_Tests()
        {
            var networksAPI = new BeyonicServices();
            var reasonPhrase = await networksAPI.GetCurrencies();
            Assert.True(reasonPhrase.Results.Length>0);
        }
    }
}