namespace Micrypto.NanoDotNet.RPC.Responses.ProofOfWork
{
    public class WorkCancelResponse : Response
    {
    }

    public class WorkGenerateResponse : Response
    {
        public string work;
    }

    public class WorkGetResponse : Response
    {
        public string work;
    }

    public class WorkSetResponse : Response
    {
        public string success;
    }

    public class WorkValidateResponse : Response
    {
        public string valid;
    }
}
