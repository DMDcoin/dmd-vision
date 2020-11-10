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
using DMDVision.Contracts.BaseUpgradeabilityProxy.ContractDefinition;

namespace DMDVision.Contracts.BaseUpgradeabilityProxy
{
    public partial class BaseUpgradeabilityProxyService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, BaseUpgradeabilityProxyDeployment baseUpgradeabilityProxyDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BaseUpgradeabilityProxyDeployment>().SendRequestAndWaitForReceiptAsync(baseUpgradeabilityProxyDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, BaseUpgradeabilityProxyDeployment baseUpgradeabilityProxyDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BaseUpgradeabilityProxyDeployment>().SendRequestAsync(baseUpgradeabilityProxyDeployment);
        }

        public static async Task<BaseUpgradeabilityProxyService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, BaseUpgradeabilityProxyDeployment baseUpgradeabilityProxyDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, baseUpgradeabilityProxyDeployment, cancellationTokenSource);
            return new BaseUpgradeabilityProxyService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public BaseUpgradeabilityProxyService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
