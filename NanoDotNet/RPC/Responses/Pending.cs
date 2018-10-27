namespace Micrypto.NanoDotNet.RPC.Responses.Pending
{
    public class PendingResponse : Response
    {
        public string[] blocks;
    }

    public class PendingExistsResponse : Response
    {
        public string exists;
    }

    public class SearchPendingResponse : Response
    {
        public string started;
    }

    public class SearchPendingAllWalletsResponse : Response
    {
        public string success;
    }
}
