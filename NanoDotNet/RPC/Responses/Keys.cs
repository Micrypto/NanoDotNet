namespace Micrypto.NanoDotNet.RPC.Responses.Keys
{
    public class DeterministicKeyResponse : Response
    {
        public string @private;
        public string @public;
        public string account;
    }

    public class KeyCreateResponse : Response
    {
        public string @private;
        public string @public;
        public string account;
    }

    public class KeyExpandResponse : Response
    {
        public string @private;
        public string @public;
        public string account;
    }

}
