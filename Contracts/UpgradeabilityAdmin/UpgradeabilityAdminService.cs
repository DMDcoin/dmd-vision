using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.Contracts.UpgradeabilityAdmin.ContractDefinition;

namespace DMDVision.Contracts.UpgradeabilityAdmin
{
    public partial class UpgradeabilityAdminService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, UpgradeabilityAdminDeployment upgradeabilityAdminDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<UpgradeabilityAdminDeployment>().SendRequestAndWaitForReceiptAsync(upgradeabilityAdminDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, UpgradeabilityAdminDeployment upgradeabilityAdminDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<UpgradeabilityAdminDeployment>().SendRequestAsync(upgradeabilityAdminDeployment);
        }

        public static async Task<UpgradeabilityAdminService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, UpgradeabilityAdminDeployment upgradeabilityAdminDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, upgradeabilityAdminDeployment, cancellationTokenSource);
            return new UpgradeabilityAdminService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public UpgradeabilityAdminService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
