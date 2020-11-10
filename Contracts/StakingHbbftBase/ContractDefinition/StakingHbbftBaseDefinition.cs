using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace DMDVision.Contracts.StakingHbbftBase.ContractDefinition
{


    public partial class StakingHbbftBaseDeployment : StakingHbbftBaseDeploymentBase
    {
        public StakingHbbftBaseDeployment() : base(BYTECODE) { }
        public StakingHbbftBaseDeployment(string byteCode) : base(byteCode) { }
    }

    public class StakingHbbftBaseDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public StakingHbbftBaseDeploymentBase() : base(BYTECODE) { }
        public StakingHbbftBaseDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class MAX_CANDIDATESFunction : MAX_CANDIDATESFunctionBase { }

    [Function("MAX_CANDIDATES", "uint256")]
    public class MAX_CANDIDATESFunctionBase : FunctionMessage
    {

    }

    public partial class CandidateMinStakeFunction : CandidateMinStakeFunctionBase { }

    [Function("candidateMinStake", "uint256")]
    public class CandidateMinStakeFunctionBase : FunctionMessage
    {

    }

    public partial class DelegatorMinStakeFunction : DelegatorMinStakeFunctionBase { }

    [Function("delegatorMinStake", "uint256")]
    public class DelegatorMinStakeFunctionBase : FunctionMessage
    {

    }

    public partial class DelegatorStakeSnapshotFunction : DelegatorStakeSnapshotFunctionBase { }

    [Function("delegatorStakeSnapshot", "uint256")]
    public class DelegatorStakeSnapshotFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
    }

    public partial class OrderWithdrawEpochFunction : OrderWithdrawEpochFunctionBase { }

    [Function("orderWithdrawEpoch", "uint256")]
    public class OrderWithdrawEpochFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class OrderedWithdrawAmountFunction : OrderedWithdrawAmountFunctionBase { }

    [Function("orderedWithdrawAmount", "uint256")]
    public class OrderedWithdrawAmountFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class OrderedWithdrawAmountTotalFunction : OrderedWithdrawAmountTotalFunctionBase { }

    [Function("orderedWithdrawAmountTotal", "uint256")]
    public class OrderedWithdrawAmountTotalFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolDelegatorInactiveIndexFunction : PoolDelegatorInactiveIndexFunctionBase { }

    [Function("poolDelegatorInactiveIndex", "uint256")]
    public class PoolDelegatorInactiveIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class PoolDelegatorIndexFunction : PoolDelegatorIndexFunctionBase { }

    [Function("poolDelegatorIndex", "uint256")]
    public class PoolDelegatorIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class PoolInactiveIndexFunction : PoolInactiveIndexFunctionBase { }

    [Function("poolInactiveIndex", "uint256")]
    public class PoolInactiveIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolIndexFunction : PoolIndexFunctionBase { }

    [Function("poolIndex", "uint256")]
    public class PoolIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolInfoFunction : PoolInfoFunctionBase { }

    [Function("poolInfo", typeof(PoolInfoOutputDTO))]
    public class PoolInfoFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolToBeElectedIndexFunction : PoolToBeElectedIndexFunctionBase { }

    [Function("poolToBeElectedIndex", "uint256")]
    public class PoolToBeElectedIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolToBeRemovedIndexFunction : PoolToBeRemovedIndexFunctionBase { }

    [Function("poolToBeRemovedIndex", "uint256")]
    public class PoolToBeRemovedIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RewardWasTakenFunction : RewardWasTakenFunctionBase { }

    [Function("rewardWasTaken", "bool")]
    public class RewardWasTakenFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
    }

    public partial class StakeAmountFunction : StakeAmountFunctionBase { }

    [Function("stakeAmount", "uint256")]
    public class StakeAmountFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class StakeAmountTotalFunction : StakeAmountTotalFunctionBase { }

    [Function("stakeAmountTotal", "uint256")]
    public class StakeAmountTotalFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class StakeFirstEpochFunction : StakeFirstEpochFunctionBase { }

    [Function("stakeFirstEpoch", "uint256")]
    public class StakeFirstEpochFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class StakeLastEpochFunction : StakeLastEpochFunctionBase { }

    [Function("stakeLastEpoch", "uint256")]
    public class StakeLastEpochFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class StakingEpochFunction : StakingEpochFunctionBase { }

    [Function("stakingEpoch", "uint256")]
    public class StakingEpochFunctionBase : FunctionMessage
    {

    }

    public partial class StakingEpochStartTimeFunction : StakingEpochStartTimeFunctionBase { }

    [Function("stakingEpochStartTime", "uint256")]
    public class StakingEpochStartTimeFunctionBase : FunctionMessage
    {

    }

    public partial class StakingFixedEpochDurationFunction : StakingFixedEpochDurationFunctionBase { }

    [Function("stakingFixedEpochDuration", "uint256")]
    public class StakingFixedEpochDurationFunctionBase : FunctionMessage
    {

    }

    public partial class StakingTransitionTimeframeLengthFunction : StakingTransitionTimeframeLengthFunctionBase { }

    [Function("stakingTransitionTimeframeLength", "uint256")]
    public class StakingTransitionTimeframeLengthFunctionBase : FunctionMessage
    {

    }

    public partial class StakingWithdrawDisallowPeriodFunction : StakingWithdrawDisallowPeriodFunctionBase { }

    [Function("stakingWithdrawDisallowPeriod", "uint256")]
    public class StakingWithdrawDisallowPeriodFunctionBase : FunctionMessage
    {

    }

    public partial class ValidatorSetContractFunction : ValidatorSetContractFunctionBase { }

    [Function("validatorSetContract", "address")]
    public class ValidatorSetContractFunctionBase : FunctionMessage
    {

    }

    public partial class AddPoolFunction : AddPoolFunctionBase { }

    [Function("addPool")]
    public class AddPoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "_miningAddress", 1)]
        public virtual string MiningAddress { get; set; }
        [Parameter("bytes", "_publicKey", 2)]
        public virtual byte[] PublicKey { get; set; }
        [Parameter("bytes16", "_ip", 3)]
        public virtual byte[] Ip { get; set; }
    }

    public partial class SetPoolInfoFunction : SetPoolInfoFunctionBase { }

    [Function("setPoolInfo")]
    public class SetPoolInfoFunctionBase : FunctionMessage
    {
        [Parameter("bytes", "_publicKey", 1)]
        public virtual byte[] PublicKey { get; set; }
        [Parameter("bytes16", "_ip", 2)]
        public virtual byte[] Ip { get; set; }
    }

    public partial class IncrementStakingEpochFunction : IncrementStakingEpochFunctionBase { }

    [Function("incrementStakingEpoch")]
    public class IncrementStakingEpochFunctionBase : FunctionMessage
    {

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_validatorSetContract", 1)]
        public virtual string ValidatorSetContract { get; set; }
        [Parameter("address[]", "_initialStakingAddresses", 2)]
        public virtual List<string> InitialStakingAddresses { get; set; }
        [Parameter("uint256", "_delegatorMinStake", 3)]
        public virtual BigInteger DelegatorMinStake { get; set; }
        [Parameter("uint256", "_candidateMinStake", 4)]
        public virtual BigInteger CandidateMinStake { get; set; }
        [Parameter("uint256", "_stakingFixedEpochDuration", 5)]
        public virtual BigInteger StakingFixedEpochDuration { get; set; }
        [Parameter("uint256", "_stakingTransitionTimeframeLength", 6)]
        public virtual BigInteger StakingTransitionTimeframeLength { get; set; }
        [Parameter("uint256", "_stakingWithdrawDisallowPeriod", 7)]
        public virtual BigInteger StakingWithdrawDisallowPeriod { get; set; }
        [Parameter("bytes32[]", "_publicKeys", 8)]
        public virtual List<byte[]> PublicKeys { get; set; }
        [Parameter("bytes16[]", "_internetAddresses", 9)]
        public virtual List<byte[]> InternetAddresses { get; set; }
    }

    public partial class RemovePoolFunction : RemovePoolFunctionBase { }

    [Function("removePool")]
    public class RemovePoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "_stakingAddress", 1)]
        public virtual string StakingAddress { get; set; }
    }

    public partial class RemovePoolsFunction : RemovePoolsFunctionBase { }

    [Function("removePools")]
    public class RemovePoolsFunctionBase : FunctionMessage
    {

    }

    public partial class RemoveMyPoolFunction : RemoveMyPoolFunctionBase { }

    [Function("removeMyPool")]
    public class RemoveMyPoolFunctionBase : FunctionMessage
    {

    }

    public partial class SetStakingEpochStartTimeFunction : SetStakingEpochStartTimeFunctionBase { }

    [Function("setStakingEpochStartTime")]
    public class SetStakingEpochStartTimeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_timestamp", 1)]
        public virtual BigInteger Timestamp { get; set; }
    }

    public partial class MoveStakeFunction : MoveStakeFunctionBase { }

    [Function("moveStake")]
    public class MoveStakeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_fromPoolStakingAddress", 1)]
        public virtual string FromPoolStakingAddress { get; set; }
        [Parameter("address", "_toPoolStakingAddress", 2)]
        public virtual string ToPoolStakingAddress { get; set; }
        [Parameter("uint256", "_amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class StakeFunction : StakeFunctionBase { }

    [Function("stake")]
    public class StakeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_toPoolStakingAddress", 1)]
        public virtual string ToPoolStakingAddress { get; set; }
    }

    public partial class WithdrawFunction : WithdrawFunctionBase { }

    [Function("withdraw")]
    public class WithdrawFunctionBase : FunctionMessage
    {
        [Parameter("address", "_fromPoolStakingAddress", 1)]
        public virtual string FromPoolStakingAddress { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class OrderWithdrawFunction : OrderWithdrawFunctionBase { }

    [Function("orderWithdraw")]
    public class OrderWithdrawFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolStakingAddress", 1)]
        public virtual string PoolStakingAddress { get; set; }
        [Parameter("int256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class ClaimOrderedWithdrawFunction : ClaimOrderedWithdrawFunctionBase { }

    [Function("claimOrderedWithdraw")]
    public class ClaimOrderedWithdrawFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolStakingAddress", 1)]
        public virtual string PoolStakingAddress { get; set; }
    }

    public partial class SetCandidateMinStakeFunction : SetCandidateMinStakeFunctionBase { }

    [Function("setCandidateMinStake")]
    public class SetCandidateMinStakeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_minStake", 1)]
        public virtual BigInteger MinStake { get; set; }
    }

    public partial class SetDelegatorMinStakeFunction : SetDelegatorMinStakeFunctionBase { }

    [Function("setDelegatorMinStake")]
    public class SetDelegatorMinStakeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_minStake", 1)]
        public virtual BigInteger MinStake { get; set; }
    }

    public partial class GetPoolsFunction : GetPoolsFunctionBase { }

    [Function("getPools", "address[]")]
    public class GetPoolsFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoolPublicKeyFunction : GetPoolPublicKeyFunctionBase { }

    [Function("getPoolPublicKey", "bytes")]
    public class GetPoolPublicKeyFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolAddress", 1)]
        public virtual string PoolAddress { get; set; }
    }

    public partial class GetPoolInternetAddressFunction : GetPoolInternetAddressFunctionBase { }

    [Function("getPoolInternetAddress", "bytes16")]
    public class GetPoolInternetAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolAddress", 1)]
        public virtual string PoolAddress { get; set; }
    }

    public partial class GetPoolsInactiveFunction : GetPoolsInactiveFunctionBase { }

    [Function("getPoolsInactive", "address[]")]
    public class GetPoolsInactiveFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoolsLikelihoodFunction : GetPoolsLikelihoodFunctionBase { }

    [Function("getPoolsLikelihood", typeof(GetPoolsLikelihoodOutputDTO))]
    public class GetPoolsLikelihoodFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoolsToBeElectedFunction : GetPoolsToBeElectedFunctionBase { }

    [Function("getPoolsToBeElected", "address[]")]
    public class GetPoolsToBeElectedFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoolsToBeRemovedFunction : GetPoolsToBeRemovedFunctionBase { }

    [Function("getPoolsToBeRemoved", "address[]")]
    public class GetPoolsToBeRemovedFunctionBase : FunctionMessage
    {

    }

    public partial class AreStakeAndWithdrawAllowedFunction : AreStakeAndWithdrawAllowedFunctionBase { }

    [Function("areStakeAndWithdrawAllowed", "bool")]
    public class AreStakeAndWithdrawAllowedFunctionBase : FunctionMessage
    {

    }

    public partial class IsInitializedFunction : IsInitializedFunctionBase { }

    [Function("isInitialized", "bool")]
    public class IsInitializedFunctionBase : FunctionMessage
    {

    }

    public partial class IsPoolActiveFunction : IsPoolActiveFunctionBase { }

    [Function("isPoolActive", "bool")]
    public class IsPoolActiveFunctionBase : FunctionMessage
    {
        [Parameter("address", "_stakingAddress", 1)]
        public virtual string StakingAddress { get; set; }
    }

    public partial class MaxWithdrawAllowedFunction : MaxWithdrawAllowedFunctionBase { }

    [Function("maxWithdrawAllowed", "uint256")]
    public class MaxWithdrawAllowedFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolStakingAddress", 1)]
        public virtual string PoolStakingAddress { get; set; }
        [Parameter("address", "_staker", 2)]
        public virtual string Staker { get; set; }
    }

    public partial class MaxWithdrawOrderAllowedFunction : MaxWithdrawOrderAllowedFunctionBase { }

    [Function("maxWithdrawOrderAllowed", "uint256")]
    public class MaxWithdrawOrderAllowedFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolStakingAddress", 1)]
        public virtual string PoolStakingAddress { get; set; }
        [Parameter("address", "_staker", 2)]
        public virtual string Staker { get; set; }
    }

    public partial class PoolDelegatorsFunction : PoolDelegatorsFunctionBase { }

    [Function("poolDelegators", "address[]")]
    public class PoolDelegatorsFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolStakingAddress", 1)]
        public virtual string PoolStakingAddress { get; set; }
    }

    public partial class PoolDelegatorsInactiveFunction : PoolDelegatorsInactiveFunctionBase { }

    [Function("poolDelegatorsInactive", "address[]")]
    public class PoolDelegatorsInactiveFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolStakingAddress", 1)]
        public virtual string PoolStakingAddress { get; set; }
    }

    public partial class StakeAmountByCurrentEpochFunction : StakeAmountByCurrentEpochFunctionBase { }

    [Function("stakeAmountByCurrentEpoch", "uint256")]
    public class StakeAmountByCurrentEpochFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolStakingAddress", 1)]
        public virtual string PoolStakingAddress { get; set; }
        [Parameter("address", "_staker", 2)]
        public virtual string Staker { get; set; }
    }

    public partial class StartTimeOfNextPhaseTransitionFunction : StartTimeOfNextPhaseTransitionFunctionBase { }

    [Function("startTimeOfNextPhaseTransition", "uint256")]
    public class StartTimeOfNextPhaseTransitionFunctionBase : FunctionMessage
    {

    }

    public partial class StakingFixedEpochEndTimeFunction : StakingFixedEpochEndTimeFunctionBase { }

    [Function("stakingFixedEpochEndTime", "uint256")]
    public class StakingFixedEpochEndTimeFunctionBase : FunctionMessage
    {

    }

    public partial class ClaimedOrderedWithdrawalEventDTO : ClaimedOrderedWithdrawalEventDTOBase { }

    [Event("ClaimedOrderedWithdrawal")]
    public class ClaimedOrderedWithdrawalEventDTOBase : IEventDTO
    {
        [Parameter("address", "fromPoolStakingAddress", 1, true )]
        public virtual string FromPoolStakingAddress { get; set; }
        [Parameter("address", "staker", 2, true )]
        public virtual string Staker { get; set; }
        [Parameter("uint256", "stakingEpoch", 3, true )]
        public virtual BigInteger StakingEpoch { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class MovedStakeEventDTO : MovedStakeEventDTOBase { }

    [Event("MovedStake")]
    public class MovedStakeEventDTOBase : IEventDTO
    {
        [Parameter("address", "fromPoolStakingAddress", 1, false )]
        public virtual string FromPoolStakingAddress { get; set; }
        [Parameter("address", "toPoolStakingAddress", 2, true )]
        public virtual string ToPoolStakingAddress { get; set; }
        [Parameter("address", "staker", 3, true )]
        public virtual string Staker { get; set; }
        [Parameter("uint256", "stakingEpoch", 4, true )]
        public virtual BigInteger StakingEpoch { get; set; }
        [Parameter("uint256", "amount", 5, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class OrderedWithdrawalEventDTO : OrderedWithdrawalEventDTOBase { }

    [Event("OrderedWithdrawal")]
    public class OrderedWithdrawalEventDTOBase : IEventDTO
    {
        [Parameter("address", "fromPoolStakingAddress", 1, true )]
        public virtual string FromPoolStakingAddress { get; set; }
        [Parameter("address", "staker", 2, true )]
        public virtual string Staker { get; set; }
        [Parameter("uint256", "stakingEpoch", 3, true )]
        public virtual BigInteger StakingEpoch { get; set; }
        [Parameter("int256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class PlacedStakeEventDTO : PlacedStakeEventDTOBase { }

    [Event("PlacedStake")]
    public class PlacedStakeEventDTOBase : IEventDTO
    {
        [Parameter("address", "toPoolStakingAddress", 1, true )]
        public virtual string ToPoolStakingAddress { get; set; }
        [Parameter("address", "staker", 2, true )]
        public virtual string Staker { get; set; }
        [Parameter("uint256", "stakingEpoch", 3, true )]
        public virtual BigInteger StakingEpoch { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class WithdrewStakeEventDTO : WithdrewStakeEventDTOBase { }

    [Event("WithdrewStake")]
    public class WithdrewStakeEventDTOBase : IEventDTO
    {
        [Parameter("address", "fromPoolStakingAddress", 1, true )]
        public virtual string FromPoolStakingAddress { get; set; }
        [Parameter("address", "staker", 2, true )]
        public virtual string Staker { get; set; }
        [Parameter("uint256", "stakingEpoch", 3, true )]
        public virtual BigInteger StakingEpoch { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class MAX_CANDIDATESOutputDTO : MAX_CANDIDATESOutputDTOBase { }

    [FunctionOutput]
    public class MAX_CANDIDATESOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CandidateMinStakeOutputDTO : CandidateMinStakeOutputDTOBase { }

    [FunctionOutput]
    public class CandidateMinStakeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DelegatorMinStakeOutputDTO : DelegatorMinStakeOutputDTOBase { }

    [FunctionOutput]
    public class DelegatorMinStakeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DelegatorStakeSnapshotOutputDTO : DelegatorStakeSnapshotOutputDTOBase { }

    [FunctionOutput]
    public class DelegatorStakeSnapshotOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OrderWithdrawEpochOutputDTO : OrderWithdrawEpochOutputDTOBase { }

    [FunctionOutput]
    public class OrderWithdrawEpochOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OrderedWithdrawAmountOutputDTO : OrderedWithdrawAmountOutputDTOBase { }

    [FunctionOutput]
    public class OrderedWithdrawAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OrderedWithdrawAmountTotalOutputDTO : OrderedWithdrawAmountTotalOutputDTOBase { }

    [FunctionOutput]
    public class OrderedWithdrawAmountTotalOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolDelegatorInactiveIndexOutputDTO : PoolDelegatorInactiveIndexOutputDTOBase { }

    [FunctionOutput]
    public class PoolDelegatorInactiveIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolDelegatorIndexOutputDTO : PoolDelegatorIndexOutputDTOBase { }

    [FunctionOutput]
    public class PoolDelegatorIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolInactiveIndexOutputDTO : PoolInactiveIndexOutputDTOBase { }

    [FunctionOutput]
    public class PoolInactiveIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolIndexOutputDTO : PoolIndexOutputDTOBase { }

    [FunctionOutput]
    public class PoolIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolInfoOutputDTO : PoolInfoOutputDTOBase { }

    [FunctionOutput]
    public class PoolInfoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "publicKey", 1)]
        public virtual byte[] PublicKey { get; set; }
        [Parameter("bytes16", "internetAddress", 2)]
        public virtual byte[] InternetAddress { get; set; }
    }

    public partial class PoolToBeElectedIndexOutputDTO : PoolToBeElectedIndexOutputDTOBase { }

    [FunctionOutput]
    public class PoolToBeElectedIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolToBeRemovedIndexOutputDTO : PoolToBeRemovedIndexOutputDTOBase { }

    [FunctionOutput]
    public class PoolToBeRemovedIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class RewardWasTakenOutputDTO : RewardWasTakenOutputDTOBase { }

    [FunctionOutput]
    public class RewardWasTakenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class StakeAmountOutputDTO : StakeAmountOutputDTOBase { }

    [FunctionOutput]
    public class StakeAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakeAmountTotalOutputDTO : StakeAmountTotalOutputDTOBase { }

    [FunctionOutput]
    public class StakeAmountTotalOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakeFirstEpochOutputDTO : StakeFirstEpochOutputDTOBase { }

    [FunctionOutput]
    public class StakeFirstEpochOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakeLastEpochOutputDTO : StakeLastEpochOutputDTOBase { }

    [FunctionOutput]
    public class StakeLastEpochOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakingEpochOutputDTO : StakingEpochOutputDTOBase { }

    [FunctionOutput]
    public class StakingEpochOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakingEpochStartTimeOutputDTO : StakingEpochStartTimeOutputDTOBase { }

    [FunctionOutput]
    public class StakingEpochStartTimeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakingFixedEpochDurationOutputDTO : StakingFixedEpochDurationOutputDTOBase { }

    [FunctionOutput]
    public class StakingFixedEpochDurationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakingTransitionTimeframeLengthOutputDTO : StakingTransitionTimeframeLengthOutputDTOBase { }

    [FunctionOutput]
    public class StakingTransitionTimeframeLengthOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakingWithdrawDisallowPeriodOutputDTO : StakingWithdrawDisallowPeriodOutputDTOBase { }

    [FunctionOutput]
    public class StakingWithdrawDisallowPeriodOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ValidatorSetContractOutputDTO : ValidatorSetContractOutputDTOBase { }

    [FunctionOutput]
    public class ValidatorSetContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }































    public partial class GetPoolsOutputDTO : GetPoolsOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class GetPoolPublicKeyOutputDTO : GetPoolPublicKeyOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolPublicKeyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetPoolInternetAddressOutputDTO : GetPoolInternetAddressOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolInternetAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes16", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetPoolsInactiveOutputDTO : GetPoolsInactiveOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolsInactiveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class GetPoolsLikelihoodOutputDTO : GetPoolsLikelihoodOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolsLikelihoodOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "likelihoods", 1)]
        public virtual List<BigInteger> Likelihoods { get; set; }
        [Parameter("uint256", "sum", 2)]
        public virtual BigInteger Sum { get; set; }
    }

    public partial class GetPoolsToBeElectedOutputDTO : GetPoolsToBeElectedOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolsToBeElectedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class GetPoolsToBeRemovedOutputDTO : GetPoolsToBeRemovedOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolsToBeRemovedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class AreStakeAndWithdrawAllowedOutputDTO : AreStakeAndWithdrawAllowedOutputDTOBase { }

    [FunctionOutput]
    public class AreStakeAndWithdrawAllowedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsInitializedOutputDTO : IsInitializedOutputDTOBase { }

    [FunctionOutput]
    public class IsInitializedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsPoolActiveOutputDTO : IsPoolActiveOutputDTOBase { }

    [FunctionOutput]
    public class IsPoolActiveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class MaxWithdrawAllowedOutputDTO : MaxWithdrawAllowedOutputDTOBase { }

    [FunctionOutput]
    public class MaxWithdrawAllowedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MaxWithdrawOrderAllowedOutputDTO : MaxWithdrawOrderAllowedOutputDTOBase { }

    [FunctionOutput]
    public class MaxWithdrawOrderAllowedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolDelegatorsOutputDTO : PoolDelegatorsOutputDTOBase { }

    [FunctionOutput]
    public class PoolDelegatorsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class PoolDelegatorsInactiveOutputDTO : PoolDelegatorsInactiveOutputDTOBase { }

    [FunctionOutput]
    public class PoolDelegatorsInactiveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class StakeAmountByCurrentEpochOutputDTO : StakeAmountByCurrentEpochOutputDTOBase { }

    [FunctionOutput]
    public class StakeAmountByCurrentEpochOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StartTimeOfNextPhaseTransitionOutputDTO : StartTimeOfNextPhaseTransitionOutputDTOBase { }

    [FunctionOutput]
    public class StartTimeOfNextPhaseTransitionOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class StakingFixedEpochEndTimeOutputDTO : StakingFixedEpochEndTimeOutputDTOBase { }

    [FunctionOutput]
    public class StakingFixedEpochEndTimeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }
}
