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

namespace DMDVision.Contracts.TxPermissionHbbft.ContractDefinition
{


    public partial class TxPermissionHbbftDeployment : TxPermissionHbbftDeploymentBase
    {
        public TxPermissionHbbftDeployment() : base(BYTECODE) { }
        public TxPermissionHbbftDeployment(string byteCode) : base(byteCode) { }
    }

    public class TxPermissionHbbftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5061104e806100206000396000f3fe608060405234801561001057600080fd5b50600436106100f55760003560e01c8063a0a8e46011610097578063d46005b111610066578063d46005b11461037a578063d9eb2d5e14610405578063dfc8bf4e1461040d578063efc7840114610415576100f5565b8063a0a8e46014610259578063b47aef1f14610261578063b9056afa14610269578063c746c8f414610354576100f5565b8063392e53cd116100d3578063392e53cd14610190578063469ab1e3146101ac578063471eab5c146101b457806375d0c0dc146101dc576100f5565b80631a9ebeaa146100fa5780631b9f67a11461011e5780633272b28c14610138575b600080fd5b61010261043b565b604080516001600160a01b039092168252519081900360200190f35b61012661044a565b60408051918252519081900360200190f35b610140610451565b60408051602080825283518183015283519192839290830191858101910280838360005b8381101561017c578181015183820152602001610164565b505050509050019250505060405180910390f35b6101986104b4565b604080519115158252519081900360200190f35b6101266104c5565b6101da600480360360208110156101ca57600080fd5b50356001600160a01b0316610541565b005b6101e46106a7565b6040805160208082528351818301528351919283929083019185019080838360005b8381101561021e578181015183820152602001610206565b50505050905090810190601f16801561024b5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6101266106d7565b6101026106dc565b610334600480360360a081101561027f57600080fd5b6001600160a01b03823581169260208101359091169160408201359160608101359181019060a0810160808201356401000000008111156102bf57600080fd5b8201836020820111156102d157600080fd5b803590602001918460018302840111640100000000831117156102f357600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295506106eb945050505050565b6040805163ffffffff909316835290151560208301528051918290030190f35b6101da6004803603602081101561036a57600080fd5b50356001600160a01b0316610c8c565b6101da6004803603608081101561039057600080fd5b8101906020810181356401000000008111156103ab57600080fd5b8201836020820111156103bd57600080fd5b803590602001918460208302840111640100000000831117156103df57600080fd5b91935091506001600160a01b038135811691602081013582169160409091013516610d00565b610126610e95565b610102610e9c565b6101986004803603602081101561042b57600080fd5b50356001600160a01b0316610eab565b6001546001600160a01b031681565b621e848081565b606060008054806020026020016040519081016040528092919081815260200182805480156104a957602002820191906000526020600020905b81546001600160a01b0316815260019091019060200180831161048b575b505050505090505b90565b6004546001600160a01b0316151590565b60006104cf6106a7565b6040516020018082805190602001908083835b602083106105015780518252601f1990920191602091820191016104e2565b6001836020036101000a03801982511681845116808217855250505050505090500191505060405160208183030381529060405280519060200120905090565b610549610ec0565b6001600160a01b0316336001600160a01b0316146105985760405162461bcd60e51b815260040180806020018281038252602b815260200180610fef602b913960400191505060405180910390fd5b6105a06104b4565b6105a957600080fd5b6001600160a01b03811660009081526003602052604090205460ff166105ce57600080fd5b60008054905b8181101561068457600081815481106105e957fe5b6000918252602090912001546001600160a01b038481169116141561067c576000600183038154811061061857fe5b600091825260208220015481546001600160a01b0390911691908390811061063c57fe5b6000918252602082200180546001600160a01b0319166001600160a01b039390931692909217909155805490610676906000198301610f83565b50610684565b6001016105d4565b50506001600160a01b03166000908152600360205260409020805460ff19169055565b604080518082019091526016815275151617d41154935254d4d253d397d0d3d395149050d560521b602082015290565b600390565b6002546001600160a01b031681565b6001600160a01b038516600090815260036020526040812054819060ff161561071d575063ffffffff90506000610c82565b60006060815b60048651101580156107355750600481105b15610768578060080286828151811061074a57fe5b01602001516001600160f81b031916901c9290921791600101610723565b6004546001600160a01b038a8116911614156109e7576001600160e01b03198316630311db7560e61b14156109435760406004875103116107ad5760048651036107b0565b60405b6040519080825280601f01601f1916602001820160405280156107da576020820181803883390190505b509150600090505b8151811015610830578581600401815181106107fa57fe5b602001015160f81c60f81b82828151811061081157fe5b60200101906001600160f81b031916908160001a9053506001016107e2565b60008083806020019051604081101561084857600080fd5b810190808051906020019092919080519060200190929190505050915091506000600460009054906101000a90046001600160a01b03166001600160a01b031663a670eb568e85856040518463ffffffff1660e01b815260040180846001600160a01b03166001600160a01b03168152602001836001600160a01b03166001600160a01b031681526020018281526020019350505050604080518083038186803b1580156108f557600080fd5b505afa158015610909573d6000803e3d6000fd5b505050506040513d604081101561091f57600080fd5b505190508061092f576000610932565b60025b600097509750505050505050610c82565b86156109e257600480546040805163facd743b60e01b81526001600160a01b038e8116948201949094529051929091169163facd743b91602480820192602092909190829003018186803b15801561099a57600080fd5b505afa1580156109ae573d6000803e3d6000fd5b505050506040513d60208110156109c457600080fd5b50516109d15760026109d4565b60005b600094509450505050610c82565b610a8f565b6002546001600160a01b038a811691161415610a8f57600480546040805163fb64aac160e01b81526001600160a01b038e8116948201949094529051929091169163fb64aac191602480820192602092909190829003018186803b158015610a4e57600080fd5b505afa158015610a62573d6000803e3d6000fd5b505050506040513d6020811015610a7857600080fd5b505115610a8f576002600094509450505050610c82565b600480546040805163facd743b60e01b81526001600160a01b038e8116948201949094529051929091169163facd743b91602480820192602092909190829003018186803b158015610ae057600080fd5b505afa158015610af4573d6000803e3d6000fd5b505050506040513d6020811015610b0a57600080fd5b50518015610b185750600087115b15610b465760008a6001600160a01b03163111610b365760006109d4565b6001600094509450505050610c82565b600480546040805163facd743b60e01b81526001600160a01b038d8116948201949094529051929091169163facd743b91602480820192602092909190829003018186803b158015610b9757600080fd5b505afa158015610bab573d6000803e3d6000fd5b505050506040513d6020811015610bc157600080fd5b505115610bd75760008094509450505050610c82565b86610c7357600154604080516303a388eb60e61b81526001600160a01b038d811660048301529151919092169163e8e23ac0916024808301926020929190829003018186803b158015610c2957600080fd5b505afa158015610c3d573d6000803e3d6000fd5b505050506040513d6020811015610c5357600080fd5b5051610c605760006109d4565b63ffffffff600094509450505050610c82565b63ffffffff6000945094505050505b9550959350505050565b610c94610ec0565b6001600160a01b0316336001600160a01b031614610ce35760405162461bcd60e51b815260040180806020018281038252602b815260200180610fef602b913960400191505060405180910390fd5b610ceb6104b4565b610cf457600080fd5b610cfd81610ee5565b50565b610d08610ec0565b6001600160a01b0316336001600160a01b03161480610d3f5750610d2a610ec0565b6001600160a01b0316326001600160a01b0316145b80610d585750610d4d610ec0565b6001600160a01b0316155b80610d61575043155b610d6a57600080fd5b610d726104b4565b15610dae5760405162461bcd60e51b8152600401808060200182810382526024815260200180610fcb6024913960400191505060405180910390fd5b6001600160a01b038316610dc157600080fd5b6001600160a01b038216610e1c576040805162461bcd60e51b815260206004820152601a60248201527f56616c696461746f72536574206d757374206e6f742062652030000000000000604482015290519081900360640190fd5b60005b84811015610e5357610e4b868683818110610e3657fe5b905060200201356001600160a01b0316610ee5565b600101610e1f565b50600180546001600160a01b039485166001600160a01b0319918216179091556004805493851693821693909317909255600280549190931691161790555050565b6298968081565b6004546001600160a01b031681565b60036020526000908152604090205460ff1681565b7fb53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d61035490565b6001600160a01b03811660009081526003602052604090205460ff1615610f0b57600080fd5b6001600160a01b038116610f1e57600080fd5b60008054600181810183557f290decd9548b62a8d60345a988386fc84ba6bc95484008f6362f93160ef3e56390910180546001600160a01b039094166001600160a01b031990941684179055918152600360205260409020805460ff19169091179055565b815481835581811115610fa757600083815260209020610fa7918101908301610fac565b505050565b6104b191905b80821115610fc65760008155600101610fb2565b509056fe696e697469616c697a6174696f6e2063616e206f6e6c7920626520646f6e65206f6e63656f6e6c792061646d696e20697320616c6c6f77656420746f2063616c6c20746869732066756e6374696f6ea265627a7a72315820ceee80d376247bf1ac019643a8cf401a599a63c3a0fe052509600f93de4a15b864736f6c63430005100032";
        public TxPermissionHbbftDeploymentBase() : base(BYTECODE) { }
        public TxPermissionHbbftDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BLOCK_GAS_LIMITFunction : BLOCK_GAS_LIMITFunctionBase { }

    [Function("BLOCK_GAS_LIMIT", "uint256")]
    public class BLOCK_GAS_LIMITFunctionBase : FunctionMessage
    {

    }

    public partial class BLOCK_GAS_LIMIT_REDUCEDFunction : BLOCK_GAS_LIMIT_REDUCEDFunctionBase { }

    [Function("BLOCK_GAS_LIMIT_REDUCED", "uint256")]
    public class BLOCK_GAS_LIMIT_REDUCEDFunctionBase : FunctionMessage
    {

    }

    public partial class CertifierContractFunction : CertifierContractFunctionBase { }

    [Function("certifierContract", "address")]
    public class CertifierContractFunctionBase : FunctionMessage
    {

    }

    public partial class IsSenderAllowedFunction : IsSenderAllowedFunctionBase { }

    [Function("isSenderAllowed", "bool")]
    public class IsSenderAllowedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class KeyGenHistoryContractFunction : KeyGenHistoryContractFunctionBase { }

    [Function("keyGenHistoryContract", "address")]
    public class KeyGenHistoryContractFunctionBase : FunctionMessage
    {

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
        [Parameter("address[]", "_allowed", 1)]
        public virtual List<string> Allowed { get; set; }
        [Parameter("address", "_certifier", 2)]
        public virtual string Certifier { get; set; }
        [Parameter("address", "_validatorSet", 3)]
        public virtual string ValidatorSet { get; set; }
        [Parameter("address", "_keyGenHistoryContract", 4)]
        public virtual string KeyGenHistoryContract { get; set; }
    }

    public partial class AddAllowedSenderFunction : AddAllowedSenderFunctionBase { }

    [Function("addAllowedSender")]
    public class AddAllowedSenderFunctionBase : FunctionMessage
    {
        [Parameter("address", "_sender", 1)]
        public virtual string Sender { get; set; }
    }

    public partial class RemoveAllowedSenderFunction : RemoveAllowedSenderFunctionBase { }

    [Function("removeAllowedSender")]
    public class RemoveAllowedSenderFunctionBase : FunctionMessage
    {
        [Parameter("address", "_sender", 1)]
        public virtual string Sender { get; set; }
    }

    public partial class ContractNameFunction : ContractNameFunctionBase { }

    [Function("contractName", "string")]
    public class ContractNameFunctionBase : FunctionMessage
    {

    }

    public partial class ContractNameHashFunction : ContractNameHashFunctionBase { }

    [Function("contractNameHash", "bytes32")]
    public class ContractNameHashFunctionBase : FunctionMessage
    {

    }

    public partial class ContractVersionFunction : ContractVersionFunctionBase { }

    [Function("contractVersion", "uint256")]
    public class ContractVersionFunctionBase : FunctionMessage
    {

    }

    public partial class AllowedSendersFunction : AllowedSendersFunctionBase { }

    [Function("allowedSenders", "address[]")]
    public class AllowedSendersFunctionBase : FunctionMessage
    {

    }

    public partial class AllowedTxTypesFunction : AllowedTxTypesFunctionBase { }

    [Function("allowedTxTypes", typeof(AllowedTxTypesOutputDTO))]
    public class AllowedTxTypesFunctionBase : FunctionMessage
    {
        [Parameter("address", "_sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256", "_gasPrice", 4)]
        public virtual BigInteger GasPrice { get; set; }
        [Parameter("bytes", "_data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class IsInitializedFunction : IsInitializedFunctionBase { }

    [Function("isInitialized", "bool")]
    public class IsInitializedFunctionBase : FunctionMessage
    {

    }

    public partial class BLOCK_GAS_LIMITOutputDTO : BLOCK_GAS_LIMITOutputDTOBase { }

    [FunctionOutput]
    public class BLOCK_GAS_LIMITOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BLOCK_GAS_LIMIT_REDUCEDOutputDTO : BLOCK_GAS_LIMIT_REDUCEDOutputDTOBase { }

    [FunctionOutput]
    public class BLOCK_GAS_LIMIT_REDUCEDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CertifierContractOutputDTO : CertifierContractOutputDTOBase { }

    [FunctionOutput]
    public class CertifierContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsSenderAllowedOutputDTO : IsSenderAllowedOutputDTOBase { }

    [FunctionOutput]
    public class IsSenderAllowedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class KeyGenHistoryContractOutputDTO : KeyGenHistoryContractOutputDTOBase { }

    [FunctionOutput]
    public class KeyGenHistoryContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ValidatorSetContractOutputDTO : ValidatorSetContractOutputDTOBase { }

    [FunctionOutput]
    public class ValidatorSetContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }







    public partial class ContractNameOutputDTO : ContractNameOutputDTOBase { }

    [FunctionOutput]
    public class ContractNameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ContractNameHashOutputDTO : ContractNameHashOutputDTOBase { }

    [FunctionOutput]
    public class ContractNameHashOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class ContractVersionOutputDTO : ContractVersionOutputDTOBase { }

    [FunctionOutput]
    public class ContractVersionOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class AllowedSendersOutputDTO : AllowedSendersOutputDTOBase { }

    [FunctionOutput]
    public class AllowedSendersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class AllowedTxTypesOutputDTO : AllowedTxTypesOutputDTOBase { }

    [FunctionOutput]
    public class AllowedTxTypesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "typesMask", 1)]
        public virtual uint TypesMask { get; set; }
        [Parameter("bool", "cache", 2)]
        public virtual bool Cache { get; set; }
    }

    public partial class IsInitializedOutputDTO : IsInitializedOutputDTOBase { }

    [FunctionOutput]
    public class IsInitializedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }
}
