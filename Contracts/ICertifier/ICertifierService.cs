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
using DMDVision.Contracts.ICertifier.ContractDefinition;

namespace DMDVision.Contracts.ICertifier
{
    public partial class ICertifierService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ICertifierDeployment iCertifierDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ICertifierDeployment>().SendRequestAndWaitForReceiptAsync(iCertifierDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ICertifierDeployment iCertifierDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ICertifierDeployment>().SendRequestAsync(iCertifierDeployment);
        }

        public static async Task<ICertifierService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ICertifierDeployment iCertifierDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iCertifierDeployment, cancellationTokenSource);
            return new ICertifierService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ICertifierService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<bool> CertifiedExplicitlyQueryAsync(CertifiedExplicitlyFunction certifiedExplicitlyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CertifiedExplicitlyFunction, bool>(certifiedExplicitlyFunction, blockParameter);
        }

        
        public Task<bool> CertifiedExplicitlyQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var certifiedExplicitlyFunction = new CertifiedExplicitlyFunction();
                certifiedExplicitlyFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<CertifiedExplicitlyFunction, bool>(certifiedExplicitlyFunction, blockParameter);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(List<string> returnValue1, string returnValue2)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(List<string> returnValue1, string returnValue2, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }
    }
}
