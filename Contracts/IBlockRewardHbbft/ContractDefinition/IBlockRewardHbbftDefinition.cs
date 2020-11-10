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

namespace DMDVision.Contracts.IBlockRewardHbbft.ContractDefinition
{


    public partial class IBlockRewardHbbftDeployment : IBlockRewardHbbftDeploymentBase
    {
        public IBlockRewardHbbftDeployment() : base(BYTECODE) { }
        public IBlockRewardHbbftDeployment(string byteCode) : base(byteCode) { }
    }

    public class IBlockRewardHbbftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IBlockRewardHbbftDeploymentBase() : base(BYTECODE) { }
        public IBlockRewardHbbftDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class EpochsPoolGotRewardForFunction : EpochsPoolGotRewardForFunctionBase { }

    [Function("epochsPoolGotRewardFor", "uint256[]")]
    public class EpochsPoolGotRewardForFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class EpochsPoolGotRewardForOutputDTO : EpochsPoolGotRewardForOutputDTOBase { }

    [FunctionOutput]
    public class EpochsPoolGotRewardForOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }
}
