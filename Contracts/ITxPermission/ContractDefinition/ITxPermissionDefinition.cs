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

namespace DMDVision.Contracts.ITxPermission.ContractDefinition
{


    public partial class ITxPermissionDeployment : ITxPermissionDeploymentBase
    {
        public ITxPermissionDeployment() : base(BYTECODE) { }
        public ITxPermissionDeployment(string byteCode) : base(byteCode) { }
    }

    public class ITxPermissionDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public ITxPermissionDeploymentBase() : base(BYTECODE) { }
        public ITxPermissionDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("address", "", 3)]
        public virtual string ReturnValue3 { get; set; }
        [Parameter("address", "", 4)]
        public virtual string ReturnValue4 { get; set; }
    }


}
