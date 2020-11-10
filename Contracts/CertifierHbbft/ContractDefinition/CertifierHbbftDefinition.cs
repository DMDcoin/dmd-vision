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

namespace DMDVision.Contracts.CertifierHbbft.ContractDefinition
{


    public partial class CertifierHbbftDeployment : CertifierHbbftDeploymentBase
    {
        public CertifierHbbftDeployment() : base(BYTECODE) { }
        public CertifierHbbftDeployment(string byteCode) : base(byteCode) { }
    }

    public class CertifierHbbftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610751806100206000396000f3fe608060405234801561001057600080fd5b506004361061007d5760003560e01c806374a8f1031161005b57806374a8f1031461013f578063cc1d4c0214610165578063dfc8bf4e1461018b578063e8e23ac0146101af5761007d565b80631425388714610082578063392e53cd146100aa578063462d0b2e146100c6575b600080fd5b6100a86004803603602081101561009857600080fd5b50356001600160a01b03166101d5565b005b6100b261027b565b604080519115158252519081900360200190f35b6100a8600480360360408110156100dc57600080fd5b8101906020810181356401000000008111156100f757600080fd5b82018360208201111561010957600080fd5b8035906020019184602083028401116401000000008311171561012b57600080fd5b9193509150356001600160a01b031661028c565b6100a86004803603602081101561015557600080fd5b50356001600160a01b0316610446565b6100b26004803603602081101561017b57600080fd5b50356001600160a01b0316610529565b6101936105d3565b604080516001600160a01b039092168252519081900360200190f35b6100b2600480360360208110156101c557600080fd5b50356001600160a01b03166105e2565b6101dd610600565b6001600160a01b0316336001600160a01b03161461022c5760405162461bcd60e51b815260040180806020018281038252602b8152602001806106f2602b913960400191505060405180910390fd5b61023461027b565b61026f5760405162461bcd60e51b81526004018080602001828103825260258152602001806106cd6025913960400191505060405180910390fd5b61027881610625565b50565b6001546001600160a01b0316151590565b610294610600565b6001600160a01b0316336001600160a01b031614806102cb57506102b6610600565b6001600160a01b0316326001600160a01b0316145b806102e457506102d9610600565b6001600160a01b0316155b806102ed575043155b610335576040805162461bcd60e51b815260206004820152601460248201527329b2b73232b91036bab9ba1031329030b236b4b760611b604482015290519081900360640190fd5b61033d61027b565b1561038f576040805162461bcd60e51b815260206004820152601f60248201527f436f6e747261637420697320616c726561647920696e697469616c697a656400604482015290519081900360640190fd5b6001600160a01b0381166103ea576040805162461bcd60e51b815260206004820152601a60248201527f56616c696461746f72736574206d757374206e6f742062652030000000000000604482015290519081900360640190fd5b60005b828110156104215761041984848381811061040457fe5b905060200201356001600160a01b0316610625565b6001016103ed565b50600180546001600160a01b0319166001600160a01b03929092169190911790555050565b61044e610600565b6001600160a01b0316336001600160a01b03161461049d5760405162461bcd60e51b815260040180806020018281038252602b8152602001806106f2602b913960400191505060405180910390fd5b6104a561027b565b6104e05760405162461bcd60e51b81526004018080602001828103825260258152602001806106cd6025913960400191505060405180910390fd5b6001600160a01b038116600081815260208190526040808220805460ff19169055517fb6fa8b8bd5eab60f292eca876e3ef90722275b785309d84b1de113ce0b8c4e749190a250565b6001600160a01b03811660009081526020819052604081205460ff1615610552575060016105ce565b600154604080516343f76bb560e11b81526001600160a01b038581166004830152915191909216916387eed76a916024808301926020929190829003018186803b15801561059f57600080fd5b505afa1580156105b3573d6000803e3d6000fd5b505050506040513d60208110156105c957600080fd5b505190505b919050565b6001546001600160a01b031681565b6001600160a01b031660009081526020819052604090205460ff1690565b7fb53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d61035490565b6001600160a01b038116610680576040805162461bcd60e51b815260206004820152601f60248201527f636572746966696572206d757374206e6f742062652061646472657373203000604482015290519081900360640190fd5b6001600160a01b038116600081815260208190526040808220805460ff19166001179055517fd415b905d4dd806bfba99a7a0e6351bd0c9db3a9912add21c0e6bef4479f673f9190a25056fe436f6e747261637420726571756972657320746f20626520696e697469616c697a656428296f6e6c792061646d696e20697320616c6c6f77656420746f2063616c6c20746869732066756e6374696f6ea265627a7a72315820317186fe4228d1d53ae0bd76f440f37af347098a6f936de2c5fc92f3a9bfadfd64736f6c63430005100032";
        public CertifierHbbftDeploymentBase() : base(BYTECODE) { }
        public CertifierHbbftDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class ValidatorSetContractFunction : ValidatorSetContractFunctionBase { }

    [Function("validatorSetContract", "address")]
    public class ValidatorSetContractFunctionBase : FunctionMessage
    {

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "_certifiedAddresses", 1)]
        public virtual List<string> CertifiedAddresses { get; set; }
        [Parameter("address", "_validatorSet", 2)]
        public virtual string ValidatorSet { get; set; }
    }

    public partial class CertifyFunction : CertifyFunctionBase { }

    [Function("certify")]
    public class CertifyFunctionBase : FunctionMessage
    {
        [Parameter("address", "_who", 1)]
        public virtual string Who { get; set; }
    }

    public partial class RevokeFunction : RevokeFunctionBase { }

    [Function("revoke")]
    public class RevokeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_who", 1)]
        public virtual string Who { get; set; }
    }

    public partial class CertifiedFunction : CertifiedFunctionBase { }

    [Function("certified", "bool")]
    public class CertifiedFunctionBase : FunctionMessage
    {
        [Parameter("address", "_who", 1)]
        public virtual string Who { get; set; }
    }

    public partial class CertifiedExplicitlyFunction : CertifiedExplicitlyFunctionBase { }

    [Function("certifiedExplicitly", "bool")]
    public class CertifiedExplicitlyFunctionBase : FunctionMessage
    {
        [Parameter("address", "_who", 1)]
        public virtual string Who { get; set; }
    }

    public partial class IsInitializedFunction : IsInitializedFunctionBase { }

    [Function("isInitialized", "bool")]
    public class IsInitializedFunctionBase : FunctionMessage
    {

    }

    public partial class ConfirmedEventDTO : ConfirmedEventDTOBase { }

    [Event("Confirmed")]
    public class ConfirmedEventDTOBase : IEventDTO
    {
        [Parameter("address", "who", 1, true )]
        public virtual string Who { get; set; }
    }

    public partial class RevokedEventDTO : RevokedEventDTOBase { }

    [Event("Revoked")]
    public class RevokedEventDTOBase : IEventDTO
    {
        [Parameter("address", "who", 1, true )]
        public virtual string Who { get; set; }
    }

    public partial class ValidatorSetContractOutputDTO : ValidatorSetContractOutputDTOBase { }

    [FunctionOutput]
    public class ValidatorSetContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }







    public partial class CertifiedOutputDTO : CertifiedOutputDTOBase { }

    [FunctionOutput]
    public class CertifiedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class CertifiedExplicitlyOutputDTO : CertifiedExplicitlyOutputDTOBase { }

    [FunctionOutput]
    public class CertifiedExplicitlyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsInitializedOutputDTO : IsInitializedOutputDTOBase { }

    [FunctionOutput]
    public class IsInitializedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }
}
