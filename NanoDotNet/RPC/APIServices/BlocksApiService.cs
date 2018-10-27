using Micrypto.NanoDotNet.RPC.Procs.Blocks;

namespace Micrypto.NanoDotNet.RPC.APIServices
{
    public class BlocksApiService
    {
        private Client.IClient _client;

        private BlocksApiService()
        {
        }

        public BlocksApiService(Client.IClient client)
        {
            _client = client;
        }

        public BlockAccount BlockAccount
        {
            get
            {
                return new BlockAccount(_client);
            }
        }

        public BlockCount BlockCount
        {
            get
            {
                return new BlockCount(_client);
            }
        }

        public BlockCountByType BlockCountByType
        {
            get
            {
                return new BlockCountByType(_client);
            }
        }

        public Chain Chain
        {
            get
            {
                return new Chain(_client);
            }
        }

        public CreateBlockChange CreateBlockChange
        {
            get
            {
                return new CreateBlockChange(_client);
            }
        }

        public CreateBlockOpen CreateBlockOpen
        {
            get
            {
                return new CreateBlockOpen(_client);
            }
        }

        public CreateBlockReceive CreateBlockReceive
        {
            get
            {
                return new CreateBlockReceive(_client);
            }
        }

        public CreateBlockSend CreateBlockSend
        {
            get
            {
                return new CreateBlockSend(_client);
            }
        }

        public ProcessBlock ProcessBlock
        {
            get
            {
                return new ProcessBlock(_client);
            }
        }

        public RetrieveBlock RetrieveBlock
        {
            get
            {
                return new RetrieveBlock(_client);
            }
        }

        public RetrieveBlocks RetrieveBlocks
        {
            get
            {
                return new RetrieveBlocks(_client);
            }
        }

        public RetrieveBlocksWithInfo RetrieveBlocksWithInfo
        {
            get
            {
                return new RetrieveBlocksWithInfo(_client);
            }
        }
    }
}
