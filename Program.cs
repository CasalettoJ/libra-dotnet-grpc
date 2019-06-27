using System;
using Grpc.Core;

namespace libra_grpc_example
{
    class Program
    {
        private const string testnetAddr = "ac.testnet.libra.org:8000";

        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Opening channel to testnet...");
                Channel channel = new Channel(testnetAddr, ChannelCredentials.Insecure);
                var client = new AdmissionControl.AdmissionControl.AdmissionControlClient(channel);
                Console.WriteLine("Client created.  Testing empty UpdateToLatestLedger call...");

                var request = new Types.UpdateToLatestLedgerRequest();
                request.ClientKnownVersion = 0;
                var response = client.UpdateToLatestLedger(request);
                Console.WriteLine();
                Console.WriteLine($"Ledger Version: {response.LedgerInfoWithSigs.LedgerInfo.Version}");
                Console.WriteLine($"Transaction Accumulator Hash: {response.LedgerInfoWithSigs.LedgerInfo.TransactionAccumulatorHash.ToBase64()}");
                Console.WriteLine($"Consensus Data Hash: {response.LedgerInfoWithSigs.LedgerInfo.ConsensusDataHash.ToBase64()}");
                Console.WriteLine($"Consensus Block ID: {response.LedgerInfoWithSigs.LedgerInfo.ConsensusBlockId.ToBase64()}");
                Console.WriteLine($"EpochNum: {response.LedgerInfoWithSigs.LedgerInfo.EpochNum}");
                Console.WriteLine($"Timestamp: {response.LedgerInfoWithSigs.LedgerInfo.TimestampUsecs} (microseconds unix time)");
                Console.WriteLine("Validators:"); 

                int i = 1;
                foreach(var validator in response.LedgerInfoWithSigs.Signatures)
                {
                    Console.WriteLine($"#{i++}:");
                    Console.WriteLine($"Signature: {validator.Signature.ToBase64()}");
                    Console.WriteLine($"Validator ID: {validator.ValidatorId.ToBase64()}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            } 
        }
    }
}
