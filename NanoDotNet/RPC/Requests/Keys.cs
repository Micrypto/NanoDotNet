using System.Numerics;

namespace Micrypto.NanoDotNet.RPC.Requests.Keys
{
    public class DeterministicKeyRequest : Request
    {
        public BigInteger seed;
        public BigInteger index;
    }

    public class KeyCreateRequest : Request
    {
    }

    public class KeyExpandRequest : Request
    {
        public string key;
    }

}
