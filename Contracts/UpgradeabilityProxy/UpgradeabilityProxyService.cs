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
using DMDVision.Contracts.UpgradeabilityProxy.ContractDefinition;

namespace DMDVision.Contracts.UpgradeabilityProxy
{
    public partial class UpgradeabilityProxyService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, UpgradeabilityProxyDeployment upgradeabilityProxyDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<UpgradeabilityProxyDeployment>().SendRequestAndWaitForReceiptAsync(upgradeabilityProxyDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, UpgradeabilityProxyDeployment upgradeabilityProxyDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<UpgradeabilityProxyDeployment>().SendRequestAsync(upgradeabilityProxyDeployment);
        }

        public static async Task<UpgradeabilityProxyService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, UpgradeabilityProxyDeployment upgradeabilityProxyDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, upgradeabilityProxyDeployment, cancellationTokenSource);
            return new UpgradeabilityProxyService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public UpgradeabilityProxyService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
