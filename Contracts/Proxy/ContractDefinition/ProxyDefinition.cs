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

namespace DMDVision.Contracts.Proxy.ContractDefinition
{


    public partial class ProxyDeployment : ProxyDeploymentBase
    {
        public ProxyDeployment() : base(BYTECODE) { }
        public ProxyDeployment(string byteCode) : base(byteCode) { }
    }

    public class ProxyDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x";
        public ProxyDeploymentBase() : base(BYTECODE) { }
        public ProxyDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
