namespace Micrypto.NanoDotNet.RPC.Requests.Peers
{
    public class AddWorkPeerRequest : Request
    {
        public string address;
        public int port;
    }

    public class ClearWorkPeersRequest : Request
    {
    }

    public class RetrieveOnlinePeersRequest : Request
    {
    }

    public class RetrieveWorkPeersRequest : Request
    {
    }

}
