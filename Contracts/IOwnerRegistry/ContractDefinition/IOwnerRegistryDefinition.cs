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

namespace DMDVision.Contracts.IOwnerRegistry.ContractDefinition
{


    public partial class IOwnerRegistryDeployment : IOwnerRegistryDeploymentBase
    {
        public IOwnerRegistryDeployment() : base(BYTECODE) { }
        public IOwnerRegistryDeployment(string byteCode) : base(byteCode) { }
    }

    public class IOwnerRegistryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IOwnerRegistryDeploymentBase() : base(BYTECODE) { }
        public IOwnerRegistryDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class GetOwnerFunction : GetOwnerFunctionBase { }

    [Function("getOwner", "address")]
    public class GetOwnerFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
    }

    public partial class DroppedEventDTO : DroppedEventDTOBase { }

    [Event("Dropped")]
    public class DroppedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "name", 1, true )]
        public virtual byte[] Name { get; set; }
        [Parameter("address", "owner", 2, true )]
        public virtual string Owner { get; set; }
    }

    public partial class ReservedEventDTO : ReservedEventDTOBase { }

    [Event("Reserved")]
    public class ReservedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "name", 1, true )]
        public virtual byte[] Name { get; set; }
        [Parameter("address", "owner", 2, true )]
        public virtual string Owner { get; set; }
    }

    public partial class TransferredEventDTO : TransferredEventDTOBase { }

    [Event("Transferred")]
    public class TransferredEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "name", 1, true )]
        public virtual byte[] Name { get; set; }
        [Parameter("address", "oldOwner", 2, true )]
        public virtual string OldOwner { get; set; }
        [Parameter("address", "newOwner", 3, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class GetOwnerOutputDTO : GetOwnerOutputDTOBase { }

    [FunctionOutput]
    public class GetOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
