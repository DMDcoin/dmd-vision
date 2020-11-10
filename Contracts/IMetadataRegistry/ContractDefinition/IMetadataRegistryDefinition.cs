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

namespace DMDVision.Contracts.IMetadataRegistry.ContractDefinition
{


    public partial class IMetadataRegistryDeployment : IMetadataRegistryDeploymentBase
    {
        public IMetadataRegistryDeployment() : base(BYTECODE) { }
        public IMetadataRegistryDeployment(string byteCode) : base(byteCode) { }
    }

    public class IMetadataRegistryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IMetadataRegistryDeploymentBase() : base(BYTECODE) { }
        public IMetadataRegistryDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class GetDataFunction : GetDataFunctionBase { }

    [Function("getData", "bytes32")]
    public class GetDataFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
        [Parameter("string", "_key", 2)]
        public virtual string Key { get; set; }
    }

    public partial class GetAddressFunction : GetAddressFunctionBase { }

    [Function("getAddress", "address")]
    public class GetAddressFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
        [Parameter("string", "_key", 2)]
        public virtual string Key { get; set; }
    }

    public partial class GetUintFunction : GetUintFunctionBase { }

    [Function("getUint", "uint256")]
    public class GetUintFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
        [Parameter("string", "_key", 2)]
        public virtual string Key { get; set; }
    }

    public partial class DataChangedEventDTO : DataChangedEventDTOBase { }

    [Event("DataChanged")]
    public class DataChangedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "name", 1, true )]
        public virtual byte[] Name { get; set; }
        [Parameter("string", "key", 2, false )]
        public virtual string Key { get; set; }
        [Parameter("string", "plainKey", 3, false )]
        public virtual string PlainKey { get; set; }
    }

    public partial class GetDataOutputDTO : GetDataOutputDTOBase { }

    [FunctionOutput]
    public class GetDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetAddressOutputDTO : GetAddressOutputDTOBase { }

    [FunctionOutput]
    public class GetAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetUintOutputDTO : GetUintOutputDTOBase { }

    [FunctionOutput]
    public class GetUintOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }
}
