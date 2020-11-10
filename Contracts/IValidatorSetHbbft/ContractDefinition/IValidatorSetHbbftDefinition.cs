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

namespace DMDVision.Contracts.IValidatorSetHbbft.ContractDefinition
{


    public partial class IValidatorSetHbbftDeployment : IValidatorSetHbbftDeploymentBase
    {
        public IValidatorSetHbbftDeployment() : base(BYTECODE) { }
        public IValidatorSetHbbftDeployment(string byteCode) : base(byteCode) { }
    }

    public class IValidatorSetHbbftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IValidatorSetHbbftDeploymentBase() : base(BYTECODE) { }
        public IValidatorSetHbbftDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("address", "", 3)]
        public virtual string ReturnValue3 { get; set; }
        [Parameter("address", "", 4)]
        public virtual string ReturnValue4 { get; set; }
        [Parameter("address[]", "", 5)]
        public virtual List<string> ReturnValue5 { get; set; }
        [Parameter("address[]", "", 6)]
        public virtual List<string> ReturnValue6 { get; set; }
    }

    public partial class FinalizeChangeFunction : FinalizeChangeFunctionBase { }

    [Function("finalizeChange")]
    public class FinalizeChangeFunctionBase : FunctionMessage
    {

    }

    public partial class NewValidatorSetFunction : NewValidatorSetFunctionBase { }

    [Function("newValidatorSet")]
    public class NewValidatorSetFunctionBase : FunctionMessage
    {

    }

    public partial class RemoveMaliciousValidatorsFunction : RemoveMaliciousValidatorsFunctionBase { }

    [Function("removeMaliciousValidators")]
    public class RemoveMaliciousValidatorsFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class SetStakingAddressFunction : SetStakingAddressFunctionBase { }

    [Function("setStakingAddress")]
    public class SetStakingAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class AreDelegatorsBannedFunction : AreDelegatorsBannedFunctionBase { }

    [Function("areDelegatorsBanned", "bool")]
    public class AreDelegatorsBannedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class BlockRewardContractFunction : BlockRewardContractFunctionBase { }

    [Function("blockRewardContract", "address")]
    public class BlockRewardContractFunctionBase : FunctionMessage
    {

    }

    public partial class GetPendingValidatorsFunction : GetPendingValidatorsFunctionBase { }

    [Function("getPendingValidators", "address[]")]
    public class GetPendingValidatorsFunctionBase : FunctionMessage
    {

    }

    public partial class GetPreviousValidatorsFunction : GetPreviousValidatorsFunctionBase { }

    [Function("getPreviousValidators", "address[]")]
    public class GetPreviousValidatorsFunctionBase : FunctionMessage
    {

    }

    public partial class GetValidatorsFunction : GetValidatorsFunctionBase { }

    [Function("getValidators", "address[]")]
    public class GetValidatorsFunctionBase : FunctionMessage
    {

    }

    public partial class IsReportValidatorValidFunction : IsReportValidatorValidFunctionBase { }

    [Function("isReportValidatorValid", "bool")]
    public class IsReportValidatorValidFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsValidatorFunction : IsValidatorFunctionBase { }

    [Function("isValidator", "bool")]
    public class IsValidatorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsValidatorBannedFunction : IsValidatorBannedFunctionBase { }

    [Function("isValidatorBanned", "bool")]
    public class IsValidatorBannedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsValidatorOrPendingFunction : IsValidatorOrPendingFunctionBase { }

    [Function("isValidatorOrPending", "bool")]
    public class IsValidatorOrPendingFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsPendingValidatorFunction : IsPendingValidatorFunctionBase { }

    [Function("isPendingValidator", "bool")]
    public class IsPendingValidatorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MAX_VALIDATORSFunction : MAX_VALIDATORSFunctionBase { }

    [Function("MAX_VALIDATORS", "uint256")]
    public class MAX_VALIDATORSFunctionBase : FunctionMessage
    {

    }

    public partial class MiningByStakingAddressFunction : MiningByStakingAddressFunctionBase { }

    [Function("miningByStakingAddress", "address")]
    public class MiningByStakingAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RandomContractFunction : RandomContractFunctionBase { }

    [Function("randomContract", "address")]
    public class RandomContractFunctionBase : FunctionMessage
    {

    }

    public partial class ReportMaliciousCallableFunction : ReportMaliciousCallableFunctionBase { }

    [Function("reportMaliciousCallable", typeof(ReportMaliciousCallableOutputDTO))]
    public class ReportMaliciousCallableFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
    }

    public partial class StakingByMiningAddressFunction : StakingByMiningAddressFunctionBase { }

    [Function("stakingByMiningAddress", "address")]
    public class StakingByMiningAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PublicKeyByStakingAddressFunction : PublicKeyByStakingAddressFunctionBase { }

    [Function("publicKeyByStakingAddress", "bytes")]
    public class PublicKeyByStakingAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetPublicKeyFunction : GetPublicKeyFunctionBase { }

    [Function("getPublicKey", "bytes")]
    public class GetPublicKeyFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class StakingContractFunction : StakingContractFunctionBase { }

    [Function("stakingContract", "address")]
    public class StakingContractFunctionBase : FunctionMessage
    {

    }

    public partial class GetCurrentTimestampFunction : GetCurrentTimestampFunctionBase { }

    [Function("getCurrentTimestamp", "uint256")]
    public class GetCurrentTimestampFunctionBase : FunctionMessage
    {

    }











    public partial class AreDelegatorsBannedOutputDTO : AreDelegatorsBannedOutputDTOBase { }

    [FunctionOutput]
    public class AreDelegatorsBannedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class BlockRewardContractOutputDTO : BlockRewardContractOutputDTOBase { }

    [FunctionOutput]
    public class BlockRewardContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetPendingValidatorsOutputDTO : GetPendingValidatorsOutputDTOBase { }

    [FunctionOutput]
    public class GetPendingValidatorsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class GetPreviousValidatorsOutputDTO : GetPreviousValidatorsOutputDTOBase { }

    [FunctionOutput]
    public class GetPreviousValidatorsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class GetValidatorsOutputDTO : GetValidatorsOutputDTOBase { }

    [FunctionOutput]
    public class GetValidatorsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class IsReportValidatorValidOutputDTO : IsReportValidatorValidOutputDTOBase { }

    [FunctionOutput]
    public class IsReportValidatorValidOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsValidatorOutputDTO : IsValidatorOutputDTOBase { }

    [FunctionOutput]
    public class IsValidatorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsValidatorBannedOutputDTO : IsValidatorBannedOutputDTOBase { }

    [FunctionOutput]
    public class IsValidatorBannedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsValidatorOrPendingOutputDTO : IsValidatorOrPendingOutputDTOBase { }

    [FunctionOutput]
    public class IsValidatorOrPendingOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsPendingValidatorOutputDTO : IsPendingValidatorOutputDTOBase { }

    [FunctionOutput]
    public class IsPendingValidatorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class MAX_VALIDATORSOutputDTO : MAX_VALIDATORSOutputDTOBase { }

    [FunctionOutput]
    public class MAX_VALIDATORSOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MiningByStakingAddressOutputDTO : MiningByStakingAddressOutputDTOBase { }

    [FunctionOutput]
    public class MiningByStakingAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RandomContractOutputDTO : RandomContractOutputDTOBase { }

    [FunctionOutput]
    public class RandomContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ReportMaliciousCallableOutputDTO : ReportMaliciousCallableOutputDTOBase { }

    [FunctionOutput]
    public class ReportMaliciousCallableOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
        [Parameter("bool", "", 2)]
        public virtual bool ReturnValue2 { get; set; }
    }

    public partial class StakingByMiningAddressOutputDTO : StakingByMiningAddressOutputDTOBase { }

    [FunctionOutput]
    public class StakingByMiningAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PublicKeyByStakingAddressOutputDTO : PublicKeyByStakingAddressOutputDTOBase { }

    [FunctionOutput]
    public class PublicKeyByStakingAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetPublicKeyOutputDTO : GetPublicKeyOutputDTOBase { }

    [FunctionOutput]
    public class GetPublicKeyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class StakingContractOutputDTO : StakingContractOutputDTOBase { }

    [FunctionOutput]
    public class StakingContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetCurrentTimestampOutputDTO : GetCurrentTimestampOutputDTOBase { }

    [FunctionOutput]
    public class GetCurrentTimestampOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }
}
