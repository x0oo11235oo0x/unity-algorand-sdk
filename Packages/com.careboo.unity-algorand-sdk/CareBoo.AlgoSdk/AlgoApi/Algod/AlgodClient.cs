using System;
using AlgoSdk.Crypto;
using Cysharp.Threading.Tasks;
using Unity.Collections;

namespace AlgoSdk
{
    public struct AlgodClient : IAlgodClient
    {
        readonly string address;

        readonly string token;

        public AlgodClient(string address, string token)
        {
            this.address = address.TrimEnd('/');
            this.token = token;
        }

        public string Address => address;

        public string Token => token;

        public string TokenHeader => "X-Algo-API-Token";

        public async UniTask<AlgoApiResponse<AlgoApiObject>> GetGenesisInformation()
        {
            return await this
                .Get("/genesis")
                .Send();
        }

        public async UniTask<AlgoApiResponse> GetHealth()
        {
            return await this
                .Get("/health")
                .Send();
        }

        public async UniTask<AlgoApiResponse> GetMetrics()
        {
            return await this
                .Get("/metrics")
                .Send();
        }

        public async UniTask<AlgoApiResponse<AlgoApiObject>> GetSwaggerSpec()
        {
            return await this
                .Get("/swagger.json")
                .Send();
        }

        public async UniTask<AlgoApiResponse<Account>> GetAccountInformation(Address accountAddress)
        {
            return await this
                .Get($"/v2/accounts/{accountAddress}")
                .Send();
        }

        public async UniTask<AlgoApiResponse<PendingTransactions>> GetPendingTransactions(ulong max = 0)
        {
            return await this
                .Get($"/v2/transactions/pending?max={max}&format=msgpack")
                .Send();
        }

        public async UniTask<AlgoApiResponse<PendingTransactions>> GetPendingTransactions(Address accountAddress, ulong max = 0)
        {
            return await this
                .Get($"/v2/accounts/{accountAddress}/transactions/pending?max={max}")
                .Send();
        }

        public async UniTask<AlgoApiResponse<PendingTransaction>> GetPendingTransaction(Sha512_256_Hash txid)
        {
            FixedString64Bytes txidstr = default;
            Base64Encoding.CopyToBase64(txid, ref txidstr);
            return await this
                .Get($"/v2/transactions/pending/{txidstr}?format=msgpack")
                .Send();
        }

        public async UniTask<AlgoApiResponse<Application>> GetApplication(ulong applicationId)
        {
            return await this
                .Get($"/v2/applications/{applicationId}")
                .Send();
        }

        public async UniTask<AlgoApiResponse<Asset>> GetAsset(ulong assetId)
        {
            return await this
                .Get($"/v2/assets/{assetId}")
                .Send();
        }

        public async UniTask<AlgoApiResponse<BlockResponse>> GetBlock(ulong round)
        {
            return await this
                .Get($"/v2/blocks/{round}?format=msgpack")
                .Send();
        }

        public async UniTask<AlgoApiResponse<MerkleProof>> GetMerkleProof(ulong round, Sha512_256_Hash txid)
        {
            FixedString64Bytes txidstr = default;
            Base64Encoding.CopyToBase64(txid, ref txidstr);
            return await this
                .Get($"/v2/blocks/{round}/transactions/{txidstr}/proof")
                .Send();
        }

        public async UniTask<AlgoApiResponse<CatchupMessage>> StartCatchup(string catchpoint)
        {
            return await this
                .Post($"/v2/catchup/{catchpoint}")
                .Send();
        }

        public async UniTask<AlgoApiResponse<CatchupMessage>> AbortCatchup(string catchpoint)
        {
            return await this
                .Delete($"/v2/catchup/{catchpoint}")
                .Send();
        }

        public async UniTask<AlgoApiResponse<LedgerSupply>> GetLedgerSupply()
        {
            return await this
                .Get("/v2/ledger/supply")
                .Send();
        }

        public async UniTask<AlgoApiResponse<TransactionIdResponse>> RegisterParticipationKeys(
            Address accountAddress,
            ulong fee = 1000,
            Optional<ulong> keyDilution = default,
            Optional<bool> noWait = default,
            Optional<bool> roundLastValid = default)
        {
            using var queryBuilder = new QueryBuilder(Allocator.Persistent)
                .Add("fee", fee, (ulong)1000)
                .Add("key-dilution", keyDilution)
                .Add("no-wait", noWait)
                .Add("round-last-valid", roundLastValid)
                ;
            var endpoint = $"/v2/register-participation-keys/{accountAddress}{queryBuilder}";
            return await AlgoApiRequest.Post(this.GetUrl(endpoint))
                .Send();
        }

        public async UniTask<AlgoApiResponse> ShutDown(Optional<ulong> timeout = default)
        {
            return await this
                .Post("/v2/shutdown")
                .Send();
        }

        public async UniTask<AlgoApiResponse<Status>> GetCurrentStatus()
        {
            return await this
                .Get("/v2/status")
                .Send();
        }

        public async UniTask<AlgoApiResponse<Status>> GetStatusAfterWaitingForRound(ulong round)
        {
            return await this
                .Get($"/v2/status/wait-for-block-after/{round}")
                .Send();
        }

        public async UniTask<AlgoApiResponse<TealCompilationResult>> TealCompile(string source)
        {
            return await this
                .Post("/v2/teal/compile")
                .SetPlainTextBody(source)
                .Send();
        }

        public async UniTask<AlgoApiResponse<DryrunResults>> TealDryrun(Optional<DryrunRequest> dryrunRequest = default)
        {
            const string endpoint = "/v2/teal/dryrun";
            using var data = AlgoApiSerializer.SerializeMessagePack(dryrunRequest.Value, Allocator.Persistent);
            return dryrunRequest.HasValue
                ? await this
                    .Post(endpoint)
                    .SetMessagePackBody(data.AsArray().AsReadOnly())
                    .Send()
                : await this
                    .Post(endpoint)
                    .Send()
                ;
        }

        public async UniTask<AlgoApiResponse<TransactionIdResponse>> SendTransaction<T>(Signed<T> txn)
            where T : struct, ITransaction, IEquatable<T>
        {
            using var data = AlgoApiSerializer.SerializeMessagePack(txn, Allocator.Persistent);
            return await this
                .Post("/v2/transactions")
                .SetMessagePackBody(data.AsArray().AsReadOnly())
                .Send();
        }

        public async UniTask<AlgoApiResponse<TransactionParams>> GetSuggestedParams()
        {
            return await this
                .Get("/v2/transactions/params")
                .Send();
        }

        public async UniTask<AlgoApiResponse<Version>> GetVersions()
        {
            return await this
                .Get("/versions")
                .Send();
        }
    }
}
