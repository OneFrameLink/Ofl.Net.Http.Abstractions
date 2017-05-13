using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Ofl.Net.Http.Abstractions.Tests
{
    public class HttpClientFactoryTests
    {
        private class HttpClientFactory : IHttpClientFactory
        {
            #region Implementation of IHttpClientFactory

            public Task<HttpClient> CreateAsync(HttpMessageHandler handler, bool disposeHandler, CancellationToken cancellationToken)
            {
                // Return a new client.
                return Task.FromResult(new HttpClient());
            }

            #endregion
        }

        [Fact]
        public async Task Test_CreateAsync_Interface_Async()
        {
            // Cancellation token.
            CancellationToken cancellationToken = CancellationToken.None;

            // The client factory.
            IHttpClientFactory factory = new HttpClientFactory();

            // Not null.
            Assert.NotNull(factory);

            // Create client.
            HttpClient client = await factory.CreateAsync(null, true, cancellationToken).ConfigureAwait(false);

            // Not null.
            Assert.NotNull(client);
        }

        [Fact]
        public async Task Test_CreateAsync_Concrete_Async()
        {
            // Cancellation token.
            CancellationToken cancellationToken = CancellationToken.None;

            // The client factory.
            var factory = new HttpClientFactory();

            // Not null.
            Assert.NotNull(factory);

            // Create client.
            HttpClient client = await factory.CreateAsync(null, true, cancellationToken).ConfigureAwait(false);

            // Not null.
            Assert.NotNull(client);
        }
    }
}
