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

namespace DMDVision.Contracts.Migrations.ContractDefinition
{


    public partial class MigrationsDeployment : MigrationsDeploymentBase
    {
        public MigrationsDeployment() : base(BYTECODE) { }
        public MigrationsDeployment(string byteCode) : base(byteCode) { }
    }

    public class MigrationsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50600080546001600160a01b031916331790556101b3806100326000396000f3fe608060405234801561001057600080fd5b506004361061004c5760003560e01c80630900f01014610051578063445df0ac146100795780638da5cb5b14610093578063fdacd576146100b7575b600080fd5b6100776004803603602081101561006757600080fd5b50356001600160a01b03166100d4565b005b610081610151565b60408051918252519081900360200190f35b61009b610157565b604080516001600160a01b039092168252519081900360200190f35b610077600480360360208110156100cd57600080fd5b5035610166565b6000546001600160a01b031633141561014e576000819050806001600160a01b031663fdacd5766001546040518263ffffffff1660e01b815260040180828152602001915050600060405180830381600087803b15801561013457600080fd5b505af1158015610148573d6000803e3d6000fd5b50505050505b50565b60015481565b6000546001600160a01b031681565b6000546001600160a01b031633141561014e5760015556fea265627a7a723158206b7d8522eee5bc503c4d3b64e2e8ad72279fe4ccafb270ce88af023fa00154bc64736f6c63430005100032";
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

    public partial class UpgradeFunction : UpgradeFunctionBase { }

    [Function("upgrade")]
    public class UpgradeFunctionBase : FunctionMessage
    {
        [Parameter("address", "new_address", 1)]
        public virtual string New_address { get; set; }
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
