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

namespace DMDVision.Contracts.SafeMath.ContractDefinition
{


    public partial class SafeMathDeployment : SafeMathDeploymentBase
    {
        public SafeMathDeployment() : base(BYTECODE) { }
        public SafeMathDeployment(string byteCode) : base(byteCode) { }
    }

    public class SafeMathDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60556023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea265627a7a72315820339468d2302202e425c87c73ea4d5b81d5be893aae0993b7ae61f31abdeee71264736f6c63430005100032";
        public SafeMathDeploymentBase() : base(BYTECODE) { }
        public SafeMathDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
