using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.Client
{
    public interface IClient
    {
        Task<T> SendRequestAsync<T>(RPC.Requests.Request request);
    }
}
