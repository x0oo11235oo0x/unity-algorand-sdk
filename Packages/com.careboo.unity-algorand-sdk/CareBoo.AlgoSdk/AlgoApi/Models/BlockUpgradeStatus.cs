using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public struct BlockUpgradeStatus
        : IEquatable<BlockUpgradeStatus>
    {
        [AlgoApiKey("current-protocol")]
        public FixedString128Bytes CurrentProtocol;

        [AlgoApiKey("next-protocol")]
        public FixedString128Bytes NextProtocol;

        [AlgoApiKey("next-protocol-approvals")]
        public Optional<ulong> NextProtocolApprovals;

        [AlgoApiKey("next-protocol-switch-on")]
        public Optional<ulong> NextProtocolSwitchOn;

        [AlgoApiKey("next-protocol-vote-before")]
        public Optional<ulong> NextProtocolVoteBefore;


        public bool Equals(BlockUpgradeStatus other)
        {
            return CurrentProtocol.Equals(other.CurrentProtocol)
                && NextProtocol.Equals(other.NextProtocol)
                && NextProtocolApprovals.Equals(other.NextProtocolApprovals)
                && NextProtocolSwitchOn.Equals(other.NextProtocolSwitchOn)
                && NextProtocolVoteBefore.Equals(other.NextProtocolVoteBefore)
                ;
        }
    }
}