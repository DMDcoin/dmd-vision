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
using DMDVision.Contracts.Sacrifice2.ContractDefinition;

namespace DMDVision.Contracts.Sacrifice2
{
    public partial class Sacrifice2Service
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Sacrifice2Deployment sacrifice2Deployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Sacrifice2Deployment>().SendRequestAndWaitForReceiptAsync(sacrifice2Deployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Sacrifice2Deployment sacrifice2Deployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Sacrifice2Deployment>().SendRequestAsync(sacrifice2Deployment);
        }

        public static async Task<Sacrifice2Service> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Sacrifice2Deployment sacrifice2Deployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, sacrifice2Deployment, cancellationTokenSource);
            return new Sacrifice2Service(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Sacrifice2Service(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
