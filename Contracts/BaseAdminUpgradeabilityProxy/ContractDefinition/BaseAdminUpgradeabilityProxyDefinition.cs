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

namespace DMDVision.Contracts.BaseAdminUpgradeabilityProxy.ContractDefinition
{


    public partial class BaseAdminUpgradeabilityProxyDeployment : BaseAdminUpgradeabilityProxyDeploymentBase
    {
        public BaseAdminUpgradeabilityProxyDeployment() : base(BYTECODE) { }
        public BaseAdminUpgradeabilityProxyDeployment(string byteCode) : base(byteCode) { }
    }

    public class BaseAdminUpgradeabilityProxyDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5061052c806100206000396000f3fe60806040526004361061004a5760003560e01c80633659cfe6146100545780634f1ef286146100875780635c60da1b146101075780638f28397014610138578063f851a4401461016b575b610052610180565b005b34801561006057600080fd5b506100526004803603602081101561007757600080fd5b50356001600160a01b031661019a565b6100526004803603604081101561009d57600080fd5b6001600160a01b0382351691908101906040810160208201356401000000008111156100c857600080fd5b8201836020820111156100da57600080fd5b803590602001918460018302840111640100000000831117156100fc57600080fd5b5090925090506101cb565b34801561011357600080fd5b5061011c61026f565b604080516001600160a01b039092168252519081900360200190f35b34801561014457600080fd5b506100526004803603602081101561015b57600080fd5b50356001600160a01b031661027e565b34801561017757600080fd5b5061011c61033c565b610188610198565b610198610193610346565b61036b565b565b6101a261038f565b6001600160a01b0316336001600160a01b0316146101bf57600080fd5b6101c8816103b4565b50565b6101d361038f565b6001600160a01b0316336001600160a01b0316146101f057600080fd5b6101f9836103b4565b6000836001600160a01b031683836040518083838082843760405192019450600093509091505080830381855af49150503d8060008114610256576040519150601f19603f3d011682016040523d82523d6000602084013e61025b565b606091505b505090508061026957600080fd5b50505050565b6000610279610346565b905090565b61028661038f565b6001600160a01b0316336001600160a01b0316146102a357600080fd5b6001600160a01b0381166102e85760405162461bcd60e51b81526004018080602001828103825260368152602001806104876036913960400191505060405180910390fd5b7f7e644d79422f17c01e4894b5f4f588d331ebfa28653d42ae832dc59e38c9798f61031161038f565b604080516001600160a01b03928316815291841660208301528051918290030190a16101c8816103f4565b600061027961038f565b7f360894a13ba1a3210667c828492db98dca3e2076cc3735a920a3ca505d382bbc5490565b3660008037600080366000845af43d6000803e80801561038a573d6000f35b3d6000fd5b7fb53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d61035490565b6103bd81610418565b6040516001600160a01b038216907fbc7cd75a20ee27fd9adebab32041f755214dbc6bffa90cc0225b39da2e5c2d3b90600090a250565b7fb53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d610355565b61042181610480565b61045c5760405162461bcd60e51b815260040180806020018281038252603b8152602001806104bd603b913960400191505060405180910390fd5b7f360894a13ba1a3210667c828492db98dca3e2076cc3735a920a3ca505d382bbc55565b3b15159056fe43616e6e6f74206368616e6765207468652061646d696e206f6620612070726f787920746f20746865207a65726f206164647265737343616e6e6f742073657420612070726f787920696d706c656d656e746174696f6e20746f2061206e6f6e2d636f6e74726163742061646472657373a265627a7a723158206a8bf7bce3ff3cb9c0832a285075099a7abc5893616ef3216c25484b252d685964736f6c63430005100032";
        public BaseAdminUpgradeabilityProxyDeploymentBase() : base(BYTECODE) { }
        public BaseAdminUpgradeabilityProxyDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AdminFunction : AdminFunctionBase { }

    [Function("admin", "address")]
    public class AdminFunctionBase : FunctionMessage
    {

    }

    public partial class ImplementationFunction : ImplementationFunctionBase { }

    [Function("implementation", "address")]
    public class ImplementationFunctionBase : FunctionMessage
    {

    }

    public partial class ChangeAdminFunction : ChangeAdminFunctionBase { }

    [Function("changeAdmin")]
    public class ChangeAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "newAdmin", 1)]
        public virtual string NewAdmin { get; set; }
    }

    public partial class UpgradeToFunction : UpgradeToFunctionBase { }

    [Function("upgradeTo")]
    public class UpgradeToFunctionBase : FunctionMessage
    {
        [Parameter("address", "newImplementation", 1)]
        public virtual string NewImplementation { get; set; }
    }

    public partial class UpgradeToAndCallFunction : UpgradeToAndCallFunctionBase { }

    [Function("upgradeToAndCall")]
    public class UpgradeToAndCallFunctionBase : FunctionMessage
    {
        [Parameter("address", "newImplementation", 1)]
        public virtual string NewImplementation { get; set; }
        [Parameter("bytes", "data", 2)]
        public virtual byte[] Data { get; set; }
    }

    public partial class AdminChangedEventDTO : AdminChangedEventDTOBase { }

    [Event("AdminChanged")]
    public class AdminChangedEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousAdmin", 1, false )]
        public virtual string PreviousAdmin { get; set; }
        [Parameter("address", "newAdmin", 2, false )]
        public virtual string NewAdmin { get; set; }
    }

    public partial class UpgradedEventDTO : UpgradedEventDTOBase { }

    [Event("Upgraded")]
    public class UpgradedEventDTOBase : IEventDTO
    {
        [Parameter("address", "implementation", 1, true )]
        public virtual string Implementation { get; set; }
    }

    public partial class AdminOutputDTO : AdminOutputDTOBase { }

    [FunctionOutput]
    public class AdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ImplementationOutputDTO : ImplementationOutputDTOBase { }

    [FunctionOutput]
    public class ImplementationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }






}
