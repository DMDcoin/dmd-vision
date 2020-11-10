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

namespace DMDVision.Contracts.IStakingHbbft.ContractDefinition
{


    public partial class IStakingHbbftDeployment : IStakingHbbftDeploymentBase
    {
        public IStakingHbbftDeployment() : base(BYTECODE) { }
        public IStakingHbbftDeployment(string byteCode) : base(byteCode) { }
    }

    public class IStakingHbbftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IStakingHbbftDeploymentBase() : base(BYTECODE) { }
        public IStakingHbbftDeploymentBase(string byteCode) : base(byteCode) { }

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
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address[]", "", 2)]
        public virtual List<string> ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256", "", 4)]
        public virtual BigInteger ReturnValue4 { get; set; }
        [Parameter("uint256", "", 5)]
        public virtual BigInteger ReturnValue5 { get; set; }
        [Parameter("uint256", "", 6)]
        public virtual BigInteger ReturnValue6 { get; set; }
        [Parameter("uint256", "", 7)]
        public virtual BigInteger ReturnValue7 { get; set; }
        [Parameter("bytes32[]", "", 8)]
        public virtual List<byte[]> ReturnValue8 { get; set; }
        [Parameter("bytes16[]", "", 9)]
        public virtual List<byte[]> ReturnValue9 { get; set; }
    }

    public partial class RemovePoolFunction : RemovePoolFunctionBase { }

    [Function("removePool")]
    public class RemovePoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RemovePoolsFunction : RemovePoolsFunctionBase { }

    [Function("removePools")]
    public class RemovePoolsFunctionBase : FunctionMessage
    {

    }

    public partial class SetStakingEpochStartTimeFunction : SetStakingEpochStartTimeFunctionBase { }

    [Function("setStakingEpochStartTime")]
    public class SetStakingEpochStartTimeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetPoolPublicKeyFunction : GetPoolPublicKeyFunctionBase { }

    [Function("getPoolPublicKey", "bytes")]
    public class GetPoolPublicKeyFunctionBase : FunctionMessage
    {
        [Parameter("address", "_poolAddress", 1)]
        public virtual string PoolAddress { get; set; }
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

    public partial class IsPoolActiveFunction : IsPoolActiveFunctionBase { }

    [Function("isPoolActive", "bool")]
    public class IsPoolActiveFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MAX_CANDIDATESFunction : MAX_CANDIDATESFunctionBase { }

    [Function("MAX_CANDIDATES", "uint256")]
    public class MAX_CANDIDATESFunctionBase : FunctionMessage
    {

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

    public partial class PoolDelegatorsFunction : PoolDelegatorsFunctionBase { }

    [Function("poolDelegators", "address[]")]
    public class PoolDelegatorsFunctionBase : FunctionMessage
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

    public partial class StakingWithdrawDisallowPeriodFunction : StakingWithdrawDisallowPeriodFunctionBase { }

    [Function("stakingWithdrawDisallowPeriod", "uint256")]
    public class StakingWithdrawDisallowPeriodFunctionBase : FunctionMessage
    {

    }

    public partial class StakingEpochFunction : StakingEpochFunctionBase { }

    [Function("stakingEpoch", "uint256")]
    public class StakingEpochFunctionBase : FunctionMessage
    {

    }

    public partial class StakingFixedEpochDurationFunction : StakingFixedEpochDurationFunctionBase { }

    [Function("stakingFixedEpochDuration", "uint256")]
    public class StakingFixedEpochDurationFunctionBase : FunctionMessage
    {

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

    public partial class StakingEpochStartTimeFunction : StakingEpochStartTimeFunctionBase { }

    [Function("stakingEpochStartTime", "uint256")]
    public class StakingEpochStartTimeFunctionBase : FunctionMessage
    {

    }











    public partial class GetPoolPublicKeyOutputDTO : GetPoolPublicKeyOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolPublicKeyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetPoolsLikelihoodOutputDTO : GetPoolsLikelihoodOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolsLikelihoodOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
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

    public partial class IsPoolActiveOutputDTO : IsPoolActiveOutputDTOBase { }

    [FunctionOutput]
    public class IsPoolActiveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class MAX_CANDIDATESOutputDTO : MAX_CANDIDATESOutputDTOBase { }

    [FunctionOutput]
    public class MAX_CANDIDATESOutputDTOBase : IFunctionOutputDTO 
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

    public partial class PoolDelegatorsOutputDTO : PoolDelegatorsOutputDTOBase { }

    [FunctionOutput]
    public class PoolDelegatorsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
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

    public partial class StakingWithdrawDisallowPeriodOutputDTO : StakingWithdrawDisallowPeriodOutputDTOBase { }

    [FunctionOutput]
    public class StakingWithdrawDisallowPeriodOutputDTOBase : IFunctionOutputDTO 
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

    public partial class StakingFixedEpochDurationOutputDTO : StakingFixedEpochDurationOutputDTOBase { }

    [FunctionOutput]
    public class StakingFixedEpochDurationOutputDTOBase : IFunctionOutputDTO 
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

    public partial class StakingEpochStartTimeOutputDTO : StakingEpochStartTimeOutputDTOBase { }

    [FunctionOutput]
    public class StakingEpochStartTimeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }
}
