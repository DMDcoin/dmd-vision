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

namespace DMDVision.Contracts.IReverseRegistry.ContractDefinition
{


    public partial class IReverseRegistryDeployment : IReverseRegistryDeploymentBase
    {
        public IReverseRegistryDeployment() : base(BYTECODE) { }
        public IReverseRegistryDeployment(string byteCode) : base(byteCode) { }
    }

    public class IReverseRegistryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IReverseRegistryDeploymentBase() : base(BYTECODE) { }
        public IReverseRegistryDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class HasReverseFunction : HasReverseFunctionBase { }

    [Function("hasReverse", "bool")]
    public class HasReverseFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
    }

    public partial class GetReverseFunction : GetReverseFunctionBase { }

    [Function("getReverse", "address")]
    public class GetReverseFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
    }

    public partial class CanReverseFunction : CanReverseFunctionBase { }

    [Function("canReverse", "bool")]
    public class CanReverseFunctionBase : FunctionMessage
    {
        [Parameter("address", "_data", 1)]
        public virtual string Data { get; set; }
    }

    public partial class ReverseFunction : ReverseFunctionBase { }

    [Function("reverse", "string")]
    public class ReverseFunctionBase : FunctionMessage
    {
        [Parameter("address", "_data", 1)]
        public virtual string Data { get; set; }
    }

    public partial class ReverseConfirmedEventDTO : ReverseConfirmedEventDTOBase { }

    [Event("ReverseConfirmed")]
    public class ReverseConfirmedEventDTOBase : IEventDTO
    {
        [Parameter("string", "name", 1, false )]
        public virtual string Name { get; set; }
        [Parameter("address", "reverse", 2, true )]
        public virtual string Reverse { get; set; }
    }

    public partial class ReverseRemovedEventDTO : ReverseRemovedEventDTOBase { }

    [Event("ReverseRemoved")]
    public class ReverseRemovedEventDTOBase : IEventDTO
    {
        [Parameter("string", "name", 1, false )]
        public virtual string Name { get; set; }
        [Parameter("address", "reverse", 2, true )]
        public virtual string Reverse { get; set; }
    }

    public partial class HasReverseOutputDTO : HasReverseOutputDTOBase { }

    [FunctionOutput]
    public class HasReverseOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class GetReverseOutputDTO : GetReverseOutputDTOBase { }

    [FunctionOutput]
    public class GetReverseOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class CanReverseOutputDTO : CanReverseOutputDTOBase { }

    [FunctionOutput]
    public class CanReverseOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class ReverseOutputDTO : ReverseOutputDTOBase { }

    [FunctionOutput]
    public class ReverseOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
