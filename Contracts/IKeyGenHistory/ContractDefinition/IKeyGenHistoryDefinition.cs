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

namespace DMDVision.Contracts.IKeyGenHistory.ContractDefinition
{


    public partial class IKeyGenHistoryDeployment : IKeyGenHistoryDeploymentBase
    {
        public IKeyGenHistoryDeployment() : base(BYTECODE) { }
        public IKeyGenHistoryDeployment(string byteCode) : base(byteCode) { }
    }

    public class IKeyGenHistoryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public IKeyGenHistoryDeploymentBase() : base(BYTECODE) { }
        public IKeyGenHistoryDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address[]", "", 2)]
        public virtual List<string> ReturnValue2 { get; set; }
        [Parameter("bytes[]", "", 3)]
        public virtual List<byte[]> ReturnValue3 { get; set; }
        [Parameter("bytes[][]", "", 4)]
        public virtual List<List<byte[]>> ReturnValue4 { get; set; }
    }

    public partial class ClearPrevKeyGenStateFunction : ClearPrevKeyGenStateFunctionBase { }

    [Function("clearPrevKeyGenState")]
    public class ClearPrevKeyGenStateFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }




}
