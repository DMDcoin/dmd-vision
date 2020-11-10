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

namespace DMDVision.Contracts.ICertifier.ContractDefinition
{


    public partial class ICertifierDeployment : ICertifierDeploymentBase
    {
        public ICertifierDeployment() : base(BYTECODE) { }
        public ICertifierDeployment(string byteCode) : base(byteCode) { }
    }

    public class ICertifierDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public ICertifierDeploymentBase() : base(BYTECODE) { }
        public ICertifierDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CertifiedExplicitlyFunction : CertifiedExplicitlyFunctionBase { }

    [Function("certifiedExplicitly", "bool")]
    public class CertifiedExplicitlyFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class CertifiedExplicitlyOutputDTO : CertifiedExplicitlyOutputDTOBase { }

    [FunctionOutput]
    public class CertifiedExplicitlyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }


}
