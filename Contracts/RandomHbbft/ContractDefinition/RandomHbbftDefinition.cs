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

namespace DMDVision.Contracts.RandomHbbft.ContractDefinition
{


    public partial class RandomHbbftDeployment : RandomHbbftDeploymentBase
    {
        public RandomHbbftDeployment() : base(BYTECODE) { }
        public RandomHbbftDeployment(string byteCode) : base(byteCode) { }
    }

    public class RandomHbbftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610105806100206000396000f3fe6080604052348015600f57600080fd5b506004361060325760003560e01c806383220626146037578063919cc19c14604f575b600080fd5b603d606b565b60408051918252519081900360200190f35b606960048036036020811015606357600080fd5b50356071565b005b60005481565b6002600160a01b03331460cb576040805162461bcd60e51b815260206004820152601a60248201527f4d7573742062652065786563757465642062792053797374656d000000000000604482015290519081900360640190fd5b60005556fea265627a7a72315820271a8be9700ea6cf3ebe14eda3531e22efa15477023693dbde4c29ac44ab4d7164736f6c63430005100032";
        public RandomHbbftDeploymentBase() : base(BYTECODE) { }
        public RandomHbbftDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CurrentSeedFunction : CurrentSeedFunctionBase { }

    [Function("currentSeed", "uint256")]
    public class CurrentSeedFunctionBase : FunctionMessage
    {

    }

    public partial class SetCurrentSeedFunction : SetCurrentSeedFunctionBase { }

    [Function("setCurrentSeed")]
    public class SetCurrentSeedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_currentSeed", 1)]
        public virtual BigInteger CurrentSeed { get; set; }
    }

    public partial class CurrentSeedOutputDTO : CurrentSeedOutputDTOBase { }

    [FunctionOutput]
    public class CurrentSeedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }


}
