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

namespace DMDVision.Contracts.IRandomHbbft.ContractDefinition
{


    public partial class IRandomHbbftDeployment : IRandomHbbftDeploymentBase
    {
        public IRandomHbbftDeployment() : base(BYTECODE) { }
        public IRandomHbbftDeployment(string byteCode) : base(byteCode) { }
    }

    public class IRandomHbbftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IRandomHbbftDeploymentBase() : base(BYTECODE) { }
        public IRandomHbbftDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CurrentSeedFunction : CurrentSeedFunctionBase { }

    [Function("currentSeed", "uint256")]
    public class CurrentSeedFunctionBase : FunctionMessage
    {

    }

    public partial class CurrentSeedOutputDTO : CurrentSeedOutputDTOBase { }

    [FunctionOutput]
    public class CurrentSeedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }
}
