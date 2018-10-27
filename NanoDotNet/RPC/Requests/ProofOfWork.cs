namespace Micrypto.NanoDotNet.RPC.Requests.ProofOfWork
{
    public class WorkCancelRequest : Request
    {
        public string hash;
    }

    public class WorkGenerateRequest : Request
    {
        public string hash;
    }

    public class WorkGetRequest : Request
    {
        public string wallet;
        public string account;
    }

    public class WorkSetRequest : Request
    {
        public string wallet;
        public string account;
        public string work;
    }


    public class WorkValidateRequest : Request
    {
        public string work;
        public string hash;
    }

}
