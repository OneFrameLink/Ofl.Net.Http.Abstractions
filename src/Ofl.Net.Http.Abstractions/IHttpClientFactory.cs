using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Net.Http
{
    public interface IHttpClientFactory
    {
        Task<HttpClient> CreateAsync(HttpMessageHandler handler, bool disposeHandler, CancellationToken cancellationToken);
    }
}
