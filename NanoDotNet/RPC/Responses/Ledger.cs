using System.Collections.Generic;

namespace Micrypto.NanoDotNet.RPC.Responses.Ledger
{
    public class HistoryResponse : Response
    {
        public DTOs.History[] history;
    }

    public class LedgerResponse : Response
    {
        public Dictionary<string, DTOs.Account> accounts;
    }

    public class SuccessorsResponse : Response
    {
        public string[] blocks;
    }
}
