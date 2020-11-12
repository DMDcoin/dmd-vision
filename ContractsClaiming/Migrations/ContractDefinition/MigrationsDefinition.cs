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

namespace DMDVision.ContractsClaiming.Migrations.ContractDefinition
{


    public partial class MigrationsDeployment : MigrationsDeploymentBase
    {
        public MigrationsDeployment() : base(BYTECODE) { }
        public MigrationsDeployment(string byteCode) : base(byteCode) { }
    }

    public class MigrationsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5060008054600160a060020a0319163317905561014d806100326000396000f3fe608060405234801561001057600080fd5b506004361061005d577c01000000000000000000000000000000000000000000000000000000006000350463445df0ac81146100625780638da5cb5b1461007c578063fdacd576146100ad575b600080fd5b61006a6100cc565b60408051918252519081900360200190f35b6100846100d2565b6040805173ffffffffffffffffffffffffffffffffffffffff9092168252519081900360200190f35b6100ca600480360360208110156100c357600080fd5b50356100ee565b005b60015481565b60005473ffffffffffffffffffffffffffffffffffffffff1681565b60005473ffffffffffffffffffffffffffffffffffffffff163314156101145760018190555b5056fea2646970667358221220b124215f0f6227499a5e4c2e9845a9af7822cf86287e0082211129cf1b46116a64736f6c63430006020033";
        public MigrationsDeploymentBase() : base(BYTECODE) { }
        public MigrationsDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class Last_completed_migrationFunction : Last_completed_migrationFunctionBase { }

    [Function("last_completed_migration", "uint256")]
    public class Last_completed_migrationFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class SetCompletedFunction : SetCompletedFunctionBase { }

    [Function("setCompleted")]
    public class SetCompletedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "completed", 1)]
        public virtual BigInteger Completed { get; set; }
    }

    public partial class Last_completed_migrationOutputDTO : Last_completed_migrationOutputDTOBase { }

    [FunctionOutput]
    public class Last_completed_migrationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}
