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

namespace DMDVision.ContractsClaiming.ClaimContract.ContractDefinition
{


    public partial class ClaimContractDeployment : ClaimContractDeploymentBase
    {
        public ClaimContractDeployment() : base(BYTECODE) { }
        public ClaimContractDeployment(string byteCode) : base(byteCode) { }
    }

    public class ClaimContractDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611601806100206000396000f3fe608060405234801561001057600080fd5b5060043610610107576000357c01000000000000000000000000000000000000000000000000000000009004806392867f38116100a9578063e180dea911610083578063e180dea914610423578063e581528a14610451578063eaa2b1cd1461049f578063f2113dc9146104e257610107565b806392867f38146102f0578063a9880f3214610331578063c48a5ba5146103d457610107565b806330c1a785116100e557806330c1a7851461010c578063433cc269146101e657806371382209146102185780637b99c36d1461024a57610107565b806301f015e51461010c5780630e6f41541461014b57806326b8ed32146101a6575b600080fd5b61012f6004803603604081101561012257600080fd5b508035906020013561050e565b60408051600160a060020a039092168252519081900360200190f35b610192600480360360c081101561016157600080fd5b50600160a060020a038135169060208101359060408101359060ff6060820135169060808101359060a0013561053a565b604080519115158252519081900360200190f35b6101d4600480360360408110156101bc57600080fd5b50600160a060020a0381351690602001351515610701565b60408051918252519081900360200190f35b61012f600480360360808110156101fc57600080fd5b508035906020810135906040810135906060013560ff1661071c565b61012f6004803603608081101561022e57600080fd5b508035906020810135906040810135906060013560ff16610788565b6101d46004803603602081101561026057600080fd5b81019060208101813564010000000081111561027b57600080fd5b82018360208201111561028d57600080fd5b803590602001918460018302840111640100000000831117156102af57600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250929550610842945050505050565b610192600480360360a081101561030657600080fd5b50803590602081013560ff169060408101359060608101359060800135600160a060020a0316610973565b61035f6004803603604081101561034757600080fd5b50600160a060020a03813516906020013515156109fb565b6040805160208082528351818301528351919283929083019185019080838360005b83811015610399578181015183820152602001610381565b50505050905090810190601f1680156103c65780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b610192600480360360e08110156103ea57600080fd5b50600160a060020a0381351690602081013515159060408101359060608101359060ff6080820135169060a08101359060c00135610b4b565b61035f6004803603604081101561043957600080fd5b50600160a060020a0381351690602001351515610c79565b61047d6004803603606081101561046757600080fd5b508035906020810135906040013560ff16610e43565b604080516bffffffffffffffffffffffff199092168252519081900360200190f35b61012f600480360360a08110156104b557600080fd5b50600160a060020a0381351690602081013515159060ff6040820135169060608101359060800135611352565b6101d4600480360360208110156104f857600080fd5b50356bffffffffffffffffffffffff19166113d7565b604080516020808201949094528082019290925280518083038201815260609092019052805191012090565b600060606105498860016109fb565b90506000600280836040516020018082805190602001908083835b602083106105835780518252601f199092019160209182019101610564565b6001836020036101000a0380198251168184511680821785525050505050509050019150506040516020818303038152906040526040518082805190602001908083835b602083106105e65780518252601f1990920191602091820191016105c7565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa158015610625573d6000803e3d6000fd5b5050506040513d602081101561063a57600080fd5b50516040805160208181019390935281518082038401815290820191829052805190928291908401908083835b602083106106865780518252601f199092019160209182019101610667565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa1580156106c5573d6000803e3d6000fd5b5050506040513d60208110156106da57600080fd5b505190506106f4818787876106ef8d8d61050e565b610973565b9998505050505050505050565b600061071561071084846109fb565b610842565b9392505050565b604080516000808252602080830180855288905260ff85168385015260608301879052608083018690529251909260019260a080820193601f1981019281900390910190855afa158015610774573d6000803e3d6000fd5b5050604051601f1901519695505050505050565b600060048260ff1610156107e7576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252604d81526020018061157f604d913960600191505060405180910390fd5b6040805160008152602080820180845288905260ff600319860116828401526060820187905260808201869052915160019260a0808401939192601f1981019281900390910190855afa158015610774573d6000803e3d6000fd5b6000600280836040518082805190602001908083835b602083106108775780518252601f199092019160209182019101610858565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa1580156108b6573d6000803e3d6000fd5b5050506040513d60208110156108cb57600080fd5b50516040805160208181019390935281518082038401815290820191829052805190928291908401908083835b602083106109175780518252601f1990920191602091820191016108f8565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa158015610956573d6000803e3d6000fd5b5050506040513d602081101561096b57600080fd5b505192915050565b600081600160a060020a031660018787878760405160008152602001604052604051808581526020018460ff1660ff1681526020018381526020018281526020019450505050506020604051602081039080840390855afa1580156109dc573d6000803e3d6000fd5b50505060206040510351600160a060020a031614905095945050505050565b60408051602081019091526000815260609081610a188585610c79565b82516040517f180000000000000000000000000000000000000000000000000000000000000060208083019182527f426974636f696e205369676e6564204d6573736167653a0a00000000000000006021840181905260ff602a90950194851660f860020a0260398501528751959650601895909493889388939092603a90920191908501908083835b60208310610ac15780518252601f199092019160209182019101610aa2565b51815160209384036101000a600019018019909216911617905285519190930192850191508083835b60208310610b095780518252601f199092019160209182019101610aea565b6001836020036101000a038019825116818451168082178552505050505050905001955050505050506040516020818303038152906040529250505092915050565b6000601b8460ff1610158015610b655750601e8460ff1611155b610bd057604080517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152600960248201527f7620696e76616c69640000000000000000000000000000000000000000000000604482015290519081900360640190fd5b6000610bdc878761050e565b90506000610bed6107108b8b6109fb565b905081600160a060020a031660018288888860405160008152602001604052604051808581526020018460ff1660ff1681526020018381526020018281526020019450505050506020604051602081039080840390855afa158015610c56573d6000803e3d6000fd5b50505060206040510351600160a060020a03161492505050979650505050505050565b6040805160288082526060828101909352829190602082018180388339019050509050610cc8816bffffffffffffffffffffffff196c01000000000000000000000000870216600060146113e9565b8215610d3957805160208201206000805b6014811015610d35576000838260208110610cf057fe5b600185019460f860020a9290911a8202919091049150610d18908690601060ff8516046114e5565b610d2c858480600101955083600f166114e5565b50600101610cd9565b5050505b60408051602a80825260608201909252906020820181803883390190505091507f300000000000000000000000000000000000000000000000000000000000000082600081518110610d8757fe5b6020010190600160f860020a031916908160001a9053507f780000000000000000000000000000000000000000000000000000000000000082600181518110610dcc57fe5b6020010190600160f860020a031916908160001a90535060005b6028811015610e3b57818181518110610dfb57fe5b602001015160f860020a900460f860020a02838260020181518110610e1c57fe5b6020010190600160f860020a031916908160001a905350600101610de6565b505092915050565b600080806001846003811115610e5557fe5b1480610e6c57506003846003811115610e6a57fe5b145b15610fe9576001851615610e81576003610e84565b60025b9050600360028288604051602001808360ff1660ff1660f860020a028152600101828152602001925050506040516020818303038152906040526040518082805190602001908083835b60208310610eed5780518252601f199092019160209182019101610ece565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa158015610f2c573d6000803e3d6000fd5b5050506040513d6020811015610f4157600080fd5b50516040805160208181019390935281518082038401815290820191829052805190928291908401908083835b60208310610f8d5780518252601f199092019160209182019101610f6e565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa158015610fcc573d6000803e3d6000fd5b505050604051516c01000000000000000000000000029150611167565b50604080517f0400000000000000000000000000000000000000000000000000000000000000602080830191909152602182018890526041808301889052835180840390910181526061909201928390528151600493600393600293909282918401908083835b6020831061106f5780518252601f199092019160209182019101611050565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa1580156110ae573d6000803e3d6000fd5b5050506040513d60208110156110c357600080fd5b50516040805160208181019390935281518082038401815290820191829052805190928291908401908083835b6020831061110f5780518252601f1990920191602091820191016110f0565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa15801561114e573d6000803e3d6000fd5b505050604051516c010000000000000000000000000291505b600084600381111561117557fe5b148061118c5750600184600381111561118a57fe5b145b1561119957509050610715565b60028460038111156111a757fe5b14806111be575060038460038111156111bc57fe5b145b1561134957604080517e140000000000000000000000000000000000000000000000000000000000006020808301919091526bffffffffffffffffffffffff198516602283015282516016818403018152603690920192839052815160039360029392909182918401908083835b6020831061124b5780518252601f19909201916020918201910161122c565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa15801561128a573d6000803e3d6000fd5b5050506040513d602081101561129f57600080fd5b50516040805160208181019390935281518082038401815290820191829052805190928291908401908083835b602083106112eb5780518252601f1990920191602091820191016112cc565b51815160209384036101000a60001901801990921691161790526040519190930194509192505080830381855afa15801561132a573d6000803e3d6000fd5b505050604051516c010000000000000000000000000292505050610715565b50509392505050565b60008061136261071088886109fb565b905060018186868660405160008152602001604052604051808581526020018460ff1660ff1681526020018381526020018281526020019450505050506020604051602081039080840390855afa1580156113c1573d6000803e3d6000fd5b5050604051601f19015198975050505050505050565b60006020819052908152604090205481565b8160005b828110156114dd57600085826020811061140357fe5b60f860020a91901a81020490507f3031323334353637383961626364656600000000000000000000000000000000601060ff8084168290041690811061144557fe5b1a60f860020a0287848060010195508151811061145e57fe5b6020010190600160f860020a031916908160001a9053507f3031323334353637383961626364656600000000000000000000000000000000600f8216601081106114a457fe5b1a60f860020a028784806001019550815181106114bd57fe5b6020010190600160f860020a031916908160001a905350506001016113ed565b505050505050565b60008383815181106114f357fe5b602001015160f860020a900460f860020a0290507f610000000000000000000000000000000000000000000000000000000000000081600160f860020a03191610158015611545575060088260ff1610155b156115785780602060f860020a021884848151811061156057fe5b6020010190600160f860020a031916908160001a9053505b5050505056fe426974636f696e2061646473206120636f6e7374616e74203420746f2074686520762076616c75652e2074686973207369676e6174757265207365656d7320746f20626520696e76616c69642ea2646970667358221220cce2b1151de2be34b7351473dc40cc25b8e4490551fad9b727a19ada83fe744b64736f6c63430006020033";
        public ClaimContractDeploymentBase() : base(BYTECODE) { }
        public ClaimContractDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BalancesFunction : BalancesFunctionBase { }

    [Function("balances", "uint256")]
    public class BalancesFunctionBase : FunctionMessage
    {
        [Parameter("bytes20", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetPublicKeyFromBitcoinSignatureFunction : GetPublicKeyFromBitcoinSignatureFunctionBase { }

    [Function("getPublicKeyFromBitcoinSignature", "address")]
    public class GetPublicKeyFromBitcoinSignatureFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "hashValue", 1)]
        public virtual byte[] HashValue { get; set; }
        [Parameter("bytes32", "r", 2)]
        public virtual byte[] R { get; set; }
        [Parameter("bytes32", "s", 3)]
        public virtual byte[] S { get; set; }
        [Parameter("uint8", "v", 4)]
        public virtual byte V { get; set; }
    }

    public partial class PublicKeyToBitcoinAddressFunction : PublicKeyToBitcoinAddressFunctionBase { }

    [Function("PublicKeyToBitcoinAddress", "bytes20")]
    public class PublicKeyToBitcoinAddressFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "a_publicKeyX", 1)]
        public virtual byte[] A_publicKeyX { get; set; }
        [Parameter("bytes32", "a_publicKeyY", 2)]
        public virtual byte[] A_publicKeyY { get; set; }
        [Parameter("uint8", "a_nAddressType", 3)]
        public virtual byte A_nAddressType { get; set; }
    }

    public partial class PublicKeyToEthereumAddressFunction : PublicKeyToEthereumAddressFunctionBase { }

    [Function("PublicKeyToEthereumAddress", "address")]
    public class PublicKeyToEthereumAddressFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "a_publicKeyX", 1)]
        public virtual byte[] A_publicKeyX { get; set; }
        [Parameter("bytes32", "a_publicKeyY", 2)]
        public virtual byte[] A_publicKeyY { get; set; }
    }

    public partial class ValidateSignatureFunction : ValidateSignatureFunctionBase { }

    [Function("ValidateSignature", "bool")]
    public class ValidateSignatureFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_hash", 1)]
        public virtual byte[] Hash { get; set; }
        [Parameter("uint8", "_v", 2)]
        public virtual byte V { get; set; }
        [Parameter("bytes32", "_r", 3)]
        public virtual byte[] R { get; set; }
        [Parameter("bytes32", "_s", 4)]
        public virtual byte[] S { get; set; }
        [Parameter("address", "_address", 5)]
        public virtual string Address { get; set; }
    }

    public partial class ECDSAVerifyFunction : ECDSAVerifyFunctionBase { }

    [Function("ECDSAVerify", "bool")]
    public class ECDSAVerifyFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addressClaiming", 1)]
        public virtual string AddressClaiming { get; set; }
        [Parameter("bytes32", "_publicKeyX", 2)]
        public virtual byte[] PublicKeyX { get; set; }
        [Parameter("bytes32", "_publicKeyY", 3)]
        public virtual byte[] PublicKeyY { get; set; }
        [Parameter("uint8", "_v", 4)]
        public virtual byte V { get; set; }
        [Parameter("bytes32", "_r", 5)]
        public virtual byte[] R { get; set; }
        [Parameter("bytes32", "_s", 6)]
        public virtual byte[] S { get; set; }
    }

    public partial class CheckSignatureFunction : CheckSignatureFunctionBase { }

    [Function("checkSignature", "address")]
    public class CheckSignatureFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_hash", 1)]
        public virtual byte[] Hash { get; set; }
        [Parameter("bytes32", "_r", 2)]
        public virtual byte[] R { get; set; }
        [Parameter("bytes32", "_s", 3)]
        public virtual byte[] S { get; set; }
        [Parameter("uint8", "_v", 4)]
        public virtual byte V { get; set; }
    }

    public partial class PubKeyToEthAddressFunction : PubKeyToEthAddressFunctionBase { }

    [Function("pubKeyToEthAddress", "address")]
    public class PubKeyToEthAddressFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "pubKeyX", 1)]
        public virtual byte[] PubKeyX { get; set; }
        [Parameter("bytes32", "pubKeyY", 2)]
        public virtual byte[] PubKeyY { get; set; }
    }

    public partial class CalcHash256Function : CalcHash256FunctionBase { }

    [Function("calcHash256", "bytes32")]
    public class CalcHash256FunctionBase : FunctionMessage
    {
        [Parameter("bytes", "data", 1)]
        public virtual byte[] Data { get; set; }
    }

    public partial class CalculateAddressStringFunction : CalculateAddressStringFunctionBase { }

    [Function("calculateAddressString", "bytes")]
    public class CalculateAddressStringFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
        [Parameter("bool", "_includeAddrChecksum", 2)]
        public virtual bool IncludeAddrChecksum { get; set; }
    }

    public partial class CreateClaimMessageFunction : CreateClaimMessageFunctionBase { }

    [Function("createClaimMessage", "bytes")]
    public class CreateClaimMessageFunctionBase : FunctionMessage
    {
        [Parameter("address", "_claimToAddr", 1)]
        public virtual string ClaimToAddr { get; set; }
        [Parameter("bool", "_claimAddrChecksum", 2)]
        public virtual bool ClaimAddrChecksum { get; set; }
    }

    public partial class GetHashForClaimMessageFunction : GetHashForClaimMessageFunctionBase { }

    [Function("getHashForClaimMessage", "bytes32")]
    public class GetHashForClaimMessageFunctionBase : FunctionMessage
    {
        [Parameter("address", "_claimToAddr", 1)]
        public virtual string ClaimToAddr { get; set; }
        [Parameter("bool", "_claimAddrChecksum", 2)]
        public virtual bool ClaimAddrChecksum { get; set; }
    }

    public partial class GetEthAddressFromSignatureFunction : GetEthAddressFromSignatureFunctionBase { }

    [Function("getEthAddressFromSignature", "address")]
    public class GetEthAddressFromSignatureFunctionBase : FunctionMessage
    {
        [Parameter("address", "_claimToAddr", 1)]
        public virtual string ClaimToAddr { get; set; }
        [Parameter("bool", "_claimAddrChecksum", 2)]
        public virtual bool ClaimAddrChecksum { get; set; }
        [Parameter("uint8", "_v", 3)]
        public virtual byte V { get; set; }
        [Parameter("bytes32", "_r", 4)]
        public virtual byte[] R { get; set; }
        [Parameter("bytes32", "_s", 5)]
        public virtual byte[] S { get; set; }
    }

    public partial class ClaimMessageMatchesSignatureFunction : ClaimMessageMatchesSignatureFunctionBase { }

    [Function("claimMessageMatchesSignature", "bool")]
    public class ClaimMessageMatchesSignatureFunctionBase : FunctionMessage
    {
        [Parameter("address", "_claimToAddr", 1)]
        public virtual string ClaimToAddr { get; set; }
        [Parameter("bool", "_claimAddrChecksum", 2)]
        public virtual bool ClaimAddrChecksum { get; set; }
        [Parameter("bytes32", "_pubKeyX", 3)]
        public virtual byte[] PubKeyX { get; set; }
        [Parameter("bytes32", "_pubKeyY", 4)]
        public virtual byte[] PubKeyY { get; set; }
        [Parameter("uint8", "_v", 5)]
        public virtual byte V { get; set; }
        [Parameter("bytes32", "_r", 6)]
        public virtual byte[] R { get; set; }
        [Parameter("bytes32", "_s", 7)]
        public virtual byte[] S { get; set; }
    }

    public partial class BalancesOutputDTO : BalancesOutputDTOBase { }

    [FunctionOutput]
    public class BalancesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetPublicKeyFromBitcoinSignatureOutputDTO : GetPublicKeyFromBitcoinSignatureOutputDTOBase { }

    [FunctionOutput]
    public class GetPublicKeyFromBitcoinSignatureOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PublicKeyToBitcoinAddressOutputDTO : PublicKeyToBitcoinAddressOutputDTOBase { }

    [FunctionOutput]
    public class PublicKeyToBitcoinAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes20", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class PublicKeyToEthereumAddressOutputDTO : PublicKeyToEthereumAddressOutputDTOBase { }

    [FunctionOutput]
    public class PublicKeyToEthereumAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ValidateSignatureOutputDTO : ValidateSignatureOutputDTOBase { }

    [FunctionOutput]
    public class ValidateSignatureOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class ECDSAVerifyOutputDTO : ECDSAVerifyOutputDTOBase { }

    [FunctionOutput]
    public class ECDSAVerifyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class CheckSignatureOutputDTO : CheckSignatureOutputDTOBase { }

    [FunctionOutput]
    public class CheckSignatureOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PubKeyToEthAddressOutputDTO : PubKeyToEthAddressOutputDTOBase { }

    [FunctionOutput]
    public class PubKeyToEthAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class CalcHash256OutputDTO : CalcHash256OutputDTOBase { }

    [FunctionOutput]
    public class CalcHash256OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class CalculateAddressStringOutputDTO : CalculateAddressStringOutputDTOBase { }

    [FunctionOutput]
    public class CalculateAddressStringOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "addrStr", 1)]
        public virtual byte[] AddrStr { get; set; }
    }

    public partial class CreateClaimMessageOutputDTO : CreateClaimMessageOutputDTOBase { }

    [FunctionOutput]
    public class CreateClaimMessageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetHashForClaimMessageOutputDTO : GetHashForClaimMessageOutputDTOBase { }

    [FunctionOutput]
    public class GetHashForClaimMessageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetEthAddressFromSignatureOutputDTO : GetEthAddressFromSignatureOutputDTOBase { }

    [FunctionOutput]
    public class GetEthAddressFromSignatureOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ClaimMessageMatchesSignatureOutputDTO : ClaimMessageMatchesSignatureOutputDTOBase { }

    [FunctionOutput]
    public class ClaimMessageMatchesSignatureOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }
}
