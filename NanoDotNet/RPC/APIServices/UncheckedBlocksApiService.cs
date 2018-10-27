using Micrypto.NanoDotNet.RPC.Procs.UncheckedBlocks;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class UncheckedBlocksApiService
    {
        private Client.IClient _client;

        private UncheckedBlocksApiService()
        {
        }

        public UncheckedBlocksApiService(Client.IClient client)
        {
            _client = client;
        }

        public ClearUncheckedBlocks ClearUncheckedBlocks
        {
            get
            {
                return new ClearUncheckedBlocks(_client);
            }
        }

        public RetrieveUncheckedBlock RetrieveUncheckedBlock
        {
            get
            {
                return new RetrieveUncheckedBlock(_client);
            }
        }

        public UncheckedBlocks UncheckedBlocks
        {
            get
            {
                return new UncheckedBlocks(_client);
            }
        }

        public UncheckedBlocksWithDatabaseKeys UncheckedBlocksWithDatabaseKeys
        {
            get
            {
                return new UncheckedBlocksWithDatabaseKeys(_client);
            }
        }
    }
}