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

namespace DMDVision.Contracts.Owned.ContractDefinition
{


    public partial class OwnedDeployment : OwnedDeploymentBase
    {
        public OwnedDeployment() : base(BYTECODE) { }
        public OwnedDeployment(string byteCode) : base(byteCode) { }
    }

    public class OwnedDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052600080546001600160a01b0319163317905534801561002257600080fd5b506101e0806100326000396000f3fe608060405234801561001057600080fd5b50600436106100365760003560e01c806313af40351461003b5780638da5cb5b14610063575b600080fd5b6100616004803603602081101561005157600080fd5b50356001600160a01b0316610087565b005b61006b61019c565b604080516001600160a01b039092168252519081900360200190f35b6000546001600160a01b031633146100e6576040805162461bcd60e51b815260206004820181905260248201527f4f6e6c79206f776e657220697320616c6c6f77656420746f2065786563757465604482015290519081900360640190fd5b6001600160a01b038116610141576040805162461bcd60e51b815260206004820152601960248201527f4e6577206f776e6572206d757374206e6f742062652030783000000000000000604482015290519081900360640190fd5b600080546040516001600160a01b03808516939216917f70aea8d848e8a90fb7661b227dc522eb6395c3dac71b63cb59edd5c9899b236491a3600080546001600160a01b0319166001600160a01b0392909216919091179055565b6000546001600160a01b03168156fea265627a7a7231582007c150a72a3add235da267a5dcb84c9d5560f0c66f873485e687d2f5e77e5fb964736f6c63430005100032";
        public OwnedDeploymentBase() : base(BYTECODE) { }
        public OwnedDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class SetOwnerFunction : SetOwnerFunctionBase { }

    [Function("setOwner")]
    public class SetOwnerFunctionBase : FunctionMessage
    {
        [Parameter("address", "_new", 1)]
        public virtual string New { get; set; }
    }

    public partial class NewOwnerEventDTO : NewOwnerEventDTOBase { }

    [Event("NewOwner")]
    public class NewOwnerEventDTOBase : IEventDTO
    {
        [Parameter("address", "old", 1, true )]
        public virtual string Old { get; set; }
        [Parameter("address", "current", 2, true )]
        public virtual string Current { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}
