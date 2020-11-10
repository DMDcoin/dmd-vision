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

namespace DMDVision.Contracts.UpgradeabilityAdmin.ContractDefinition
{


    public partial class UpgradeabilityAdminDeployment : UpgradeabilityAdminDeploymentBase
    {
        public UpgradeabilityAdminDeployment() : base(BYTECODE) { }
        public UpgradeabilityAdminDeployment(string byteCode) : base(byteCode) { }
    }

    public class UpgradeabilityAdminDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052348015600f57600080fd5b50603e80601d6000396000f3fe6080604052600080fdfea265627a7a72315820a703c2bc02437c3a48b21cf16a68301e6a494999bf090e68b156154ba9b5c4ee64736f6c63430005100032";
        public UpgradeabilityAdminDeploymentBase() : base(BYTECODE) { }
        public UpgradeabilityAdminDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
