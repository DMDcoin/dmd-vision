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

namespace DMDVision.Contracts.IBlockRewardHbbftCoins.ContractDefinition
{


    public partial class IBlockRewardHbbftCoinsDeployment : IBlockRewardHbbftCoinsDeploymentBase
    {
        public IBlockRewardHbbftCoinsDeployment() : base(BYTECODE) { }
        public IBlockRewardHbbftCoinsDeployment(string byteCode) : base(byteCode) { }
    }

    public class IBlockRewardHbbftCoinsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IBlockRewardHbbftCoinsDeploymentBase() : base(BYTECODE) { }
        public IBlockRewardHbbftCoinsDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class TransferRewardFunction : TransferRewardFunctionBase { }

    [Function("transferReward")]
    public class TransferRewardFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class GetDelegatorRewardFunction : GetDelegatorRewardFunctionBase { }

    [Function("getDelegatorReward", "uint256")]
    public class GetDelegatorRewardFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("address", "", 3)]
        public virtual string ReturnValue3 { get; set; }
    }

    public partial class GetValidatorRewardFunction : GetValidatorRewardFunctionBase { }

    [Function("getValidatorReward", "uint256")]
    public class GetValidatorRewardFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }



    public partial class GetDelegatorRewardOutputDTO : GetDelegatorRewardOutputDTOBase { }

    [FunctionOutput]
    public class GetDelegatorRewardOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetValidatorRewardOutputDTO : GetValidatorRewardOutputDTOBase { }

    [FunctionOutput]
    public class GetValidatorRewardOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }
}
