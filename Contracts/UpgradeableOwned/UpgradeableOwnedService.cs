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
using DMDVision.Contracts.UpgradeableOwned.ContractDefinition;

namespace DMDVision.Contracts.UpgradeableOwned
{
    public partial class UpgradeableOwnedService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, UpgradeableOwnedDeployment upgradeableOwnedDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<UpgradeableOwnedDeployment>().SendRequestAndWaitForReceiptAsync(upgradeableOwnedDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, UpgradeableOwnedDeployment upgradeableOwnedDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<UpgradeableOwnedDeployment>().SendRequestAsync(upgradeableOwnedDeployment);
        }

        public static async Task<UpgradeableOwnedService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, UpgradeableOwnedDeployment upgradeableOwnedDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, upgradeableOwnedDeployment, cancellationTokenSource);
            return new UpgradeableOwnedService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public UpgradeableOwnedService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
