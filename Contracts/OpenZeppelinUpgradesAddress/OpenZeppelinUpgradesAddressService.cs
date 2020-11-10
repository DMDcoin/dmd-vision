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
using DMDVision.Contracts.OpenZeppelinUpgradesAddress.ContractDefinition;

namespace DMDVision.Contracts.OpenZeppelinUpgradesAddress
{
    public partial class OpenZeppelinUpgradesAddressService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, OpenZeppelinUpgradesAddressDeployment openZeppelinUpgradesAddressDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<OpenZeppelinUpgradesAddressDeployment>().SendRequestAndWaitForReceiptAsync(openZeppelinUpgradesAddressDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, OpenZeppelinUpgradesAddressDeployment openZeppelinUpgradesAddressDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<OpenZeppelinUpgradesAddressDeployment>().SendRequestAsync(openZeppelinUpgradesAddressDeployment);
        }

        public static async Task<OpenZeppelinUpgradesAddressService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, OpenZeppelinUpgradesAddressDeployment openZeppelinUpgradesAddressDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, openZeppelinUpgradesAddressDeployment, cancellationTokenSource);
            return new OpenZeppelinUpgradesAddressService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public OpenZeppelinUpgradesAddressService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
