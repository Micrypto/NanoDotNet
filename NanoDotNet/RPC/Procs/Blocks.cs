using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Micrypto.NanoDotNet.RPC.Procs.Blocks
{
    public class BlockAccount
    {
        private Client.IClient _client;

        private BlockAccount()
        {
        }

        public BlockAccount(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.BlockAccountResponse> SendRequestAsync(string hash)
        {
            Requests.Blocks.BlockAccountRequest request = new Requests.Blocks.BlockAccountRequest();

            request.action = "block_account";
            request.hash = hash;

            return _client.SendRequestAsync<Responses.Blocks.BlockAccountResponse>(request);
        }
    }

    public class BlockCountByType
    {
        private Client.IClient _client;

        private BlockCountByType()
        {
        }

        public BlockCountByType(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.BlockCountByTypeResponse> SendRequestAsync()
        {
            Requests.Blocks.BlockCountByTypeRequest request = new Requests.Blocks.BlockCountByTypeRequest();

            request.action = "block_count_type";

            return _client.SendRequestAsync<Responses.Blocks.BlockCountByTypeResponse>(request);
        }
    }

    public class BlockCount
    {
        private Client.IClient _client;

        private BlockCount()
        {
        }

        public BlockCount(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.BlockCountResponse> SendRequestAsync()
        {
            Requests.Blocks.BlockCountRequest request = new Requests.Blocks.BlockCountRequest();

            request.action = "block_count";

            return _client.SendRequestAsync<Responses.Blocks.BlockCountResponse>(request);
        }
    }

    public class Chain
    {
        private Client.IClient _client;

        private Chain()
        {
        }

        public Chain(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.ChainResponse> SendRequestAsync(string block, BigInteger count)
        {
            Requests.Blocks.ChainRequest request = new Requests.Blocks.ChainRequest();

            request.action = "chain";
            request.block = block;
            request.count = count;

            return _client.SendRequestAsync<Responses.Blocks.ChainResponse>(request);
        }
    }

    public class CreateBlockOpen
    {
        private Client.IClient _client;

        private CreateBlockOpen()
        {
        }

        public CreateBlockOpen(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.CreateBlockOpenResponse> SendRequestAsync(string key, string account, string representative, string source)
        {
            Requests.Blocks.CreateBlockOpenRequest request = new Requests.Blocks.CreateBlockOpenRequest();

            request.action = "block_create";
            request.type = "open";
            request.key = key;
            request.account = account;
            request.representative = representative;
            request.source = source;

            return _client.SendRequestAsync<Responses.Blocks.CreateBlockOpenResponse>(request);
        }
    }

    public class CreateBlockReceive
    {
        private Client.IClient _client;

        private CreateBlockReceive()
        {
        }

        public CreateBlockReceive(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.CreateBlockReceiveResponse> SendRequestAsync(string wallet, string account, string source, string previous)
        {
            Requests.Blocks.CreateBlockReceiveRequest request = new Requests.Blocks.CreateBlockReceiveRequest();

            request.action = "block_create";
            request.type = "receive";
            request.wallet = wallet;
            request.account = account;
            request.source = source;
            request.previous = previous;

            return _client.SendRequestAsync<Responses.Blocks.CreateBlockReceiveResponse>(request);
        }
    }

    public class CreateBlockSend
    {
        private Client.IClient _client;

        private CreateBlockSend()
        {
        }

        public CreateBlockSend(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.CreateBlockSendResponse> SendRequestAsync(string wallet, string account, string destination, BigInteger balance, BigInteger amount, string previous)
        {
            Requests.Blocks.CreateBlockSendRequest request = new Requests.Blocks.CreateBlockSendRequest();

            request.action = "block_create";
            request.type = "send";
            request.wallet = wallet;
            request.account = account;
            request.destination = destination;
            request.balance = balance;
            request.amount = amount;
            request.previous = previous;

            return _client.SendRequestAsync<Responses.Blocks.CreateBlockSendResponse>(request);
        }
    }

    public class CreateBlockChange
    {
        private Client.IClient _client;

        private CreateBlockChange()
        {
        }

        public CreateBlockChange(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.CreateBlockChangeResponse> SendRequestAsync(string wallet, string account, string representative, string previous)
        {
            Requests.Blocks.CreateBlockChangeRequest request = new Requests.Blocks.CreateBlockChangeRequest();

            request.action = "block_create";
            request.type = "change";
            request.wallet = wallet;
            request.account = account;
            request.representative = representative;
            request.previous = previous;

            return _client.SendRequestAsync<Responses.Blocks.CreateBlockChangeResponse>(request);
        }
    }

    public class ProcessBlock
    {
        private Client.IClient _client;

        private ProcessBlock()
        {
        }

        public ProcessBlock(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.ProcessBlockResponse> SendRequestAsync(string block)
        {
            Requests.Blocks.ProcessBlockRequest request = new Requests.Blocks.ProcessBlockRequest();

            request.action = "process";
            request.block = block;

            return _client.SendRequestAsync<Responses.Blocks.ProcessBlockResponse>(request);
        }
    }

    public class RetrieveBlock
    {
        private Client.IClient _client;

        private RetrieveBlock()
        {
        }

        public RetrieveBlock(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.RetrieveBlockResponse> SendRequestAsync(string hash)
        {
            Requests.Blocks.RetrieveBlockRequest request = new Requests.Blocks.RetrieveBlockRequest();

            request.action = "block";
            request.hash = hash;

            return _client.SendRequestAsync<Responses.Blocks.RetrieveBlockResponse>(request);
        }
    }

    public class RetrieveBlocks
    {
        private Client.IClient _client;

        private RetrieveBlocks()
        {
        }

        public RetrieveBlocks(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.RetrieveBlocksResponse> SendRequestAsync(string[] hashes)
        {
            Requests.Blocks.RetrieveBlocksRequest request = new Requests.Blocks.RetrieveBlocksRequest();

            request.action = "blocks";
            request.hashes = hashes;

            return _client.SendRequestAsync<Responses.Blocks.RetrieveBlocksResponse>(request);
        }
    }

    public class RetrieveBlocksWithInfo
    {
        private Client.IClient _client;

        private RetrieveBlocksWithInfo()
        {
        }

        public RetrieveBlocksWithInfo(Client.IClient client)
        {
            _client = client;
        }

        public Task<Responses.Blocks.RetrieveBlocksWithInfoResponse> SendRequestAsync(string[] hashes)
        {
            Requests.Blocks.RetrieveBlocksWithInfoRequest request = new Requests.Blocks.RetrieveBlocksWithInfoRequest();

            request.action = "blocks_info";
            request.hashes = hashes;

            return _client.SendRequestAsync<Responses.Blocks.RetrieveBlocksWithInfoResponse>(request);
        }
    }
}
